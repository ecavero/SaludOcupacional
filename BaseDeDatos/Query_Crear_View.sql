CREATE VIEW v_Paciente
AS

SELECT pe.idPersona, pe.dni, pe.apellidoPaterno, pe.apellidoMaterno, pe.nombre, u.departamento, u.provincia, u.distrito
FROM Persona pe
INNER JOIN Paciente pa
ON pa.idPersona = pe.idPersona
INNER JOIN Ubigeo u
ON u.idUbigeo = pe.idUbigeo
GO
         
