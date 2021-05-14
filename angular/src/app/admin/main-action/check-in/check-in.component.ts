import { Component, OnInit } from '@angular/core';
import { CreateOrUpdateCustomerInTimeTableRequest, CustomerInTImeTableServiceProxy, CustomerServiceProxy, CustomerViewModel, ProductInBillServiceProxy, ProductInBillViewModel, TimeTableServiceProxy, TimeTableViewModel } from '@shared/service-proxies/service-proxies';
import * as moment from 'moment';

@Component({
  selector: 'app-check-in',
  templateUrl: './check-in.component.html',
})
export class CheckInComponent implements OnInit {

  customerList: CustomerViewModel[] = [];
  customerFullList: CustomerViewModel[] = [];
  timeTableList: TimeTableViewModel[] = [];
  productInBillList: ProductInBillViewModel[] = [];
  binding3  :string
  
  constructor(private customerService: CustomerServiceProxy,
    private productInBillService: ProductInBillServiceProxy,
    private customerInClassService : CustomerInTImeTableServiceProxy,
    private timeTableService: TimeTableServiceProxy,) { }

  ngOnInit(): void {
    this.getAllCustomer('');
    this.getTimeTableByDate();
  }

  getAllCustomer(keyword: string) {
    this.customerService.getAllCustomer(keyword).subscribe(x => this.customerFullList = x);
  }
  
  getCustomerById(id:number)
  {
    this.customerService.getCustomerById(id).subscribe(x => this.customerList = x)
  }

  getProductInBillByCustomerId(customerId : number)
  {
    this.productInBillService.getProductInBillByCustomerId(customerId).subscribe(x => this.productInBillList = x)
  }

  getAllTimeTable(keyword:string, fromDate : string, toDate : string) {
    var fromDateConvert
    var toDateConvert
    if(fromDate != undefined)
    {
      fromDateConvert = moment(fromDate)
    }
    else
    {
      fromDateConvert = undefined
    }

    if(fromDate != undefined)
    {
      toDateConvert = moment(toDate)
    }
    else
    {
      toDateConvert = undefined
    }
    
    this.timeTableService.getAllTimeTable(keyword, fromDateConvert, toDateConvert).subscribe(x => this.timeTableList = x);
  }

  getTimeTableByDate()
  {
    this.timeTableService.getTimeTableByDate(moment(moment().format('YYYY MM DD'))).subscribe(x => this.timeTableList = x)
    console.log(this.timeTableList)
  }

  insertCustomerIntoClass(cusId : number, classId : number)
  {
    const date = moment();
    var request = new CreateOrUpdateCustomerInTimeTableRequest();
    request.customerId = cusId;
    request.timeTableId = classId,
    this.customerInClassService.createOrUpdateCustomerInTimeTable(request).subscribe();
    alert('Đã thêm học viên vào lớp học thành công')
  }
}
