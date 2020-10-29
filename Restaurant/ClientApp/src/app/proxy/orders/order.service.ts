import { Injectable } from "@angular/core";
import { Order } from './model';

@Injectable({
    providedIn:'root'
})
export class OrderService{

    formData:Order
    constructor() {
        
    }
}