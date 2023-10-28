import { Component } from '@angular/core';
import { UserService } from '../../../services/common/models/user.service';
import { BaseComponent } from '../../../base/base.component';
import { NgxSpinnerService } from 'ngx-spinner';
import { Token } from '../../../contracts/token/token';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from '../../../services/ui/custom-toastr.service';
import { AuthService } from '../../../services/common/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent extends BaseComponent {

  constructor(private userService: UserService, spinner: NgxSpinnerService, private toastrService: CustomToastrService, private authService: AuthService) {
    super(spinner)
  }

  async login(usernameOrEmail: string, password: string) {
    this.showSpinner();

    const token: any = await this.userService.login(usernameOrEmail, password, () => {
      this.hideSpinner();
      this.authService.identityCheck()
    });
    
    if (token) {
      this.toastrService.message("Giriş Başarılı", "", ToastrMessageType.Success, ToastrPosition.BottomCenter);
      
      localStorage.setItem("accessToken", token.token.accessToken);

    }
    else {
      this.toastrService.message("Hata", "", ToastrMessageType.Error, ToastrPosition.BottomCenter);

    }
  }
}
