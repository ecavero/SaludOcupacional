CREATE VIEW v_Paciente
AS
SELECT pe.idPersona, pe.dni, pe.apellidoPaterno, pe.apellidoMaterno, pe.nombre, u.departamento, u.provincia, u.distrito
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
SELECT u.codDepartamento, u.codProvincia, u.codDistrito, MAX(u.distrito) as distrito
FROM Ubigeo u
GROUP BY u.codDepartamento, u.codProvincia, u.codDistrito
GO
