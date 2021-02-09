import { identifierName } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import{Router} from '@angular/router';
import{ApiService} from '../api.service';



@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {

  items: any;
  

  constructor(public apiService: ApiService,public router:Router) {
    this.apiService.getItems().subscribe((res:any) =>{
      this.items = res
      console.log(this.items)
    })
  }

  ngOnInit(): void {
    this.refreshItems();
  }
  onClick(id:number)
  {
    this.router.navigate(['/edit-item',id]);
  }

  addClick(){
    this.router.navigate(['/edit-item/0'])
  }
  deleteitem(item:any){
    if(confirm('Are you sure??')){
      this.apiService.deleteItem(item)
        window.location.reload();
      }
  }
  refreshItems(){
    this.apiService.getItems().subscribe(data=>{
      this.items=data;
    });
  }


 



}
