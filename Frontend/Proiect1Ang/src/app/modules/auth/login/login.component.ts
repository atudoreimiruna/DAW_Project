import { Component, OnDestroy, OnInit } from '@angular/core';
import { AbstractControl, FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { Observable, Subscription } from 'rxjs';
import { DataService } from 'src/app/services/data.service';
import { DesignersService } from 'src/app/services/designers.service';
import { LoginService } from 'src/app/services/login.service';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit, OnDestroy {

  public message!: string;
  public subscription!: Subscription;
  public loginForm : FormGroup = new FormGroup({
    username: new FormControl(''),
    password: new FormControl('')
  });

  public token : any;

  constructor(
    private router: Router,
    private data: DataService,
    private LoginService: LoginService
  ) { }


  get username() : AbstractControl | null {
    return this.loginForm.get('username');
  }

  get password() : AbstractControl | null {
    return this.loginForm.get('password');
  }

  ngOnInit(): void {
    localStorage.setItem('Role', 'Admin');
    this.subscription = this.data.currentMessage.subscribe( message => this.message = message);
  }


  public login() : void {
    this.data.changeMessage('Hello from Login');
    this.router.navigate(['/designers']);
  }

  public register() : void {
    this.data.changeMessage('Hello from Register');
    this.router.navigate(['/register']);
  }

  ngOnDestroy() {
    this.subscription.unsubscribe();
  }

  
  /*
  public login() : void {
    this.dataService.changeMessage('Hello from Login');
    this.router.navigate(['/designers']);
    
    console.log(this.loginForm.value);
    this.dataService.changeUserData(this.loginForm.value);
    this.LoginService.login(this.loginForm.value).subscribe(
      (result: any) =>{
        console.log(result);
        this.token = result;
        localStorage.setItem('Role',this.token.accesToken); 
        this.router.navigate(['/designers']);

      },
      (error: any) => {
        console.error(error);
        this.token = null;
      }
    );

  }
  */

}