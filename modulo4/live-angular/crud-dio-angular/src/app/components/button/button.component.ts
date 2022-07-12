import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent implements OnInit {
  @Input() btnText = 'Clique';
  @Input() btnType = '';
  @Output() clickChildren = new EventEmitter;
  textFilho = 'Clicou no filho';

  constructor() { }

  ngOnInit(): void {
  }

  clicou() {
    this.clickChildren.emit(this.textFilho);
  }
}