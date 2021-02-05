import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  Email:string="bakedinheaven@gmail.com";
  Phone:string="9495801248";
  

  constructor() { }

  ngOnInit(): void {
  }

}
