import { HttpErrorResponse } from '@angular/common/http';
import { Directive, ElementRef, EventEmitter, HostListener, Input, Output, Renderer2 } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { DeleteDialogComponent, DeleteState } from 'src/app/dialogs/delete-dialog/delete-dialog.component';
import { AlertifyService, MessageType, Position } from 'src/app/services/admin/alertify.service';
import { HttpClientService } from 'src/app/services/common/http-client.service';
import { DialogService } from '../../services/common/dialog.service';

declare var $: any;

@Directive({
  selector: '[appDelete]'
})
export class DeleteDirective {

  constructor(
    private element: ElementRef,
    private _renderer: Renderer2,
    private httpClientService: HttpClientService,
    public dialog: MatDialog,
    private alertifyService: AlertifyService,
    private dialogService: DialogService
  ) {
    const img = _renderer.createElement("img");
    img.setAttribute("src", "/assets/icon/delete_icon.png")
    img.setAttribute("style", "cursor:pointer;");
    img.width = 32;
    _renderer.appendChild(element.nativeElement, img);
  }
  @Input() controller: string;
  @Input() id: string;
  @Output() callBackInit: EventEmitter<any> = new EventEmitter();
  @HostListener("click")
  async onclick() {
    this.dialogService.openDialog({
      componentType: DeleteDialogComponent,
      data: DeleteState.Yes,
      afterClosed: (async () => {
        const td: HTMLTableCellElement = this.element.nativeElement;

        //await this.productService.delete(this.id);

        this.httpClientService.delete({
          controller: this.controller
        }, this.id).subscribe(data => {
          $(td.parentElement).animate({
            opacity: 0,
            left: "+=50",
            height: "toogle"
          }, 700, () => {

            this.callBackInit.emit;
            this.alertifyService.message("Ürün Başarıyla Silinmiştir", {
              msgType: MessageType.Success,
              position: Position.BottomCenter
            });
          })

        }, (errorResponse: HttpErrorResponse) => {
          this.alertifyService.message("Hata", {
            msgType: MessageType.Warning,
            position: Position.BottomCenter
          });
        })




      })
    });

  }

}
