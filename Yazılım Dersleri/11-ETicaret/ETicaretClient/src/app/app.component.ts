import { Component } from '@angular/core';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from './services/ui/custom-toastr.service';
import { AuthService } from './services/common/auth.service';
declare var $: any;
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ETicaretClient';


  constructor(public authService: AuthService) {
    authService.identityCheck();

  }
  signOut() {
    localStorage.removeItem("accessToken");
    this.authService.identityCheck();
  }
}
