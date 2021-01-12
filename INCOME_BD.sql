Create Database INCOME
Use INCOME


create table Usuarios
(IdUser int IDENTITY primary key,
nombre varchar(40),
username varchar(20),
email varchar(40),
password varchar(25),
foto varchar(40))

create table Categorias
(IdCategoria int primary key,
IdUser int foreign key references Usuarios(IdUser),
Descripcion varchar(30),
Monto money,
Tipo varchar(20),
Fecha datetime)

create Table Ingresos
(IdIngreso int primary key,
Descripcion varchar(30))

Create table Egresos
(IdEgresos int primary key,
Descripcion varchar(30))

Create table Subtotal
(IdSubtotal int primary key,
IdUser int foreign key references Usuarios(IdUser),
Ingreso money,
Egreso money,
Balance money)
