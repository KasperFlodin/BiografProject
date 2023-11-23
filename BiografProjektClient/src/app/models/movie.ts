import { Genre } from './genre';
export class Movie {
  id:number = 0;
  name:string = '';
  releaseDate:number = 0;
  lenght:number = 0;
  genres?: Genre[];
}
