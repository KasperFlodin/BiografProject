import { CommonModule } from '@angular/common';
import { MovieService } from './../../services/movie.service';
import { Component, OnInit } from '@angular/core';
import { Movie } from 'src/app/models/movie';
import { ActivatedRoute, RouterModule } from '@angular/router';

@Component({
  standalone: true,
  selector: 'app-movie',
  templateUrl: './movie.component.html',
  styleUrls: ['./movie.component.css'],
  imports: [CommonModule, RouterModule]
})
export class MovieComponent implements OnInit {
movies: Movie[] | undefined;
movie: Movie[]=[];
popup = false;
movieData!: Movie;


constructor(
  private movieService: MovieService,
  private activatedRoute: ActivatedRoute
  ) { }

ngOnInit(): void {
  this.movieService.getAll().subscribe(data => {this.movies = data});
}

clickpopup(movieId:number){
  this.popup = true;
  // let Id = this.activatedRoute.snapshot.paramMap.get('Id');
//   Id && this.movieService.FindById(movieId).subscribe(res => {
//     console.log(res);
//     this.movieData = res;
// });
this.movieService.FindById(movieId).subscribe(res => {
  console.log(res);
  this.movieData = res;
});
}



}
