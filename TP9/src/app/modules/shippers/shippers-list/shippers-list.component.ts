import { Component, OnInit } from '@angular/core';
import { Shipper } from '../models/shipper';
import { ShippersService } from '../services/shippers.service';
import { ActivatedRoute, Router } from '@angular/router';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';



@Component({
  selector: 'app-shippers-list',
  templateUrl: './shippers-list.component.html',
  styleUrls: ['./shippers-list.component.scss']
})
export class ShippersListComponent implements OnInit {

  shipper!: Shipper;
  shippersList: Shipper[] = [];
  closeResult: string = '';

  constructor( private shippersService: ShippersService, private activatedRoute: ActivatedRoute, private router: Router, private modalService: NgbModal){}

  ngOnInit(): void {
    this.getAllShippers();
    this.activatedRoute.data.subscribe(({ shipper }) => {
      this.shipper = shipper;
    });
  }

  removeShipper(id: string){
    if (confirm("Seguro de eliminar?") == true) {
      this.shippersService.deleteShipper(id).subscribe(() => {
      this.getAllShippers();
    });
    }
  }

  getAllShippers(){
    this.shippersService.getShippers().subscribe(response => {
      this.shippersList = response
    });
  }

  openAdd(content:any) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  openEdit(content:any,shipper: Shipper) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
    this.shipper = shipper;
  } 

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return  `with: ${reason}`;
    }
  }

}
