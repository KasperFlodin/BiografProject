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
import { FrontpageComponent } from './frontpage.component';
import { HttpClientModule } from '@angular/common/http';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

// ng add @ng-bootstrap/ng-bootstrap

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MovieComponent,
    HallComponent,
    TicketComponent,
    UserComponent,
    GenreComponent,
    SeatComponent,
    FrontpageComponent,
    HttpClientModule,
    NgbModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
