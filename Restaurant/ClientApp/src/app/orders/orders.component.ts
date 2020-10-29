import { Component, OnInit } from '@angular/core';
import { OrderService } from '../proxy/orders/order.service';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styles: [
  ]
})
export class OrdersComponent implements OnInit {

  constructor(private service:OrderService) { }

  ngOnInit(): void {
  }

}
