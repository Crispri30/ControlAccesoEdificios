USE [ControlEdificios]
GO
/****** Object:  Table [dbo].[Accesos]    Script Date: 29/05/2025 5:28:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accesos](
	[AccesoID] [int] IDENTITY(1,1) NOT NULL,
	[EmpleadoID] [int] NULL,
	[VisitanteID] [int] NULL,
	[ZonaID] [int] NULL,
	[FechaHoraEntrada] [datetime] NOT NULL,
	[FechaHoraSalida] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[AccesoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlertaSeguridad]    Script Date: 29/05/2025 5:28:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlertaSeguridad](
	[AlertaID] [int] IDENTITY(1,1) NOT NULL,
	[EmpleadoID] [int] NOT NULL,
	[FechaHora] [datetime] NULL,
	[TipoAlerta] [nvarchar](100) NULL,
	[Descripcion] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[AlertaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 29/05/2025 5:28:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[EmpleadoID] [int] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Rol] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpleadoZonas]    Script Date: 29/05/2025 5:28:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpleadoZonas](
	[EmpleadoID] [int] NOT NULL,
	[ZonasID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpleadoID] ASC,
	[ZonasID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 29/05/2025 5:28:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[Rol] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visitantes]    Script Date: 29/05/2025 5:28:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visitantes](
	[VisitanteID] [int] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Telefono] [nvarchar](50) NULL,
	[MotivoVisita] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[VisitanteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zonas]    Script Date: 29/05/2025 5:28:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zonas](
	[ZonasID] [int] IDENTITY(1,1) NOT NULL,
	[NombreZona] [nvarchar](50) NOT NULL,
	[AccesoRestringido] [bit] NOT NULL,
	[HoraInicio] [time](7) NULL,
	[HoraFin] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[ZonasID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accesos] ON 

INSERT [dbo].[Accesos] ([AccesoID], [EmpleadoID], [VisitanteID], [ZonaID], [FechaHoraEntrada], [FechaHoraSalida]) VALUES (1, 1114148, NULL, 5, CAST(N'2025-05-29T17:02:33.730' AS DateTime), CAST(N'2025-05-29T17:02:48.787' AS DateTime))
INSERT [dbo].[Accesos] ([AccesoID], [EmpleadoID], [VisitanteID], [ZonaID], [FechaHoraEntrada], [FechaHoraSalida]) VALUES (2, 1114148, NULL, 4, CAST(N'2025-05-29T17:06:13.087' AS DateTime), CAST(N'2025-05-29T17:06:16.430' AS DateTime))
INSERT [dbo].[Accesos] ([AccesoID], [EmpleadoID], [VisitanteID], [ZonaID], [FechaHoraEntrada], [FechaHoraSalida]) VALUES (3, 1114148, NULL, 5, CAST(N'2025-05-29T17:15:55.403' AS DateTime), CAST(N'2025-05-29T17:16:05.400' AS DateTime))
SET IDENTITY_INSERT [dbo].[Accesos] OFF
GO
INSERT [dbo].[Empleados] ([EmpleadoID], [Nombre], [Rol]) VALUES (1114148, N'Cristian', N'Administrador')
INSERT [dbo].[Empleados] ([EmpleadoID], [Nombre], [Rol]) VALUES (1114148789, N'Felipe', N'Empleado')
GO
INSERT [dbo].[EmpleadoZonas] ([EmpleadoID], [ZonasID]) VALUES (1114148, 1)
INSERT [dbo].[EmpleadoZonas] ([EmpleadoID], [ZonasID]) VALUES (1114148, 2)
INSERT [dbo].[EmpleadoZonas] ([EmpleadoID], [ZonasID]) VALUES (1114148, 3)
INSERT [dbo].[EmpleadoZonas] ([EmpleadoID], [ZonasID]) VALUES (1114148, 4)
INSERT [dbo].[EmpleadoZonas] ([EmpleadoID], [ZonasID]) VALUES (1114148, 5)
INSERT [dbo].[EmpleadoZonas] ([EmpleadoID], [ZonasID]) VALUES (1114148789, 1)
INSERT [dbo].[EmpleadoZonas] ([EmpleadoID], [ZonasID]) VALUES (1114148789, 2)
INSERT [dbo].[EmpleadoZonas] ([EmpleadoID], [ZonasID]) VALUES (1114148789, 3)
GO
INSERT [dbo].[Usuarios] ([Usuario], [Contraseña], [Rol]) VALUES (N'Cristian', N'3000', N'Administrador')
INSERT [dbo].[Usuarios] ([Usuario], [Contraseña], [Rol]) VALUES (N'Manuela', N'2000', N'Administrador')
INSERT [dbo].[Usuarios] ([Usuario], [Contraseña], [Rol]) VALUES (N'Camilo', N'1000', N'Seguridad')
GO
SET IDENTITY_INSERT [dbo].[Zonas] ON 

INSERT [dbo].[Zonas] ([ZonasID], [NombreZona], [AccesoRestringido], [HoraInicio], [HoraFin]) VALUES (1, N'Principal', 1, CAST(N'08:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Zonas] ([ZonasID], [NombreZona], [AccesoRestringido], [HoraInicio], [HoraFin]) VALUES (2, N'Oficinas', 1, CAST(N'08:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Zonas] ([ZonasID], [NombreZona], [AccesoRestringido], [HoraInicio], [HoraFin]) VALUES (3, N'Restaurante', 1, CAST(N'08:00:00' AS Time), CAST(N'17:00:00' AS Time))
INSERT [dbo].[Zonas] ([ZonasID], [NombreZona], [AccesoRestringido], [HoraInicio], [HoraFin]) VALUES (4, N'Racks', 1, CAST(N'06:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Zonas] ([ZonasID], [NombreZona], [AccesoRestringido], [HoraInicio], [HoraFin]) VALUES (5, N'Primeros Auxilios', 1, CAST(N'06:00:00' AS Time), CAST(N'20:00:00' AS Time))
INSERT [dbo].[Zonas] ([ZonasID], [NombreZona], [AccesoRestringido], [HoraInicio], [HoraFin]) VALUES (6, N'Terraza', 1, CAST(N'06:00:00' AS Time), CAST(N'20:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[Zonas] OFF
GO
ALTER TABLE [dbo].[Accesos]  WITH CHECK ADD FOREIGN KEY([EmpleadoID])
REFERENCES [dbo].[Empleados] ([EmpleadoID])
GO
ALTER TABLE [dbo].[Accesos]  WITH CHECK ADD FOREIGN KEY([VisitanteID])
REFERENCES [dbo].[Visitantes] ([VisitanteID])
GO
ALTER TABLE [dbo].[Accesos]  WITH CHECK ADD FOREIGN KEY([ZonaID])
REFERENCES [dbo].[Zonas] ([ZonasID])
GO
ALTER TABLE [dbo].[AlertaSeguridad]  WITH CHECK ADD FOREIGN KEY([EmpleadoID])
REFERENCES [dbo].[Empleados] ([EmpleadoID])
GO
ALTER TABLE [dbo].[EmpleadoZonas]  WITH CHECK ADD FOREIGN KEY([EmpleadoID])
REFERENCES [dbo].[Empleados] ([EmpleadoID])
GO
ALTER TABLE [dbo].[EmpleadoZonas]  WITH CHECK ADD FOREIGN KEY([ZonasID])
REFERENCES [dbo].[Zonas] ([ZonasID])
GO
/****** Object:  StoredProcedure [dbo].[SP_AsignarZona]    Script Date: 29/05/2025 5:28:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Procedimiento Asignar Zona
CREATE PROCEDURE [dbo].[SP_AsignarZona]
	@EmpleadoID INT,
	@Rol NVARCHAR(50)
AS
BEGIN
	DELETE FROM [ControlEdificios].[dbo].[EmpleadoZonas] WHERE EmpleadoID = @EmpleadoID

	IF @Rol = 'Empleado'
	BEGIN
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 1);
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 2);
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 3);
	END

	IF @Rol = 'Administrador'
	BEGIN
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 1);
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 2);
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 3);
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 4);
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 5);
	END

	IF @Rol = 'Seguridad'
	BEGIN
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 1);
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 2);
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 3);
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 4);
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 5);
		INSERT INTO EmpleadoZonas VALUES (@EmpleadoID, 6);
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_GenerarAlerta]    Script Date: 29/05/2025 5:28:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Registrar Alerta

CREATE PROCEDURE [dbo].[SP_GenerarAlerta]
	@EmpleadoID INT,
	@TipoAlerta NVARCHAR(100),
	@Descripcion NVARCHAR(200)
AS
BEGIN
	INSERT INTO [ControlEdificios].[dbo].[AlertaSeguridad] (EmpleadoID, FechaHora, TipoAlerta, Descripcion)
	VALUES (@EmpleadoID, GETDATE(), @TipoAlerta, @Descripcion);
END;


GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarAcceso]    Script Date: 29/05/2025 5:28:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_RegistrarAcceso]
	@EmpleadoID INT = NULL,
	@VisitanteID INT = NULL,
	@ZonaID INT,
	@Mensaje NVARCHAR(100) OUTPUT

AS
BEGIN
	DECLARE @AccesoID INT;

	--Verificar si ya tiene acceso un empleado
	IF @EmpleadoID IS NOT NULL
	BEGIN
		SELECT @AccesoID = AccesoID FROM Accesos
		WHERE EmpleadoID = @EmpleadoID AND FechaHoraSalida IS NULL;

		IF @AccesoID IS NOT NULL
		BEGIN
			UPDATE Accesos
			SET FechaHoraSalida = GETDATE()
			WHERE AccesoID = @AccesoID;

			SET @Mensaje = 'Salida registrada';

			RETURN;
		END
		--Si no hay acceso activo se registra uno
		ELSE 
		BEGIN
			INSERT INTO Accesos(EmpleadoID,ZonaID,FechaHoraEntrada)
			VALUES (@EmpleadoID,@ZonaID,GETDATE());

			SET @Mensaje = 'Ingreso registrado';

			RETURN;
		END
	END

	--Verificar si ya tiene acceso un visitante
	IF @VisitanteID IS NOT NULL
	BEGIN
		SELECT @AccesoID = AccesoID FROM Accesos
		WHERE VisitanteID = @VisitanteID AND FechaHoraSalida IS NULL;

		IF @AccesoID IS NOT NULL
		BEGIN
			UPDATE Accesos
			SET FechaHoraSalida = GETDATE()
			WHERE AccesoID = @AccesoID;
			SET @Mensaje = 'Salida registrada';
		RETURN;
		END

		ELSE
		BEGIN
			INSERT INTO Accesos(VisitanteID,ZonaID,FechaHoraEntrada)
			VALUES (@VisitanteID,@ZonaID,GETDATE());
			SET @Mensaje = 'Ingreso registrado';
		RETURN;
		END
	END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ValidarLogin]    Script Date: 29/05/2025 5:28:37 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Validar login
CREATE PROCEDURE [dbo].[SP_ValidarLogin]
	@Usuario NVARCHAR(50),
	@Contraseña NVARCHAR(50)
AS
BEGIN
	SELECT Usuario, Contraseña, Rol
	FROM [ControlEdificios].[dbo].[Usuarios]
	WHERE Usuario = @Usuario AND Contraseña = @Contraseña;
END


GO
