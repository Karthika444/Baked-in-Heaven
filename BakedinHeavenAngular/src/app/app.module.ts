import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ItemComponent } from './items/items.component';

import { RouterModule } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { EditItemComponent } from './edit-item/edit-item.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ItemComponent,
    AdminComponent,
    EditItemComponent,
    
    

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    RouterModule,
    FormsModule,  

 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
