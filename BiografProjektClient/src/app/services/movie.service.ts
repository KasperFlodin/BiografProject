import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
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

  FindById(movieId: number): Observable<Movie> {
    return this.http.get<Movie>(this.apiUrl+movieId);
  }

  delete(movieId: number): Observable<Movie> {
    return this.http.delete<Movie>(this.apiUrl+movieId)
  }

  create(movie: Movie): Observable<Movie> {
    return this.http.post<Movie>(this.apiUrl, movie);
  }

  update(movie: Movie): Observable<Movie> {
    return this.http.put<Movie>(this.apiUrl, movie);
  }
}

