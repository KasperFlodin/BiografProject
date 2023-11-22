import { Role } from './role';

export class User {
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
