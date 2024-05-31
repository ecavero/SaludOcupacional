CREATE VIEW v_Paciente
AS
SELECT pe.idPersona, pe.dni, pe.apellidoPaterno, pe.apellidoMaterno, pe.nombre, u.departamento, u.provincia, u.distrito, pa.numeroDeHistoria, 
CASE pa.estado
        WHEN 1 THEN 'Activo'
        WHEN 0 THEN 'Inactivo'
END AS estado
FROM Persona pe
INNER JOIN Paciente pa
ON pa.idPersona = pe.idPersona
INNER JOIN Ubigeo u
ON u.idUbigeo = pe.idUbigeo
GO

CREATE VIEW v_Departamentos
AS
SELECT u.codDepartamento, MAX(u.departamento) as departamento
FROM Ubigeo u
GROUP BY u.codDepartamento
GO

CREATE VIEW v_Provincias
AS
SELECT u.codDepartamento, u.codProvincia, MAX(u.provincia) as provincia
FROM Ubigeo u
GROUP BY u.codDepartamento, u.codProvincia
GO

CREATE VIEW v_Distritos
AS
SELECT u.idUbigeo, u.codDepartamento, u.codProvincia, u.codDistrito, MAX(u.distrito) as distrito
FROM Ubigeo u
GROUP BY u.idUbigeo, u.codDepartamento, u.codProvincia, u.codDistritoGO
GO

CREATE VIEW v_Empleado
AS
SELECT pe.idPersona, pe.dni, pe.apellidoPaterno, pe.apellidoMaterno, pe.nombre, u.departamento, u.provincia, u.distrito, e.nombreEmpleado, e.clave, 
CASE e.estado
        WHEN 1 THEN 'Activo'
        WHEN 0 THEN 'Inactivo'
END AS estado
FROM Persona pe
INNER JOIN Empleado e
ON e.idPersona = pe.idPersona
INNER JOIN Ubigeo u
ON u.idUbigeo = pe.idUbigeo
GO

CREATE VIEW v_Medico
AS
SELECT pe.idPersona, pe.dni, pe.apellidoPaterno, pe.apellidoMaterno, pe.nombre, u.departamento, u.provincia, u.distrito, m.nroColegiatura, 
m.especialidad, 
CASE m.estado
        WHEN 1 THEN 'Activo'
        WHEN 0 THEN 'Inactivo'
END AS estado
FROM Persona pe
INNER JOIN Medico m
ON m.idPersona = pe.idPersona
INNER JOIN Ubigeo u
ON u.idUbigeo = pe.idUbigeo
GO

