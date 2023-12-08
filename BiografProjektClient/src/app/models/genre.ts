export class Genre {
    id:number = 0;
    name:string = '';
 }

 export function resetGenre() {
    return { id: 0, name: ''};
  }