import { Injectable } from '@angular/core';
import { environment } from '../Environment/Environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Genre } from '../models/genre';

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  private readonly apiUrl=environment.apiUrl+"Genre";
  constructor(private http:HttpClient) { }


  getAll():Observable<Genre[]>{
    return this.http.get<Genre[]>(this.apiUrl)
  }

  FindById(Id: string): Observable<Genre> {
    return this.http.get<Genre>(this.apiUrl+Id);
  }

  delete(Id: number): Observable<Genre> {
    return this.http.delete<Genre>(this.apiUrl+Id)
  }

  create(genre: Genre): Observable<Genre> {
    return this.http.post<Genre>(this.apiUrl, genre);
  }

  update(Id:number, genre: Genre): Observable<Genre> {
    return this.http.put<Genre>(this.apiUrl+Id, genre);
  }
}
