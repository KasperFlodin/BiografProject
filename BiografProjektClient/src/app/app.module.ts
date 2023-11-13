import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MovieComponent } from './components/movie/movie.component';
import { HallComponent } from './components/hall/hall.component';
import { TicketComponent } from './components/ticket/ticket.component';
import { UserComponent } from './components/user/user.component';
import { GenreComponent } from './components/genre/genre.component';
import { SeatComponent } from './components/seat/seat.component';

// ng add @ng-bootstrap/ng-bootstrap

@NgModule({
  declarations: [
    AppComponent,
    MovieComponent,
    HallComponent,
    TicketComponent,
    UserComponent,
    GenreComponent,
    SeatComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
