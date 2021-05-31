import { Component, OnInit } from '@angular/core';
import { CustomerServiceProxy, CustomerViewModel, ProductInBillServiceProxy, ProductInBillViewModel } from '@shared/service-proxies/service-proxies';
import * as moment from 'moment';

@Component({
  selector: 'app-customer-info',
  templateUrl: './customer-info.component.html',
  //styleUrls: ['./customer-info.component.css']
})
export class CustomerInfoComponent implements OnInit {

  productInBillList: ProductInBillViewModel[] = [];
  productOfCurentUserList : ProductInBillViewModel[] = [];
  productInBillListFilter : ProductInBillViewModel[] = [];
  customerList: CustomerViewModel[] = [];
  radio : string;
  isVisible = false;
  isConfirmLoading = false;

  curentAccount : CustomerViewModel;
  radioStatus : string = 'all'
  customerListFilter: CustomerViewModel;
 
  constructor(
    private customerService: CustomerServiceProxy,
    private productInBillService: ProductInBillServiceProxy,
  ) { }

  ngOnInit(): void {
    this.getAllProductInBill('', 'all')
    this.getAllCustomer('');
    
  }

  getAllCustomer(keyword: string) {
    this.customerService.getAllCustomer(keyword).subscribe(x => this.customerList = x);
    setTimeout(() => {
      this.curentAccount = this.customerList.find(x => x.id == Number(sessionStorage.getItem('loginAcountId')))
    }, 1000); 
  }

  getAllProductInBill(keyword: string , switchStatus : string) {
    this.productInBillService.getAllProductInBill(keyword).subscribe(x => {
      this.productInBillList = x
    });
    console.log(switchStatus)
    setTimeout(() => {
      if(switchStatus == 'all')
      {
        this.productOfCurentUserList = this.productInBillList.filter(x => x.customerId == Number(sessionStorage.getItem('loginAcountId')))
      }
      else if(switchStatus == 'inTime')
      {
        this.productOfCurentUserList = this.productInBillList.filter(x => x.customerId == Number(sessionStorage.getItem('loginAcountId')&& x.toDate.isAfter(moment()) == true ))
      }
      else if(switchStatus == 'outTime')
      {
        this.productOfCurentUserList = this.productInBillList.filter(x => x.customerId == Number(sessionStorage.getItem('loginAcountId')&& x.toDate.isAfter(moment()) == false ))
      }
    
      console.log(this.productOfCurentUserList)
    }, 500);
  }

  showModal(): void {
    if (Number(sessionStorage.getItem('loginAcountId')) != undefined) {
      this.customerListFilter = this.customerList.find(x => x.id == Number(sessionStorage.getItem('loginAcountId')));
    }
    this.isVisible = true;
  }

  handleOk(): void {
    this.isConfirmLoading = true;
    setTimeout(() => {
      this.isVisible = false;
      this.isConfirmLoading = false;
    }, 1000);

    this.customerListFilter = undefined

    this.getAllCustomer('')
    setTimeout(() => {
      location.reload();
    }, 500);

  }

  handleCancel(): void {
    this.isVisible = false;
    this.customerListFilter = undefined
  }

}
