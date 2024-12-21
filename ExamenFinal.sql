create database examenfinal
go
use examenfinal
go
create table Empleados
(
id int identity primary key,
NumeroCarnet varchar(300)unique,
Nombre varchar(300),
FechaNacimiento varchar(300),
Categoria varchar(300),
Salario varchar(300) default'250000',
Direccion varchar(300)default'San Jose',
telefono varchar(300),
correo varchar(300)unique
)
select * from Empleados
insert into Empleados  (NumeroCarnet,Nombre,FechaNacimiento,Categoria,Direccion,Telefono,correo) values('9','v','6756','v','t','b','6')
create procedure AgregarEmpleados

@NumeroCarnet varchar(300),
@Nombre varchar(300),
@FechaNacimiento varchar(300),
@Categoria varchar(300),
@Salario varchar(300) ,
@Direccion varchar(300) ,
@telefono varchar(300),
@correo varchar(300)

as 
begin
insert into Empleados values (@NumeroCarnet,@Nombre,@FechaNacimiento,@Categoria,@Salario,@Direccion,@Telefono,@correo)

end
create procedure borararEmpleado
@id int
as
begin
delete Empleados where id=@id

end
create procedure ConsultarEmpleado
@id int
as
begin
select * from Empleados where id=@id

end

create table Proyectos
(
Id int identity primary key,
Codigo Varchar(300) unique,
Nombre varchar(300) unique,
Fechainicio varchar(300),
FechaFin varchar(300),
)
insert into Proyectos (Codigo,Nombre,Fechainicio,FechaFin) values('4','Jahir','10/2/2025','4/2/2026')
select * from Proyectos
create procedure AgregarProyectos

@codigo varchar(300),
@Nombre varchar(300),
@Fechainicio varchar(300),
@Fechafin varchar(300)

as 
begin
insert into Proyectos values (@Codigo,@Nombre,@Fechainicio,@Fechafin)

end
create procedure borararProyecto
@id int
as
begin
delete Proyectos where id=@id

end

create table Asignaciones
(
id int identity primary key,
Empleadoid int foreign key references Empleados(id),
Proyectoid int foreign key references Proyectos(Id),
FechaAsignacion varchar(300) 
)
create procedure AgregarAsignacion

@Empleadoid int,
@Proyectoid int,
@FechaAsignacion varchar(300)


as 
begin
insert into Asignaciones values (@Empleadoid,@Proyectoid,@FechaAsignacion)

end
create procedure borararAsignacion
@id int
as
begin
delete Asignaciones where id=@id

end
create table Categoria
(
id int identity primary key,
Categoria varchar(300),
)