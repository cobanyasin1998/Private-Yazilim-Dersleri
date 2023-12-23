import { Component, Inject, OnInit, Output } from '@angular/core';
import { BaseDialog } from '../base/base-dialog';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { FileUploadOptions } from '../../services/common/fileupload/fileupload.component';
import { ProductService } from '../../services/common/models/product.service';
import { List_Product_Image } from '../../contracts/list_product_image';
import { NgxSpinnerModule, NgxSpinnerService } from 'ngx-spinner';
import { MatCard } from '@angular/material/card';

declare var $: any;

@Component({
  selector: 'app-select-product-image-dialog',
  templateUrl: './select-product-image-dialog.component.html',
  styleUrls: ['./select-product-image-dialog.component.css']
})
export class SelectProductImageDialogComponent extends BaseDialog<SelectProductImageDialogComponent> implements OnInit {
  constructor(dialogRef: MatDialogRef<SelectProductImageDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public data: SelectProductImageState | string, private productService: ProductService)
  {
    super(dialogRef)
  }
  images: List_Product_Image[];

  async ngOnInit() {
   
    this.images = await this.productService.readImages(this.data as string, () => {   });
    
    }

  async deleteImage(imageId: string, event: any) {
    
    await this.productService.deleteImage(this.data as string, imageId, () => {
 
      $(event.target.parentElement.parentElement.parentElement).fadeOut(1000);
  
    });
  }

  @Output() options: Partial<FileUploadOptions> = {
    accept: ".png, .jpeg, .jpg",
    action: "upload",
    controller: "product",
    explanation: "Ürün Resimini Seçin veya buraya sürükleyin",
    isAdminPage: true,
    queryString:`id=${this.data}`
  };


}
export enum SelectProductImageState {
  Close
}
