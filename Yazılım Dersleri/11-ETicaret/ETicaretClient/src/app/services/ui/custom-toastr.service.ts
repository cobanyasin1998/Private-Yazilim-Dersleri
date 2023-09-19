import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class CustomToastrService {

  constructor(private toastr: ToastrService) {

  }
  message(msg: string, title: string, type: ToastrMessageType, position: any) {
    this.toastr[type](title, msg, {
      positionClass: position
    });
  }
}

export enum ToastrMessageType {
  Error = "error",
  Success = "success",
  Info = "info",
  Warning = "warning"

}

export enum ToastrPosition {
  TopRight = "toast-top-right",
  BottomLeft = "toast-bottom-left",
  BottomRight = "toast-bottom-right",
  TopLeft = "toast-top-left",
  TopFullWidth = "toast-top-full-width",
  BottomFullWidth = "toast-bottom-full-width-right",
  TopCenter = "toast-top-center",
  BottomCenter = "toast-bottom-center",
}
