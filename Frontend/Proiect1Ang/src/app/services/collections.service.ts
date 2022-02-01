import { Injectable } from '@angular/core';
import { Collection } from '../interfaces/collection';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Designer } from '../interfaces/designer';


@Injectable({
  providedIn: 'root'
})
export class CollectionsService {

  public url = 'https://localhost:44335/api/Collections';

  constructor( private http: HttpClient ) { }

  public getCollections(id: any) : Observable<Collection[]> {
    return this.http.get<any>(`${this.url}/byId/${id}`);
  }
}


