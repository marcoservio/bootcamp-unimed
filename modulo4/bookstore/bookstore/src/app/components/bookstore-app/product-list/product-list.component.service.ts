import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Book } from './model/Book';

@Injectable()
export class BooksService {
  private url = '';
  httpOption = {
    Headers: new HttpHeaders({'content-type':'aplication/json'})
  }

  constructor(private http: HttpClient) { }

  getBook() {
    return this.http.get(this.url);
  }
}
