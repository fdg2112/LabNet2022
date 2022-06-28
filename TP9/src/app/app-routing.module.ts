import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './modules/home/home.component';
import { ShipperAddComponent } from './modules/shippers/shipper-add/shipper-add.component';
import { ShippersListComponent } from './modules/shippers/shippers-list/shippers-list.component';

const routes: Routes = [{
  path: 'home',
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
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
