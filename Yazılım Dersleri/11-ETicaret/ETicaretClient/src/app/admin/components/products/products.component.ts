import { Component } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent } from 'src/app/base/base.component';
import { HttpClientService } from 'src/app/services/common/http-client.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent extends BaseComponent {

  constructor(spinner: NgxSpinnerService, private httpClientService: HttpClientService) {
    super(spinner);

  }
  ngOnInit(): void {
    // this.httpClientService.get<Product[]>({
    //   controller: "product"
    // }).subscribe(data => console.log(data));

    // this.httpClientService.post({ controller: "product" }, {
    //   name: "Kalem",
    //   stock: 100,
    //   price: 15
    // }).subscribe(data => console.log(data));

    // this.httpClientService.put(
    //   { controller: "product" },
    //   {
    //     id: "6cc2b389-f8b5-4b56-b7e9-345f20c139dd",
    //     name: "Merhaba PUT",
    //     stock: 100,
    //     price: 15
    //   }).subscribe(data => console.log(data));

    // this.httpClientService.delete(
    //   { controller: "product" },
    //   "6cc2b389-f8b5-4b56-b7e9-345f20c139dd",).subscribe(data => console.log(data));

  }
}
