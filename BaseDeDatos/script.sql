alter table Persona
add Foto varbinary(max)

go



ALTER PROCEDURE [dbo].[usp_editarMedico]
@idPersona int,
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombre varchar(100),
@idUbigeo varchar(6),
@nroColegiatura int,
@especialidad varchar(100), 
@estado bit,
@foto varbinary(max)
AS
BEGIN
	UPDATE Persona
	SET 
  dni = @dni,
	apellidoPaterno = @apellidoPaterno,
	apellidoMaterno = @apellidoMaterno,
	nombre = @nombre,
	idUbigeo = @idUbigeo,
	estado = @estado,
	Foto = @foto
	WHERE idPersona = @idPersona
	UPDATE Medico
	SET 	
	nroColegiatura = @nroColegiatura,
  especialidad = @especialidad,
	estado = @estado
	WHERE idPersona = @idPersona
END

go


ALTER PROCEDURE [dbo].[usp_insertarMedico]
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombre varchar(100),
@idUbigeo varchar(6),
@nroColegiatura int,
@especialidad varchar(100), 
@estado bit,
@foto varbinary(max)
AS
BEGIN
	DECLARE @ultimoId int
	SELECT @ultimoId = MAX(p.idPersona)
	FROM Persona p
	SET @ultimoId = @ultimoId + 1
	INSERT INTO Persona(idPersona, dni, apellidoPaterno, apellidoMaterno, nombre, idUbigeo, idTipoPersona, estado, Foto)
	VALUES(@ultimoId, @dni, @apellidoPaterno, @apellidoMaterno, @nombre, @idUbigeo, 2, @estado, @foto)
	INSERT INTO Medico(idPersona, nroColegiatura, especialidad, estado)
	VALUES(@ultimoId, @nroColegiatura, @especialidad, @estado)
END

go


ALTER PROCEDURE [dbo].[usp_buscarMedico]
@idPersona int
AS
BEGIN
	SELECT pe.idPersona, pe.dni, pe.nombre, pe.apellidoPaterno, pe.apellidoMaterno, u.codDepartamento, u.codProvincia, u.codDistrito, 
    me.nroColegiatura, me.especialidad, me.estado, pe.Foto
	FROM Persona pe
	INNER JOIN Ubigeo u
	ON u.idUbigeo = pe.idUbigeo
	INNER JOIN Medico me
	ON me.idPersona = pe.idPersona
	WHERE pe.idPersona = @idPersona
END

go


ALTER PROCEDURE [dbo].[usp_editarEmpleado]
@idPersona int,
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombre varchar(100),
@idUbigeo varchar(6),
@usuario varchar(100),
@clave varchar(100),
@estado bit,
@foto varbinary(max)
AS
BEGIN
	UPDATE Persona
	SET 
  dni = @dni,
	apellidoPaterno = @apellidoPaterno,
	apellidoMaterno = @apellidoMaterno,
	nombre = @nombre,
	idUbigeo = @idUbigeo,
	Foto = @foto
	WHERE idPersona = @idPersona
	UPDATE Empleado
	SET 	
	nombreEmpleado = @usuario,
	clave = @clave,
	estado = @estado
	WHERE idPersona = @idPersona
END

go


ALTER PROCEDURE [dbo].[usp_buscarEmpleado]
@idPersona int
AS
BEGIN
        SELECT pe.idPersona, pe.dni, pe.apellidoPaterno, pe.apellidoMaterno, pe.nombre, u.codDepartamento, u.codProvincia, u.codDistrito,
        e.nombreEmpleado, e.clave, e.estado, pe.Foto
        FROM Persona pe
        INNER JOIN Empleado e
        ON e.idPersona = pe.idPersona
        INNER JOIN Ubigeo u
        ON u.idUbigeo = pe.idUbigeo
        WHERE pe.idPersona = @idPersona
END

go



ALTER PROCEDURE [dbo].[usp_insertarEmpleado]
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombreEmpleado varchar(100),
@idUbigeo varchar(6),
@usuario varchar(100),
@clave varchar(100),
@estado bit,
@foto varbinary(max)
AS
BEGIN
	DECLARE @ultimoId int
	SELECT @ultimoId = MAX(p.idPersona)
	FROM Persona p
	SET @ultimoId = @ultimoId + 1
	INSERT INTO Persona(idPersona, dni, apellidoPaterno, apellidoMaterno, nombre, idUbigeo, idTipoPersona, estado, Foto)
	VALUES(@ultimoId, @dni, @apellidoPaterno, @apellidoMaterno, @nombreEmpleado, @idUbigeo, 3, @estado, @foto)
	INSERT INTO Empleado(idPersona, nombreEmpleado, clave, estado)
	VALUES(@ultimoId, @usuario, @clave, @estado)
END

go


ALTER PROCEDURE [dbo].[usp_editarPaciente]
@idPersona int,
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombre varchar(100),
@idUbigeo varchar(6),
@numeroDeHistoria varchar(20),
@estado bit,
@foto varbinary(max)
AS
BEGIN
	UPDATE Persona
	SET 
  dni = @dni,
	apellidoPaterno = @apellidoPaterno,
	apellidoMaterno = @apellidoMaterno,
	nombre = @nombre,
	idUbigeo = @idUbigeo,
	estado = @estado,
	Foto = @foto
	WHERE idPersona = @idPersona
	UPDATE Paciente
	SET 	
	numeroDeHistoria = @numeroDeHistoria,
	estado = @estado
	WHERE idPersona = @idPersona
END

go

ALTER PROCEDURE [dbo].[usp_buscarPaciente]
@idPersona int
AS
BEGIN
	SELECT pe.idPersona, pe.dni, pe.nombre, pe.apellidoPaterno, pe.apellidoMaterno, u.codDepartamento, u.codProvincia, u.codDistrito, 
    pa.numeroDeHistoria, pa.estado, pe.Foto
	FROM Persona pe
	INNER JOIN Ubigeo u
	ON u.idUbigeo = pe.idUbigeo
	INNER JOIN Paciente pa
	ON pa.idPersona = pe.idPersona
	WHERE pe.idPersona = @idPersona
END

go


ALTER PROCEDURE [dbo].[usp_insertarPaciente]
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombre varchar(100),
@idUbigeo varchar(6),
@numeroDeHistoria varchar(20),
@estado bit,
@foto varbinary(max)
AS
BEGIN
	DECLARE @ultimoId int
	SELECT @ultimoId = MAX(p.idPersona)
	FROM Persona p
	SET @ultimoId = @ultimoId + 1
	INSERT INTO Persona(idPersona, dni, apellidoPaterno, apellidoMaterno, nombre, idUbigeo, idTipoPersona, estado, Foto)
	VALUES(@ultimoId, @dni, @apellidoPaterno, @apellidoMaterno, @nombre, @idUbigeo, 1, @estado, @foto)
	INSERT INTO Paciente(idPersona, numeroDeHistoria, estado)
	VALUES(@ultimoId, @numeroDeHistoria, @estado)
END
