import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private jwtHelper: JwtHelperService) { }
  identityCheck() {
    const token: string = localStorage.getItem("accessToken");
    let expired: boolean = false;
    
    if (token && !this.jwtHelper.isTokenExpired(token)) {
      
      expired =true;
    }

    _isAuth = expired;
  }
  get isAuth(): boolean {
    
    return _isAuth;
  }
}


export let _isAuth: boolean;
