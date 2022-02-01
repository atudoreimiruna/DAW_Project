import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Award } from '../interfaces/award';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Designer } from '../interfaces/designer';


@Injectable({
  providedIn: 'root'
})
export class AwardsService {

  public url = 'https://localhost:44335/api/Awards';
  
  constructor( private http: HttpClient ) { }

  public getAwards(id: any): Observable<Award[]> {
    return this.http.get<any>(`${this.url}/byId/${id}`);
  }
  
}


