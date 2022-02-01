import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FeedbackService {

  public url = 'https://localhost:44335/api/Feedback';

  constructor(
    private http: HttpClient
  ) { }

  public createFeedback(body: {id: number; name: string; message: string;}): Observable<any> {
    return this.http.post<any>(`${this.url}/fromBody`, body);
  }  
}
