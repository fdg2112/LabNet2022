import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShippersListComponent } from './shippers-list/shippers-list.component';
import { ReactiveFormsModule } from '@angular/forms';
import { ShipperAddComponent } from './shipper-add/shipper-add.component';
import { HttpClientModule } from '@angular/common/http';


@NgModule({
  declarations: [
    ShippersListComponent,
    ShipperAddComponent,
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpClientModule
  ]
})
export class ShippersModule { }