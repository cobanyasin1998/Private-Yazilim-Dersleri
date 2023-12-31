import { Component, OnInit } from '@angular/core';
import { ProductService } from '../../../../services/common/models/product.service';
import { List_Product } from '../../../../contracts/list_product';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

  constructor(private productService: ProductService, private activatedRoute: ActivatedRoute) { }

  currentPageNo: number;
  totalProductCount: number;
  totalPageCount: number;
  pageSize: number = 12;
  products: List_Product[];
  pageList: number[] = [];



   ngOnInit() {
     this.activatedRoute.params.subscribe(async params => {
       this.currentPageNo = parseInt(params["pageNo"] ?? 1);


       const data = await this.productService.read(this.currentPageNo - 1, this.pageSize, () => {

      }, errorMessage => {


      });

       this.products = data.products;

      

       this.totalProductCount = data.totalCount;
       this.totalPageCount = Math.ceil(this.totalProductCount / this.pageSize);

       this.pageList = [];

       if (this.currentPageNo - 3 <= 0) {
         for (let i = 0; i < 7; i++) {
           this.pageList.push(i);
         }
       }
       else if (this.currentPageNo + 3 >= this.totalPageCount) {
         for (let i = this.totalPageCount - 6; i <= this.totalPageCount; i++) {
           this.pageList.push(i);
         }
       }
       else {
         for (var i = this.currentPageNo - 3; i <= this.currentPageNo + 3; i++) {
           this.pageList.push(i);
         }
       }


     });

  }
}
