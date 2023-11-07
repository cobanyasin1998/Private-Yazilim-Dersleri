import { Component, OnInit } from '@angular/core';
import { SignalRService } from '../../../services/common/signalr.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

  constructor(private signalRService: SignalRService) {
    
  }

  ngOnInit(): void {
    this.signalRService.on("/product-hub", "receiveProductAddedMessage", message => {
      console.info(message);
    });
   
  }
}
