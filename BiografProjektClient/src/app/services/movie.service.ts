import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../Environment/Environment';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  private readonly apiUrl=environment.apiUrl+"Movie/";
  constructor(private http:HttpClient) { }






  getAll():Observable<Movie[]>{
    return this.http.get<Hero[]>(this.apiUrl)
  }
}

