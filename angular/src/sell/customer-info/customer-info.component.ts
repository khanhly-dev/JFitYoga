import { Component, OnInit } from '@angular/core';
import { CustomerServiceProxy, CustomerViewModel, ProductInBillServiceProxy, ProductInBillViewModel } from '@shared/service-proxies/service-proxies';

@Component({
  selector: 'app-customer-info',
  templateUrl: './customer-info.component.html',
  //styleUrls: ['./customer-info.component.css']
})
export class CustomerInfoComponent implements OnInit {

  productInBillList: ProductInBillViewModel[] = [];
  productOfCurentUserList : ProductInBillViewModel[] = [];
  customerList: CustomerViewModel[] = [];

  curentAccount : CustomerViewModel;
  statusCheck : string = 'all'
 
  constructor(
    private customerService: CustomerServiceProxy,
    private productInBillService: ProductInBillServiceProxy,
  ) { }

  ngOnInit(): void {
    this.getAllProductInBill('')
    this.getAllCustomer('');
  }

  getAllCustomer(keyword: string) {
    this.customerService.getAllCustomer(keyword).subscribe(x => this.customerList = x);
    setTimeout(() => {
      this.curentAccount = this.customerList.find(x => x.id == Number(sessionStorage.getItem('loginAcountId')))
    }, 1000);
  }

  getAllProductInBill(keyword: string) {
    this.productInBillService.getAllProductInBill(keyword).subscribe(x => {
      this.productInBillList = x
    });
    setTimeout(() => {
      this.productOfCurentUserList = this.productInBillList.filter(x => x.customerId == Number(sessionStorage.getItem('loginAcountId')))
    }, 1000);
  }
}
