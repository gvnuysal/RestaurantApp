import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CustomersComponent } from './customers/customers.component';
import { OrderComponent } from './orders/order/order.component';
import { OrdersComponent } from './orders/orders.component';

const routes: Routes = [
  {path:'',redirectTo:'order',pathMatch:'full'},
  {path:'customer',component:CustomersComponent},
  {path:'orders',component:OrdersComponent},
  {path:'order',children:[
    {path:'',component:OrderComponent},
    {path:'edit/:id',component:OrderComponent}
  ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
