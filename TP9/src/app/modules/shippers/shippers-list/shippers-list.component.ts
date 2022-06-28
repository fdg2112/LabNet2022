import { Component, OnInit } from '@angular/core';
import {MatTableModule} from '@angular/material/table';
import { Shipper } from '../models/shipper';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-shippers-list',
  templateUrl: './shippers-list.component.html',
  styleUrls: ['./shippers-list.component.scss']
})
export class ShippersListComponent implements OnInit {

  shippersList: Shipper[] = [];

  constructor( private shippersService: ShippersService){}

  ngOnInit(): void {
    this.shippersService.getShippers().subscribe(response => {
      this.shippersList = response
    });
  }

  removeShipper(id: string){
    this.shippersService.deleteShipper(id);
  }

}
