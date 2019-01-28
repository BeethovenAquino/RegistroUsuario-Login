create database UsuariosssDb
go
use UsuariosssDb
go

create table Usuario
(
			UsuarioId int Primary key identity(1,1),
            Nombre Varchar(40),
            NombreUsuario varchar(13),
			Clave varchar(20),
            Fecha date,
            Email varchar(20),
            Telefono varchar(15),
            Celular varchar(10)
);
 
 truncate table Usuarios
 select *from Usuario