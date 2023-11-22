import { CommonModule } from '@angular/common';
import { MovieService } from './../../services/movie.service';
import { Component, OnInit } from '@angular/core';
import { Movie } from 'src/app/models/movie';

@Component({
  standalone: true,
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css'],
  imports: [CommonModule]
})
export class MovieComponent implements OnInit {
movies: Movie[] | undefined;


constructor(private movieService: MovieService) { }

ngOnInit(): void {
  this.movieService.getAll().subscribe(data => {this.movies = data});
}



}
