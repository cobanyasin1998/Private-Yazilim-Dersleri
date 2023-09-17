import { Injectable } from '@angular/core';
declare var alertify: any;
@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor() { }
  dismiss() {
    alertify.dismiss();
  }
  dismissAll() {
    alertify.dismissAll();
  }
  message(msg: string, options: Partial<AlertifyOptions>) {
    const alertifyProperty = alertifyMap[options.msgType];
    const positionProperty = positionMap[options.position];

    alertify.set("notifier", "delay", options.delay);
    if (positionProperty) {
      alertify.set("notifier", "position", positionProperty);
    }
    if (alertifyProperty) {
      alertify[alertifyProperty](msg);
    }
  }

}
export class AlertifyOptions {
  msgType: MessageType = MessageType.Notify;
  position: Position = Position.TopRight;
  delay: number = 3;
}
export enum MessageType {
  Error = "error",
  Success = "success",
  Message = "message",
  Warning = "warning",
  Notify = "notify"
}
export enum Position {
  TopCenter = "top-center",
  TopRight = "top-right",
  TopLeft = "top-left",
  BottomRight = "bottom-right",
  BottomCenter = "bottom-center",
  BottomLeft = "bottom-left"
}
const alertifyMap: Record<MessageType, string> = {
  [MessageType.Error]: "error",
  [MessageType.Success]: "success",
  [MessageType.Message]: "message",
  [MessageType.Warning]: "warning",
  [MessageType.Notify]: "notify"
};
const positionMap: Record<Position, string> = {
  [Position.TopCenter]: "top-center",
  [Position.TopRight]: "top-right",
  [Position.TopLeft]: "top-left",
  [Position.BottomRight]: "bottom-right",
  [Position.BottomCenter]: "bottom-center",
  [Position.BottomLeft]: "bottom-left"
};