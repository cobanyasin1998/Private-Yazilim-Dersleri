import { Component } from '@angular/core';
import { BaseComponent } from 'src/app/base/base.component';
import { NgxSpinnerService } from 'ngx-spinner';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent extends BaseComponent {

  constructor(spinner: NgxSpinnerService) {
    super(spinner)

  }
  ngOnInit(): void {
    this.showSpinner();
    setTimeout(() => { this.hideSpinner(); }, 1000)
  }

}
