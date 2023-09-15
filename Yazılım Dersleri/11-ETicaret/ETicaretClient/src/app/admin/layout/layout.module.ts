import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LayoutComponent } from './layout.component';
import { ComponentsModule } from './components/components.module';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { FooterComponent } from './components/footer/footer.component';
import { RouterLink, RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    LayoutComponent

  ],
  imports: [
    CommonModule,
    ComponentsModule,
    RouterLink,
    RouterModule
  ],
  exports: [
    LayoutComponent
  ]
})
export class LayoutModule { }
