--create database BD_PROYECTO_JM
use BD_PROYECTO_JM;
go 

create table area(
area_id int identity (0,1) primary key,
area_puesto varchar(25) not null
)

create table usuario(
usu_id int identity (0,1) primary key,
usu_nombre varchar (20) not null,
usu_pass   varchar(15) not null,
usu_area int not null

constraint fk_usu_area 
foreign key(usu_area) references area(area_id)
);

create table acceso(
acc_id int identity (0,1) primary key,
acc_seccion varchar(30) not null
)

create table acceso_usuario(
acc_usu_id int identity (0,1) primary key,
acc_usu_intacc int not null,
acc_usu_intusu int not null,
acc_usu_permiso bit default 1

constraint fk_acc_usu_intacc
foreign key(acc_usu_intacc) references acceso(acc_id),

constraint fk_acc_usu_intusu
foreign key(acc_usu_intusu) references usuario(usu_id)

)


insert into area(area_puesto) values ('SISTEMAS')
insert into area(area_puesto) values ('TEJIDO')
insert into area(area_puesto) values ('PROCESO')



insert into usuario(usu_nombre, usu_pass, usu_area)values('admin','admin',0)
insert into usuario(usu_nombre, usu_pass, usu_area)values('tejido','tejido',1)
insert into usuario(usu_nombre, usu_pass, usu_area)values('proceso','proceso',2)
SELECT * FROM area;
select * from usuario;


delete usuario where usu_id > 2

delete area where area_id > 2