import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthRoutingModule } from './auth-routing.module';
import { LoginComponent } from './login/login.component';

//import { MaterialModule } from '../material/material.module';
import { ReactiveFormsModule } from '@angular/forms';
import { MatTableModule } from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { RegisterComponent } from './register/register.component';
//import { ChildComponent } from '../designers/child/child.component';


@NgModule({
  declarations: [
    LoginComponent,
    RegisterComponent    
  ],
  imports: [
    CommonModule,
    AuthRoutingModule,
    MatTableModule,
    MatIconModule,
    MatCardModule,
    MatButtonModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule
  ]
})
export class AuthModule { }
