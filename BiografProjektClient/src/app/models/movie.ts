import { Genre } from './genre';

export class Movie {
  id:number = 0;
  name:string = '';
  releaseDate:number = 0;
  length:number = 0;
  poster:string = '';
  genres?: Genre[];
}

export function resetMovie() {
  return { id: 0, name: '', releaseDate:0, length: 0, poster: ''};
}
