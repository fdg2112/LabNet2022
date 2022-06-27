import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-shipper-add',
  templateUrl: './shipper-add.component.html',
  styleUrls: ['./shipper-add.component.scss']
})
export class ShipperAddComponent implements OnInit {

  form!: FormGroup;

  constructor( private readonly fb: FormBuilder ) { }

  ngOnInit(): void {
    this.form = this.fb.group ({
      companyName: [''],
      phone: ['']
    });

  }
}
