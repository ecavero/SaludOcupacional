CREATE PROCEDURE usp_ingresarPersona
@idTipoPersona INT,
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombre varchar(100),
@idUbigeo integer
AS
BEGIN
    INSERT INTO Persona (idTipoPersona, dni, apellidoPaterno, apellidoMaterno, nombre, idUbigeo, estado)
    VALUES (@idTipoPersona, @dni, @apellidoPaterno, @apellidoMaterno, @nombre, @idUbigeo, 1)
END
GO


CREATE PROCEDURE usp_modificarPersona
@idPersona integer,
@idTipoPersona integer,
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@idUbigeo integer
AS
BEGIN
    UPDATE Persona
    SET idTipoPersona = @idTipoPersona,
        dni = @dni,
        apellidoPaterno = @apellidoPaterno,
        apellidoMaterno = @apellidoMaterno,
        nombre = @nombre,
        idUbigeo = @idUbigeo
    WHERE idPersona = @idPersona
END
GO


CREATE PROCEDURE usp_eliminarPersona
@idPersona integer
AS
BEGIN
    UPDATE Persona
    SET estado = 0
    WHERE idPersona = @idPersona
END
GO


CREATE PROCEDURE usp_consultarPersona
@idPersona integer
AS
BEGIN
    SELECT idPersona, idTipoPersona, dni, apellidoPaterno, apellidoMaterno, nombre, idUbigeo, estado 
    FROM Persona
    WHERE idPersona = @idPersona
END
GO

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
    VALUES (@idPersona, @numeroDeHistoria, 1)
END
GO

CREATE PROCEDURE usp_insertarPaciente
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombre varchar(100),
@idUbigeo varchar(6),
@numeroDeHistoria varchar(20),
@estado bit
AS
BEGIN
	DECLARE @ultimoId int
	SELECT @ultimoId = MAX(p.idPersona)
	FROM Persona p
	SET @ultimoId = @ultimoId + 1
	INSERT INTO Persona(idPersona, dni, apellidoPaterno, apellidoMaterno, nombre, idUbigeo, idTipoPersona, estado)
	VALUES(@ultimoId, @dni, @apellidoPaterno, @apellidoMaterno, @nombre, @idUbigeo, 1, @estado)
	INSERT INTO Paciente(idPersona, numeroDeHistoria, estado)
	VALUES(@ultimoId, @numeroDeHistoria, @estado)
END
GO

CREATE PROCEDURE usp_editarPaciente
@idPersona int,
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombre varchar(100),
@idUbigeo varchar(6),
@numeroDeHistoria varchar(20),
@estado bit
AS
BEGIN
	UPDATE Persona
	SET 
  dni = @dni,
	apellidoPaterno = @apellidoPaterno,
	apellidoMaterno = @apellidoMaterno,
	nombre = @nombre,
	idUbigeo = @idUbigeo	
	WHERE idPersona = @idPersona
	UPDATE Paciente
	SET 	
	numeroDeHistoria = @numeroDeHistoria,
	estado = @estado
	WHERE idPersona = @idPersona
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
    SET estado = 0
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


CREATE PROCEDURE usp_buscarPaciente
@idPersona int
AS
BEGIN
	SELECT pe.idPersona, pe.dni, pe.nombre, pe.apellidoPaterno, pe.apellidoMaterno, u.codDepartamento, u.codProvincia, u.codDistrito, 
    pa.numeroDeHistoria, pa.estado
	FROM Persona pe
	INNER JOIN Ubigeo u
	ON u.idUbigeo = pe.idUbigeo
	INNER JOIN Paciente pa
	ON pa.idPersona = pe.idPersona
	WHERE pe.idPersona = @idPersona
END
GO

CREATE PROCEDURE usp_listarPacientes
AS
BEGIN
        SELECT idPersona, dni, apellidoPaterno, apellidoMaterno, nombre, departamento, provincia, distrito, numeroDeHistoria, estado
        FROM v_Paciente
END
GO

CREATE PROCEDURE usp_ingresarMedico
@idPersona INT,
@nroColegiatura integer,
@especialidad nvarchar(255)
AS
BEGIN
    INSERT INTO Medico (idPersona, nroColegiatura, especialidad, estado)
    VALUES (@idPersona, @nroColegiatura, @especialidad, 2)
END
GO


CREATE PROCEDURE usp_insertarMedico
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombre varchar(100),
@idUbigeo varchar(6),
@nroColegiatura int,
@especialidad varchar(100) 
@estado bit
AS
BEGIN
	DECLARE @ultimoId int
	SELECT @ultimoId = MAX(p.idPersona)
	FROM Persona p
	SET @ultimoId = @ultimoId + 1
	INSERT INTO Persona(idPersona, dni, apellidoPaterno, apellidoMaterno, nombre, idUbigeo, idTipoPersona, estado)
	VALUES(@ultimoId, @dni, @apellidoPaterno, @apellidoMaterno, @nombre, @idUbigeo, 2, @estado)
	INSERT INTO Medico(idPersona, nroColegiatura, especialidad, estado)
	VALUES(@ultimoId, @nroColegiatura, @especialidad, @estado)
END
GO


CREATE PROCEDURE usp_editarMedico
@idPersona int,
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombre varchar(100),
@idUbigeo varchar(6),
@nroColegiatura int,
@especialidad varchar(100), 
@estado bit
AS
BEGIN
	UPDATE Persona
	SET 
  dni = @dni,
	apellidoPaterno = @apellidoPaterno,
	apellidoMaterno = @apellidoMaterno,
	nombre = @nombre,
	idUbigeo = @idUbigeo	
	WHERE idPersona = @idPersona
	UPDATE Medico
	SET 	
	nroColegiatura = @nroColegiatura,
  especialidad = @especialidad,
	estado = @estado
	WHERE idPersona = @idPersona
