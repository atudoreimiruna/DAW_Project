import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { DesignersModule } from './modules/designers/designers.module';
import { SharedModule } from './modules/shared/shared.module';
import {MatDialogModule} from '@angular/material/dialog';
import { BtnHoverDirective } from './btn-hover.directive';
//import { LoginComponent } from './modules/designers/login/login.component';
import { ReactiveFormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { Drtv2Directive } from './drtv2.directive';
//import { DialogAddSubscriberComponent } from './shared/dialog-add-subscriber/dialog-add-subscriber.component';
//import { MatCheckboxModule } from '@angular/material/checkbox'; 
//import { MatCheckboxModule } from '@angular/material';



@NgModule({
  declarations: [
    AppComponent,
    Drtv2Directive,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    DesignersModule,
    SharedModule,
    MatDialogModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatCheckboxModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
