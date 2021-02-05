import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import{ItemComponent} from './items/items.component';
import{HomeComponent} from './home/home.component';
import{AdminComponent} from './admin/admin.component';
import{EditItemComponent} from './edit-item/edit-item.component';


const routes: Routes = [
  {path: '',component: HomeComponent},
  {path: 'home',component: HomeComponent},
  {path: 'item',component: ItemComponent},
  {path: 'add-edit',component:AdminComponent},
  {path: 'edit-item/:id',component:EditItemComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
