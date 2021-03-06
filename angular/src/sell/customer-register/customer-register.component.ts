import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CreateOrUpdateCustomerRequest, CustomerServiceProxy, CustomerViewModel } from '@shared/service-proxies/service-proxies';
import * as moment from 'moment';

@Component({
  selector: 'app-customer-register',
  templateUrl: './customer-register.component.html',
})
export class CustomerRegisterComponent implements OnInit {

  createOrUpdateForm: FormGroup;
  customerList: CustomerViewModel[] = [];

  submitForm(value: CreateOrUpdateCustomerRequest): void {
    for (const key in this.createOrUpdateForm.controls) {
      this.createOrUpdateForm.controls[key].markAsDirty();
      this.createOrUpdateForm.controls[key].updateValueAndValidity();
    }
    this.createOrUpdateCustomer(value)
    setTimeout(() => {
      this.router.navigate(['/sell/login'])
    }, 1000);
  }

  resetForm(e: MouseEvent): void {
    e.preventDefault();
    this.createOrUpdateForm.reset();
    for (const key in this.createOrUpdateForm.controls) {
      this.createOrUpdateForm.controls[key].markAsPristine();
      this.createOrUpdateForm.controls[key].updateValueAndValidity();
    }
  }


  constructor(
    private fb: FormBuilder, 
    private customerService: CustomerServiceProxy,
    private router:Router,)
     {
    this.createOrUpdateForm = this.fb.group({
      name: ['', [Validators.required]],
      phoneNumber: ['', [Validators.required, this.checkDuplicatePhoneNumber().bind(this)]],
      adress: [''],
      born: [''],
      userName: ['', [Validators.required, this.checkDuplicateCustomerUser().bind(this)]],
      password: ['', [Validators.required]],
      email: [''],
    });
  }
  ngOnInit(): void {
    this.getAllCustomer('');
  }

  getAllCustomer(keyword: string) {
    this.customerService.getAllCustomer(keyword).subscribe(x => this.customerList = x);

  }

  checkDuplicateCustomerUser()
  {
    return (cusUser : AbstractControl) => {
      return (this.customerList.filter(x => x.userName == cusUser.value).length > 0) ? {
        invalidCusUser : true
      } : null
    };
  }

  checkDuplicatePhoneNumber()
  {
    return (phoneNumber : AbstractControl) => {
      return (this.customerList.filter(x => x.phoneNumber == phoneNumber.value).length > 0) ? {
        invalidPhoneNumber : true
      } : null
    };
  }

  createOrUpdateCustomer(request: CreateOrUpdateCustomerRequest) {
    request.name = this.createOrUpdateForm.value.name;
    request.phoneNumber = this.createOrUpdateForm.value.phoneNumber;
    request.adress = this.createOrUpdateForm.value.adress;
    request.born = moment(this.createOrUpdateForm.value.born)
    request.userName = this.createOrUpdateForm.value.userName;
    request.password = this.createOrUpdateForm.value.password;
    request.email = this.createOrUpdateForm.value.email;

    this.customerService.createOrUpdateCustomer(request).subscribe();
  }

}
