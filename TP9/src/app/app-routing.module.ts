import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './modules/home/home.component';
import { ShipperAddComponent } from './modules/shippers/shipper-add/shipper-add.component';
import { ShipperEditComponent } from './modules/shippers/shipper-edit/shipper-edit.component';
import { ShippersListComponent } from './modules/shippers/shippers-list/shippers-list.component';

const routes: Routes = [{
  path: '',
  component: HomeComponent
},
{
  path: 'shippers-add',
  component: ShipperAddComponent
},
{
  path: 'shippers-list',
  component: ShippersListComponent
}
,
{
  path: 'shippers-edit',
  component: ShipperEditComponent
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
