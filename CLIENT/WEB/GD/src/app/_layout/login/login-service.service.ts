import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { UserModel } from '../../_model/UserModel';
import { HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})

export class LoginServiceService {
  host: string = 'http://localhost:55201/';

  constructor(private _http: HttpClient) { }

  login(username, password) {
    var d = "username=" + username + "&password=" + password + "&grant_type=password";
    return this._http.post(this.host + 'token', d);
  }
}
