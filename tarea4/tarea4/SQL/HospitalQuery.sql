create database HOSPITAL

create table Paciente(
cedula int primary key,
nombre varchar(50) not null,
edad int,
genero char(1),
provincia varchar(10),
canton varchar(15),
distrito varchar(15),
telefono int,
seguro bit not null
)

insert into Paciente values('702230743','Allan Picado',29,'M','Heredia','Sto.Domingo','Sto.Tomas',62241775,1)
insert into Paciente values('302540531','Maria Fonseca',60,'F','San Jose','Tibas','cinco esq',88996644,0)

select * from Paciente
