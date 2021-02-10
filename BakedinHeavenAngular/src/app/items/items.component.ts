
import { Component, OnInit } from '@angular/core';
import{ApiService} from '../api.service';
import { DatePipe } from '@angular/common';


@Component({
  selector: 'app-item',
  templateUrl: './items.component.html',
  styleUrls: ['./items.component.css'],
  providers: [DatePipe],

})
export class ItemComponent implements OnInit {
  //items :any= {};
  items: any;
  todaydate :any=new Date()
  tomorrow :any =new Date();


  

  constructor(public apiService: ApiService,private datePipe:DatePipe) {
    this.apiService.getItems().subscribe((res:any) =>{
      this.items = res
      console.log(this.items)
      this.tomorrow.setDate(this.todaydate.getDate() + 1);

    })
   }
  selectedItem:any;
  onSelect(item:any){
    this.selectedItem =item; 
  }

  ngOnInit(): void {
  }
  checkdate(item:any)
  {
    item.availabledate = this.datePipe.transform(item.availabledate, 'yyyy-MM-dd');
    this.todaydate = this.datePipe.transform(this.todaydate, 'yyyy-MM-dd');
    this.tomorrow = this.datePipe.transform(this.tomorrow, 'yyyy-MM-dd');
    
      
    if((item.availabledate==this.todaydate)||(item.availabledate==this.tomorrow))
    {
      return true;
    }
    else{
      return false;
    }
  }


}
