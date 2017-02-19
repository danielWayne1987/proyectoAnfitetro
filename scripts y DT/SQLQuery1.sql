create database anfiteatro

use anfiteatro

create table Productos(
id_producto int not null,nombre_producto varchar(40),fecha_producto date not null,
cantidad_actual int not null,cantidad_minima int not null)

select * from Productos

create table pasword (pass1 varchar (10),pass2 varchar(10))
select * from pasword

insert into pasword values ('anfi123456','anfiteatro')