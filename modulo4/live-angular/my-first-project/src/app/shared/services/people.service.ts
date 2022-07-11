import { Injectable } from '@angular/core';
import { Observable, observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PeopleService {

  constructor() { }

  getPeople(): Observable<any> {
    let peopleArray = [
      {
        firstName: 'Marco',
        lastName: 'Sérvio',
        age: 24
      },
      {
        firstName: 'Maria',
        lastName: 'Silva',
        age: 28
      },
      {
        firstName: 'Joao',
        lastName: 'Pereira',
        age: 32
      },
      {
        firstName: 'Marcio',
        lastName: 'Santos',
        age: 40
      },
    ];

    return of(peopleArray);
  }
}
