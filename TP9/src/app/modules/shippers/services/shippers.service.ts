import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Shipper } from '../models/shipper';
import { EventEmitter } from 'stream';

@Injectable({
  providedIn: 'root'
})
export class ShippersService {

  $modal = new EventEmitter<any>();

  constructor(private http: HttpClient) { }

  createShipper(request: Shipper) : Observable<any>{
    let endpoint = "api/Shippers"
    return this.http.post(environment.shipper + endpoint, request);
  }

  getShippers() : Observable<any>{
    let endpoint = "api/Shippers"
    return this.http.get(environment.shipper + endpoint);
  }
  
  updateShipper(request: Shipper) : Observable<any>{
    let endpoint = "api/Shippers"
    return this.http.put(environment.shipper + endpoint, request);
  }

  deleteShipper(id: string) : Observable<number>{
    let endpoint = "api/Shippers/"
    return this.http.delete<number>(environment.shipper + endpoint + id);
  }
  
}
