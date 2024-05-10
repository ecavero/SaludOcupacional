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
go

create procedure usp_consultarPersona
@idPersona integer
as

select idTipoPersona, dni, apellidoPaterno, apellidoMaterno, idUbigeo, estado 
from Persona
where idPersona = @idPersona
go


CREATE PROCEDURE usp_ingresarTipoPersona
@descripcion varchar(10)
AS
BEGIN
    INSERT INTO TipoPersona (descripcion)
    VALUES (@descripcion)
END
GO

CREATE PROCEDURE usp_modificarTipoPersona
@idTipoPersona integer,
@descripcion varchar(10)
AS
BEGIN
    UPDATE TipoPersona
    SET descripcion = @descripcion
    WHERE idTipoPersona = @idTipoPersona
END
GO

CREATE PROCEDURE usp_eliminarTipoPersona
@idTipoPersona integer
AS
BEGIN
    DELETE FROM TipoPersona
    WHERE idTipoPersona = @idTipoPersona
END
GO

CREATE PROCEDURE usp_consultarTipoPersona
@idTipoPersona integer
AS
BEGIN
    SELECT descripcion
    FROM TipoPersona
    WHERE idTipoPersona = @idTipoPersona
END
GO


CREATE PROCEDURE usp_ingresarPaciente
@idPersona INT,
@numeroDeHistoria varchar(20)
AS
BEGIN
    INSERT INTO Paciente (idPersona, numeroDeHistoria, estado)
    VALUES (@idPersona, @numeroDeHistoria, true)
END
GO

CREATE PROCEDURE usp_modificarPaciente
@idPersona integer,
@numeroDeHistoria varchar(20)
AS
BEGIN
    UPDATE Paciente
    SET numeroDeHistoria = @numeroDeHistoria
    WHERE idPersona = @idPersona
END
GO

CREATE PROCEDURE usp_eliminarPaciente
@idPersona integer
AS
BEGIN
    UPDATE Paciente
    SET estado = false
    WHERE idPersona = @idPersona
END
GO

CREATE PROCEDURE usp_consultarPaciente
@idPersona integer
AS
BEGIN
    SELECT idPersona, numeroDeHistoria, estado 
    FROM Paciente
    WHERE idPersona = @idPersona
END
GO


CREATE PROCEDURE usp_ingresarMedico
@idPersona INT,
@nroColegiatura integer,
@especialiad nvarchar(255)
AS
BEGIN
    INSERT INTO Medico (idPersona, nroColegiatura, especialiad, estado)
    VALUES (@idPersona, @nroColegiatura, @especialiad, true)
END
GO

CREATE PROCEDURE usp_modificarMedico
@idPersona integer,
@nroColegiatura integer,
@especialiad nvarchar(255)
AS
BEGIN
    UPDATE Medico
    SET nroColegiatura = @nroColegiatura,
        especialiad = @especialiad
    WHERE idPersona = @idPersona
END
GO


CREATE PROCEDURE usp_ingresarUsuario
@idPersona INT,
@nombreUsuario varchar(100),
@clave nvarchar(255)
AS
BEGIN
    INSERT INTO Usuario (idPersona, nombreUsuario, clave, estado)
    VALUES (@idPersona, @nombreUsuario, @clave, true)
END
GO

CREATE PROCEDURE usp_modificarUsuario
@idPersona integer,
@nombreUsuario varchar(100),
@clave nvarchar(255)
AS
BEGIN
    UPDATE Usuario
    SET nombreUsuario = @nombreUsuario,
        clave = @clave
    WHERE idPersona = @idPersona
END
GO

CREATE PROCEDURE usp_eliminarUsuario
@idPersona integer
AS
BEGIN
    UPDATE Usuario
    SET estado = false
    WHERE idPersona = @idPersona
END
GO

CREATE PROCEDURE usp_consultarUsuario
@idPersona integer
AS
BEGIN
    SELECT idPersona, nombreUsuario, clave, estado 
    FROM Usuario
    WHERE idPersona = @idPersona
END
GO

CREATE PROCEDURE usp_eliminarMedico
@idPersona integer
AS
BEGIN
    UPDATE Medico
    SET estado = false
    WHERE idPersona = @idPersona
END
GO

CREATE PROCEDURE usp_consultarMedico
@idPersona integer
AS
BEGIN
    SELECT idPersona, nroColegiatura, especialiad, estado 
    FROM Medico
    WHERE idPersona = @idPersona
END
GO


CREATE PROCEDURE usp_ingresarEmpresa
@nombre varchar(100),
@RUC varchar(60),
@idUbigeo integer
AS
BEGIN
    INSERT INTO Empresa (nombre, RUC, idUbigeo, estado)
    VALUES (@nombre, @RUC, @idUbigeo, true)
END
GO

CREATE PROCEDURE usp_modificarEmpresa
@idEmpresa integer,
@nombre varchar(100),
@RUC varchar(60),
@idUbigeo integer
AS
BEGIN
    UPDATE Empresa
    SET nombre = @nombre,
        RUC = @RUC,
        idUbigeo = @idUbigeo
    WHERE idEmpresa = @idEmpresa
END
GO

CREATE PROCEDURE usp_eliminarEmpresa
@idEmpresa integer
AS
BEGIN
    UPDATE Empresa
    SET estado = false
    WHERE idEmpresa = @idEmpresa
END
GO

CREATE PROCEDURE usp_consultarEmpresa
@idEmpresa integer
AS
BEGIN
    SELECT idEmpresa, nombre, RUC, idUbigeo, estado 
    FROM Empresa
    WHERE idEmpresa = @idEmpresa
END
GO
