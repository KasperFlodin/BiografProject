import { HallService } from './../../services/hall.service';
import { Hall } from 'src/app/models/hall';
import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SeatService } from 'src/app/services/seat.service';

@Component({
  standalone: true,
  selector: 'app-hall',
  templateUrl: './hall.component.html',
  styleUrls: ['./hall.component.css'],
  imports: [CommonModule]
})
export class HallComponent implements OnInit {
  halls: Hall[] | undefined;
  hallData!: Hall;

constructor(private hallService: HallService, private seatService: SeatService) { }

  ngOnInit(): void {
    this.hallService.getAll().subscribe(data => {this.halls = data});
  }

  selecthallseats(hallId:number){
    this.hallService.FindById(hallId).subscribe(res => {
      console.log(res);
      this.hallData = res;
    });
  }


}
