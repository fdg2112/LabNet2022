import { Component, OnInit, ViewChild } from '@angular/core';
import { Shipper } from '../models/shipper';
import { ShippersService } from '../services/shippers.service';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';


@Component({
  selector: 'app-shippers-list',
  templateUrl: './shippers-list.component.html',
  styleUrls: ['./shippers-list.component.scss']
})
export class ShippersListComponent implements OnInit {

  @ViewChild('myModal') myModal;

  shippersList: Shipper[] = [];

  constructor( private shippersService: ShippersService){}

  ngOnInit(): void {
    this.getAllShippers();
  }


  removeShipper(id: string){
    this.shippersService.deleteShipper(id).subscribe(() => {
      this.getAllShippers();
    })
  }

  
  getAllShippers(){
    this.shippersService.getShippers().subscribe(response => {
      this.shippersList = response
    });
  }

  openModalShipper(shipper: Shipper){
    this.myModal.nativeElement.className = 'modal fade show';
  }



}
