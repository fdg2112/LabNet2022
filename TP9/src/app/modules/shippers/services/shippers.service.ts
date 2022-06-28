import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Shipper } from '../models/shipper';

@Injectable({
  providedIn: 'root'
})
export class ShippersService {

  constructor(private http: HttpClient) { }

  createShipper(request: Shipper) : Observable<any>{
    let endpoint = "api/Shippers"
    return this.http.post(environment.shipper + endpoint, request);
  }

  getShippers() : Observable<any>{
    let endpoint = "api/Shippers"
    return this.http.get(environment.shipper + endpoint);
  }
}
