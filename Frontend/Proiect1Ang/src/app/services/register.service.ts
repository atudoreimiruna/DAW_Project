import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {

  public url = 'https://localhost:44335/api/Auth';

  constructor(public http : HttpClient) { }

  public signup(user:any) : Observable<any>{
    return this.http.post(`${this.url}/register`,user);
}
}
