import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { User } from '../../../entities/user';
import { UserService } from '../../../services/common/models/user.service';
import { Create_User } from '../../../contracts/users/create_user';
import { CustomToastrService, ToastrMessageType, ToastrPosition } from '../../../services/ui/custom-toastr.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  constructor(private formBuilder: FormBuilder, private userService: UserService, private toastrService: CustomToastrService) { }


  ngOnInit(): void {
    this.frm = this.formBuilder.group({
      nameSurname: ["",
        [
          Validators.required,
          Validators.maxLength(50),
          Validators.minLength(3)]
      ],
      username: ["",
        [
          Validators.required,
          Validators.maxLength(50),
          Validators.minLength(3)]
      ],
      email: ["",
        [
          Validators.required,
          Validators.maxLength(250),
          Validators.minLength(3)],
        Validators.email
      ],
      password: ["",
        [
          Validators.required,
          Validators.maxLength(50),
          Validators.minLength(3)]
      ],
      repassword: ["",
        [
          Validators.required,
          Validators.maxLength(50),
          Validators.minLength(3)]
      ]
    })
  }

  get component() {
    return this.frm.controls;
  }
  submitted: boolean;
  async onSubmit(data: User) {
    this.submitted = true;
    if (this.frm.invalid) {
      return;
    }
    const result: Create_User = await this.userService.create(data);
    debugger
    if (result.success) {
      this.toastrService.message(result.message, "KullanıcıKaydıBaşarılı", ToastrMessageType.Success, ToastrPosition.BottomCenter);
    }
    else {
      this.toastrService.message(result.message, "KullanıcıKaydıBaşarısız", ToastrMessageType.Error, ToastrPosition.BottomCenter);

    }

  }

  frm: FormGroup;



}
