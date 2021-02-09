import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { getTranslationDeclStmts } from '@angular/compiler/src/render3/view/template';
import {Subject } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class ApiService {
  
  //public selectedItem = new Subject<any>();
  //itemSelected = this.selectedItem.asObservable();

  constructor(public http: HttpClient) { }
  getItems(){
  return this.http.get("https://localhost:44317/api/Bakery");
  }
  getItem(id:any){
    return this.http.get(`https://localhost:44317/api/Bakery/${id}`)
  }

  postItem(item: any){
    this.http.post('https://localhost:44317/api/Bakery',item).subscribe(res => {
        console.log(res);
    })
  }
  putItem(item: any){
    this.http.put(`https://localhost:44317/api/Bakery/${item.id}`,item).subscribe(res => {
        console.log(res);
    });
    
  }


  deleteItem(item: any){
    this.http.delete(`https://localhost:44317/api/Bakery/${item.id}`,item).subscribe(res => {
      console.log(res);
      

    });

    
  }
  getUsers()
  {
    return this.http.get("https://localhost:44317/api/User");
  }

  

  

    
  

  /*selectItem(item: any) {
            
    this.selectedItem.next(item);
  }*/
  

}