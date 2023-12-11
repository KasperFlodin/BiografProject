use BiografProjekt
go

create table a
(
id int primary key identity(1,1),
mail nvarchar(128),
newrow nvarchar(128)
)
insert into a values('a','newrow1')
insert into a values('b','newrow2')
insert into a values('c','newrow3')
insert into a values('d','newrow4')
insert into a values('e','newrow5')
insert into a values('f','newrow6')
insert into a values('g','newrow7')

select * from a where 1=1;

delete from a where newrow='newrow3';

truncate table a

drop table a