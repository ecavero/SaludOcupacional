INSERT INTO [Persona] ([idPersona], [idTipoPersona], [dni], [apellidoPaterno], [apellidoMaterno], [idUbigeo], [estado])
VALUES
(1, 1, '8765432', 'García', 'Fernández', '010101', 1),
(2, 2, '7654321', 'López', 'Martínez', '020101', 0),
(3, 3, '6543210', 'Pérez', 'González', '030101', 1),
(4, 1, '5432109', 'Sánchez', 'Ramírez', '040101', 0),
(5, 2, '4321098', 'Torres', 'Ruiz', '050101', 1),
(6, 3, '3210987', 'Flores', 'Morales', '060101', 1),
(7, 1, '2109876', 'Gómez', 'Ortiz', '070101', 0),
(8, 2, '1098765', 'Díaz', 'Moreno', '080101', 1),
(9, 3, '0987654', 'Mendoza', 'Jiménez', '090101', 0),
(10, 1, '9876543', 'Alvarez', 'Pérez', '100101', 1),
(11, 2, '8765439', 'Vargas', 'Gutiérrez', '110101', 1),
(12, 3, '7654328', 'Castillo', 'Rojas', '120101', 0),
(13, 1, '6543217', 'Ortega', 'Cruz', '130101', 1),
(14, 2, '5432106', 'Suárez', 'Delgado', '010201', 0),
(15, 3, '4321095', 'Molina', 'Soto', '020201', 1),
(16, 1, '3210984', 'Romero', 'Vásquez', '030201', 1),
(17, 2, '2109873', 'Santos', 'Herrera', '040201', 0),
(18, 3, '1098762', 'Salazar', 'Aguilar', '050201', 1),
(19, 1, '0987651', 'Luna', 'Castro', '060201', 0),
(20, 3, '9876540', 'Cabrera', 'Espinoza', '070101', 1);
GO

INSERT INTO [TipoPersona] ([idTipoPersona], [descripcion])
VALUES 
    (1, 'Paciente'),
    (2, 'Médico'),
    (3, 'Empleado');
GO

INSERT INTO [Paciente] ([idPersona], [numeroDeHistoria], [estado])
VALUES
(1, '12345678', 1),
(4, '23456789', 0),
(7, '34567890', 1),
(10, '45678901', 1),
(13, '56789012', 1),
(16, '67890123', 1),
(19, '78901234', 0);
GO

INSERT INTO [Medico] ([idPersona], [nroColegiatura], [especialiad], [estado])
VALUES
(2, '012345', 'Cardiología', 1),
(5, '023456', 'Dermatología', 1),
(8, '034567', 'Neurología', 0),
(11, '045678', 'Pediatría', 1),
(14, '056789', 'Ginecología', 0),
(17, '067890', 'Oncología', 1),
(20, '078901', 'Traumatología', 1);
GO

INSERT INTO [Empleado] ([idPersona], [nombreEmpleado], [clave], [estado])
VALUES
(3, 'Juan', 'clave123', 1),
(6, 'Ana', 'clave456', 1),
(9, 'Carlos', 'clave789', 0),
(12, 'Lucía', 'clave012', 0),
(15, 'Miguel', 'clave345', 1),
(18, 'Sofía', 'clave678', 1),
(20, 'Gabriela', 'clave901', 1);
GO

INSERT INTO [Empresa] ([idEmpresa], [nombre], [RUC], [idUbigeo], [estado])
VALUES
(1, 'Productos Globales S.A.C', '2012345678', '010101', 1),
(2, 'Industrias Unidas S.A.C', '2023456789', '020101', 0),
(3, 'Comercializadora Andina S.A.C', '2034567890', '030101', 1),
(4, 'Inversiones Pacífico S.A.C', '2045678901', '040101', 0),
(5, 'Electrónicos Modernos S.A.C', '2056789012', '050101', 1),
(6, 'Textiles Importados S.A.C', '2067890123', '060101', 1),
(7, 'Construcciones Metropolitanas S.A.C', '2078901234', '070101', 0),
(8, 'Cosmética Natural S.A.C', '2089012345', '080101', 1),
(9, 'Agronegocios del Sur S.A.C', '2090123456', '090101', 0),
(10, 'Distribuidora Centro S.A.C', '2012345678', '100101', 1),
(11, 'Minería Nacional S.A.C', '2023456789', '110101', 0),
(12, 'Envases y Embalajes S.A.C', '2034567890', '120101', 1),
(13, 'Consultoría Integral S.A.C', '2045678901', '130101', 0),
(14, 'Bebidas y Refrescos S.A.C', '2056789012', '010201', 1),
(15, 'Comunicaciones Avanzadas S.A.C', '2067890123', '020201', 0),
(16, 'Automotriz Nacional S.A.C', '2078901234', '030201', 1),
(17, 'Transportes Rápidos S.A.C', '2089012345', '040201', 0),
(18, 'Servicios Corporativos S.A.C', '2090123456', '050201', 1),
(19, 'Cosméticos y Belleza S.A.C', '2012345678', '060201', 0),
(20, 'Editorial Educativa S.A.C', '2023456789', '070101', 1);
GO

