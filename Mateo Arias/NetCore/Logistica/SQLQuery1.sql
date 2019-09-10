
create database Prueba4
use Prueba4

create table Rol (
RolID int identity not null, 
NombreRol varchar(45) not null, 
constraint PK_Primary_Roles primary key (RolID)
);

create table Administrador (
AdministradorID int identity not null, 
Documento varchar(45)  not null unique, 
Nombre varchar(45) not null unique, 
Contraseña varchar(45) not null,  
RolID int not null, 
constraint PK_Primary_Administrador primary key (AdministradorID),
constraint FK_Administrador_Rol foreign key (RolID) references Rol (RolID)
);

create table Cliente (
ClienteID int identity not null, 
Documento varchar(45)  not null unique, 
Correo varchar(50) not null unique, 
Nombre varchar(45) not null, 
Direccion varchar(50) not null, 
Contraseña varchar(45) not null,
RolID int not null,
constraint PK_Primary_Cliente Primary key (ClienteID), 
constraint FK_Cliente_Rol foreign key (RolID)  references Rol (RolID)
);

create table Domiciliario (
DomiciliarioID int identity not null, 
Documento varchar(45)  not null unique, 
Correo varchar(50) not null unique, 
Nombre varchar(45) not null, 
Contraseña varchar(45) not null ,
RolID int not null,
constraint PK_Primary_Domiciliario Primary key (DomiciliarioID), 
constraint FK_Domiciliario_Rol foreign key (RolID)  references Rol (RolID) 
);

create table personas (
PersonaID int identity not null, 
Documento varchar(45)  not null unique, 
Correo varchar(45) not null unique, 
Nombre varchar(45) not null, 
Direccion varchar(50) not null,  
Contraseña varchar(45) not null ,
RolID int not null,
constraint PK_Primary_Persona Primary key (PersonaID), 
constraint FK_Persona_Rol foreign key (RolID)  references Rol (RolID)
);

insert into Domiciliario (Documento,Correo,Nombre,Contraseña,RolID) values 
('12323','Dom1@gmail.com','Loco','Loquitos',3),
('132','Dom2@gmail.com','Loquete','Sun',3)

insert into Cliente(Documento, Correo, Nombre, Direccion,Contraseña,RolID) values 
('7777','teito@gmail.com','Teito','Cr 123123','Teos',1),
('88888','Juansito@gmail.com','Juanse','Cr 123123','Juanes',1)


insert into Administrador(Documento,Nombre,Contraseña,RolID) values
('13233','Juanse','Juanan',2),
('2333','Teito','Teto',2)

insert into personas(Documento, Correo, Nombre, Direccion,Contraseña,RolID) values 
('123112323','Juansi312to@gmail.com','Juans32ito','Cr 23123','545',1),
('1231233','JuanLoco@gmail.com','JuanLoco','Cr 333','5454',1),
('333','Juansit3223@gmail.com','Juan','Cr 23123','454545',2),
('344','JuanLoc3223o@gmail.com','JuanLoc','Cr 333','54',2),
('444','Juansi3232to@gmail.com','Teo','Cr 23123','04040',3),
('455','JuanLo2323co@gmail.com','Teito','Cr 333','0399',3)



insert into Rol (NombreRol) values 
('Cliente'),
('Administrador'),
('Domiciliario')


select * from personas
select * from Administrador
select * from Cliente
select * from Domiciliario	
select * from Rol