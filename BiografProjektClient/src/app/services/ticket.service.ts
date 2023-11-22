import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../Environment/Environment';
import { Observable } from 'rxjs';
import { Ticket } from '../models/ticket';

@Injectable({
  providedIn: 'root'
})
export class TicketService {

  private readonly apiUrl=environment.apiUrl+"Ticket";
  constructor(private http:HttpClient) { }


  getAll():Observable<Ticket[]>{
    return this.http.get<Ticket[]>(this.apiUrl)
  }

  FindById(Id: string): Observable<Ticket> {
    return this.http.get<Ticket>(this.apiUrl+Id);
  }

  delete(Id: number): Observable<Ticket> {
    return this.http.delete<Ticket>(this.apiUrl+Id)
  }

  create(ticket: Ticket): Observable<Ticket> {
    return this.http.post<Ticket>(this.apiUrl, ticket);
  }

  update(Id:number, ticket: Ticket): Observable<Ticket> {
    return this.http.put<Ticket>(this.apiUrl+Id, ticket);
  }
}