INSERT INTO [PerfilMedico] ([idPerfilMedico], [idPersona], [idEmpresa], [descripcion])
VALUES
(1, 1, 1, 'Revisión anual completa incluyendo evaluación cardiovascular y pruebas de esfuerzo.'),
(2, 4, 2, 'Evaluación ergonómica para prevenir lesiones por esfuerzo repetitivo.'),
(3, 7, 3, 'Examen visual y auditivo para trabajadores en ambientes de alta demanda sensorial.'),
(4, 10, 4, 'Control de salud mental y estrés laboral para optimizar el rendimiento y bienestar.'),
(5, 13, 5, 'Chequeo general pre-empleo con énfasis en capacidad respiratoria.'),
(6, 16, 1, 'Evaluaciones periódicas para trabajadores nocturnos, enfocándose en ritmos circadianos.'),
(7, 19, 2, 'Exámenes regulares para detectar riesgos ocupacionales específicos del sector industrial.');
GO

CREATE TABLE [Examen] (
  [idExamen] integer PRIMARY KEY,
  [nombre] varchar(100)
)
GO

INSERT INTO [Examen] ([idExamen], [nombre])
VALUES
(1, 'Evaluación Cardiovascular Completa'),
(2, 'Prueba de Esfuerzo Cardíaco'),
(3, 'Evaluación Ergonómica'),
(4, 'Examen Visual Estándar'),
(5, 'Examen Auditivo'),
(6, 'Evaluación de Salud Mental'),
(7, 'Control de Estrés Laboral'),
(8, 'Chequeo General Pre-empleo'),
(9, 'Prueba de Capacidad Respiratoria'),
(10, 'Evaluación de Ritmos Circadianos'),
(11, 'Análisis de Riesgos Ocupacionales'),
(12, 'Examen de Flexibilidad y Movilidad'),
(13, 'Test de Tolerancia al Estrés'),
(14, 'Examen Dermatológico Básico'),
(15, 'Monitorización de la Presión Arterial'),
(16, 'Screening de Diabetes Ocupacional'),
(17, 'Análisis de Postura y Movimiento'),
(18, 'Evaluación Nutricional'),
(19, 'Revisión Ortopédica'),
(20, 'Pruebas de Detección de Sustancias');
GO

INSERT INTO [PerfilMedicoExamen] ([idPerfilMedicoExamen], [idPerfilMedico], [idExamen])
VALUES
(1, 1, 1),
(2, 1, 2),
(3, 2, 3),
(4, 2, 17),
(5, 3, 4),
(6, 3, 5),
(7, 4, 6),
(8, 4, 7),
(9, 5, 8),
(10, 5, 9),
(11, 6, 10),
(12, 7, 11),
(13, 1, 15),
(14, 2, 12),
(15, 3, 14),
(16, 4, 13),
(17, 5, 18),
(18, 6, 16),
(19, 7, 19),
(20, 1, 20),
(21, 2, 20),
(22, 3, 20),
(23, 4, 20),
(24, 5, 20),
(25, 6, 20),
(26, 7, 20);
GO

