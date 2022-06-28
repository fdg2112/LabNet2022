import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ShipperAddComponent } from './modules/shippers/shipper-add/shipper-add.component';
import { ShippersListComponent } from './modules/shippers/shippers-list/shippers-list.component';

const routes: Routes = [{
  path: 'shippers-add',
  component: ShipperAddComponent
},
{
  path: 'shippers-list',
  component: ShippersListComponent
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
