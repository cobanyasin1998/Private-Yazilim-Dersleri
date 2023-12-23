import { Component } from '@angular/core';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from './services/ui/custom-toastr.service';
import { AuthService } from './services/common/auth.service';
import { Router } from '@angular/router';
declare var $: any;
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ETicaretClient';


  constructor(public authService: AuthService, private toastrService: CustomToastrService,private router:Router) {
    authService.identityCheck();

  }
  signOut() {
    this.toastrService.message("Çıkış Yapıldı", "...", ToastrMessageType.Info, ToastrPosition.BottomCenter);
    localStorage.removeItem("accessToken");
    this.authService.identityCheck();
    this.router.navigate([""]);
  }
}
