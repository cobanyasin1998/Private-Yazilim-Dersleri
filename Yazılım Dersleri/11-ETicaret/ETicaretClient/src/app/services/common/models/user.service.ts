import { Injectable } from '@angular/core';
import { HttpClientService } from '../http-client.service';
import { User } from '../../../entities/user';
import { Create_User } from '../../../contracts/users/create_user';
import { Observable, firstValueFrom } from 'rxjs';
import { Token } from '../../../contracts/token/token';
import { SocialUser } from '@abacritt/angularx-social-login';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private httpClientService: HttpClientService) { }

  async create(user: User): Promise<Create_User> {
    const observable: Observable<Create_User | User> = this.httpClientService.post<Create_User | User>({
      controller: "users"
    }, user);

    return await firstValueFrom(observable) as Create_User;
  }


  async login(userNameOrEmail: string, password: string, callBackFunction?: () => void): Promise<any> {
    const observable: Observable<any | Token> = this.httpClientService.post<any | Token>({
      controller: "users",
      action: "login"
    },
      {
        userNameOrEmail,
        password
      }
    );
    callBackFunction();
    return await firstValueFrom(observable);
  
  }


  async googleLogin(user: SocialUser, callBackFunction?: () => void): Promise<any> {
    const observable: Observable<any | Token> = this.httpClientService.post<SocialUser | Token>({
      controller: "users",
      action: "google-login"
    }, user);
    callBackFunction();
    return await firstValueFrom(observable);

  }

}
