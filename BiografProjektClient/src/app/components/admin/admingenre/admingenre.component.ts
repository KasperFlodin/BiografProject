import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Genre, resetGenre } from 'src/app/models/genre';
import { GenreService } from 'src/app/services/genre.service';

@Component({
  selector: 'app-admingenre',
  templateUrl: './admingenre.component.html',
  styleUrls: ['./admingenre.component.css'],
  standalone: true,
  imports: [CommonModule, FormsModule],
})
export class AdmingenreComponent implements OnInit {
  message: string = '';
  genres: Genre[] = [];
  genre: Genre = resetGenre();

  constructor(private genreService: GenreService) { }

  ngOnInit(): void {
    this.genreService.getAll().subscribe(g => this.genres = g)
  }

  edit(genre: Genre): void {
    this.genre = {
      id: genre.id,
      name: genre.name
    };
  }

  delete(genre: Genre): void{
    if (confirm('Vil du slette?')){
      this.genreService.delete(genre.id).subscribe(() => {
        this.genres = this.genres.filter(x => x.id != genre.id)
      })
    }
  }

  cancel(): void {
    this.message = '';
    this.genre = resetGenre();
  }

  save(): void{
    this.message = '';
    if (this.genre.id == 0) {
      this.genreService.create(this.genre).subscribe({
        next: (x) => {
          this.genres.push(x);
          this.genre = resetGenre();
        },
        error: (err) => {
          this.message = Object.values(err.error.errors).join(', ');
        }
      });
    }
    else {
      this.genreService.update(this.genre).subscribe({
        error: (err) => {
          this.message = Object.values(err.error.errors).join(', ');
        },
        complete: () => {
          this.genreService.getAll().subscribe(x => this.genres = x);
          this.genre = resetGenre();
        }
      });
    }
  }

}
