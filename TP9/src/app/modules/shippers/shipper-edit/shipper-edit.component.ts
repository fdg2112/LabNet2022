import { Component, Input, Output, OnInit, EventEmitter } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Shipper } from '../models/shipper';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-shipper-edit',
  templateUrl: './shipper-edit.component.html',
  styleUrls: ['./shipper-edit.component.scss']
})
export class ShipperEditComponent implements OnInit {

  @Input() shipper!: Shipper;

  @Output() save = new EventEmitter();

  public form!: FormGroup;

  constructor( private readonly fb: FormBuilder, private shipperService: ShippersService, private router: Router) { }

  ngOnInit(): void {
    this.form = this.fb.group ({
      companyName: new FormControl ('',[Validators.required,Validators.maxLength(60)]),
      phone: new FormControl ('',[Validators.maxLength(24),Validators.pattern('[0-9]+$')])
    });
    if (this.shipper) {
      this.form.patchValue({
        'companyName': this.shipper.CompanyName,
        'phone': this.shipper.Phone
      });
    }
  }

  get f(){
    return this.form.controls;
  }
  
  editShipper(){
    var shipperM = new Shipper();
    shipperM.CompanyName = this.form.get('companyName')?.value;
    shipperM.Phone = this.form.get('phone')?.value;
    this.shipperService.updateShipper(this.shipper.ShipperID,shipperM).subscribe(() => {
      this.save.emit();
      this.form.reset();
    })
  }



}
