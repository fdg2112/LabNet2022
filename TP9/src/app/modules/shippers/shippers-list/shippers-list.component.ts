import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Shipper } from '../models/shipper';
import { ShippersService } from '../services/shippers.service';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-shippers-list',
  templateUrl: './shippers-list.component.html',
  styleUrls: ['./shippers-list.component.scss']
})
export class ShippersListComponent implements OnInit {

  shipper!: Shipper;

  @ViewChild('modalShipper') modal!: ElementRef;

  modalSwitch!: boolean;

  shippersList: Shipper[] = [];

  constructor( private shippersService: ShippersService, private activatedRoute: ActivatedRoute, private modalShipper: NgbModal){}

  ngOnInit(): void {
    this.getAllShippers();
    this.activatedRoute.data.subscribe(({ shipper }) => {
      this.shipper = shipper;
      //this.openModalShipper(this.modal ,shipper);
  });
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

  openModalAdd(){
      this.modalSwitch=true;
  }

  // openModalShipper(modal: ElementRef, shipper: Shipper){
  //   this.shipper = shipper;
  //   this.modalShipper.open(modal);
  // }



}
