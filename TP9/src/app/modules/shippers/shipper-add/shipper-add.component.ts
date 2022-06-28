import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Shipper } from '../models/shipper';
import { ShippersService } from '../services/shippers.service';

@Component({
  selector: 'app-shipper-add',
  templateUrl: './shipper-add.component.html',
  styleUrls: ['./shipper-add.component.scss']
})
export class ShipperAddComponent implements OnInit {

  public form!: FormGroup;

  constructor( private readonly fb: FormBuilder, private shipperService: ShippersService) { }

  ngOnInit(): void {
    this.form = this.fb.group ({
      companyName: new FormControl ('',Validators.required),
      phone: new FormControl ('',Validators.required)
    });
  }

  addShipper(){
    var shipper = new Shipper();
    shipper.companyName = this.form.get('companyName')?.value;
    shipper.phone = this.form.get('phone')?.value;
    this.shipperService.createShipper(shipper).subscribe(res => {
      alert('Proveedor Agregado!' + res);
      this.form.reset();
    })
  }

}