END
GO


CREATE PROCEDURE usp_modificarMedico
@idPersona integer,
@nroColegiatura integer,
@especialidad nvarchar(255)
AS
BEGIN
    UPDATE Medico
    SET nroColegiatura = @nroColegiatura,
        especialidad = @especialidad
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
    VALUES (@idPersona, @nombreUsuario, @clave, 1)
END
GO


CREATE PROCEDURE usp_insertarEmpleado
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombreEmpleado varchar(100),
@idUbigeo varchar(6),
@usuario varchar(100),
@clave varchar(100),
@estado bit
AS
BEGIN
	DECLARE @ultimoId int
	SELECT @ultimoId = MAX(p.idPersona)
	FROM Persona p
	SET @ultimoId = @ultimoId + 1
	INSERT INTO Persona(idPersona, dni, apellidoPaterno, apellidoMaterno, nombre, idUbigeo, idTipoPersona, estado)
	VALUES(@ultimoId, @dni, @apellidoPaterno, @apellidoMaterno, @nombreEmpleado, @idUbigeo, 3, @estado)
	INSERT INTO Empleado(idPersona, nombreEmpleado, clave, estado)
	VALUES(@ultimoId, @usuario, @clave, @estado)
END
GO


CREATE PROCEDURE usp_editarEmpleado
@idPersona int,
@dni varchar(10),
@apellidoPaterno varchar(100),
@apellidoMaterno varchar(100),
@nombre varchar(100),
@idUbigeo varchar(6),
@usuario varchar(100),
@clave varchar(100),
@estado bit
AS
BEGIN
	UPDATE Persona
	SET 
  dni = @dni,
	apellidoPaterno = @apellidoPaterno,
	apellidoMaterno = @apellidoMaterno,
	nombre = @nombre,
	idUbigeo = @idUbigeo	
	WHERE idPersona = @idPersona
	UPDATE Empleado
	SET 	
	nombreEmpleado = @usuario,
  clave = @clave,
	estado = @estado
	WHERE idPersona = @idPersona
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
    SET estado = 0
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

CREATE PROCEDURE usp_buscarEmpleado
@idPersona int
AS
BEGIN
        SELECT pe.idPersona, pe.dni, pe.apellidoPaterno, pe.apellidoMaterno, pe.nombre, u.codDepartamento, u.codProvincia, u.codDistrito,
        e.nombreEmpleado, e.clave, e.estado
        FROM Persona pe
        INNER JOIN Empleado e
        ON e.idPersona = pe.idPersona
        INNER JOIN Ubigeo u
        ON u.idUbigeo = pe.idUbigeo
        WHERE pe.idPersona = @idPersona
END
GO

CREATE PROCEDURE usp_listarEmpleados
AS
BEGIN
        SELECT idPersona, dni, apellidoPaterno, apellidoMaterno, nombre, departamento, provincia, distrito, nombreEmpleado, clave, estado
        FROM v_Empleado
END
GO


CREATE PROCEDURE usp_eliminarMedico
@idPersona integer
AS
BEGIN
    UPDATE Medico
    SET estado = 0
    WHERE idPersona = @idPersona
END
GO

CREATE PROCEDURE usp_consultarMedico
@idPersona integer
AS
BEGIN
    SELECT idPersona, nroColegiatura, especialidad, estado 
    FROM Medico
    WHERE idPersona = @idPersona
END
GO


CREATE PROCEDURE usp_listarMedicos
AS
BEGIN
        SELECT idPersona, dni, apellidoPaterno, apellidoMaterno, nombre, departamento, provincia, distrito, nroColegiatura, especialidad, estado
        FROM v_Medico
END
GO


CREATE PROCEDURE usp_ingresarEmpresa
@nombre varchar(100),
@RUC varchar(60),
@idUbigeo integer
AS
BEGIN
    INSERT INTO Empresa (nombre, RUC, idUbigeo, estado)
    VALUES (@nombre, @RUC, @idUbigeo, 1)
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
    SET estado = 0
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

CREATE PROCEDURE usp_listarDepartamentos
AS
BEGIN
        SELECT codDepartamento, departamento
        FROM v_Departamentos
END
GO

CREATE PROCEDURE usp_listarProvincias
@codDepartamento varchar(2)
AS
BEGIN
        SELECT codProvincia, provincia
        FROM v_Provincias
        WHERE codDepartamento = @codDepartamento
END
GO

CREATE PROCEDURE usp_listarDistritos
@codDepartamento varchar(2),
@codProvincia varchar(2)
AS
BEGIN
        SELECT idUbigeo, codDistrito, distrito
        FROM v_Distritos
        WHERE codDepartamento = @codDepartamento
        AND codProvincia = @codProvincia
END

CREATE TRIGGER ActualizarEstadoCita
ON Cita
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @fechaActual datetime
    SET @fechaActual = GETDATE()

    UPDATE Cita
    SET estado = CASE 
                    WHEN fecha < @fechaActual THEN 0  -- Si la fecha de la cita es anterior a la fecha actual, establece el estado como 0 (pasada)
                    ELSE 1  -- Si la fecha de la cita es igual o posterior a la fecha actual, establece el estado como 1 (programada)
                 END
    WHERE idCita IN (SELECT idCita FROM inserted)
END
