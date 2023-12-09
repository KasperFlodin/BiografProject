import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Movie, resetMovie } from 'src/app/models/movie';
import { MovieService } from 'src/app/services/movie.service';

@Component({
  selector: 'app-adminmovie',
  templateUrl: './adminmovie.component.html',
  styleUrls: ['./adminmovie.component.css'],
  standalone: true,
  imports: [CommonModule, FormsModule],
})
export class AdminmovieComponent implements OnInit{
  message: string = '';
  movies: Movie[] = [];
  movie: Movie = resetMovie();


  constructor(private movieService: MovieService) { }

  ngOnInit(): void {
    this.movieService.getAll().subscribe(m => this.movies = m)
  }

  edit(movie: Movie): void {
    this.movie = {
      id: movie.id,
      name: movie.name,
      releaseDate: movie.releaseDate,
      length: movie.length,
      poster: movie.poster,
    };
  }

  delete(movie: Movie): void{
    if (confirm('Vil du slette?')){
      this.movieService.delete(movie.id).subscribe(() => {
        this.movies = this.movies.filter(x => x.id != movie.id)
      })
    }
  }

  cancel(): void {
    this.message = '';
    this.movie = resetMovie();
  }

  save(): void{
    this.message = '';
    if (this.movie.id == 0) {
      this.movieService.create(this.movie).subscribe({
        next: (x) => {
          this.movies.push(x);
          this.movie = resetMovie();
        },
        error: (err) => {
          this.message = Object.values(err.error.errors).join(', ');
        }
      });
    }
    else {
      this.movieService.update(this.movie).subscribe({
        error: (err) => {
          this.message = Object.values(err.error.errors).join(', ');
        },
        complete: () => {
          this.movieService.getAll().subscribe(x => this.movies = x);
          this.movie = resetMovie();
        }
      });
    }
  }

}
