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
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatSidenavModule} from '@angular/material/sidenav';
import { MatListModule} from '@angular/material/list';
import { MatButtonModule} from '@angular/material/button';
import { MatIconModule} from '@angular/material/icon';
import { LoginComponent } from './login/login.component';
import { ReactiveFormsModule } from '@angular/forms';
import {MatCardModule} from '@angular/material/card';











@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ItemComponent,
    AdminComponent,
    EditItemComponent,
    LoginComponent,
  
    
    

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    RouterModule,
    FormsModule,
    BrowserAnimationsModule, 
    MatToolbarModule,
    MatSidenavModule, 
    MatListModule,
    MatButtonModule,
    MatIconModule,
    ReactiveFormsModule,
    MatCardModule,
   
 

 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
