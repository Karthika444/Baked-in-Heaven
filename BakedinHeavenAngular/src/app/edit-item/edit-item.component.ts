import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import{ApiService} from '../api.service';
import{Router} from '@angular/router';

@Component({
  selector: 'app-edit-item',
  templateUrl: './edit-item.component.html',
  styleUrls: ['./edit-item.component.css']
})
export class EditItemComponent{
  
  panelTitle:any;
  //Item: any = {} 
  
  items: any = {}
  itemid:any

  constructor(public apiService: ApiService,private route:ActivatedRoute,public router:Router) {
   
   }

  ngOnInit(): void {
    this.route.paramMap.subscribe(parameterMap => {
      const id = parameterMap.get('id');
      this.getItem(id);
      this.itemid=id;
    });
  
  }
  private getItem(id:any)
  {
    if(id !=0){
      this.items= this.apiService.getItem(id).subscribe(
        (item) => { this.items = item;
          console.log(this.items)
        });
      this.panelTitle = 'Edit Item';

     
    }
    else{
      this.panelTitle = 'Add Item';
      this.items ={
        id :"",
        name :"",
        price : "",
        quantity :"",
        weightInGrams:"",
        

        
      }
    }
    
  }
  addClick(items:any){
    this.apiService.postItem(items);
    this.router.navigate(['/add-edit'])
    
  }
  editClick(items:any){
    this.apiService.putItem(items);
    this.router.navigate(['/add-edit'])
      this.refreshItems();
    
  }
  refreshItems(){
    this.apiService.getItems().subscribe(data=>{
      this.items=data;
    });
  }
}
