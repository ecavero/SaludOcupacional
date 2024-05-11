CREATE TABLE [Persona] (
  [idPersona] integer PRIMARY KEY,
  [idTipoPersona] integer,
  [dni] varchar(10),
  [apellidoPaterno] varchar(100),
  [apellidoMaterno] varchar(100),
  [idUbigeo] varchar(6),
  [estado] bit
)
GO

CREATE TABLE [TipoPersona] (
  [idTipoPersona] integer PRIMARY KEY,
  [descripcion] varchar(100)
)
GO

CREATE TABLE [Paciente] (
  [idPersona] integer PRIMARY KEY,
  [numeroDeHistoria] varchar(20),
  [estado] bit
)
GO

CREATE TABLE [Medico] (
  [idPersona] integer PRIMARY KEY,
  [nroColegiatura] integer,
  [especialiad] varchar(100),
  [estado] bit
)
GO

CREATE TABLE [Empleado] (
  [idPersona] integer PRIMARY KEY,
  [nombreEmpleado] varchar(100),
  [clave] varchar(100),
  [estado] bit
)
GO

CREATE TABLE [Empresa] (
  [idEmpresa] integer PRIMARY KEY,
  [nombre] varchar(100),
  [RUC] varchar(60),
  [idUbigeo] varchar(6),
  [estado] bit
)
GO

CREATE TABLE [PerfilMedico] (
  [idPerfilMedico] integer PRIMARY KEY,
  [idPersona] integer,
  [idEmpresa] integer,
  [descripcion] varchar(100)
)
GO

CREATE TABLE [Examen] (
  [idExamen] integer PRIMARY KEY,
  [nombre] varchar(100)
)
GO

CREATE TABLE [PerfilMedicoExamen] (
  [idPerfilMedicoExamen] integer PRIMARY KEY,
  [idPerfilMedico] integer,
  [idExamen] integer
)
GO

CREATE TABLE [Cita] (
  [idCita] integer PRIMARY KEY,
  [idPersona] integer,
  [idPerfilMedico] integer,
  [fecha] datetime,
  [idEmpladoCrea] integer,
  [idEmpleadoModifica] integer,
  [idEmpleadoElimina] integer,
  [estado] bit
)
GO

CREATE TABLE [CitaExamen] (
  [idCitaExamen] integer PRIMARY KEY,
  [idCita] integer,
  [idExamen] integer,
  [idMedico] integer,
  [estado] bit
)
GO

CREATE TABLE [Ubigeo] (
  [idUbigeo] varchar(6) PRIMARY KEY,
  [codProvincia] varchar(2),
  [codDepartamento] varchar(2),
  [codDistrito] varchar(2),
  [provincia] varchar(100),
  [departamento] varchar(100),
  [distrito] varchar(100),
  [estado] bit
)
GO

CREATE TABLE [CitaExamenResultado] (
  [idCitaExamenResultado] integer PRIMARY KEY,
  [idCita] integer,
  [idExamenComponente] integer,
  [resultado] varchar(100),
  [estado] bit
)
GO

CREATE TABLE [ExamenComponente] (
  [idExamenComponente] integer PRIMARY KEY,
  [idExamen] integer,
  [descripcionComponente] varchar(100),
  [estado] bit
)
GO

CREATE TABLE [Auditoria] (
  [idAuditoria] integer PRIMARY KEY,
  [idEmpleado] integer,
  [idCita] integer,
  [fecha] datetime,
  [accion] varchar(100),
  [descripcion] varchar(255)
)
GO

ALTER TABLE [Persona] ADD FOREIGN KEY ([idTipoPersona]) REFERENCES [TipoPersona] ([idTipoPersona])
GO

ALTER TABLE [Paciente] ADD FOREIGN KEY ([idPersona]) REFERENCES [Persona] ([idPersona])
GO

ALTER TABLE [Medico] ADD FOREIGN KEY ([idPersona]) REFERENCES [Persona] ([idPersona])
GO

ALTER TABLE [Empleado] ADD FOREIGN KEY ([idPersona]) REFERENCES [Persona] ([idPersona])
GO

ALTER TABLE [PerfilMedicoExamen] ADD FOREIGN KEY ([idPerfilMedico]) REFERENCES [PerfilMedico] ([idPerfilMedico])
GO

ALTER TABLE [PerfilMedicoExamen] ADD FOREIGN KEY ([idExamen]) REFERENCES [Examen] ([idExamen])
GO

ALTER TABLE [Cita] ADD FOREIGN KEY ([idPerfilMedico]) REFERENCES [PerfilMedico] ([idPerfilMedico])
GO

ALTER TABLE [CitaExamen] ADD FOREIGN KEY ([idCita]) REFERENCES [Cita] ([idCita])
GO

ALTER TABLE [CitaExamen] ADD FOREIGN KEY ([idMedico]) REFERENCES [Medico] ([idPersona])
GO

ALTER TABLE [Cita] ADD FOREIGN KEY ([idPersona]) REFERENCES [Paciente] ([idPersona])
GO

ALTER TABLE [CitaExamenResultado] ADD FOREIGN KEY ([idExamenComponente]) REFERENCES [ExamenComponente] ([idExamenComponente])
GO

ALTER TABLE [CitaExamenResultado] ADD FOREIGN KEY ([idCita]) REFERENCES [Cita] ([idCita])
GO

ALTER TABLE [ExamenComponente] ADD FOREIGN KEY ([idExamen]) REFERENCES [Examen] ([idExamen])
GO

ALTER TABLE [PerfilMedico] ADD FOREIGN KEY ([idPersona]) REFERENCES [Paciente] ([idPersona])
GO

ALTER TABLE [PerfilMedico] ADD FOREIGN KEY ([idEmpresa]) REFERENCES [Empresa] ([idEmpresa])
GO

ALTER TABLE [Persona] ADD FOREIGN KEY ([idUbigeo]) REFERENCES [Ubigeo] ([idUbigeo])
GO

ALTER TABLE [Empresa] ADD FOREIGN KEY ([idUbigeo]) REFERENCES [Ubigeo] ([idUbigeo])
GO

ALTER TABLE [Auditoria] ADD FOREIGN KEY ([idEmpleado]) REFERENCES [Empleado] ([idPersona])
GO

ALTER TABLE [Auditoria] ADD FOREIGN KEY ([idCita]) REFERENCES [Cita] ([idCita])
GO