INSERT INTO [Cita] ([idCita], [idPersona], [idPerfilMedico], [fecha], [idEmpladoCrea], [idEmpleadoModifica], [idEmpleadoElimina], [estado])
VALUES
(1, 1, 1, '2023-01-15 09:00:00', 3, NULL, NULL, 1),
(2, 4, 2, '2023-03-22 10:30:00', 6, 9, NULL, 1),
(3, 7, 3, '2022-11-01 14:00:00', 12, NULL, 18, 0),
(4, 10, 4, '2024-02-18 16:45:00', 15, 15, 20, 1),
(5, 13, 5, '2023-05-20 08:15:00', 18, 3, NULL, 1),
(6, 16, 6, '2023-07-30 11:00:00', 20, NULL, NULL, 0),
(7, 19, 7, '2023-09-15 13:30:00', 3, 6, 9, 1),
(8, 1, 1, '2023-12-05 09:45:00', 12, NULL, NULL, 1),
(9, 4, 2, '2022-10-21 14:30:00', 15, 18, 20, 0),
(10, 7, 3, '2024-01-11 15:00:00', 6, 12, 18, 1);
GO

INSERT INTO [CitaExamen] ([idCitaExamen], [idCita], [idExamen], [idMedico], [estado])
VALUES
(1, 1, 1, 2, 1),
(2, 1, 2, 2, 1),
(3, 2, 3, 5, 1),
(4, 3, 4, 8, 0),
(5, 3, 5, 8, 1),
(6, 4, 6, 11, 1),
(7, 5, 7, 14, 1),
(8, 6, 8, 17, 0),
(9, 7, 9, 20, 1),
(10, 8, 10, 2, 1),
(11, 9, 11, 5, 0),
(12, 10, 12, 8, 1),
(13, 1, 13, 2, 1),
(14, 2, 14, 5, 1),
(15, 3, 15, 8, 1),
(16, 4, 16, 11, 0),
(17, 5, 17, 14, 1),
(18, 6, 18, 17, 0),
(19, 7, 19, 20, 1),
(20, 8, 20, 2, 1);
GO

INSERT INTO [Ubigeo] ([idUbigeo], [codProvincia], [codDepartamento], [codDistrito], [provincia], [departamento], [distrito], [estado])
VALUES
('010101', '01', '01', '01', 'Chachapoyas', 'Amazonas', 'Chachapoyas', 1),
('010201', '02', '01', '01', 'Bagua', 'Amazonas', 'Aramango', 0),
('020101', '01', '02', '01', 'Huaraz', 'Ancash', 'Huaraz', 1),
('020201', '02', '02', '01', 'Aija', 'Ancash', 'Aija', 1),
('030101', '01', '03', '01', 'Abancay', 'Apurímac', 'Abancay', 0),
('030201', '02', '03', '01', 'Andahuaylas', 'Apurímac', 'Talavera', 0),
('040101', '01', '04', '01', 'Arequipa', 'Arequipa', 'Arequipa', 1),
('040201', '02', '04', '01', 'Caravelí', 'Arequipa', 'Caravelí', 0),
('050101', '01', '05', '01', 'Ayacucho', 'Ayacucho', 'Ayacucho', 1),
('050201', '02', '05', '01', 'Huanta', 'Ayacucho', 'Huanta', 0),
('060101', '01', '06', '01', 'Cajamarca', 'Cajamarca', 'Cajamarca', 1),
('060201', '02', '06', '01', 'Celendín', 'Cajamarca', 'Celendín', 1),
('070101', '01', '07', '01', 'Callao', 'Callao', 'Callao', 0),
('080101', '01', '08', '01', 'Cusco', 'Cusco', 'Cusco', 1),
('080201', '02', '08', '01', 'Canas', 'Cusco', 'Yanaoca', 0),
('090101', '01', '09', '01', 'Huancavelica', 'Huancavelica', 'Huancavelica', 0),
('100101', '01', '10', '01', 'Huánuco', 'Huánuco', 'Huánuco', 1),
('110101', '01', '11', '01', 'Ica', 'Ica', 'Ica', 0),
('120101', '01', '12', '01', 'Huancayo', 'Junín', 'Huancayo', 1),
('130101', '01', '13', '01', 'Trujillo', 'La Libertad', 'Trujillo', 0);
GO

INSERT INTO [CitaExamenResultado] ([idCitaExamenResultado], [idCita], [idExamenComponente], [resultado], [estado])
VALUES
(1, 1, 1, 'Niveles de glucosa normales', 1),
(2, 1, 2, 'Presión arterial elevada', 1),
(3, 2, 3, 'Respuesta neurológica adecuada', 1),
(4, 3, 4, 'Disminución en la capacidad auditiva', 0),
(5, 3, 5, 'Visión dentro de los parámetros normales', 1),
(6, 4, 6, 'Niveles elevados de colesterol', 1),
(7, 5, 7, 'Función pulmonar óptima', 1),
(8, 6, 8, 'Marcadores tumorales negativos', 0),
(9, 7, 9, 'Signos de estrés crónico', 1),
(10, 8, 10, 'Buena movilidad articular', 1),
(11, 9, 11, 'Riesgo cardiovascular bajo', 0),
(12, 10, 12, 'Sin signos de anemia', 1);
GO

