import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup } from '@angular/forms';
import { OrderService } from 'src/app/proxy/orders/order.service';

@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})
export class OrderComponent implements OnInit {

  orderNo:number=1;

  orderForm:FormGroup
  buildOrderForm(){
  this.orderForm=this.fb.group({
     orderNo:[this.orderNo+1],
     customerId:[''],
     pMethod:[''],
     gTotal:[0]
  });}

  onSubmit(){
    this.orderNo+=1
    this.buildOrderForm()
  }

  constructor(private service:OrderService,private fb:FormBuilder) {
    this.orderNo=0
   }

  ngOnInit(): void {
    this.buildOrderForm()
  }

}
