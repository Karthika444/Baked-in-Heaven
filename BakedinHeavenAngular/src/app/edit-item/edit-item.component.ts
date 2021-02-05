import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import{ApiService} from '../api.service';

@Component({
  selector: 'app-edit-item',
  templateUrl: './edit-item.component.html',
  styleUrls: ['./edit-item.component.css']
})
export class EditItemComponent implements OnInit {
  
  panelTitle:any;
  //Item: any = {} 
  itemName="";
  price="";
  Quantity="";
  items: any;

  constructor(public apiService: ApiService,private route:ActivatedRoute) {
    this.apiService.getItems().subscribe((res:any) =>{
      this.items = res
      console.log(this.items)
    })
   }

  ngOnInit(): void {
    this.route.paramMap.subscribe(parameterMap => {
      const id = parameterMap.get('id');
      this.getItem(id);
    });
  
  }
  private getItem(id:any)
  {
    if(id !=0){
      this.items=   Object.assign({},this.getItem(id) );
      this.panelTitle = 'Edit Employee';
    }
    else{
      this.panelTitle = 'Create Employee';
      this.items ={
        itemName :"",
        price : "",
        quantity :"",
        weightInGrams:""
        
      }
    }
    
  }

  

  /*post(Item: any){
    this.apiService.postItem(Item);
    
  }*/

  

}
