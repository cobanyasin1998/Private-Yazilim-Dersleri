import { Component } from '@angular/core';
import { UserService } from '../../../services/common/models/user.service';
import { BaseComponent } from '../../../base/base.component';
import { NgxSpinnerService } from 'ngx-spinner';
import { Token } from '../../../contracts/token/token';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from '../../../services/ui/custom-toastr.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent extends BaseComponent {

  constructor(private userService: UserService, spinner: NgxSpinnerService, private toastrService: CustomToastrService) {
    super(spinner)
  }

  async login(usernameOrEmail: string, password: string) {
    this.showSpinner();
    debugger
    const token: any = await this.userService.login(usernameOrEmail, password, () => this.hideSpinner());
    debugger
    if (token) {
      this.toastrService.message("Giriş Başarılı", "", ToastrMessageType.Success, ToastrPosition.BottomCenter);
      debugger
      localStorage.setItem("accessToken", token.token.accessToken);

    }
    else {
      this.toastrService.message("Hata", "", ToastrMessageType.Error, ToastrPosition.BottomCenter);

    }
  }
}
