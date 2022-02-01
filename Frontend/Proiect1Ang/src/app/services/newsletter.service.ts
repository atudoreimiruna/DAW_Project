import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

//import { Subscriber } from '../interfaces/subscriber';

@Injectable({
  providedIn: 'root'
})
export class NewsletterService {

  public url = 'https://localhost:44335/api/NewsLetter';

  constructor(
    private http: HttpClient
  ) { }

  public createSubscriber(body: {id: number; email: string;}): Observable<any> {
    return this.http.post<any>(`${this.url}/fromBody`, body);
  }  
  
}