import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../Environment/Environment';
import { Observable } from 'rxjs';
import { User } from '../models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private readonly apiUrl=environment.apiUrl+"User";
  constructor(private http:HttpClient) { }


  getAll():Observable<User[]>{
    return this.http.get<User[]>(this.apiUrl)
  }

  FindById(Id: string): Observable<User> {
    return this.http.get<User>(this.apiUrl+Id);
  }

  delete(Id: number): Observable<User> {
    return this.http.delete<User>(this.apiUrl+Id)
  }

  create(user: User): Observable<User> {
    return this.http.post<User>(this.apiUrl, user);
  }

  update(Id:number, user: User): Observable<User> {
    return this.http.put<User>(this.apiUrl+Id, user);
  }
}
