import { Component } from '@angular/core';
import { AlertifyService, MessageType, Position } from 'src/app/services/admin/alertify.service';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent {

  constructor(private alertify: AlertifyService) {
    this.alertify.message("Merhaba", {
      msgType: MessageType.Success,
      position: Position.TopRight,
      delay: 5
    })
  }
  ngOnInit(): void {

  }
}
