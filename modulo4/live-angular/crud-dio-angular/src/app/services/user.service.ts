import { useAnimation } from '@angular/animations';
import { User } from './../models/user';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  apiUrl = 'https://sheet.best/api/sheets/d78a6df4-57a7-4137-a772-79fb5e6c255f';
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    })
  }

  constructor(private httpCliente: HttpClient) { }

  // C.R.U.D - CREATE, READ, UPDATE, DELETE

  // Retorna a lista de usuarios READ
  getUsers(): Observable<User[]> {
    return this.httpCliente.get<User[]>(this.apiUrl);
  }

  // Salva usuario no banco CREATE
  postUser(user: User): Observable<User> {
    return this.httpCliente.post<User>(this.apiUrl, user, this.httpOptions);
  }

  // Exclui o usuario do banco DELETE
  deleteUser(id: number): Observable<User> {
    return this.httpCliente.delete<User>(`${this.apiUrl}/id/${id}`);
  }

  // Edita Usuario UPDATE
  updateUser(id: string, user: User): Observable<User> {
    return this.httpCliente.put<User>(`${this.apiUrl}/id/${id}`, user, this.httpOptions);
  }

  // Lista Usuario unico
  getUser(id: string): Observable<User[]> {
    return this.httpCliente.get<User[]>(`${this.apiUrl}/id/${id}`)
  }
}
