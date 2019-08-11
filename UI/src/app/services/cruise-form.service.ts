import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';

import { catchError } from 'rxjs/operators';
import { throwError, Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Http, Response, Headers, RequestOptions } from "@angular/http";

@Injectable({
  providedIn: 'root'
})
export class CruiseFormService {
  apiUrl: string = environment.apiUrl;
  apiCruiseUrl: string = this.apiUrl + '/api/Cruise';
  cruiseLineUrl: string = this.apiCruiseUrl + '/CruiseLine';
  shipsUrl: string = this.apiCruiseUrl + '/ships?nId=';
  catagoriesUrl: string = this.apiCruiseUrl + '/catagories';
  constructor(private http: HttpClient) { }
  getCruises() {
    return this.http.get<any[]>(`${this.cruiseLineUrl}`).pipe(
      catchError(this.handleError)
    );
  }

  getShips(nid: any) {
    return this.http.get<any[]>(`${this.shipsUrl}` + nid).pipe(
      catchError(this.handleError)
    );
  }

  getCatagories(nid: any, shipid: any) {
    return this.http.get<any[]>(`${this.catagoriesUrl}` + '?nId=' + nid + '&shipId=' + shipid).pipe(
      catchError(this.handleError)
    );
  }

  postCruise(cruise: any) {
    return this.http.post(`${this.apiCruiseUrl}`, cruise).pipe(
      catchError(this.handleError)
    );
  }

  private handleError(error: any) {
    return throwError(error);
  }

}
