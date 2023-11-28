import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', loadComponent: () => import('./frontpage.component').then(_=>_.FrontpageComponent) },
  { path: 'movie', loadComponent: () => import('./components/movie/movie.component').then(_=>_.MovieComponent) },
  { path: 'genre', loadComponent: () => import('./components/genre/genre.component').then(_=>_.GenreComponent) },
  { path: 'hall', loadComponent: () => import('./components/hall/hall.component').then(_=>_.HallComponent) },
  { path: 'seat', loadComponent: () => import('./components/seat/seat.component').then(_=>_.SeatComponent) },
  { path: 'ticket', loadComponent: () => import('./components/ticket/ticket.component').then(_=>_.TicketComponent) },
  { path: 'user', loadComponent: () => import('./components/user/user.component').then(_=>_.UserComponent) },

  { path: '**', redirectTo: '', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
