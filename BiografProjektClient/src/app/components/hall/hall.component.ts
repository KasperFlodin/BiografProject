import { HallService } from './../../services/hall.service';
import { Hall } from 'src/app/models/hall';
import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  standalone: true,
  selector: 'app-hall',
  templateUrl: './hall.component.html',
  styleUrls: ['./hall.component.css'],
  imports: [CommonModule]
})
export class HallComponent implements OnInit {
  halls: Hall[] | undefined;


constructor(private hallService: HallService) { }

  ngOnInit(): void {
    this.hallService.getAll().subscribe(data => {this.halls = data});
  }


}
