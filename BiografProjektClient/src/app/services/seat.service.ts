import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../Environment/Environment';
import { Observable } from 'rxjs';
import { Seat } from '../models/seat';

@Injectable({
  providedIn: 'root'
})
export class SeatService {

  private readonly apiUrl=environment.apiUrl+"Seat";
  constructor(private http:HttpClient) { }

  getAll():Observable<Seat[]>{
    return this.http.get<Seat[]>(this.apiUrl)
  }

  FindById(Id: string): Observable<Seat> {
    return this.http.get<Seat>(this.apiUrl+Id);
  }

  delete(Id: number): Observable<Seat> {
    return this.http.delete<Seat>(this.apiUrl+Id)
  }

  create(seat: Seat): Observable<Seat> {
    return this.http.post<Seat>(this.apiUrl, seat);
  }

  update(Id:number, seat: Seat): Observable<Seat> {
    return this.http.put<Seat>(this.apiUrl+Id, seat);
  }
}
