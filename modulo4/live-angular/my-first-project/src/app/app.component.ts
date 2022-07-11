import { Component, OnInit } from '@angular/core';
import { PeopleService } from './shared/services/people.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  count = 0;
  nome = "Marco Sérvio Almeida Capanema";
  text = '';
  pessoas = [
    {
      firstName: '',
      lastName: '',
      age: 0
    },
  ];
  
  constructor(private peopleService: PeopleService) { }

  ngOnInit(): void {
    this.getPeople();
    let interval = setInterval(() => {
      this.count++;
      if(this.count === 10) {
        clearInterval(interval);
      }
    }, 1000)

  }

  clicou(nome: string):void {
    console.log('Clicou em mim', nome);
  }

  getPeople() {
    this.peopleService.getPeople().subscribe(people => {
      this.pessoas = people;
    });
  }
}
