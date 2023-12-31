import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsModule } from './products/products.module';
import { CustomerModule } from './customer/customer.module';
import { DashboardModule } from './dashboard/dashboard.module';
import { OrderModule } from './order/order.module';



@NgModule({
 
  imports: [
    CommonModule,
    ProductsModule,
    CustomerModule,
    DashboardModule,
    OrderModule
  ]
})
export class ComponentsModule { }
