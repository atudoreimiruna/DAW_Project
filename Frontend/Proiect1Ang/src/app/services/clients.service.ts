import { Injectable } from '@angular/core';
import { Client } from '../interfaces/client';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class ClientsService {

  public url = 'https://localhost:44335/api/clients';

  constructor( private http: HttpClient ) { }

  public getClients(id: any) : Observable<Client[]> {
    return this.http.get<any>(`${this.url}/byId/${id}`);
  }
}



