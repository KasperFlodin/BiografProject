import { HallService } from './../../services/hall.service';
import { Hall } from 'src/app/models/hall';
import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SeatService } from 'src/app/services/seat.service';
import { Seat } from 'src/app/models/seat';
import {MatIconModule} from '@angular/material/icon';

@Component({
  standalone: true,
  selector: 'app-hall',
  templateUrl: './hall.component.html',
  styleUrls: ['./hall.component.css'],
  imports: [CommonModule, MatIconModule]
})
export class HallComponent implements OnInit {
  halls: Hall[] | undefined;
  hallData!: Hall;
  seatData!: Seat;
  hallSelected = false;

constructor(private hallService: HallService, private seatService: SeatService) { }

  ngOnInit(): void {
    this.hallService.getAll().subscribe(data => {this.halls = data});
  }

  selectHallseats(hallId:number){
    this.hallSelected = true;
    this.hallService.FindById(hallId).subscribe(h => {
      console.log(h);
      this.hallData = h;
    });
  }

  selectSeatsbyHallId(hallId:number){
    this.hallSelected = true;
    this.seatService.FindByHallId(hallId).subscribe(h => {
      this.seatData = h;
    });
  }

}
