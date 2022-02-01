import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  public url = 'https://localhost:44335/api/Auth';

  constructor(public http : HttpClient) { }


  public login(user : any) : Observable<any> {
    const token = this.http.post(`${this.url}/Login`, user);
    return token;
  }

}
