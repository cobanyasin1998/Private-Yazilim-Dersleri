import { Component } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent } from 'src/app/base/base.component';
import { Create_Product } from 'src/app/contracts/create_product';
import { AlertifyOptions, AlertifyService, MessageType, Position } from 'src/app/services/admin/alertify.service';
import { ProductService } from 'src/app/services/common/models/product.service';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent extends BaseComponent {

  constructor(spinner: NgxSpinnerService, private productService: ProductService, private alertify: AlertifyService) {
    super(spinner);

  }
  create(
    name: HTMLInputElement,
    price: HTMLInputElement,
    stock: HTMLInputElement) {
    this.showSpinner();
    const create_product: Create_Product = new Create_Product();
    create_product.name = name.value;
    create_product.stock = parseInt(stock.value);
    create_product.price = parseFloat(price.value);
    this.productService.create(create_product, () => {
      this.hideSpinner();
      this.alertify.message("Ürün Başarıyla Eklenmiştir.", {
        msgType: MessageType.Success,
        position: Position.BottomCenter,
        delay: 3
      });
    });
  }
}
