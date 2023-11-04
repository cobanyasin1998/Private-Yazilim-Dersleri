import { Component } from '@angular/core';
import { UserService } from '../../../services/common/models/user.service';
import { BaseComponent } from '../../../base/base.component';
import { NgxSpinnerService } from 'ngx-spinner';
import { Token } from '../../../contracts/token/token';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from '../../../services/ui/custom-toastr.service';
import { AuthService } from '../../../services/common/auth.service';
import { ActivatedRoute, Router } from '@angular/router';
import { FacebookLoginProvider, SocialAuthService, SocialUser } from '@abacritt/angularx-social-login';
import { HttpClientService } from '../../../services/common/http-client.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent extends BaseComponent {

  constructor(
    private userService: UserService,
    spinner: NgxSpinnerService,
    private toastrService: CustomToastrService,
    private authService: AuthService,
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private socialAuthService: SocialAuthService) {
    super(spinner);

    this.socialAuthService.authState.subscribe(async(user: SocialUser) => {
      console.log(user);
      this.showSpinner();


      switch (user.provider) {
        case "GOOGLE":
          const token: any = await this.userService.googleLogin(user, () => {
            this.hideSpinner();
            this.authService.identityCheck()
          });

          if (token) {
            this.toastrService.message("Google Giriş Başarılı", "", ToastrMessageType.Success, ToastrPosition.BottomCenter);

            localStorage.setItem("accessToken", token.token.accessToken);
            localStorage.setItem("refreshToken", token.token.refreshToken);

          }
          else {
            this.toastrService.message("Hata", "", ToastrMessageType.Error, ToastrPosition.BottomCenter);

          }
          break;
        case "FACEBOOK":
          const tokenn: any = await this.userService.facebookLogin(user, () => {
            this.hideSpinner();
            this.authService.identityCheck()
          });

          if (tokenn) {
            this.toastrService.message("Facebook Giriş Başarılı", "", ToastrMessageType.Success, ToastrPosition.BottomCenter);

            localStorage.setItem("accessToken", tokenn.token.accessToken);
            localStorage.setItem("refreshToken", tokenn.token.refreshToken);


          }
          else {
            this.toastrService.message("Hata", "", ToastrMessageType.Error, ToastrPosition.BottomCenter);

          }
          break;
          
      }

      
    });
  }
  facebookLogin() {
    debugger
    this.socialAuthService.signIn(FacebookLoginProvider.PROVIDER_ID);
  }
  async login(usernameOrEmail: string, password: string) {
    this.showSpinner();

    const token: any = await this.userService.login(usernameOrEmail, password, () => {
      this.hideSpinner();
      this.authService.identityCheck()
    });
    debugger
    if (token) {
      debugger
      this.activatedRoute.queryParams.subscribe(params => {
        const returnUrl: string = params["returnUrl"];

        if (returnUrl) {
          this.router.navigate([returnUrl]);
        }
      });
      this.toastrService.message("Giriş Başarılı", "", ToastrMessageType.Success, ToastrPosition.BottomCenter);
      
      localStorage.setItem("accessToken", token.token.accessToken);
      localStorage.setItem("refreshToken", token.token.refreshToken);


    }
    else {
      this.toastrService.message("Hata", "", ToastrMessageType.Error, ToastrPosition.BottomCenter);

    }
  }
}
