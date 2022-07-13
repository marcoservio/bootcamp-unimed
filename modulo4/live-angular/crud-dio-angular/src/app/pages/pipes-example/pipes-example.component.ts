import { UpperCasePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pipes-example',
  templateUrl: './pipes-example.component.html',
  styleUrls: ['./pipes-example.component.css']
})
export class PipesExampleComponent implements OnInit {
  number = 0;
  text = 'Hello World!';
  date = new Date;
  pessoa = {
    nome: 'Marco',
    idade: '24',
    profissao: 'Desenvolvedor'
  };
  nomes = ['Marco'];

  constructor(private uppercasePipe: UpperCasePipe) { }

  ngOnInit(): void {
    this.text = this.uppercasePipe.transform(this.text)
  }

  mudaValor() {
    this.number = 123456789;
  }

  add(texto: string) {
    this.nomes.push(texto);
  }
}
