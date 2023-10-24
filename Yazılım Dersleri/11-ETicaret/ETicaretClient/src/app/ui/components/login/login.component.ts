import { Component } from '@angular/core';
import { UserService } from '../../../services/common/models/user.service';
import { BaseComponent } from '../../../base/base.component';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent extends BaseComponent {

  constructor(private userService: UserService, spinner: NgxSpinnerService) {
    super(spinner)
  }

  async login(usernameOrEmail: string, password: string) {
    this.showSpinner();
    debugger
    await this.userService.login(usernameOrEmail, password, ()=> this.hideSpinner());
    
  }
}
