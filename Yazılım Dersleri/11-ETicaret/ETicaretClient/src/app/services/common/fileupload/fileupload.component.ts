import { Component, Input } from '@angular/core';
import { NgxFileDropEntry, FileSystemFileEntry, FileSystemDirectoryEntry } from 'ngx-file-drop';
import { HttpClientService } from '../http-client.service';
import { HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { AlertifyService, MessageType, Position } from '../../admin/alertify.service';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from '../../ui/custom-toastr.service';
import { MatDialog } from '@angular/material/dialog';
import { FileUploadDialogComponent, FileUploadDialogState } from 'src/app/dialogs/file-upload-dialog/file-upload-dialog.component';
import { DialogService } from '../dialog.service';
@Component({
  selector: 'app-fileupload',
  templateUrl: './fileupload.component.html',
  styleUrls: ['./fileupload.component.css']
})
export class FileuploadComponent {

  constructor(
    private httpClientService: HttpClientService,
    private alertifyService: AlertifyService,
    private toastrService: CustomToastrService,
    private dialog: MatDialog,
    private dialogService: DialogService
  ) {


  }
  public files: NgxFileDropEntry[];

  @Input() options: Partial<FileUploadOptions>

  public selectedFiles(files: NgxFileDropEntry[]) {
    this.files = files;
    const fileData: FormData = new FormData();

    for (const file of files) {
      (file.fileEntry as FileSystemFileEntry).file((_file: File) => {
        fileData.append(_file.name, _file, file.relativePath);
      });
      

    }

    this.dialogService.openDialog({

      componentType: FileUploadDialogComponent,
      data: FileUploadDialogState.Yes,
      afterClosed: () => {
        
        this.httpClientService.post({
          controller: this.options.controller,
          action: this.options.action,
          queryString: this.options.queryString,
          headers: new HttpHeaders({
            "responseType": "blob"
          })
        }, fileData).subscribe(data => {
          const message = "Dosyalar Başarıyla Yüklenmiştir";
          if (this.options.isAdminPage) {
            this.alertifyService.dismissAll();
            this.alertifyService.message(message, {
              msgType: MessageType.Success,
              position: Position.BottomCenter
            })
          }
          else {
            this.toastrService.message(message, "Başarılı", ToastrMessageType.Success, ToastrPosition.BottomCenter);
          }
        }, (errorResponse: HttpErrorResponse) => {
          const message = "Dosyalar Yüklenemedi";
          if (this.options.isAdminPage) {
            this.alertifyService.dismissAll();
            this.alertifyService.message(message, {
              msgType: MessageType.Warning,
              position: Position.BottomCenter
            })
          }
          else {
            this.toastrService.message(message, "Hata", ToastrMessageType.Warning, ToastrPosition.BottomCenter);
          }
        });
}
    });





  }


  
}
export class FileUploadOptions {
  controller?: string;
  action?: string;
  queryString?: string;
  explanation?: string;
  accept?: string;
  isAdminPage?: boolean = false;
}
