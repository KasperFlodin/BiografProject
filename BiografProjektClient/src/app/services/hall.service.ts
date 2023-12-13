import { Injectable } from '@angular/core';
import { environment } from '../Environment/Environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Hall } from '../models/hall';

@Injectable({
  providedIn: 'root'
})
export class HallService {

  private readonly apiUrl=environment.apiUrl+"Hall";
  constructor(private http:HttpClient) { }


  getAll():Observable<Hall[]>{
    return this.http.get<Hall[]>(this.apiUrl)
  }

  FindById(Id: number): Observable<Hall> {
    return this.http.get<Hall>(this.apiUrl+Id);
  }

  delete(Id: number): Observable<Hall> {
    return this.http.delete<Hall>(this.apiUrl+Id)
  }

  create(hall: Hall): Observable<Hall> {
    return this.http.post<Hall>(this.apiUrl, hall);
  }

  update(Id:number, hall: Hall): Observable<Hall> {
    return this.http.put<Hall>(this.apiUrl+Id, hall);
  }
}