INSERT INTO [ExamenComponente] ([idExamenComponente], [idExamen], [descripcionComponente], [estado])
VALUES
(1, 1, 'Medición de la presión arterial', 1),
(2, 1, 'Electrocardiograma (ECG)', 1),
(3, 1, 'Ecocardiograma', 1),
(4, 2, 'Monitoreo cardiaco durante ejercicio', 1),
(5, 2, 'Medición de la capacidad de recuperación', 1),
(6, 2, 'Análisis de la frecuencia cardiaca', 1),
(7, 3, 'Evaluación de posturas', 1),
(8, 3, 'Test de repetición de movimiento', 1),
(9, 3, 'Análisis de movimientos ergonómicos', 1),
(10, 4, 'Examen de agudeza visual', 1),
(11, 4, 'Test de campo visual', 1),
(12, 4, 'Examen de ojo derecho', 1),
(13, 5, 'Audiometría tonal', 1),
(14, 5, 'Audiometría verbal', 1),
(15, 5, 'Test de susceptibilidad a ruidos', 1),
(16, 6, 'Evaluación de ansiedad', 1),
(17, 6, 'Evaluación de depresión', 1),
(18, 6, 'Evaluación de estrés', 1),
(19, 7, 'Test de manejo del estrés', 1),
(20, 7, 'Monitoreo de la reacción al estrés', 1),
(21, 7, 'Evaluación de la fatiga laboral', 1),
(22, 8, 'Examen físico general', 1),
(23, 8, 'Prueba de flexibilidad', 1),
(24, 8, 'Análisis de sangre completo', 1),
(25, 9, 'Capacidad pulmonar total', 1),
(26, 9, 'Prueba de esfuerzo pulmonar', 1),
(27, 9, 'Medición de flujo espiratorio', 1),
(28, 10, 'Monitoreo del sueño', 1),
(29, 10, 'Evaluación del ciclo sueño-vigilia', 1),
(30, 10, 'Test de latencia del sueño', 1),
(31, 11, 'Identificación de agentes de riesgo', 1),
(32, 11, 'Evaluación de exposición a riesgos', 1),
(33, 11, 'Medidas de control de riesgos', 1),
(34, 12, 'Test de movilidad articular', 1),
(35, 12, 'Prueba de fuerza muscular', 1),
(36, 12, 'Evaluación de equilibrio', 1),
(37, 13, 'Test de tolerancia al estrés físico', 1),
(38, 13, 'Test de resistencia', 1),
(39, 13, 'Análisis de la respuesta al estrés', 1),
(40, 14, 'Inspección de la piel', 1),
(41, 14, 'Prueba de reacciones dérmicas', 1),
(42, 14, 'Evaluación de condiciones de la piel', 1),
(43, 15, 'Medición de la presión arterial sistólica', 1),
(44, 15, 'Medición de la presión arterial diastólica', 1),
(45, 15, 'Monitoreo continuo de la presión arterial', 1),
(46, 16, 'Medición de glucosa en sangre', 1),
(47, 16, 'Prueba de tolerancia a la glucosa', 1),
(48, 16, 'Monitoreo de niveles de insulina', 1),
(49, 17, 'Análisis de postura sentada', 1),
(50, 17, 'Evaluación de postura al caminar', 1),
(51, 17, 'Test de alineación corporal', 1),
(52, 18, 'Análisis nutricional básico', 1),
(53, 18, 'Evaluación de dieta y nutrición', 1),
(54, 18, 'Seguimiento de ingesta de micronutrientes', 1),
(55, 19, 'Examen de la estructura ósea', 1),
(56, 19, 'Evaluación de la función articular', 1),
(57, 19, 'Pruebas de resistencia ósea', 1),
(58, 20, 'Detección de alcohol en sangre', 1),
(59, 20, 'Detección de sustancias prohibidas', 1),
(60, 20, 'Pruebas de detección de nicotina', 1);
GO
