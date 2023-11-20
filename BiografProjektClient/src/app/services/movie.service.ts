import { Injectable, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../Environment/Environment';
import { Observable } from 'rxjs';
import { Movie } from '../models/movie';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  private readonly apiUrl=environment.apiUrl+"Movie/";
  constructor(private http:HttpClient) { }


  getAll():Observable<Movie[]>{
    return this.http.get<Movie[]>(this.apiUrl)
  }

  delete(movieId: number): Observable<Movie> {
    return this.http.delete<Movie>(this.apiUrl+movieId)
  }

  create(movie: Movie): Observable<Movie> {
    return this.http.post<Movie>(this.apiUrl, movie);
  }

  update(movieId:number, movie: Movie): Observable<Movie> {
    return this.http.put<Movie>(this.apiUrl+movieId, movie);
  }

  FindById(movieId: string): Observable<Movie> {
    return this.http.get<Movie>(this.apiUrl+movieId);
  }
}

