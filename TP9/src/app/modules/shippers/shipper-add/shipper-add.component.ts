import { Component, Output, OnInit, EventEmitter } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Shipper } from '../models/shipper';
import { ShippersService } from '../services/shippers.service';


@Component({
  selector: 'app-shipper-add',
  templateUrl: './shipper-add.component.html',
  styleUrls: ['./shipper-add.component.scss']
})
export class ShipperAddComponent implements OnInit {

  @Output() save = new EventEmitter();

  public form!: FormGroup;

  constructor( private readonly fb: FormBuilder, private shipperService: ShippersService) { }

  ngOnInit(): void {
    this.form = this.fb.group ({
      companyName: new FormControl ('',[Validators.required,Validators.maxLength(60)]),
      phone: new FormControl ('',[Validators.maxLength(24),Validators.pattern('[0-9]+$')])
    });
  }

  get f(){
    return this.form.controls;
  }

  addShipper(){
    var shipper = new Shipper();
    shipper.CompanyName = this.form.get('companyName')?.value;
    shipper.Phone = this.form.get('phone')?.value;
    this.shipperService.createShipper(shipper).subscribe(() => {
      this.save.emit();
      this.form.reset();
    })
  }


}
