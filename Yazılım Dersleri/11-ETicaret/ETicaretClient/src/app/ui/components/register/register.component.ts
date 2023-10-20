import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  constructor(private formBuilder: FormBuilder) { }


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
  onSubmit(data: User) {
    this.submitted = true;
    if (this.frm.invalid) {
      return;
    }



  }

  frm: FormGroup;



}
