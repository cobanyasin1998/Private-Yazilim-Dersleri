import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest, HttpStatusCode } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, catchError, of } from 'rxjs';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from '../ui/custom-toastr.service';
import { UserService } from './models/user.service';

@Injectable({
  providedIn: 'root'
})
export class HttpErrorHandlerInceptorService implements HttpInterceptor {

  constructor(private toastrService: CustomToastrService, private userAuthService: UserService) { }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {

    return next.handle(req).pipe(catchError(error => {
      
      switch (error.status) {
        case HttpStatusCode.Unauthorized:
          debugger

          this.userAuthService.refreshTokenLogin(localStorage.getItem("refreshToken"));



          this.toastrService.message("Yetkisiz İşlem", "Yetkiniz Bulunmamaktadır", ToastrMessageType.Error, ToastrPosition.BottomCenter);






          break;
        case HttpStatusCode.InternalServerError:
          this.toastrService.message("Sunucu Hatası", "Sunucu Hatası", ToastrMessageType.Error, ToastrPosition.BottomCenter);

          break;
        case HttpStatusCode.BadRequest:
          this.toastrService.message("Bad Request", "Bad Request", ToastrMessageType.Error, ToastrPosition.BottomCenter);

          break;
        case HttpStatusCode.NotFound:
          this.toastrService.message("404", "NotFound", ToastrMessageType.Error, ToastrPosition.BottomCenter);

          break;
        case 0:
          this.toastrService.message("Hata", "Hata", ToastrMessageType.Error, ToastrPosition.BottomCenter);

          break;
        default:
          this.toastrService.message("Hata", "Hata", ToastrMessageType.Error, ToastrPosition.BottomCenter);

          break;
      }

      return of(error);
    }));

  }



}
