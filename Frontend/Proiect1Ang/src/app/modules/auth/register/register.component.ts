import { Component, OnInit, OnDestroy } from '@angular/core';
import { AbstractControl,FormControl, FormGroup } from '@angular/forms';
import { MatCheckboxModule } from '@angular/material/checkbox'; 
import {ThemePalette} from '@angular/material/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { DataService } from 'src/app/services/data.service';
import { DesignersService } from 'src/app/services/designers.service';
import { RegisterService } from 'src/app/services/register.service';



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  public registerForm : FormGroup = new FormGroup({
    firstname: new FormControl(''),
    lastname: new FormControl(''),
    username: new FormControl(''),
    password: new FormControl(''),
    confirmpassword: new FormControl(''),
  });

  constructor(
    private router: Router,
    private data: DataService,
    private registerService : RegisterService
  ) { }

  get username() :AbstractControl{
    return this.registerForm.get('username')!;
  }

  get password() :AbstractControl{
    return this.registerForm.get('password')!;
  }


  public register() : void {
    this.data.changeMessage('Hello from Register');
    this.router.navigate(['/designers']);
  }


  ngOnInit(): void {
  }

  /*
  public register() : void {
    console.log(this.registerForm.value);
    this.registerService.signup(this.registerForm.value).subscribe(
      (result: any) => {
        console.log(result);
        this.router.navigate(['/designers'])
      },
      (error: any) => {
        console.error(error);
        console.error('Userul nu a fost creat');

      }
    )
    }
  */
  
  
}
