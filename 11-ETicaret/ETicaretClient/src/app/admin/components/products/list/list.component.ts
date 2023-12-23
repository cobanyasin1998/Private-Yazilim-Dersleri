import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { NgxSpinnerService } from 'ngx-spinner';
import { BaseComponent } from 'src/app/base/base.component';
import { List_Product } from 'src/app/contracts/list_product';
import { AlertifyService, MessageType, Position } from 'src/app/services/admin/alertify.service';
import { ProductService } from 'src/app/services/common/models/product.service';
import { DialogService } from '../../../../services/common/dialog.service';
import { SelectProductImageDialogComponent } from '../../../../dialogs/select-product-image-dialog/select-product-image-dialog.component';

declare var $: any;
@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent extends BaseComponent {

  constructor(private productService: ProductService, spinner: NgxSpinnerService, private alertifyService: AlertifyService, private dialogService: DialogService) {
    super(spinner);
  }
  displayedColumns: string[] = ['name', 'stock', 'price', 'createdDate', 'updatedDate','photos', 'edit', 'delete']
  dataSource: MatTableDataSource<List_Product> = null; // new MatTableDataSource<PeriodicElement>(ELEMENT_DATA);
  @ViewChild(MatPaginator) paginator: MatPaginator;


  async getProducts() {
    this.showSpinner();
    
    const allProducts: { totalCount: number, products: List_Product[] } = await this.productService.read(this.paginator ? this.paginator.pageIndex : 0, this.paginator ? this.paginator.pageSize : 5, () => this.hideSpinner(), errorMessage => this.alertifyService.message(errorMessage, {
      msgType: MessageType.Error,
      position: Position.BottomCenter
    }));
    this.dataSource = new MatTableDataSource<List_Product>(allProducts.products);
    this.paginator.length = allProducts.totalCount;
    // this.dataSource.paginator = this.paginator;

  }
  async pageChanged() {
    await this.getProducts();
  }

  async ngOnInit() {
    this.getProducts();
  }

  addProductsImages(id: string) {
    this.dialogService.openDialog({
      componentType: SelectProductImageDialogComponent,
      data: id,
      options: {
        width:"1500px"
      }
    })
  }


}
