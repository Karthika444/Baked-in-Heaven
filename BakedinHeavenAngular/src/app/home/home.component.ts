import { Component, OnInit } from '@angular/core';
import{ApiService} from '../api.service';
import{Router} from '@angular/router';
import { WHITE_ON_BLACK_CSS_CLASS } from '@angular/cdk/a11y/high-contrast-mode/high-contrast-mode-detector';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  Email:string="bakedinheaven@gmail.com";
  Phone:string="9495801248";
  
  
  constructor() {
    
  }

  

  ngOnInit(): void {
  }
  


}
