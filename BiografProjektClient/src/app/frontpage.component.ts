import { CommonModule } from "@angular/common";
import { Component } from "@angular/core";
import { RouterModule } from "@angular/router";


@Component({
  selector: 'app-frontpage',
  standalone:true,
  imports:[CommonModule, RouterModule],
  template:`
    <p>frontpage works!</p>
    <p>Homepage</p>
  `,
  styles: []
})
export class FrontpageComponent  {


  constructor() { }

  ngOnInit(): void {

  }


}
