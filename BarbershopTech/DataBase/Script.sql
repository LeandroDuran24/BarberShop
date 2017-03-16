create table Usuarios(
UsuarioId int identity(1,1) primary key,
Nombres varchar(50),
Email varchar(70),
Contrasena varchar(25),
Confirmar varchar(25),
);

create table Clientes(
ClienteId int identity(1,1) primary key,
Nombres varchar(50),
Apellidos varchar(50),
Direccion varchar(50),
Cedula varchar(25),
Email varchar(255),
Fecha datetime,
Telefono varchar(12),
Celular varchar(12),
);

create table Peluqueros(
PeluqueroId int identity(1,1)primary key,
Nombre varchar(25),
);

create table Turnos(
TurnosId int identity(1,1) primary key,
ClienteId int,
PeluqueroId int,
ServicioId int,
NombrePeluquero varchar(50),
NombreCliente varchar(50),
NombreServicio varchar(25)
);

create table TipoServicios(
ServicioId int identity(1,1) primary key,
Nombre varchar(25)
);