import { Component, EventEmitter, Output } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent } from 'src/app/base/base.component';
import { Create_Product } from 'src/app/contracts/create_product';
import { AlertifyOptions, AlertifyService, MessageType, Position } from 'src/app/services/admin/alertify.service';
import { FileUploadOptions } from 'src/app/services/common/fileupload/fileupload.component';
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

  @Output() createdProduct: EventEmitter<Create_Product> = new EventEmitter();

  @Output() fileUploadOptions: Partial<FileUploadOptions> = {
    action: "upload",
    controller: "product",
    explanation: "Resimleri Sürükleyin veya seçin...",
    isAdminPage: true,
    accept: ".png,.jpg,.jpeg"
  };

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
      this.createdProduct.emit(create_product);
    }, errorMessage => {
      this.alertify.message(errorMessage, {
        msgType: MessageType.Error,
        position: Position.BottomCenter,
        delay: 5
      });
    });
  }
}
