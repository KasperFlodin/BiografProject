import { Component, OnInit } from '@angular/core';
import { SeatService } from './../../services/seat.service';

@Component({
  standalone: true,
  selector: 'app-seat',
  templateUrl: './seat.component.html',
  styleUrls: ['./seat.component.css']
})
export class SeatComponent implements OnInit{


  constructor() { }

  ngOnInit(): void {
    // this.seatService.FindById(Id).subscribe(res => {
    //   console.log(res);
    //   this.seatData = res;
    // });
  }

}
