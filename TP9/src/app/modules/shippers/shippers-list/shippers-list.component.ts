import { Component, OnInit } from '@angular/core';
import {MatTableModule} from '@angular/material/table';

export interface shippers {
  id: Int32List;
  companyName: string;
  phone: string;
}

@Component({
  selector: 'app-shippers-list',
  templateUrl: './shippers-list.component.html',
  styleUrls: ['./shippers-list.component.scss']
})
export class ShippersListComponent implements OnInit {

  ngOnInit(): void {
    //displayedColumns: string[] = ['id', 'companyName', 'phone'];
    //dataSource = ELEMENT_DATA;
  }

}
