import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Shipper } from '../models/shipper';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-shipper-edit',
  templateUrl: './shipper-edit.component.html',
  styleUrls: ['./shipper-edit.component.scss']
})
export class ShipperEditComponent implements OnInit {

  public form!: FormGroup;

  constructor( private readonly fb: FormBuilder, private shipperService: ShippersService) { }

  ngOnInit(): void {
    
  }

  editShipper(){
    
  }

}
