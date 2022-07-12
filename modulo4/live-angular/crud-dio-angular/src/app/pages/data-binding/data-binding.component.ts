import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-data-binding',
  templateUrl: './data-binding.component.html',
  styleUrls: ['./data-binding.component.css']
})
export class DataBindingComponent implements OnInit {
  text = 'Marco Sérvio';
  imageUrl = 'https://picsum.photos/300/300';
  imageDesc = 'Essa é uma imagem';
  buttonText = 'Clique aqui';
  textRed = false;;
  bgColor = 'green';
  fontSize = '25px';
  widthImg = 600;
  textInput = '';
  number = 0;
  destroy = false;

  constructor() { }

  ngOnInit(): void {
  }

  retornaNome() {
    return this.text;
  }

  clicou(value: any) {
    this.text = 'Marco Sérvio Almeida Capanema'
    console.log(value);
    this.textRed = true;
  }

  clicouNoFilho(text: any) {
    console.log(text);
  }

  incrementa() {
    this.number++;
  }

  destroiComponente() {
    this.destroy = true;
  }
}
