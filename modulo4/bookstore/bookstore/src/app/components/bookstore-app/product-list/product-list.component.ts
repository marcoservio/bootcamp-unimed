import { BooksService } from './product-list.component.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  livros: any;
  bookService: BooksService

  constructor(bookService: BooksService) {
    this.bookService = bookService
   }

  ngOnInit(): void {
    this.livros = this.bookService.getBook().subscribe((data => {
      this.livros = data;
      console.log(this.livros);
    }))
  }

}
