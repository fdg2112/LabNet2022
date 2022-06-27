import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShippersListComponent } from './shippers-list/shippers-list.component';
import { ReactiveFormsModule } from '@angular/forms';
import { ShipperAddComponent } from './shipper-add/shipper-add.component';


@NgModule({
  declarations: [
    ShippersListComponent,
    ShipperAddComponent,
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule
  ]
})
export class ShippersModule { }
