import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerLoginComponent } from './customer-login/customer-login.component';
import { CustomerRegisterComponent } from './customer-register/customer-register.component';
import { PageComponent } from './page/page.component';
import { SellComponent } from './sell.component';
import { ShopingComponent } from './shoping/shoping.component';
import { StudentRegisterComponent } from './student-register/student-register.component';
import { TimetableOfCustomerComponent } from './timetable-of-customer/timetable-of-customer.component';


@NgModule({
  imports: [
    RouterModule.forChild([
      {
          path: '',
          component: SellComponent,
          children: [
            {path : 'shoping', component: ShopingComponent},
            {path : 'login', component: CustomerLoginComponent},
            {path : 'register', component: CustomerRegisterComponent},
            {path : 'student', component: StudentRegisterComponent},
            {path : 'page', component: PageComponent},  
            {path : 'time', component: TimetableOfCustomerComponent},      
          ]
      }
  ])
  ],
  exports: [RouterModule]
})
export class SellRoutingModule { }
