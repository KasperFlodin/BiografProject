import { Component, OnInit } from '@angular/core';
import { Genre } from 'src/app/models/genre';
import { GenreService } from 'src/app/services/genre.service';
import { CommonModule } from '@angular/common';

@Component({
  standalone: true,
  selector: 'app-genre',
  imports: [CommonModule],
  templateUrl: './genre.component.html',
  styleUrls: ['./genre.component.css']
})
export class GenreComponent implements OnInit{
  genres: Genre[] | undefined;

constructor(private genreService: GenreService) { }

  ngOnInit(): void {
    this.genreService.getAll().subscribe(data => { this.genres = data; });
  }
}


