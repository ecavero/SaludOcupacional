
USE [SaludOcupacional]
GO
/****** Object:  Table [dbo].[Auditoria]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Auditoria](
	[idAuditoria] [int] NOT NULL,
	[idEmpleado] [int] NULL,
	[idCita] [int] NULL,
	[fecha] [datetime] NULL,
	[accion] [varchar](100) NULL,
	[descripcion] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[idAuditoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[idCita] [int] NOT NULL,
	[idPersona] [int] NULL,
	[idPerfilMedico] [int] NULL,
	[fecha] [datetime] NULL,
	[idEmpladoCrea] [int] NULL,
	[idEmpleadoModifica] [int] NULL,
	[idEmpleadoElimina] [int] NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CitaExamen]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CitaExamen](
	[idCitaExamen] [int] NOT NULL,
	[idCita] [int] NULL,
	[idExamen] [int] NULL,
	[idMedico] [int] NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCitaExamen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CitaExamenResultado]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CitaExamenResultado](
	[idCitaExamenResultado] [int] NOT NULL,
	[idCita] [int] NULL,
	[idExamenComponente] [int] NULL,
	[resultado] [varchar](100) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCitaExamenResultado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[idPersona] [int] NOT NULL,
	[nombreEmpleado] [varchar](100) NULL,
	[clave] [varchar](100) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[idEmpresa] [int] NOT NULL,
	[nombre] [varchar](100) NULL,
	[RUC] [varchar](60) NULL,
	[idUbigeo] [varchar](6) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Examen]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examen](
	[idExamen] [int] NOT NULL,
	[nombre] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idExamen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamenComponente]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamenComponente](
	[idExamenComponente] [int] NOT NULL,
	[idExamen] [int] NULL,
	[descripcionComponente] [varchar](100) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idExamenComponente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medico]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medico](
	[idPersona] [int] NOT NULL,
	[nroColegiatura] [int] NULL,
	[especialidad] [varchar](100) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[idPersona] [int] NOT NULL,
	[numeroDeHistoria] [varchar](20) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PerfilMedico]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PerfilMedico](
	[idPerfilMedico] [int] NOT NULL,
	[idPersona] [int] NULL,
	[idEmpresa] [int] NULL,
	[descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPerfilMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PerfilMedicoExamen]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PerfilMedicoExamen](
	[idPerfilMedicoExamen] [int] NOT NULL,
	[idPerfilMedico] [int] NULL,
	[idExamen] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPerfilMedicoExamen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[idPersona] [int] NOT NULL,
	[idTipoPersona] [int] NULL,
	[dni] [varchar](10) NULL,
	[apellidoPaterno] [varchar](100) NULL,
	[apellidoMaterno] [varchar](100) NULL,
	[idUbigeo] [varchar](6) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPersona]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPersona](
	[idTipoPersona] [int] NOT NULL,
	[descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipoPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ubigeo]    Script Date: 5/21/2024 2:12:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ubigeo](
	[idUbigeo] [varchar](6) NOT NULL,
	[codProvincia] [varchar](2) NULL,
	[codDepartamento] [varchar](2) NULL,
	[codDistrito] [varchar](2) NULL,
	[provincia] [varchar](100) NULL,
	[departamento] [varchar](100) NULL,
	[distrito] [varchar](100) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idUbigeo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Auditoria]  WITH CHECK ADD FOREIGN KEY([idCita])
REFERENCES [dbo].[Cita] ([idCita])
GO
ALTER TABLE [dbo].[Auditoria]  WITH CHECK ADD FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([idPersona])
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD FOREIGN KEY([idPerfilMedico])
REFERENCES [dbo].[PerfilMedico] ([idPerfilMedico])
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD FOREIGN KEY([idPersona])
REFERENCES [dbo].[Paciente] ([idPersona])
GO
ALTER TABLE [dbo].[CitaExamen]  WITH CHECK ADD FOREIGN KEY([idCita])
REFERENCES [dbo].[Cita] ([idCita])
GO
ALTER TABLE [dbo].[CitaExamen]  WITH CHECK ADD FOREIGN KEY([idMedico])
REFERENCES [dbo].[Medico] ([idPersona])
GO
ALTER TABLE [dbo].[CitaExamenResultado]  WITH CHECK ADD FOREIGN KEY([idCita])
REFERENCES [dbo].[Cita] ([idCita])
GO
ALTER TABLE [dbo].[CitaExamenResultado]  WITH CHECK ADD FOREIGN KEY([idExamenComponente])
REFERENCES [dbo].[ExamenComponente] ([idExamenComponente])
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Empresa]  WITH CHECK ADD FOREIGN KEY([idUbigeo])
REFERENCES [dbo].[Ubigeo] ([idUbigeo])
GO
ALTER TABLE [dbo].[ExamenComponente]  WITH CHECK ADD FOREIGN KEY([idExamen])
REFERENCES [dbo].[Examen] ([idExamen])
GO
ALTER TABLE [dbo].[Medico]  WITH CHECK ADD FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD FOREIGN KEY([idPersona])
REFERENCES [dbo].[Persona] ([idPersona])
GO
ALTER TABLE [dbo].[PerfilMedico]  WITH CHECK ADD FOREIGN KEY([idEmpresa])
REFERENCES [dbo].[Empresa] ([idEmpresa])
GO
ALTER TABLE [dbo].[PerfilMedico]  WITH CHECK ADD FOREIGN KEY([idPersona])
REFERENCES [dbo].[Paciente] ([idPersona])
GO
ALTER TABLE [dbo].[PerfilMedicoExamen]  WITH CHECK ADD FOREIGN KEY([idExamen])
REFERENCES [dbo].[Examen] ([idExamen])
GO
ALTER TABLE [dbo].[PerfilMedicoExamen]  WITH CHECK ADD FOREIGN KEY([idPerfilMedico])
REFERENCES [dbo].[PerfilMedico] ([idPerfilMedico])
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD FOREIGN KEY([idTipoPersona])
REFERENCES [dbo].[TipoPersona] ([idTipoPersona])
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD FOREIGN KEY([idUbigeo])
REFERENCES [dbo].[Ubigeo] ([idUbigeo])
GO
USE [master]
GO
ALTER DATABASE [SaludOcupacional] SET  READ_WRITE 
GO
