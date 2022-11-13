create database ENCUESTAS

create table Personas(
cedula varchar(15) primary key,
nombre varchar(50) not null,
genero char(1) constraint chk_genero check(genero = 'F' or Genero = 'M'),
fecha date constraint def_fecha default getdate()
);
create table Respuestas(
id int identity(1,1),
cedula varchar(15),
r1 char(1),
r2 char(2),
r3 char(3)
constraint pk_id primary key(id),
constraint fk_cedula foreign key(cedula) references Personas(cedula)
);

create table RespuestasPrueba(
r1 char (1),
r2 char(1),
r3 char(1)
)

insert into RespuestasPrueba values ('f','b','a')

insert into Personas values ('1','Maria Rodriguez','F',GETDATE())
insert into Personas values ('2','Maria Rodriguez','F','')
select * from Personas
select * from Respuestas
delete from Respuestas where cedula = '11112'
delete from Personas where cedula = 2
insert into Respuestas values ('1','a','b','c')
insert into Respuestas values ('1','c','a','a')

select Personas.nombre,Respuestas.cedula,Respuestas.r1, Respuestas.r2, Respuestas.r3 from Respuestas
join Personas
on Respuestas.cedula = Personas.cedula