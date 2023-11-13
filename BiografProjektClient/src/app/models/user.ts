import { Role } from './role';

export class Hall {
    id:number = 0;
    name:string = '';
    email:string = '';
    address:string = '';
    city:string = '';
    postnr:string = '';
    phone:string = '';
    role?: Role;
    password:string = '';
 }