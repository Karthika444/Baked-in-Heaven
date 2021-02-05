
import { Component, OnInit } from '@angular/core';
import{ApiService} from '../api.service';

@Component({
  selector: 'app-item',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.css']
})
export class ItemComponent implements OnInit {
  //items :any= {};
  items: any;
  

  constructor(public apiService: ApiService) {
    this.apiService.getItems().subscribe((res:any) =>{
      this.items = res
      console.log(this.items)
    })
   }
  selectedItem:any;
  onSelect(item:any){
    this.selectedItem =item; 
  }

  ngOnInit(): void {
  }

}
