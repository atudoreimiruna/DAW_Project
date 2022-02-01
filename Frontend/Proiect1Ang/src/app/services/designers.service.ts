import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Award } from '../interfaces/award';
import { Designer } from '../interfaces/designer';

@Injectable({
  providedIn: 'root'
})
export class DesignersService {

  public url = 'https://localhost:44335/api/designers';
  
  constructor(
    private http: HttpClient
  ) { }

  public getDesigners() : Observable<Designer[]> {
    return this.http.get<any>(this.url);
  }

  public getDesignerById(id: any): Observable<Designer> {
    return this.http.get<any>(`${this.url}/byId/${id}`);
  }

  public createDesigner(body: { id: number; name: string; age: number; gender: string; }): Observable<any> {

    return this.http.post<any>(`${this.url}/fromBody`, body);
  }

  
  public deleteDesigner(designer: any): Observable<any> {
    const httpOptions = {
      headers: new HttpHeaders() 
        .set('Content-Type', 'application/json'),
      body: designer 
    };
   
   return this.http.delete<any>(this.url, httpOptions);
  }
  
}
