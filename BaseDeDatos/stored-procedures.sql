
create procedure usp_ingresarPersona
@idTipoPersona INT,
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@idUbigeo integer
as

insert into Persona (idTipoPersona, dni, apellidoPaterno, apellidoMaterno, idUbigeo, estado)
values (@idTipoPersona, @dni, @apellidoPaterno, @apellidoMaterno, @idUbigeo, true)
go

create procedure usp_modificarPersona
@idTipoPersona integer,
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@idUbigeo integer
as

update Persona p 
set 
p.dni = @dni, 
p.apellidoPaterno = @apellidoPaterno, 
p.apellidoMaterno = @apellidoMaterno, 
p.idUbigeo = @idUbigeo
where p.idPersona = @idPersona
go

create procedure usp_eliminarPersona
@idPersona integer,
as

update Persona p
set p.estado = false
where p.idPersona = @idPersona
