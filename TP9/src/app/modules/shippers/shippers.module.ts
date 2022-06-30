import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShippersListComponent } from './shippers-list/shippers-list.component';
import { ReactiveFormsModule } from '@angular/forms';
import { ShipperAddComponent } from './shipper-add/shipper-add.component';
import { HttpClientModule } from '@angular/common/http';
import { ShipperEditComponent } from './shipper-edit/shipper-edit.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';


@NgModule({
  declarations: [
    ShippersListComponent,
    ShipperAddComponent,
    ShipperEditComponent,
  ],
  entryComponents: [ShipperAddComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgbModule
  ]
})
export class ShippersModule { }
