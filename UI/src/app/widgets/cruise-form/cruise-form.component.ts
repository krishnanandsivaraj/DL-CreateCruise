import { Component, OnInit } from '@angular/core';
import { CruiseFormService } from '../../services/cruise-form.service';

export interface Food {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'dl-cruise-form',
  templateUrl: './cruise-form.component.html',
  styleUrls: ['./cruise-form.component.scss']
})
export class CruiseFormComponent implements OnInit {
  ports: any[] = [
    { value: 'port-0', viewValue: 'port 0' },
    { value: 'port-1', viewValue: 'port 1' }
  ];
  constructor(private cruiseFormService: CruiseFormService) { }
  cruisedisabled = true;
  shipsdisabled = true;
  catagorydisabled = true;
  isvalid = true;
  cruiseLine: any[];
  nid: number;
  ships: any[];
  shipid: number;
  catagories: any[];
  companyid: number;
  departuredate: Date;
  checked: boolean = false;
  ngOnInit() {
    this.cruiseFormService.getCruises().subscribe(res => {
      this.cruiseLine = res;
      this.cruisedisabled = false;
    });
  }

  changeClient(data) {
    this.cruiseFormService.getShips(data).subscribe(res => {
      if (res.length == 0) { alert('no data for ship'); }
      this.ships = res;
      this.shipsdisabled = false;
      this.nid = data;
      this.changeShip(data);
    });
  }

  changeShip(data) {
    this.cruiseFormService.getCatagories(this.nid, data).subscribe(res => {
      // if (res.length == 0) { alert('no data for catagory'); }
      this.catagories = res;
      this.catagorydisabled = false;
      this.shipid = data;

    });
  }

  changeCatagory(data) {
    this.companyid = data;
    this.isvalid = false;

  }

  Create() {
    let input = {
      "nid": this.nid,
      "shipId": this.shipid,
      "cabinType": this.companyid,
      "rid": [
        {
          "day": 0,
          "port": "string"
        }
      ],
      "departureDate": this.departuredate,
      "isFlight": this.checked
    };
    console.log(input);
    this.cruiseFormService.postCruise(input).subscribe(
      data => console.log(data),
      err => alert('server error!! try again' + err),
      () => alert('Inserted Successfully!!')//this has to be material snackbar
    );


  }

  toggle(data) {
    this.checked = data;
  }

  EndDateChange(data) {
    this.departuredate = data.value.toLocaleDateString();

  }

}
