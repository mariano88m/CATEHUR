USE [CATEHUR]
GO
/****** Object:  Table [dbo].[Vajilla]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vajilla](
	[id_Vajilla] [int] IDENTITY(1,1) NOT NULL,
	[DescripcionVajilla] [nvarchar](max) NOT NULL,
	[CantidadVajilla] [int] NOT NULL,
 CONSTRAINT [PK_Vajilla] PRIMARY KEY CLUSTERED 
(
	[id_Vajilla] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Vajilla] ON
INSERT [dbo].[Vajilla] ([id_Vajilla], [DescripcionVajilla], [CantidadVajilla]) VALUES (1, N'Plato', 9498)
INSERT [dbo].[Vajilla] ([id_Vajilla], [DescripcionVajilla], [CantidadVajilla]) VALUES (2, N'Tenedor', 9498)
INSERT [dbo].[Vajilla] ([id_Vajilla], [DescripcionVajilla], [CantidadVajilla]) VALUES (3, N'Cuchillo', 9498)
INSERT [dbo].[Vajilla] ([id_Vajilla], [DescripcionVajilla], [CantidadVajilla]) VALUES (4, N'Vasos', 9498)
INSERT [dbo].[Vajilla] ([id_Vajilla], [DescripcionVajilla], [CantidadVajilla]) VALUES (5, N'1111', 1111)
SET IDENTITY_INSERT [dbo].[Vajilla] OFF
/****** Object:  Table [dbo].[Bebida]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bebida](
	[id_bebida] [int] IDENTITY(1,1) NOT NULL,
	[nombreBebida] [nvarchar](max) NULL,
	[Precio] [decimal](18, 0) NULL,
	[Habilitado] [int] NULL,
 CONSTRAINT [PK_Bebida] PRIMARY KEY CLUSTERED 
(
	[id_bebida] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bebida] ON
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (1, N'Mate cocido, té, leche chocolatada, cafe con leche, jugo de naranja', CAST(20 AS Decimal(18, 0)), 1)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (2, N'Cafe, té o Chocolate', CAST(10 AS Decimal(18, 0)), 1)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (3, N'Jugos de Frutas Frios', CAST(15 AS Decimal(18, 0)), 1)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (4, N'Jugos de Frutas,Café, Te y chocolate', CAST(20 AS Decimal(18, 0)), 1)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (5, N'café americano, café brasileño, café con miel y jengibre o un simple café con leche', CAST(25 AS Decimal(18, 0)), 1)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (6, N' Jugo exprimido de naranja, jugo de manzana casero, licuado de melón, entre otros.', CAST(20 AS Decimal(18, 0)), 1)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (7, N'yogurt helado, Te', CAST(15 AS Decimal(18, 0)), 1)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (8, N'Licuado de melón, de frutilla, de durazno, de banana', CAST(15 AS Decimal(18, 0)), 1)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (9, N'Agua Mineral, Gaseosas, vinos', CAST(20 AS Decimal(18, 0)), 1)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (10, N'Agua Mineral, Gaseosas, Cerveza', CAST(15 AS Decimal(18, 0)), 1)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (11, N'Agua Mineral, Gaseosas, vinos, Cerveza, Champagne', CAST(30 AS Decimal(18, 0)), 1)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (12, N'Mate', CAST(44 AS Decimal(18, 0)), 0)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (13, N'prueba bebida', CAST(123 AS Decimal(18, 0)), 0)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (14, N'prueba1', CAST(123 AS Decimal(18, 0)), 0)
INSERT [dbo].[Bebida] ([id_bebida], [nombreBebida], [Precio], [Habilitado]) VALUES (15, N'pruebaBebida', CAST(30 AS Decimal(18, 0)), 1)
SET IDENTITY_INSERT [dbo].[Bebida] OFF
/****** Object:  Table [dbo].[EstadoEvento]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoEvento](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[NombreEstadoEvento] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EstadoEvento] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EstadoEvento] ON
INSERT [dbo].[EstadoEvento] ([id_estado], [NombreEstadoEvento]) VALUES (1, N'A espera de aprobacion')
INSERT [dbo].[EstadoEvento] ([id_estado], [NombreEstadoEvento]) VALUES (2, N'Compra de productos')
INSERT [dbo].[EstadoEvento] ([id_estado], [NombreEstadoEvento]) VALUES (3, N'Platos Armados')
INSERT [dbo].[EstadoEvento] ([id_estado], [NombreEstadoEvento]) VALUES (4, N'Evento Cancelado')
INSERT [dbo].[EstadoEvento] ([id_estado], [NombreEstadoEvento]) VALUES (5, N'Evento Preparado')
INSERT [dbo].[EstadoEvento] ([id_estado], [NombreEstadoEvento]) VALUES (6, N'Productos Comprados')
SET IDENTITY_INSERT [dbo].[EstadoEvento] OFF
/****** Object:  Table [dbo].[Idioma]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[LANG_ID] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[DV] [int] NULL,
 CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED 
(
	[LANG_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Idioma] ([LANG_ID], [name], [DV]) VALUES (1, N'Español', NULL)
INSERT [dbo].[Idioma] ([LANG_ID], [name], [DV]) VALUES (2, N'English', NULL)
/****** Object:  Table [dbo].[Catering]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catering](
	[id_catering] [int] IDENTITY(1,1) NOT NULL,
	[NombreCatering] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Catering] PRIMARY KEY CLUSTERED 
(
	[id_catering] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Catering] ON
INSERT [dbo].[Catering] ([id_catering], [NombreCatering]) VALUES (1, N'Breakfast')
INSERT [dbo].[Catering] ([id_catering], [NombreCatering]) VALUES (2, N'Fiestas')
INSERT [dbo].[Catering] ([id_catering], [NombreCatering]) VALUES (3, N'Brunch')
INSERT [dbo].[Catering] ([id_catering], [NombreCatering]) VALUES (4, N'Coffee Break')
INSERT [dbo].[Catering] ([id_catering], [NombreCatering]) VALUES (5, N'Party')
SET IDENTITY_INSERT [dbo].[Catering] OFF
/****** Object:  Table [dbo].[Empleado]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NULL,
	[Domicilio] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[idTipoEmpleado] [int] NOT NULL,
	[DescripcionTipoEmpleado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (1, N'Mariano', N'Marcovecchio', N'mariano88m@gmail.com', N'Av Roca 1582', N'4662-2506', 1, N'Administrador')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (2, N'Aldana Celeste', N'Figoli', N'AldanaPluton@gmail.com', N'Posadas 1278', N'4678-9085', 2, N'Coordinador')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (3, N'Pedro', N'Picapiedra', N'PPicapiedra@gmail.com', N'Av. Corrientes 678 ', N'4873-6843', 3, N'Cocinero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (16, N'Carlos', N'Gimenez', N'carlosgz@gmail.com', N'Posadas 1278', N'4678-9085', 2, N'Coordinador')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (17, N'Faustino', N'Lescano', N'faustinovdg@gmail.com', N'Av. Corrientes 678', N'4873-6843', 2, N'Coordinador')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (18, N'Juana', N'Molina', N'Juana67tt@gmail.com', N'Esmeralda 1345', N'4786-9789', 3, N'Cocinero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (19, N'Raul', N'Catalano', N'raul.9002@gmail.com', N'Darwin 322', N'4575-2040', 3, N'Cocinero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (20, N'Debora', N'Tronqueta', N'deboralatronqueta@hotmail.com', N'San Martin 700', N'4345-4520', 3, N'Cocinero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (21, N'Juan', N'Perez', N'JuanPerez@hotmail.com', N'Av de los Incoas 3244', N'4300-4345', 4, N'Camarero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (22, N'Susana', N'Gomez', N'SGomez@hotmail.com', N'San Juan 700', N'4342-4520', 4, N'Camarero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (23, N'Mirtha', N'Sanchez', N'MSanchez@hotmail.com', N'Av Peron 700', N'4302-7550', 4, N'Camarero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (24, N'Sonia', N'Bacaro', N'SoBaca@hotmail.com', N'Av Juan Castro 700', N'4502-1550', 4, N'Camarero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (25, N'Soledad', N'Alegria', N'AlegriaS@hotmail.com', N'Av Juan Castro 100', N'4302-1520', 4, N'Camarero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (26, N'Liliana', N'Rocamora', N'Rocamora@hotmail.com', N'Av Israeli 100', N'4202-0020', 4, N'Camarero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (27, N'Rosa', N'Martinez', N'LaRosa@hotmail.com', N'Av flores 140', N'4552-0025', 4, N'Camarero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (28, N'Elcira', N'Vono', N'EVono@hotmail.com', N'Av industria 120', N'2332-0025', 4, N'Camarero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (29, N'Hilda', N'Perez', N'HPerez@hotmail.com', N'Av Peru 120', N'5555-0025', 4, N'Camarero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (30, N'Elena', N'Grimi', N'EGrimi@hotmail.com', N'Av Chile 120', N'2342-0025', 4, N'Camarero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (31, N'Eduardo', N'Garcia', N'EGarcia@hotmail.com', N'Av loyola 120', N'2474-0025', 4, N'Camarero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (32, N'Javier', N'Estevez', N'JEstevez@hotmail.com', N'Av Albarracin 120', N'2474-0025', 4, N'Camarero')
INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Apellido], [email], [Domicilio], [Telefono], [idTipoEmpleado], [DescripcionTipoEmpleado]) VALUES (33, N'Santiago', N'Delgado', N'SDelgado@hotmail.com', N'Av Facebook 120', N'2474-0025', 4, N'Camarero')
SET IDENTITY_INSERT [dbo].[Empleado] OFF
/****** Object:  Table [dbo].[DDVVV]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DDVVV](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[DDVVV] [nvarchar](150) NULL,
 CONSTRAINT [PK_DDVVV] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DDVVV] ON
INSERT [dbo].[DDVVV] ([ID], [Descripcion], [DDVVV]) VALUES (1, N'Usuario', N'37295')
INSERT [dbo].[DDVVV] ([ID], [Descripcion], [DDVVV]) VALUES (2, N'Evento', N'20239')
SET IDENTITY_INSERT [dbo].[DDVVV] OFF
/****** Object:  Table [dbo].[Localidad]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[id_localidad] [int] IDENTITY(1,1) NOT NULL,
	[NombreLocalidad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[id_localidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Localidad] ON
INSERT [dbo].[Localidad] ([id_localidad], [NombreLocalidad]) VALUES (1, N'Hurlingham')
INSERT [dbo].[Localidad] ([id_localidad], [NombreLocalidad]) VALUES (2, N'Moron')
INSERT [dbo].[Localidad] ([id_localidad], [NombreLocalidad]) VALUES (3, N'William Morris')
INSERT [dbo].[Localidad] ([id_localidad], [NombreLocalidad]) VALUES (4, N'Villa Tesei')
INSERT [dbo].[Localidad] ([id_localidad], [NombreLocalidad]) VALUES (5, N'Ituzaingo')
INSERT [dbo].[Localidad] ([id_localidad], [NombreLocalidad]) VALUES (6, N'Castelar')
INSERT [dbo].[Localidad] ([id_localidad], [NombreLocalidad]) VALUES (7, N'Caseros')
INSERT [dbo].[Localidad] ([id_localidad], [NombreLocalidad]) VALUES (8, N'3 de Febrero')
INSERT [dbo].[Localidad] ([id_localidad], [NombreLocalidad]) VALUES (9, N'Bella vista')
INSERT [dbo].[Localidad] ([id_localidad], [NombreLocalidad]) VALUES (10, N'San Miguel')
SET IDENTITY_INSERT [dbo].[Localidad] OFF
/****** Object:  Table [dbo].[Ingrediente]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingrediente](
	[id_ingrediente] [int] IDENTITY(1,1) NOT NULL,
	[NombreIngrediente] [nvarchar](50) NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_Ingrediente] PRIMARY KEY CLUSTERED 
(
	[id_ingrediente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ingrediente] ON
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (1, N'Medialuna', CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (2, N'Factura', CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (3, N'Masitas', CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (4, N'Galletitas', CAST(0.50 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (5, N'Tostadas', CAST(0.60 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (6, N'Mermelada', CAST(2.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (7, N'Huevo', CAST(0.50 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (8, N'Pan', CAST(0.50 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (9, N'Manteca', CAST(0.50 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (10, N'Fruta', CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (11, N'Cereales', CAST(2.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (12, N'Pescado', CAST(30.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (13, N'Terrines', CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (14, N'Pate', CAST(12.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (15, N'Fiambres', CAST(20.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (16, N'Queso', CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (17, N'Aceitunas', CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (18, N'Riñon', CAST(20.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (19, N'Panceta', CAST(7.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (20, N'Ciruela', CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (21, N'Empanada', CAST(18.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (22, N'Brusquetas', CAST(15.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (23, N'Salchicha', CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (24, N'Wafle', CAST(6.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (25, N'Chocolate', CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (26, N'Dulce de leche', CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (27, N'Bagels', CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (28, N'Tostadas Francesas', CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (29, N'Scone Panceta', CAST(1.50 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (30, N'Scone Grouyere', CAST(1.40 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (31, N'Scone Ciboulette', CAST(1.30 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (32, N'Jamon', CAST(6.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (33, N'Crepes', CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (34, N'Flan Casero Light', CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (35, N'Pan de Calabaza', CAST(8.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (36, N'Pan de Centeno', CAST(7.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (37, N'Medialunas vegetarianas', CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (38, N'Yogurt', CAST(3.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (39, N'Asado', CAST(35.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (40, N'Chorizo', CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (41, N'Vacio', CAST(20.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (42, N'Pollo', CAST(20.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (43, N'Lechuga', CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (44, N'Tomate', CAST(8.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (45, N'Lomo', CAST(40.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (46, N'Bondiola', CAST(30.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (47, N'PrePizza', CAST(12.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (48, N'Salsa', CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (49, N'Tapa Canelon', CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (50, N'Ricota', CAST(8.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (51, N'Verdura', CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (52, N'Verdeo', CAST(4.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (53, N'Arroz', CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (54, N'Calamar', CAST(30.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (55, N'Flan', CAST(8.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (56, N'Budin de Pan', CAST(10.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (57, N'Helado Dulce de Leche', CAST(15.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (58, N'Helado Frutilla', CAST(15.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (59, N'Helado Crema Americana', CAST(15.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (60, N'Isla Flotante', CAST(20.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (61, N'Salsa Sambayon', CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (62, N'paco', CAST(5.00 AS Decimal(10, 2)))
INSERT [dbo].[Ingrediente] ([id_ingrediente], [NombreIngrediente], [Precio]) VALUES (63, N'sas', CAST(5.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Ingrediente] OFF
/****** Object:  Table [dbo].[Permiso]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (1, N'Administrador')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (2, N'Coordinador')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (3, N'Cocinero')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (4, N'Camarero')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (5, N'Gestion Familia')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (6, N'Gestion Usuario')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (7, N'Gestion Patente')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (8, N'Chequear DV')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (9, N'Alta Familia')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (10, N'Modificar Familia')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (11, N'Baja Familia')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (12, N'Buscar Familia')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (13, N'Alta Usuario')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (14, N'Modificar Usuario')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (15, N'Baja Usuario')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (16, N'Buscar Usuario')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (17, N'Bloqueo Usuario')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (18, N'Desbloqueo Usuario')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (19, N'Alta Patente')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (20, N'Modificar Patente')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (21, N'Buscar Patente')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (22, N'Baja Patente')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (23, N'Reparar DV')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (24, N'Verificar DV')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (25, N'Gestion Backup')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (26, N'Buscar Bitacora')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (27, N'Realizar Backup')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (28, N'Restore Backup')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (29, N'Gestion Cliente')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (30, N'Gestion Evento')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (31, N'Reposicion de Stock')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (32, N'Asignacion Personal')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (33, N'Alta Cliente')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (34, N'Modificar Cliente')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (35, N'Baja Cliente')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (36, N'Buscar Cliente')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (37, N'Seleccionar Menu')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (38, N'Generar Presupuesto')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (39, N'Ver Cronograma Eventos')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (40, N'Registrar Reserva')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (41, N'Superadmin')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (51, N'Gestion Almacenamiento')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (52, N'Preparacion de Entrega')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (53, N'Registro de Perdidas')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (54, N'Confeccion Orden de Compra')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (60, N'ABM Usuarios')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (69, N'Elaboracion de Platos')
INSERT [dbo].[Permiso] ([ID], [Descripcion]) VALUES (71, N'Gestion bebidas')
SET IDENTITY_INSERT [dbo].[Permiso] OFF
/****** Object:  Table [dbo].[TipoMenu]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMenu](
	[id_TipoMenu] [int] IDENTITY(1,1) NOT NULL,
	[NombreTipoMenu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoMenu] PRIMARY KEY CLUSTERED 
(
	[id_TipoMenu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TipoMenu] ON
INSERT [dbo].[TipoMenu] ([id_TipoMenu], [NombreTipoMenu]) VALUES (1, N'Entrada')
INSERT [dbo].[TipoMenu] ([id_TipoMenu], [NombreTipoMenu]) VALUES (2, N'Plato Principal')
INSERT [dbo].[TipoMenu] ([id_TipoMenu], [NombreTipoMenu]) VALUES (3, N'Postre')
INSERT [dbo].[TipoMenu] ([id_TipoMenu], [NombreTipoMenu]) VALUES (4, N'Bebida')
SET IDENTITY_INSERT [dbo].[TipoMenu] OFF
/****** Object:  Table [dbo].[Plato]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plato](
	[id_plato] [int] IDENTITY(1,1) NOT NULL,
	[nombrePlato] [nvarchar](max) NOT NULL,
	[id_tipoMenu] [int] NOT NULL,
	[ManoDeObra] [money] NOT NULL,
	[Habilitado] [int] NULL,
 CONSTRAINT [PK_Plato] PRIMARY KEY CLUSTERED 
(
	[id_plato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Plato] ON
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (8, N'Medialunas, Facturas , Masitas dulces y Saladas, Galletitas y tostadas', 1, 130.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (10, N'Tostadas, Mermeladas', 1, 30.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (11, N'Huevos, Tostadas, Panes, Manteca, Mermelada', 1, 70.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (12, N'Frutas estofadas, Cereales, Pescado y  Huevos', 1, 90.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (13, N'Porciones de Frutas, huevos, Terrines, Pates, Panes y Mermelada', 1, 100.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (14, N'Medialunas, facturas, pan con manteca, masitas dulces, saladas,  galletitas saladas y tostadas', 1, 140.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (15, N'Tabla de Fiambres y quesos con aceitunas. Cazuelas de riñoncitos al vino. Tarteletas variadas. Panceta con ciruelas. Empanadas.', 1, 160.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (17, N'Sandiwiches de diversos Fiambres', 1, 110.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (19, N'Empanadas de carne y queso/verdeo Brusquetas Capresse y Roquefort Apio y Nuez, Salchichas envueltas', 1, 340.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (20, N'Waffles de chocolate y dulce de leche, Tostadas con queso y mermelada, Bagels con pasas de uva y Tostadas francesas', 2, 350.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (21, N'Huevos revueltos con salchichas y queso, Scones salados de panceta, grouyere y ciboulette, Sándwiches de jamón y huevo y Crepés salados', 2, 310.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (22, N'Flan casero light, Pan de calabaza con especias, Pan de centeno light y Medialunas vegetarianas', 2, 290.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (23, N'Taza de yogurt con granola y frutas, Brochetas de frutas, Sopa fría de melón y Mango y frutillas con crema de maracuyá', 2, 150.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (24, N'Asado con Cuero y Salad Bar', 2, 450.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (25, N'Sandwiches de vacío, Choripanes, Sandwiches de lomo y Sandwiches de bondiola', 2, 340.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (26, N'Variedad de Pizzas', 2, 170.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (27, N'canelones con relleno de jamon, ricota y queso o ricota y verdura con salsa de toma o salsa de queso', 2, 190.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (28, N'Pollo al verdeo, Lomo Salteado, Arroz con Calamares', 2, 210.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (29, N'Flan Casero con dulce de leche y budin de pan', 3, 70.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (30, N'Helado', 3, 40.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (31, N'Islas Flotantes con Salsa Sambayon', 3, 115.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (34, N'fideos con salsa blanca', 2, 200.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (35, N'jotos', 2, 23.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (36, N'PlatoWeb', 2, 20.0000, 1)
INSERT [dbo].[Plato] ([id_plato], [nombrePlato], [id_tipoMenu], [ManoDeObra], [Habilitado]) VALUES (37, N'Prueba2', 1, 30.0000, 1)
SET IDENTITY_INSERT [dbo].[Plato] OFF
/****** Object:  Table [dbo].[Per_Per]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Per_Per](
	[Cod_Padre] [int] NOT NULL,
	[Cod_Hijo] [int] NOT NULL,
 CONSTRAINT [PK_Per_Per] PRIMARY KEY CLUSTERED 
(
	[Cod_Padre] ASC,
	[Cod_Hijo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (1, 5)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (1, 6)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (1, 7)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (1, 8)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (1, 25)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (1, 26)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (2, 29)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (2, 30)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (2, 31)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (2, 32)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (2, 51)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (3, 52)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (3, 69)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (3, 71)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (5, 9)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (5, 10)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (5, 11)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (5, 12)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (6, 17)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (6, 18)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (6, 60)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (7, 19)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (7, 20)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (7, 21)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (7, 22)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (8, 23)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (8, 24)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (25, 27)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (25, 28)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (29, 33)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (29, 34)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (29, 35)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (29, 36)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (30, 37)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (30, 38)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (30, 39)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (30, 40)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (41, 5)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (41, 8)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (41, 9)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (41, 13)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (41, 18)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (41, 20)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (41, 23)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (41, 71)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (51, 31)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (51, 52)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (51, 53)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (51, 54)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (51, 69)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (60, 13)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (60, 14)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (60, 15)
INSERT [dbo].[Per_Per] ([Cod_Padre], [Cod_Hijo]) VALUES (60, 16)
/****** Object:  Table [dbo].[IdiomaControl]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IdiomaControl](
	[page] [nvarchar](50) NOT NULL,
	[namecontrol] [nvarchar](50) NOT NULL,
	[LANG_ID] [int] NOT NULL,
	[text] [nvarchar](50) NULL,
	[CTRL_TOOLTIP] [nvarchar](50) NULL,
 CONSTRAINT [PK_Control] PRIMARY KEY CLUSTERED 
(
	[page] ASC,
	[namecontrol] ASC,
	[LANG_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'btn_AsignarEmpleado', 1, N'Asignar Empleado', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'btn_AsignarEmpleado', 2, N'Asign Employee', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'btn_baja', 1, N'baja', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'btn_baja', 2, N'low', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_apellido', 1, N'Apellido', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_apellido', 2, N'Last name', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_AsignacionPersonal', 1, N'Asignacion de Personal', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_AsignacionPersonal', 2, N'Asign Staff', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_camarero', 1, N'Camarero', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_camarero', 2, N'Waiter', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_cocinero', 1, N'Cocinero', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_cocinero', 2, N'Chef', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_domicilio', 1, N'Domicilio', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_domicilio', 2, N'Address', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_email', 1, N'Email', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_email', 2, N'Email', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'Lbl_id_empleado', 1, N'idEmpleado', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'Lbl_id_empleado', 2, N'idEmployee', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_listaEmpleadosAsignados', 1, N'Lista de empleados asignados al evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_listaEmpleadosAsignados', 2, N'List of employees assigned to the event', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_listaEventos', 1, N'Lista de eventos', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_listaEventos', 2, N'Event List', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_nombre', 1, N'Nombre', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_nombre', 2, N'Name', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_telefono', 1, N'Telefono', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_telefono', 2, N'Telephone', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_tipoDeEmpleado', 1, N'Tipo Empleado', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_AsignacionPersonal', N'lbl_tipoDeEmpleado', 2, N'Type of Employee', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_bloqueoUsuario', N'btn_bloquearUsuario', 1, N'Bloquear Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_bloqueoUsuario', N'btn_bloquearUsuario', 2, N'Block User', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_bloqueoUsuario', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_bloqueoUsuario', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_bloqueoUsuario', N'btn_DesbloquearUsuario', 1, N'Desbloqueo de Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_bloqueoUsuario', N'btn_DesbloquearUsuario', 2, N'Unlock User', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_bloqueoUsuario', N'Lbl_bloqueoUsuario', 1, N'Bloqueo de Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_bloqueoUsuario', N'Lbl_bloqueoUsuario', 2, N'User Lock', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_bloqueoUsuario', N'lbl_desbloqueoUsuario', 1, N'Desbloqueo de Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_bloqueoUsuario', N'lbl_desbloqueoUsuario', 2, N'User Unlocking', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_bloqueoUsuario', N'lbl_NombreUsuario', 1, N'Nombre de Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_bloqueoUsuario', N'lbl_NombreUsuario', 2, N'Username', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_CronogramaEventos', N'btn_buscar', 1, N'Buscar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_CronogramaEventos', N'btn_buscar', 2, N'Search', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_CronogramaEventos', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_CronogramaEventos', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_CronogramaEventos', N'lbl_CronogramaEventos', 1, N'Cronograma de Eventos', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_CronogramaEventos', N'lbl_CronogramaEventos', 2, N'Schedule of events', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_CronogramaEventos', N'lbl_FechaDesde', 1, N'Fecha Desde', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_CronogramaEventos', N'lbl_FechaDesde', 2, N'Date to', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_CronogramaEventos', N'lbl_fechaHasta', 1, N'Fecha Hasta', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_CronogramaEventos', N'lbl_fechaHasta', 2, N'Date From', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_desbloqueoUsuario', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_desbloqueoUsuario', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_desbloqueoUsuario', N'btn_DesbloquearUsuario', 1, N'Desbloqueo de Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_desbloqueoUsuario', N'btn_DesbloquearUsuario', 2, N'Unlock User', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_desbloqueoUsuario', N'lbl_desbloqueoUsuario', 1, N'Desbloqueo de Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_desbloqueoUsuario', N'lbl_desbloqueoUsuario', 2, N'User Unlocking', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_desbloqueoUsuario', N'lbl_NombreUsuario', 1, N'Nombre de Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_desbloqueoUsuario', N'lbl_NombreUsuario', 2, N'Username', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBackup', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBackup', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBackup', N'btn_examinar', 1, N'Examinar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBackup', N'btn_examinar', 2, N'Search', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBackup', N'btn_realizarBackup', 1, N'Realizar Backup', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBackup', N'btn_realizarBackup', 2, N'Make Backup', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBackup', N'lbl_nombre', 1, N'Nombre', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBackup', N'lbl_nombre', 2, N'Name', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBackup', N'lbl_RealizarBackup', 1, N'Realizar Backup', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBackup', N'lbl_RealizarBackup', 2, N'Make Backup', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBackup', N'lbl_Ubicacion', 1, N'Ubicacion', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBackup', N'lbl_Ubicacion', 2, N'Location', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_alta', 1, N'Alta', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_alta', 2, N'Create', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_asignarCatering', 1, N'Asignar Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_asignarCatering', 2, N'Asign Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_baja', 1, N'Baja', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_baja', 2, N'Low', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_limpiar', 1, N'Limpiar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_limpiar', 2, N'Clean', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_Modificar', 1, N'Modificar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_Modificar', 2, N'Modify', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_quitarCatering', 1, N'Quitar Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'btn_quitarCatering', 2, N'Remove Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_catering', 1, N'Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_catering', 2, N'Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_GestionBebidas', 1, N'Gestion de Bebidas', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_GestionBebidas', 2, N'Managment Drinks', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_idBebida', 1, N'Id Bebida', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_idBebida', 2, N'Id Drink', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_ListaBebida', 1, N'Lista de bebidas', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_ListaBebida', 2, N'List of drinks', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_ListaCateringAsignados', 1, N'Lista de Catering Asignado', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_ListaCateringAsignados', 2, N'List of Caterings Assigned', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_nombreBebida', 1, N'Nombre de la bebida', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_nombreBebida', 2, N'Drink Name', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_precio', 1, N'Precio', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_gestionBebidas', N'lbl_precio', 2, N'Price', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBitacora', N'btn_buscar', 1, N'Buscar', NULL)
GO
print 'Processed 100 total records'
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBitacora', N'btn_buscar', 2, N'Search', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBitacora', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBitacora', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBitacora', N'lbl_Descripcion', 1, N'Descripcion', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBitacora', N'lbl_Descripcion', 2, N'Description', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBitacora', N'lbl_FechaDesde', 1, N'Fecha desde', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBitacora', N'lbl_FechaDesde', 2, N'Date from', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBitacora', N'lbl_fechaHasta', 1, N'Fecha hasta', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBitacora', N'lbl_fechaHasta', 2, N'Date to', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBitacora', N'lbl_usuario', 1, N'Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionBitacora', N'lbl_usuario', 2, N'User', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'btn_alta', 1, N'Alta', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'btn_alta', 2, N'Create', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'btn_baja', 1, N'Baja', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'btn_baja', 2, N'Remove', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'btn_Modificar', 1, N'Modificar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'btn_Modificar', 2, N'Modify', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'Lbl_direccion', 1, N'Direccion', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'Lbl_direccion', 2, N'Address', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'lbl_dni', 1, N'DNI', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'lbl_dni', 2, N'DNI', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'lbl_email', 1, N'Email', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'lbl_email', 2, N'Email', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'lbl_gestionClientes', 1, N'Gestion Clientes', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'lbl_gestionClientes', 2, N'Client Managment', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'lbl_localidad', 1, N'Localidad', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'lbl_localidad', 2, N'Location', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'lbl_nombreCliente', 1, N'Nombre', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'lbl_nombreCliente', 2, N'Name', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'lbl_nroCliente', 1, N'Nro Cliente', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'lbl_nroCliente', 2, N'Client ID', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'Lbl_telefono', 1, N'Telefono', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionCliente', N'Lbl_telefono', 2, N'Telephone', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'btn_AltaPermiso', 1, N'Alta', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'btn_AltaPermiso', 2, N'Create', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'btn_bajaPermiso', 1, N'Baja', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'btn_bajaPermiso', 2, N'Remove', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'btn_modificacion', 1, N'Modificacion', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'btn_modificacion', 2, N'Modify', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'lbl_Familia', 1, N'Familia', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'lbl_Familia', 2, N'Family', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'Lbl_PermisosDisp', 1, N'Permisos Disponibles', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'Lbl_PermisosDisp', 2, N'Available Permits', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'Lbl_PermisosUsados', 1, N'Permisos Usados', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionFamilia', N'Lbl_PermisosUsados', 2, N'Used Permits', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_AgregarIngrediente', 1, N'Agregar Ingrediente', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_AgregarIngrediente', 2, N'Add Ingredient', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_alta', 1, N'Alta', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_alta', 2, N'Create', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_asignarCatering', 1, N'Asignar Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_asignarCatering', 2, N'Asing Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_baja', 1, N'Baja', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_baja', 2, N'Low', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_Modificar', 1, N'Modificar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_Modificar', 2, N'Modify', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_quitarCatering', 1, N'Quitar Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'btn_quitarCatering', 2, N'Remove Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'Btn_QuitarIngrediente', 1, N'Quitar Ingrediente', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'Btn_QuitarIngrediente', 2, N'Remove Ingredient', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_cantidad', 1, N'Cantidad', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_cantidad', 2, N'Quantity', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_catering', 1, N'Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_catering', 2, N'Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_CateringAsignados', 1, N'Lista de Catering Asignado', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_CateringAsignados', 2, N'List of Caterings Assigned', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_elaboracionPlatos', 1, N'Elaboracion de Platos', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_elaboracionPlatos', 2, N'Preparation of Dishes', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_idPlato', 1, N'Id Plato', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_idPlato', 2, N'Id Dish', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_ingrediente', 1, N'Ingrediente', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_ingrediente', 2, N'Ingredient', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_listaIngredientes', 1, N'Lista de Ingredientes', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_listaIngredientes', 2, N'List of Ingredients', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_listaPlatos', 1, N'Lista de Platos', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_listaPlatos', 2, N'List of Dishes', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_manodeobra', 1, N'Mano de Obra', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_manodeobra', 2, N'Workjob', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_nombrePlato', 1, N'Nombre del plato', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_nombrePlato', 2, N'Dish Name', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_precio', 1, N'Precio', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_precio', 2, N'Price', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_precioIngrediente', 1, N'Precio', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_precioIngrediente', 2, N'Price', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_tipoMenu', 1, N'Tipo Menu', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionPlato', N'lbl_tipoMenu', 2, N'Type Menu', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_AltaUsuario', 1, N'Alta', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_AltaUsuario', 2, N'Create', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_asignarPermisos', 1, N'Asignar Permisos', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_asignarPermisos', 2, N'Assign Permits', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_BajaUsuario', 1, N'Baja', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_BajaUsuario', 2, N'Remove', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_buscarUsuario', 1, N'Buscar Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_buscarUsuario', 2, N'User Search', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_Cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_Cerrar', 2, N'Close', NULL)
GO
print 'Processed 200 total records'
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_modificarUsuario', 1, N'Modificar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_modificarUsuario', 2, N'Modify', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_quitarPermisos', 1, N'Quitar Permisos', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'btn_quitarPermisos', 2, N'Remove Permits', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_apellido', 1, N'Apellido', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_apellido', 2, N'Last Name', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_Contraseña', 1, N'Contraseña', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_Contraseña', 2, N'Password', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_domicilio', 1, N'Domicilio', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_domicilio', 2, N'Address', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_email', 1, N'Email', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_email', 2, N'Email', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'Lbl_GestionUsuario', 1, N'Gestion de Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'Lbl_GestionUsuario', 2, N'User Managment', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_nombre', 1, N'Nombre', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_nombre', 2, N'Name', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_PermisosAsignados', 1, N'Permisos Asignados', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_PermisosAsignados', 2, N'Asign Permits', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_permisosDisp', 1, N'Permisos Disponibles', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_permisosDisp', 2, N'Available Permits', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_telefono', 1, N'Telefono', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_telefono', 2, N'Telephone', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_tipoEmpleado', 1, N'Tipo Empleado', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_tipoEmpleado', 2, N'Type Employee', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_username', 1, N'Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_username', 2, N'Username', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_usuario', 1, N'Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_GestionUsuario', N'lbl_usuario', 2, N'Username', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'btn_buscar', 1, N'Buscar Evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'btn_buscar', 2, N'Event Search', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'btn_ConfeccionarOrdenCompra', 1, N'Confeccionar orden de compra', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'btn_ConfeccionarOrdenCompra', 2, N'Make purchase order', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'btn_confirmarEntrega', 1, N'Confirmar Entrega', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'btn_confirmarEntrega', 2, N'Confirm Delivery', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'chk_ingredientes', 1, N'Ingredientes Comprados', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'chk_ingredientes', 2, N'Purchased Ingredients', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'chk_platos', 1, N'Platos Preparados', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'chk_platos', 2, N'Ready Dishes', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'chk_vajillas', 1, N'Asignar Vajillas', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'chk_vajillas', 2, N'Assign Crockery', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'lbl_id_evento', 1, N'Id Evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'lbl_id_evento', 2, N'Event ID', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'lbl_nombreEvento', 1, N'Nombre de evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'lbl_nombreEvento', 2, N'Event Name', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'lbl_PreparacionEntrega', 1, N'Preparacion de Entrega', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_PreparacionEntrega', N'lbl_PreparacionEntrega', 2, N'Delivery Preparation', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'btn_AltaCliente', 1, N'Alta Cliente', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'btn_AltaCliente', 2, N'Add Client', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'btn_GenerarPresupuesto', 1, N'Generar Presupuesto', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'btn_GenerarPresupuesto', 2, N'Make Budget', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'Btn_SeleccionMenu', 1, N'Seleccion Menu', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'Btn_SeleccionMenu', 2, N'Select Menu', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_CantPersonas', 1, N'Cant. Personas', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_CantPersonas', 2, N'Quantity Person', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_cliente', 1, N'Cliente', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_cliente', 2, N'Client', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_Comentarios', 1, N'Comentarios', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_Comentarios', 2, N'Comment', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_direccionEvento', 1, N'Direccion del Evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_direccionEvento', 2, N'Event Address', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_FechaEvento', 1, N'Fecha del Evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_FechaEvento', 2, N'Date Event', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_localidad', 1, N'Localidad', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_localidad', 2, N'Location', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_NombreEvento', 1, N'Nombre del Evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_NombreEvento', 2, N'Event name', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_precioPersona', 1, N'Precio por persona', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_precioPersona', 2, N'Price per person', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_solicitudPresupuesto', 1, N'Solicitud de Presupuesto', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_solicitudPresupuesto', 2, N'Budget Request', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_tipoCatering', 1, N'Tipo de Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_Presupuesto', N'lbl_tipoCatering', 2, N'Type of Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistrarPerdidas', N'btn_RegistrarPerdida', 1, N'Registrar Perdida', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistrarPerdidas', N'btn_RegistrarPerdida', 2, N'Record Loss', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistrarPerdidas', N'lbl_cantidad', 1, N'Cantidad', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistrarPerdidas', N'lbl_cantidad', 2, N'Quantity', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistrarPerdidas', N'lbl_registroPerdidas', 1, N'Registro de Perdidas', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistrarPerdidas', N'lbl_registroPerdidas', 2, N'Record Losses', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistrarPerdidas', N'lbl_vajillas', 1, N'Vajillas', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistrarPerdidas', N'lbl_vajillas', 2, N'Tableware', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'btn_buscar', 1, N'Buscar Evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'btn_buscar', 2, N'Search Event', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'btn_CancelarEvento', 1, N'Cancelar Evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'btn_CancelarEvento', 2, N'Cancel Event', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'btn_registrarReserva', 1, N'Registrar Reserva', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'btn_registrarReserva', 2, N'Booking Record', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'lbl_id_evento', 1, N'id Evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'lbl_id_evento', 2, N'Event ID', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'lbl_NombreEvento', 1, N'Nombre de Evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'lbl_NombreEvento', 2, N'Event Name', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'lbl_registroReserva', 1, N'Registro Reserva', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'lbl_registroReserva', 2, N'Booking Record', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'lbl_Reserva', 1, N'Reserva', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RegistroReserva', N'lbl_Reserva', 2, N'Reservation', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_ReposicionStock', N'btn_ReponerStock', 1, N'Reponer Stock', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_ReposicionStock', N'btn_ReponerStock', 2, N'Restock', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_ReposicionStock', N'lbl_cantidad', 1, N'Cantidad', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_ReposicionStock', N'lbl_cantidad', 2, N'Quantity', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_ReposicionStock', N'lbl_reposicionStock', 1, N'Reposicion de Stock', NULL)
GO
print 'Processed 300 total records'
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_ReposicionStock', N'lbl_reposicionStock', 2, N'Restocking', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_ReposicionStock', N'lbl_vajillas', 1, N'Vajillas', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_ReposicionStock', N'lbl_vajillas', 2, N'Tableware', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RestoreBackUP', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RestoreBackUP', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RestoreBackUP', N'btn_examinar', 1, N'Examinar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RestoreBackUP', N'btn_examinar', 2, N'Search', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RestoreBackUP', N'btn_restaurar', 1, N'Restaurar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RestoreBackUP', N'btn_restaurar', 2, N'Restore', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RestoreBackUP', N'lbl_ubicacion', 1, N'Ubicacion del archivo a restaurar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_RestoreBackUP', N'lbl_ubicacion', 2, N'Location of the file to be restored', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionIdioma', N'lbl_NombreIdioma', 1, N'Idioma', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionIdioma', N'lbl_NombreIdioma', 2, N'Language', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionIdioma', N'Lbl_TituloCambioIdioma', 1, N'Cambio de Idioma', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionIdioma', N'Lbl_TituloCambioIdioma', 2, N'Change Language', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'btn_aceptar', 1, N'Aceptar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'btn_aceptar', 2, N'Acept', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'btn_cerrar', 1, N'Cerrar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'btn_cerrar', 2, N'Close', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_bebida', 1, N'Bebida', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_bebida', 2, N'Drink', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_entrada', 1, N'Entrada', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_entrada', 2, N'Entry', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_platoPrincipal', 1, N'Plato Principal', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_platoPrincipal', 2, N'Main Dish', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_postre', 1, N'Postre', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_postre', 2, N'Dessert', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_precioBebida', 1, N'Precio', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_precioBebida', 2, N'Price', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_PrecioEntrada', 1, N'Precio', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_PrecioEntrada', 2, N'Price', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_precioPlatoPrincipal', 1, N'Precio', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_precioPlatoPrincipal', 2, N'Price', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_PrecioPostre', 1, N'Precio', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_PrecioPostre', 2, N'Price', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_preciototalEntradaPersona', 1, N'Precio Total', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_preciototalEntradaPersona', 2, N'Total Price', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_seleccionMenu', 1, N'Seleccion de Menu', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Frm_SeleccionMenu', N'lbl_seleccionMenu', 2, N'Select Menu', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_AsignarPersonal', 1, N'Asignar Personal', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_AsignarPersonal', 2, N'Assign Staff', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_bloqueoUsuario', 1, N'Bloqueo de Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_bloqueoUsuario', 2, N'Lock User', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_Cronograma', 1, N'Ver Cronograma de Eventos', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_Cronograma', 2, N'Schedule of Events', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_DesbloqueoUsuario', 1, N'Desbloqueo de Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_DesbloqueoUsuario', 2, N'Unlock User', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_generarPresupuesto', 1, N'Generar Presupuesto', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_generarPresupuesto', 2, N'Generate Budget', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_GestionAlmacenamiento', 1, N'Gestion de Almacenamiento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_GestionAlmacenamiento', 2, N'Stock Managment', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_GestionBackup', 1, N'Gestion Backup', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_GestionBackup', 2, N'Backup Managment', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_gestionCliente', 1, N'Gestion Cliente', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_gestionCliente', 2, N'Client Managment', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_GestionEvento', 1, N'Gestion Evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_GestionEvento', 2, N'Event Managment', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_GestionFamilia', 1, N'Gestion Familia', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_GestionFamilia', 2, N'Family Managment', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_GestionPatente', 1, N'Gestion Patente', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_GestionPatente', 2, N'Patent Managment', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_GestionUsuario', 1, N'Gestion de Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_GestionUsuario', 2, N'User Managment', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_PreparacionEntrega', 1, N'Preparacion de Entrega', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_PreparacionEntrega', 2, N'Delivery Preparation', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_RealizarBK', 1, N'Realizar Backup', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_RealizarBK', 2, N'Perform backup', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_registrarReserva', 1, N'Registrar Reserva', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_registrarReserva', 2, N'Book Reservation', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_RegistroPerdidas', 1, N'Registro de Perdidas', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_RegistroPerdidas', 2, N'Loss Record', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_reposicionStock', 1, N'Reposicion de Stock', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_reposicionStock', 2, N'Stock Repositioning', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_restore', 1, N'Restore Backup', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_restore', 2, N'Restore backup', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_SeleccionarIdioma', 1, N'Seleccionar Idioma', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btn_SeleccionarIdioma', 2, N'Select Language', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btnGestionBitacora', 1, N'Gestion Bitacora', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'FrmPantallaPrincipal', N'btnGestionBitacora', 2, N'Management Blog', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'home_aspx', N'btnLogin', 1, N'Ingresar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'home_aspx', N'btnLogin', 2, N'Login', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'btn_altaCliente', 1, N'Alta Cliente', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'btn_altaCliente', 2, N'Add Client', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'btn_fecha', 1, N'Seleccionar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'btn_fecha', 2, N'Select', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'btn_GenerarPresupuesto', 1, N'Generar Presupuesto', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'btn_GenerarPresupuesto', 2, N'Generate Budget', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'Btn_Limpiar', 1, N'Limpiar', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'Btn_Limpiar', 2, N'Clean', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'btn_SeleccionarMenu', 1, N'Sel menu', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'btn_SeleccionarMenu', 2, N'Sel menu', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Administracion', 1, N'Administracion', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Administracion', 2, N'Administration', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Almacenamiento', 1, N'Almacenamiento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Almacenamiento', 2, N'Storage', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_AsignacionPersonal', 1, N'Asignacion del Personal', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_AsignacionPersonal', 2, N'Assignment of employees', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_baseDatos', 1, N'Base de Datos', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_baseDatos', 2, N'Database', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_cantPersonas', 1, N'Cantidad Personas', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_cantPersonas', 2, N'Number of People', NULL)
GO
print 'Processed 400 total records'
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Cliente', 1, N'Cliente', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Cliente', 2, N'Client', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_clientes', 1, N'Clientes', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_clientes', 2, N'Clients', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_comentarios', 1, N'Comentarios', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_comentarios', 2, N'Comments', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Coordinacion', 1, N'Coordinacion', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Coordinacion', 2, N'Coordination', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_CronogramaEventos', 1, N'Cronograma de Eventos', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_CronogramaEventos', 2, N'Schedule of events', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_DireccionEvento', 1, N'Direccion Evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_DireccionEvento', 2, N'Event direction', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Eventos', 1, N'Eventos', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Eventos', 2, N'Events', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_fecha', 1, N'Fecha', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_fecha', 2, N'date', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_GestionBD', 1, N'Gestion backup', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_GestionBD', 2, N'Backup Management', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_gestionBitacora', 1, N'Gestion bitacora', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_gestionBitacora', 2, N'Log Management', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_GestionClientes', 1, N'Gestion Cliente', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_GestionClientes', 2, N'Client Managment', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_GestionDV', 1, N'Gestion Digito Verificador', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_GestionDV', 2, N'Verifier Digit management', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_GestionFamilia', 1, N'Gestion Familia', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_GestionFamilia', 2, N'Family management', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_GestionPatente', 1, N'Gestion Patente', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_GestionPatente', 2, N'Patent management', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_GestionUsuario', 1, N'Gestion Usuario', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_GestionUsuario', 2, N'User Management', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_localidad', 1, N'Localidad', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_localidad', 2, N'Location', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_NombreEvento', 1, N'Nombre Evento', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_NombreEvento', 2, N'Event name', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Personal', 1, N'Personal', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Personal', 2, N'Personal', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_PrecioPersona', 1, N'Precio por persona', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_PrecioPersona', 2, N'Price per person', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_PreparacionEntrega', 1, N'Preparacion de entrega', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_PreparacionEntrega', 2, N'Delivery preparation', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_registrarReserva', 1, N'Registrar Reserva', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_registrarReserva', 2, N'Register Reservation', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_registros', 1, N'Registros', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_registros', 2, N'Registry', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_SolicitudPresupuesto', 1, N'Solicitud presupuesto', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_SolicitudPresupuesto', 2, N'Budget request', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_solicitudPresupuestoMenu', 1, N'Solicitud Presupuesto', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_solicitudPresupuestoMenu', 2, N'budget request', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_TipoCatering', 1, N'Tipo Catering', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_TipoCatering', 2, N'Catering type', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Usuarios', 1, N'Usuarios', NULL)
INSERT [dbo].[IdiomaControl] ([page], [namecontrol], [LANG_ID], [text], [CTRL_TOOLTIP]) VALUES (N'Presupuesto_aspx', N'lbl_Usuarios', 2, N'Users', NULL)
/****** Object:  Table [dbo].[Cliente]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[NombreCliente] [nvarchar](max) NOT NULL,
	[DNI] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[id_localidad] [int] NOT NULL,
	[DadoDeBaja] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON
INSERT [dbo].[Cliente] ([IdCliente], [NombreCliente], [DNI], [Direccion], [Email], [Telefono], [id_localidad], [DadoDeBaja]) VALUES (1, N'1111', N'111', N'1111', N'1111', N'1111', 1, 1)
INSERT [dbo].[Cliente] ([IdCliente], [NombreCliente], [DNI], [Direccion], [Email], [Telefono], [id_localidad], [DadoDeBaja]) VALUES (2, N'2', N'2', N'2', N'2', N'2', 1, 1)
INSERT [dbo].[Cliente] ([IdCliente], [NombreCliente], [DNI], [Direccion], [Email], [Telefono], [id_localidad], [DadoDeBaja]) VALUES (3, N'Juan Perez', N'3312412412', N'belgrano 1234', N'jperez@gmail.com', N'12314132', 1, 0)
INSERT [dbo].[Cliente] ([IdCliente], [NombreCliente], [DNI], [Direccion], [Email], [Telefono], [id_localidad], [DadoDeBaja]) VALUES (4, N'Paco2', N'4232311', N'Av gomer 124', N'asdf@bofe.com', N'1534723123', 4, 0)
INSERT [dbo].[Cliente] ([IdCliente], [NombreCliente], [DNI], [Direccion], [Email], [Telefono], [id_localidad], [DadoDeBaja]) VALUES (5, N'Gustavo1', N'41241', N'Av rnqwr 2314', N'hola@gmoa.com', N'41313131', 6, 1)
INSERT [dbo].[Cliente] ([IdCliente], [NombreCliente], [DNI], [Direccion], [Email], [Telefono], [id_localidad], [DadoDeBaja]) VALUES (6, N'124125', N'352535', N'325235', N'5235235', N'5235235', 1, 1)
INSERT [dbo].[Cliente] ([IdCliente], [NombreCliente], [DNI], [Direccion], [Email], [Telefono], [id_localidad], [DadoDeBaja]) VALUES (7, N'23123213', N'2131231231', N'12313123', N'324234', N'123124', 3, 1)
INSERT [dbo].[Cliente] ([IdCliente], [NombreCliente], [DNI], [Direccion], [Email], [Telefono], [id_localidad], [DadoDeBaja]) VALUES (8, N'Debora Lopez', N'14556552', N'AV Peron 123', N'LaDeborah@morris.com', N'no tiene', 3, 0)
INSERT [dbo].[Cliente] ([IdCliente], [NombreCliente], [DNI], [Direccion], [Email], [Telefono], [id_localidad], [DadoDeBaja]) VALUES (9, N'11444', N'1144', N'1144', N'1144', N'1144', 1, 1)
INSERT [dbo].[Cliente] ([IdCliente], [NombreCliente], [DNI], [Direccion], [Email], [Telefono], [id_localidad], [DadoDeBaja]) VALUES (10, N'Aldana Celeste', N'324080213', N'Acuña de Figueroa 749 5 A', N'Aldanalaloca@gmail.com', N'1567324473', 3, 0)
INSERT [dbo].[Cliente] ([IdCliente], [NombreCliente], [DNI], [Direccion], [Email], [Telefono], [id_localidad], [DadoDeBaja]) VALUES (11, N'Mariano Marco', N'34100944', N'Av Roca 1582', N'mariano88m@gmail.com', N'46622506', 1, 0)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Contraseña] [nvarchar](50) NOT NULL,
	[IdEmpleado] [int] NULL,
	[Username] [nvarchar](50) NOT NULL,
	[IntentosFallidos] [int] NULL,
	[Bloqueado] [int] NULL,
	[DadoDeBaja] [int] NULL,
	[DDVVH] [bigint] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (1, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 1, N'Mariano', 1, 0, 0, 1859)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (5, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 2, N'Aldana', 0, 0, 0, 1880)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (6, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 3, N'ppicapiedra', 0, 0, 0, 1903)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (13, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 16, N'Carlos', 0, 0, 0, 1802)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (14, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 17, N'Faustino', 0, 0, 0, 1926)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (15, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 18, N'Juana', 0, 0, 0, 1817)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (16, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 19, N'Raul', 0, 0, 0, 1800)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (17, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 20, N'Debora', 0, 0, 0, 1861)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (18, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 22, N'Susana', 0, 0, 0, 1850)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (19, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 23, N'Mirtha', 0, 0, 0, 1908)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (20, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 24, N'Sonia', 0, 0, 0, 1867)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (21, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 25, N'Soledad', 0, 0, 0, 1815)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (22, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 26, N'Liliana', 0, 0, 0, 1905)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (23, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 27, N'Rosa', 0, 0, 0, 1848)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (24, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 28, N'Elcira', 0, 0, 0, 1908)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (25, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 29, N'Hilda', 0, 0, 0, 1866)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (26, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 30, N'Elena', 0, 0, 0, 1863)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (27, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 31, N'Eduardo', 0, 0, 0, 1798)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (28, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 32, N'Javier', 0, 0, 0, 1919)
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [IdEmpleado], [Username], [IntentosFallidos], [Bloqueado], [DadoDeBaja], [DDVVH]) VALUES (29, N'7110EDA4D09E062AA5E4A390B0A572AC0D2C0220', 33, N'Santiago', 0, 1, 0, 1900)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  Table [dbo].[TipoMenuXCatering]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoMenuXCatering](
	[id_Catering] [int] NOT NULL,
	[id_TipoMenu] [int] NOT NULL,
 CONSTRAINT [PK_TipoMenuXCatering] PRIMARY KEY CLUSTERED 
(
	[id_Catering] ASC,
	[id_TipoMenu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (1, 1)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (1, 4)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (2, 1)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (2, 2)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (2, 3)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (2, 4)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (3, 2)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (3, 4)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (4, 1)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (4, 4)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (5, 1)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (5, 2)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (5, 3)
INSERT [dbo].[TipoMenuXCatering] ([id_Catering], [id_TipoMenu]) VALUES (5, 4)
/****** Object:  Table [dbo].[BebidaXCatering]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BebidaXCatering](
	[id_bebida] [int] NOT NULL,
	[id_catering] [int] NOT NULL,
 CONSTRAINT [PK_BebidaXCatering] PRIMARY KEY CLUSTERED 
(
	[id_bebida] ASC,
	[id_catering] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (1, 1)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (1, 4)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (2, 1)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (3, 1)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (4, 1)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (4, 4)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (5, 3)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (6, 3)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (7, 3)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (8, 2)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (8, 3)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (8, 4)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (9, 2)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (9, 5)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (10, 2)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (10, 5)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (11, 2)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (12, 1)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (12, 2)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (12, 3)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (13, 1)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (13, 3)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (14, 1)
INSERT [dbo].[BebidaXCatering] ([id_bebida], [id_catering]) VALUES (14, 2)
/****** Object:  Table [dbo].[UsuarioPermiso]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPermiso](
	[IdUsuario] [int] NOT NULL,
	[ID] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioPermiso] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[UsuarioPermiso] ([IdUsuario], [ID]) VALUES (1, 1)
INSERT [dbo].[UsuarioPermiso] ([IdUsuario], [ID]) VALUES (1, 2)
INSERT [dbo].[UsuarioPermiso] ([IdUsuario], [ID]) VALUES (5, 2)
INSERT [dbo].[UsuarioPermiso] ([IdUsuario], [ID]) VALUES (6, 3)
INSERT [dbo].[UsuarioPermiso] ([IdUsuario], [ID]) VALUES (24, 31)
INSERT [dbo].[UsuarioPermiso] ([IdUsuario], [ID]) VALUES (24, 53)
INSERT [dbo].[UsuarioPermiso] ([IdUsuario], [ID]) VALUES (29, 31)
INSERT [dbo].[UsuarioPermiso] ([IdUsuario], [ID]) VALUES (29, 52)
/****** Object:  Table [dbo].[PlatoXCatering]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlatoXCatering](
	[id_catering] [int] NOT NULL,
	[id_plato] [int] NOT NULL,
 CONSTRAINT [PK_PlatoXCatering] PRIMARY KEY CLUSTERED 
(
	[id_catering] ASC,
	[id_plato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (1, 8)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (1, 10)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (1, 11)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (1, 12)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (1, 13)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (1, 14)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (1, 15)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (1, 37)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (2, 15)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (2, 19)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (2, 27)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (2, 28)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (2, 30)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (2, 31)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (2, 34)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (2, 35)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (2, 36)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (3, 20)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (3, 21)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (3, 22)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (3, 23)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (3, 35)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (3, 37)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (4, 8)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (5, 15)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (5, 17)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (5, 24)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (5, 25)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (5, 26)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (5, 29)
INSERT [dbo].[PlatoXCatering] ([id_catering], [id_plato]) VALUES (5, 30)
/****** Object:  Table [dbo].[Bitacora]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[id_bitacora] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Accion] [nvarchar](50) NOT NULL,
	[InfoAccion] [nvarchar](50) NOT NULL,
	[Categoria] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[id_bitacora] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1704, 1, CAST(0x0000A83100D71D31 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1705, 1, CAST(0x0000A83100D82F86 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1706, 26, CAST(0x0000A83100F4BD83 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1707, 1, CAST(0x0000A83100F4D264 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1708, 29, CAST(0x0000A83100F5B346 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1709, 1, CAST(0x0000A83100F5CC19 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1710, 1, CAST(0x0000A83100F78E51 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1711, 1, CAST(0x0000A83100FEABDA AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1712, 1, CAST(0x0000A83101058B66 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1713, 1, CAST(0x0000A831010D22D0 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1714, 1, CAST(0x0000A83101125792 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1715, 1, CAST(0x0000A831011D36A1 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1716, 1, CAST(0x0000A831011DE55A AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1717, 1, CAST(0x0000A831011E8E9A AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1718, 1, CAST(0x0000A8310120308D AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1719, 1, CAST(0x0000A83101218A43 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1720, 1, CAST(0x0000A8310127A5B9 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1721, 1, CAST(0x0000A83101280174 AS DateTime), N'Generar Presupuesto', N'Evento Creado', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1722, 1, CAST(0x0000A83101314956 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1723, 1, CAST(0x0000A8310131B70F AS DateTime), N'Generar Presupuesto', N'Error al crear el evento', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1724, 1, CAST(0x0000A831013222B8 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1725, 1, CAST(0x0000A831013270C2 AS DateTime), N'Generar Presupuesto', N'Evento Creado', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1726, 1, CAST(0x0000A83101333838 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1727, 1, CAST(0x0000A83101343FCB AS DateTime), N'Generar Presupuesto', N'Evento Creado', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1728, 1, CAST(0x0000A83101347F05 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1729, 1, CAST(0x0000A831013563E7 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1730, 1, CAST(0x0000A831014EE2FE AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1731, 1, CAST(0x0000A831014FB809 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1732, 5, CAST(0x0000A8310154762B AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1733, 5, CAST(0x0000A8310159EAFA AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1734, 5, CAST(0x0000A831015A37C9 AS DateTime), N'Generar Presupuesto', N'Sin Disponibilidad', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1735, 5, CAST(0x0000A831015A432E AS DateTime), N'Generar Presupuesto', N'Evento Creado', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1736, 5, CAST(0x0000A831015C2182 AS DateTime), N'Generar Presupuesto', N'Evento Creado', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1737, 5, CAST(0x0000A83101677378 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1738, 1, CAST(0x0000A8310167E7A8 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1739, 5, CAST(0x0000A8310168A754 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1740, 1, CAST(0x0000A831017BEEA2 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1741, 1, CAST(0x0000A831017CF2A4 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1742, 5, CAST(0x0000A831017DD633 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1743, 1, CAST(0x0000A831017FDAEF AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1744, 1, CAST(0x0000A83101806722 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1745, 1, CAST(0x0000A83101821556 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1746, 1, CAST(0x0000A8310182C978 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1747, 1, CAST(0x0000A8310185AABA AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1748, 1, CAST(0x0000A8320002E180 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1749, 29, CAST(0x0000A832000312E6 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1750, 1, CAST(0x0000A8320010927B AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1751, 1, CAST(0x0000A8320011D3A3 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1752, 24, CAST(0x0000A8320011FE2C AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1753, 1, CAST(0x0000A832011A1B77 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1754, 1, CAST(0x0000A832011A1B8C AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1755, 1, CAST(0x0000A832011AEABB AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1756, 1, CAST(0x0000A832011AEACE AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1757, 1, CAST(0x0000A832011B5958 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1758, 1, CAST(0x0000A832011B596A AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1759, 5, CAST(0x0000A832012AFA30 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1760, 5, CAST(0x0000A832012AFA43 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1761, 5, CAST(0x0000A832012BB6AB AS DateTime), N'Generar Presupuesto', N'Sin Disponibilidad', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1762, 5, CAST(0x0000A832012CF5C6 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1763, 5, CAST(0x0000A832012CF5D9 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1764, 1, CAST(0x0000A832012DBA0C AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1765, 1, CAST(0x0000A832012DBA1F AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1766, 1, CAST(0x0000A832012E610B AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1767, 1, CAST(0x0000A832012E611D AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1768, 6, CAST(0x0000A832012E8214 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1769, 6, CAST(0x0000A832012E8226 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1770, 1, CAST(0x0000A832012FCB26 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1771, 1, CAST(0x0000A832012FCB37 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1772, 1, CAST(0x0000A8320140244B AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1773, 1, CAST(0x0000A8320140245B AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1774, 1, CAST(0x0000A83201428B93 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1775, 1, CAST(0x0000A83201428BAA AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1776, 1, CAST(0x0000A832017EF3FF AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1777, 1, CAST(0x0000A832017EF411 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1778, 1, CAST(0x0000A8320180CFF6 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1779, 1, CAST(0x0000A8320180D009 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1780, 1, CAST(0x0000A832018185FB AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1781, 1, CAST(0x0000A8320181860E AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1782, 1, CAST(0x0000A833000928C9 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1783, 1, CAST(0x0000A833000928DB AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1784, 1, CAST(0x0000A833000BB7A0 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1785, 1, CAST(0x0000A833000BB7B2 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1786, 1, CAST(0x0000A833000FA8A1 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1787, 1, CAST(0x0000A833000FA8B3 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1788, 1, CAST(0x0000A833001032A7 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1789, 1, CAST(0x0000A833001032BA AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1790, 1, CAST(0x0000A833001114DD AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1791, 1, CAST(0x0000A833001114EF AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1792, 1, CAST(0x0000A833001635A3 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1793, 1, CAST(0x0000A833001635B8 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1794, 1, CAST(0x0000A83300182AC3 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1795, 1, CAST(0x0000A83300182AD8 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1796, 1, CAST(0x0000A83300188B79 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1797, 1, CAST(0x0000A83300188B8B AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1798, 5, CAST(0x0000A8330018B93F AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1799, 5, CAST(0x0000A8330018B950 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1800, 1, CAST(0x0000A833001984E6 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1801, 1, CAST(0x0000A833001984FA AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1802, 1, CAST(0x0000A833001B6D40 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1803, 1, CAST(0x0000A833001B6D53 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
GO
print 'Processed 100 total records'
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1804, 1, CAST(0x0000A833001BD905 AS DateTime), N'Generar Presupuesto', N'Sin Disponibilidad', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1805, 1, CAST(0x0000A833001C177F AS DateTime), N'Generar Presupuesto', N'Sin Disponibilidad', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1806, 1, CAST(0x0000A833001ED97B AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1807, 1, CAST(0x0000A833001ED98D AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1808, 1, CAST(0x0000A83300212923 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1809, 1, CAST(0x0000A83300212935 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1810, 1, CAST(0x0000A83300254784 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1811, 1, CAST(0x0000A83300254799 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1812, 5, CAST(0x0000A83300269E2F AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1813, 5, CAST(0x0000A83300269E41 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1814, 5, CAST(0x0000A833002920EA AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1815, 5, CAST(0x0000A833002920FD AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1816, 5, CAST(0x0000A8330029AE1F AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1817, 5, CAST(0x0000A8330029AE32 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1818, 1, CAST(0x0000A833002BB4C7 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1819, 1, CAST(0x0000A833002BB4DF AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1820, 6, CAST(0x0000A833002CD4A0 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1821, 6, CAST(0x0000A833002CD4B1 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1822, 1, CAST(0x0000A833009AA79A AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1823, 1, CAST(0x0000A833009AA7B0 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1824, 6, CAST(0x0000A833009B19BA AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1825, 6, CAST(0x0000A833009B19CC AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1826, 1, CAST(0x0000A833009B4F36 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1827, 1, CAST(0x0000A833009B4F4C AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1828, 1, CAST(0x0000A83300A1ADC1 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1829, 1, CAST(0x0000A83300A1ADD7 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1830, 6, CAST(0x0000A83300A1C7CA AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1831, 6, CAST(0x0000A83300A1C7DE AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1832, 1, CAST(0x0000A83300A33FD4 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1833, 1, CAST(0x0000A83300A33FEB AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1834, 6, CAST(0x0000A83300A352D3 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1835, 6, CAST(0x0000A83300A352E6 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1836, 6, CAST(0x0000A83300A46B87 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1837, 6, CAST(0x0000A83300A46B9B AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1838, 5, CAST(0x0000A83300BD0499 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1839, 5, CAST(0x0000A83300BD04AD AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1840, 6, CAST(0x0000A83300BD3002 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1841, 6, CAST(0x0000A83300BD3013 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1842, 6, CAST(0x0000A83300BE42D2 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1843, 6, CAST(0x0000A83300BE42E7 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1844, 6, CAST(0x0000A83300C0CB68 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1845, 6, CAST(0x0000A83300C0CB7A AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1846, 6, CAST(0x0000A83300C51284 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1847, 6, CAST(0x0000A83300C5129A AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1848, 6, CAST(0x0000A83300CE27C2 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1849, 6, CAST(0x0000A83300CE27D6 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1850, 6, CAST(0x0000A83300E1D1B8 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1851, 6, CAST(0x0000A83300E1D1CC AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1852, 6, CAST(0x0000A83300ECDE1E AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1853, 6, CAST(0x0000A83300ECDE30 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1854, 6, CAST(0x0000A83300ED992E AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1855, 6, CAST(0x0000A83300ED9941 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1856, 6, CAST(0x0000A83300EEAE34 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1857, 6, CAST(0x0000A83300EEAE46 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1858, 6, CAST(0x0000A83300EFB5E6 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1859, 6, CAST(0x0000A83300EFB5FA AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1860, 6, CAST(0x0000A83300F0F478 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1861, 6, CAST(0x0000A83300F0F48B AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1862, 6, CAST(0x0000A83300F1CBA1 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1863, 6, CAST(0x0000A83300F1CBB3 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1864, 6, CAST(0x0000A83300F2987B AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1865, 6, CAST(0x0000A83300F298BB AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1866, 6, CAST(0x0000A83300F43307 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1867, 6, CAST(0x0000A83300F4331D AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1868, 6, CAST(0x0000A83300F5874F AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1869, 6, CAST(0x0000A83300F5877B AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1870, 6, CAST(0x0000A83300F637C8 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1871, 6, CAST(0x0000A83300F637D3 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1872, 6, CAST(0x0000A83300F637F2 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1873, 6, CAST(0x0000A83300F637F2 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1874, 6, CAST(0x0000A83300F84411 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1875, 6, CAST(0x0000A83300F84426 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1876, 6, CAST(0x0000A83300FB6A7A AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1877, 6, CAST(0x0000A83300FB6A8D AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1878, 6, CAST(0x0000A83300FBEFE2 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1879, 6, CAST(0x0000A83300FBEFF7 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1880, 6, CAST(0x0000A83300FCA993 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1881, 6, CAST(0x0000A83300FCA9A5 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1882, 6, CAST(0x0000A83300FF3161 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1883, 6, CAST(0x0000A83300FF3176 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1884, 6, CAST(0x0000A83301001F07 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1885, 6, CAST(0x0000A83301001F1D AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1886, 6, CAST(0x0000A8330102CF64 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1887, 6, CAST(0x0000A8330102CF77 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1888, 6, CAST(0x0000A8330103C239 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1889, 6, CAST(0x0000A8330103C24C AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1890, 6, CAST(0x0000A83301047625 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1891, 6, CAST(0x0000A83301047639 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1892, 6, CAST(0x0000A83301065EFF AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1893, 6, CAST(0x0000A83301065F12 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1894, 6, CAST(0x0000A8330106E9FE AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1895, 6, CAST(0x0000A8330106EA11 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1896, 6, CAST(0x0000A83301077108 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1897, 6, CAST(0x0000A8330107711C AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1898, 6, CAST(0x0000A83301083922 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1899, 6, CAST(0x0000A83301083935 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1900, 6, CAST(0x0000A83301096A70 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1901, 6, CAST(0x0000A83301096A85 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1902, 6, CAST(0x0000A833011AE2B2 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1903, 6, CAST(0x0000A833011AE2C5 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1904, 6, CAST(0x0000A833011C30EB AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
GO
print 'Processed 200 total records'
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1905, 6, CAST(0x0000A833011C30FF AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1906, 6, CAST(0x0000A833011D2B25 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1907, 6, CAST(0x0000A833011D2B38 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1908, 6, CAST(0x0000A833011DC4CE AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1909, 6, CAST(0x0000A833011DC4E3 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1910, 6, CAST(0x0000A8330121A6DC AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1911, 6, CAST(0x0000A8330121A6EE AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1912, 6, CAST(0x0000A8330122C826 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1913, 6, CAST(0x0000A8330122C836 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1914, 6, CAST(0x0000A8330124307B AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1915, 6, CAST(0x0000A83301243092 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1916, 6, CAST(0x0000A83301249E92 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1917, 6, CAST(0x0000A83301249EA5 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1918, 6, CAST(0x0000A83301289D44 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1919, 6, CAST(0x0000A83301289D56 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1920, 6, CAST(0x0000A83301293659 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1921, 6, CAST(0x0000A8330129366B AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1922, 6, CAST(0x0000A83301338E76 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1923, 6, CAST(0x0000A83301338E89 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1924, 6, CAST(0x0000A833013488B7 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1925, 6, CAST(0x0000A833013488CC AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1926, 24, CAST(0x0000A8330135054B AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1927, 24, CAST(0x0000A8330135055D AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1928, 29, CAST(0x0000A83301353010 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1929, 29, CAST(0x0000A83301353023 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1930, 1, CAST(0x0000A8330135AFA4 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1931, 1, CAST(0x0000A8330135AFB9 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1932, 6, CAST(0x0000A83301371E37 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1933, 6, CAST(0x0000A83301371E50 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1934, 6, CAST(0x0000A83301381239 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1935, 6, CAST(0x0000A8330138124D AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1936, 6, CAST(0x0000A8330138D1AF AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1937, 6, CAST(0x0000A8330138D1C4 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1938, 1, CAST(0x0000A83301392367 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1939, 1, CAST(0x0000A8330139237A AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1940, 6, CAST(0x0000A833014782F1 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1941, 6, CAST(0x0000A83301478306 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1942, 6, CAST(0x0000A833014A901D AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1943, 6, CAST(0x0000A833014A9030 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1944, 1, CAST(0x0000A833014AC6DD AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1945, 1, CAST(0x0000A833014AC6EF AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1946, 1, CAST(0x0000A833014FFB52 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1947, 1, CAST(0x0000A833014FFB66 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1948, 1, CAST(0x0000A8330150692C AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1949, 1, CAST(0x0000A8330150693F AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1950, 1, CAST(0x0000A833015199A0 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1951, 1, CAST(0x0000A833015199B3 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1952, 1, CAST(0x0000A833015209E1 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1953, 1, CAST(0x0000A833015209F0 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1954, 1, CAST(0x0000A8330152D765 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1955, 1, CAST(0x0000A8330152D778 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1956, 1, CAST(0x0000A83301534BC4 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1957, 1, CAST(0x0000A83301534BD7 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1958, 1, CAST(0x0000A8330155A84B AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1959, 1, CAST(0x0000A8330155A85C AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1960, 1, CAST(0x0000A833015B2040 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1961, 1, CAST(0x0000A833015B2054 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1962, 1, CAST(0x0000A833015BB5AF AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1963, 1, CAST(0x0000A833015BB5C2 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1964, 1, CAST(0x0000A833015CC5BC AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1965, 1, CAST(0x0000A833015CC5BD AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1966, 1, CAST(0x0000A833015DA71E AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1967, 1, CAST(0x0000A833015DA732 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1968, 1, CAST(0x0000A833015FAE7F AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1969, 1, CAST(0x0000A833015FAE91 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1970, 1, CAST(0x0000A833016005F6 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1971, 1, CAST(0x0000A8330160060A AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1972, 1, CAST(0x0000A8330160C189 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1973, 1, CAST(0x0000A8330160C19C AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1974, 1, CAST(0x0000A8330175344F AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1975, 1, CAST(0x0000A83301753463 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1976, 1, CAST(0x0000A834009DA9A4 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1977, 1, CAST(0x0000A834009DA9A6 AS DateTime), N'Ingreso al Sistema', N'Error en la Contraseña o Usuario', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1978, 1, CAST(0x0000A83400A7AE28 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1979, 1, CAST(0x0000A83400B48E6C AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1980, 1, CAST(0x0000A83400B54F43 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1981, 1, CAST(0x0000A83400ECC887 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1982, 1, CAST(0x0000A83400F3BF88 AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1983, 1, CAST(0x0000A83400F510CE AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1984, 1, CAST(0x0000A83400F8EEDE AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1985, 1, CAST(0x0000A83400F915CE AS DateTime), N'Generar Presupuesto', N'Sin Disponibilidad', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1986, 1, CAST(0x0000A83400F92064 AS DateTime), N'Generar Presupuesto', N'Evento Creado', N'1')
INSERT [dbo].[Bitacora] ([id_bitacora], [id_usuario], [Fecha], [Accion], [InfoAccion], [Categoria]) VALUES (1987, 1, CAST(0x0000A834011F211E AS DateTime), N'Ingreso al Sistema', N'Ingreso Correcto', N'1')
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
/****** Object:  Table [dbo].[Evento]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evento](
	[id_evento] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NOT NULL,
	[DireccionEvento] [nvarchar](max) NOT NULL,
	[id_catering] [int] NOT NULL,
	[CantPersonas] [int] NOT NULL,
	[FechaEvento] [date] NOT NULL,
	[PrecioTotalEvento] [decimal](18, 0) NOT NULL,
	[id_estado] [int] NOT NULL,
	[Comentario] [nvarchar](max) NULL,
	[nombreEvento] [nvarchar](max) NOT NULL,
	[Reserva] [decimal](18, 0) NULL,
	[DDVVH] [bigint] NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[id_evento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Evento] ON
INSERT [dbo].[Evento] ([id_evento], [idCliente], [DireccionEvento], [id_catering], [CantPersonas], [FechaEvento], [PrecioTotalEvento], [id_estado], [Comentario], [nombreEvento], [Reserva], [DDVVH]) VALUES (44, 3, N'Av Corrientes 5400', 2, 30, CAST(0x963D0B00 AS Date), CAST(27450 AS Decimal(18, 0)), 5, N'Prueba123', N'Mi cumple 30', CAST(25000 AS Decimal(18, 0)), 1856)
INSERT [dbo].[Evento] ([id_evento], [idCliente], [DireccionEvento], [id_catering], [CantPersonas], [FechaEvento], [PrecioTotalEvento], [id_estado], [Comentario], [nombreEvento], [Reserva], [DDVVH]) VALUES (45, 3, N'Av Peron 100', 2, 100, CAST(0x9E3D0B00 AS Date), CAST(8750000 AS Decimal(18, 0)), 5, N'Juan', N'Cumple44', CAST(5000000 AS Decimal(18, 0)), 1795)
INSERT [dbo].[Evento] ([id_evento], [idCliente], [DireccionEvento], [id_catering], [CantPersonas], [FechaEvento], [PrecioTotalEvento], [id_estado], [Comentario], [nombreEvento], [Reserva], [DDVVH]) VALUES (46, 8, N'av Prueba 123', 2, 100, CAST(0x943D0B00 AS Date), CAST(95000 AS Decimal(18, 0)), 1, N'dfdf', N'Cumple 50', CAST(0 AS Decimal(18, 0)), 1853)
INSERT [dbo].[Evento] ([id_evento], [idCliente], [DireccionEvento], [id_catering], [CantPersonas], [FechaEvento], [PrecioTotalEvento], [id_estado], [Comentario], [nombreEvento], [Reserva], [DDVVH]) VALUES (48, 3, N'123', 2, 30, CAST(0x8F3D0B00 AS Date), CAST(18833 AS Decimal(18, 0)), 1, N'pe pe pe ', N'123', CAST(0 AS Decimal(18, 0)), 1895)
INSERT [dbo].[Evento] ([id_evento], [idCliente], [DireccionEvento], [id_catering], [CantPersonas], [FechaEvento], [PrecioTotalEvento], [id_estado], [Comentario], [nombreEvento], [Reserva], [DDVVH]) VALUES (49, 3, N'123', 2, 30, CAST(0x903D0B00 AS Date), CAST(30890008 AS Decimal(18, 0)), 1, N'pe pe pe ', N'123', CAST(0 AS Decimal(18, 0)), 1823)
INSERT [dbo].[Evento] ([id_evento], [idCliente], [DireccionEvento], [id_catering], [CantPersonas], [FechaEvento], [PrecioTotalEvento], [id_estado], [Comentario], [nombreEvento], [Reserva], [DDVVH]) VALUES (50, 8, N'123', 2, 30, CAST(0x9F3D0B00 AS Date), CAST(18833 AS Decimal(18, 0)), 5, N'1234', N'123', CAST(5700 AS Decimal(18, 0)), 1807)
INSERT [dbo].[Evento] ([id_evento], [idCliente], [DireccionEvento], [id_catering], [CantPersonas], [FechaEvento], [PrecioTotalEvento], [id_estado], [Comentario], [nombreEvento], [Reserva], [DDVVH]) VALUES (51, 3, N'11', 2, 12, CAST(0x993D0B00 AS Date), CAST(80044 AS Decimal(18, 0)), 5, N'112', N'11', CAST(0 AS Decimal(18, 0)), 1877)
INSERT [dbo].[Evento] ([id_evento], [idCliente], [DireccionEvento], [id_catering], [CantPersonas], [FechaEvento], [PrecioTotalEvento], [id_estado], [Comentario], [nombreEvento], [Reserva], [DDVVH]) VALUES (52, 3, N'11', 2, 12, CAST(0xC13D0B00 AS Date), CAST(125971 AS Decimal(18, 0)), 1, N'112', N'11', CAST(0 AS Decimal(18, 0)), 1852)
INSERT [dbo].[Evento] ([id_evento], [idCliente], [DireccionEvento], [id_catering], [CantPersonas], [FechaEvento], [PrecioTotalEvento], [id_estado], [Comentario], [nombreEvento], [Reserva], [DDVVH]) VALUES (53, 3, N'33', 2, 20, CAST(0x5A3D0B00 AS Date), CAST(10260 AS Decimal(18, 0)), 1, N'123', N'33', CAST(0 AS Decimal(18, 0)), 1785)
INSERT [dbo].[Evento] ([id_evento], [idCliente], [DireccionEvento], [id_catering], [CantPersonas], [FechaEvento], [PrecioTotalEvento], [id_estado], [Comentario], [nombreEvento], [Reserva], [DDVVH]) VALUES (54, 3, N'44', 1, 44, CAST(0x7C3D0B00 AS Date), CAST(7734 AS Decimal(18, 0)), 1, N'44', N'44', CAST(0 AS Decimal(18, 0)), 1837)
INSERT [dbo].[Evento] ([id_evento], [idCliente], [DireccionEvento], [id_catering], [CantPersonas], [FechaEvento], [PrecioTotalEvento], [id_estado], [Comentario], [nombreEvento], [Reserva], [DDVVH]) VALUES (55, 3, N'', 1, 12, CAST(0xEE3E0B00 AS Date), CAST(30658 AS Decimal(18, 0)), 1, N'sfwefwe', N'jdsbfjkdbg', CAST(0 AS Decimal(18, 0)), 1859)
SET IDENTITY_INSERT [dbo].[Evento] OFF
/****** Object:  Table [dbo].[IngredienteXPlato]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IngredienteXPlato](
	[id_plato] [int] NOT NULL,
	[id_ingrediente] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_IngredienteXPlato] PRIMARY KEY CLUSTERED 
(
	[id_plato] ASC,
	[id_ingrediente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (8, 1, 3)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (8, 2, 3)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (8, 3, 6)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (8, 4, 8)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (8, 5, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (10, 5, 4)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (10, 6, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (11, 5, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (11, 6, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (11, 7, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (11, 8, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (11, 9, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (12, 7, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (12, 9, 0)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (12, 10, 4)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (12, 11, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (12, 12, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (12, 28, 0)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (13, 6, 4)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (13, 7, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (13, 8, 4)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (13, 10, 7)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (13, 13, 3)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (13, 14, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (14, 1, 3)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (14, 2, 3)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (14, 3, 6)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (14, 4, 8)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (14, 5, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (14, 8, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (14, 9, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (15, 15, 8)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (15, 16, 6)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (15, 17, 6)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (15, 18, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (15, 19, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (15, 20, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (15, 21, 3)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (17, 8, 4)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (17, 15, 8)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (19, 21, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (19, 22, 4)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (19, 23, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (20, 5, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (20, 6, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (20, 16, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (20, 24, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (20, 25, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (20, 26, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (20, 27, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (20, 28, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (21, 7, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (21, 8, 4)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (21, 16, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (21, 23, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (21, 29, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (21, 30, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (21, 31, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (21, 32, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (21, 33, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (22, 34, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (22, 35, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (22, 36, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (22, 37, 3)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (23, 10, 9)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (23, 38, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (24, 40, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (24, 41, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (24, 42, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (24, 43, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (24, 44, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (24, 45, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (25, 8, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (25, 25, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (25, 40, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (25, 41, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (25, 46, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (26, 7, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (26, 16, 4)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (26, 23, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (26, 32, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (26, 44, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (26, 47, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (26, 48, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (27, 16, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (27, 32, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (27, 44, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (27, 48, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (27, 49, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (27, 50, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (27, 51, 2)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (28, 42, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (28, 45, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (28, 52, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (28, 53, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (28, 54, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (29, 26, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (29, 55, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (29, 56, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (30, 57, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (30, 58, 1)
GO
print 'Processed 100 total records'
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (30, 59, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (31, 60, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (31, 61, 1)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (34, 22, 5)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (34, 28, 3)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (34, 37, 5)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (35, 21, 5)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (35, 56, 0)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (35, 61, 0)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (35, 63, 0)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (36, 4, 4)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (36, 12, 4)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (36, 20, 4)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (37, 1, 4)
INSERT [dbo].[IngredienteXPlato] ([id_plato], [id_ingrediente], [Cantidad]) VALUES (37, 17, 4)
/****** Object:  Table [dbo].[PlatoXEvento]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlatoXEvento](
	[id_plato] [int] NOT NULL,
	[id_evento] [int] NOT NULL,
 CONSTRAINT [PK_PlatoXEvento] PRIMARY KEY CLUSTERED 
(
	[id_plato] ASC,
	[id_evento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (8, 54)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (10, 55)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (13, 55)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (15, 48)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (15, 50)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (15, 51)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (19, 44)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (19, 45)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (28, 44)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (28, 45)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (28, 48)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (28, 50)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (28, 51)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (30, 45)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (31, 44)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (31, 48)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (31, 50)
INSERT [dbo].[PlatoXEvento] ([id_plato], [id_evento]) VALUES (31, 51)
/****** Object:  Table [dbo].[EmpleadoXEvento]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpleadoXEvento](
	[idEmpleado] [int] NOT NULL,
	[id_evento] [int] NOT NULL,
 CONSTRAINT [PK_EmpleadoXEvento] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC,
	[id_evento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (3, 44)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (3, 45)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (3, 50)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (20, 45)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (21, 45)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (22, 45)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (23, 44)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (26, 45)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (28, 45)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (28, 50)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (31, 44)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (31, 45)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (32, 45)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (33, 45)
INSERT [dbo].[EmpleadoXEvento] ([idEmpleado], [id_evento]) VALUES (33, 50)
/****** Object:  Table [dbo].[BebidaXEvento]    Script Date: 11/23/2017 17:29:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BebidaXEvento](
	[id_bebida] [int] NOT NULL,
	[id_evento] [int] NOT NULL,
 CONSTRAINT [PK_BebidaXEvento] PRIMARY KEY CLUSTERED 
(
	[id_bebida] ASC,
	[id_evento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BebidaXEvento] ([id_bebida], [id_evento]) VALUES (1, 54)
INSERT [dbo].[BebidaXEvento] ([id_bebida], [id_evento]) VALUES (1, 55)
INSERT [dbo].[BebidaXEvento] ([id_bebida], [id_evento]) VALUES (3, 54)
INSERT [dbo].[BebidaXEvento] ([id_bebida], [id_evento]) VALUES (10, 44)
INSERT [dbo].[BebidaXEvento] ([id_bebida], [id_evento]) VALUES (10, 48)
INSERT [dbo].[BebidaXEvento] ([id_bebida], [id_evento]) VALUES (10, 50)
INSERT [dbo].[BebidaXEvento] ([id_bebida], [id_evento]) VALUES (10, 54)
INSERT [dbo].[BebidaXEvento] ([id_bebida], [id_evento]) VALUES (11, 45)
INSERT [dbo].[BebidaXEvento] ([id_bebida], [id_evento]) VALUES (11, 51)
INSERT [dbo].[BebidaXEvento] ([id_bebida], [id_evento]) VALUES (11, 54)
/****** Object:  ForeignKey [FK_Plato_TipoMenu]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[Plato]  WITH CHECK ADD  CONSTRAINT [FK_Plato_TipoMenu] FOREIGN KEY([id_tipoMenu])
REFERENCES [dbo].[TipoMenu] ([id_TipoMenu])
GO
ALTER TABLE [dbo].[Plato] CHECK CONSTRAINT [FK_Plato_TipoMenu]
GO
/****** Object:  ForeignKey [FK_Per_Per_Permiso]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[Per_Per]  WITH CHECK ADD  CONSTRAINT [FK_Per_Per_Permiso] FOREIGN KEY([Cod_Padre])
REFERENCES [dbo].[Permiso] ([ID])
GO
ALTER TABLE [dbo].[Per_Per] CHECK CONSTRAINT [FK_Per_Per_Permiso]
GO
/****** Object:  ForeignKey [FK_Per_Per_Permiso1]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[Per_Per]  WITH CHECK ADD  CONSTRAINT [FK_Per_Per_Permiso1] FOREIGN KEY([Cod_Hijo])
REFERENCES [dbo].[Permiso] ([ID])
GO
ALTER TABLE [dbo].[Per_Per] CHECK CONSTRAINT [FK_Per_Per_Permiso1]
GO
/****** Object:  ForeignKey [FK_Control_Language]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[IdiomaControl]  WITH CHECK ADD  CONSTRAINT [FK_Control_Language] FOREIGN KEY([LANG_ID])
REFERENCES [dbo].[Idioma] ([LANG_ID])
GO
ALTER TABLE [dbo].[IdiomaControl] CHECK CONSTRAINT [FK_Control_Language]
GO
/****** Object:  ForeignKey [FK_Cliente_Localidad]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Localidad]
GO
/****** Object:  ForeignKey [FK_Usuario_Empleado]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Empleado]
GO
/****** Object:  ForeignKey [FK_TipoMenuXCatering_Catering]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[TipoMenuXCatering]  WITH CHECK ADD  CONSTRAINT [FK_TipoMenuXCatering_Catering] FOREIGN KEY([id_Catering])
REFERENCES [dbo].[Catering] ([id_catering])
GO
ALTER TABLE [dbo].[TipoMenuXCatering] CHECK CONSTRAINT [FK_TipoMenuXCatering_Catering]
GO
/****** Object:  ForeignKey [FK_TipoMenuXCatering_TipoMenu]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[TipoMenuXCatering]  WITH CHECK ADD  CONSTRAINT [FK_TipoMenuXCatering_TipoMenu] FOREIGN KEY([id_TipoMenu])
REFERENCES [dbo].[TipoMenu] ([id_TipoMenu])
GO
ALTER TABLE [dbo].[TipoMenuXCatering] CHECK CONSTRAINT [FK_TipoMenuXCatering_TipoMenu]
GO
/****** Object:  ForeignKey [FK_BebidaXCatering_Bebida]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[BebidaXCatering]  WITH CHECK ADD  CONSTRAINT [FK_BebidaXCatering_Bebida] FOREIGN KEY([id_bebida])
REFERENCES [dbo].[Bebida] ([id_bebida])
GO
ALTER TABLE [dbo].[BebidaXCatering] CHECK CONSTRAINT [FK_BebidaXCatering_Bebida]
GO
/****** Object:  ForeignKey [FK_BebidaXCatering_Catering]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[BebidaXCatering]  WITH CHECK ADD  CONSTRAINT [FK_BebidaXCatering_Catering] FOREIGN KEY([id_catering])
REFERENCES [dbo].[Catering] ([id_catering])
GO
ALTER TABLE [dbo].[BebidaXCatering] CHECK CONSTRAINT [FK_BebidaXCatering_Catering]
GO
/****** Object:  ForeignKey [FK_UsuarioPermiso_Permiso]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[UsuarioPermiso]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPermiso_Permiso] FOREIGN KEY([ID])
REFERENCES [dbo].[Permiso] ([ID])
GO
ALTER TABLE [dbo].[UsuarioPermiso] CHECK CONSTRAINT [FK_UsuarioPermiso_Permiso]
GO
/****** Object:  ForeignKey [FK_UsuarioPermiso_Usuario]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[UsuarioPermiso]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPermiso_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[UsuarioPermiso] CHECK CONSTRAINT [FK_UsuarioPermiso_Usuario]
GO
/****** Object:  ForeignKey [FK_PlatoXCatering_Catering]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[PlatoXCatering]  WITH CHECK ADD  CONSTRAINT [FK_PlatoXCatering_Catering] FOREIGN KEY([id_catering])
REFERENCES [dbo].[Catering] ([id_catering])
GO
ALTER TABLE [dbo].[PlatoXCatering] CHECK CONSTRAINT [FK_PlatoXCatering_Catering]
GO
/****** Object:  ForeignKey [FK_PlatoXCatering_Plato]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[PlatoXCatering]  WITH CHECK ADD  CONSTRAINT [FK_PlatoXCatering_Plato] FOREIGN KEY([id_plato])
REFERENCES [dbo].[Plato] ([id_plato])
GO
ALTER TABLE [dbo].[PlatoXCatering] CHECK CONSTRAINT [FK_PlatoXCatering_Plato]
GO
/****** Object:  ForeignKey [FK_Bitacora_Usuario]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
/****** Object:  ForeignKey [FK_Evento_Catering]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Catering] FOREIGN KEY([id_catering])
REFERENCES [dbo].[Catering] ([id_catering])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Catering]
GO
/****** Object:  ForeignKey [FK_Evento_Cliente]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Cliente]
GO
/****** Object:  ForeignKey [FK_Evento_EstadoEvento]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_EstadoEvento] FOREIGN KEY([id_estado])
REFERENCES [dbo].[EstadoEvento] ([id_estado])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_EstadoEvento]
GO
/****** Object:  ForeignKey [FK_IngredienteXPlato_Ingrediente]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[IngredienteXPlato]  WITH CHECK ADD  CONSTRAINT [FK_IngredienteXPlato_Ingrediente] FOREIGN KEY([id_ingrediente])
REFERENCES [dbo].[Ingrediente] ([id_ingrediente])
GO
ALTER TABLE [dbo].[IngredienteXPlato] CHECK CONSTRAINT [FK_IngredienteXPlato_Ingrediente]
GO
/****** Object:  ForeignKey [FK_IngredienteXPlato_Plato]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[IngredienteXPlato]  WITH CHECK ADD  CONSTRAINT [FK_IngredienteXPlato_Plato] FOREIGN KEY([id_plato])
REFERENCES [dbo].[Plato] ([id_plato])
GO
ALTER TABLE [dbo].[IngredienteXPlato] CHECK CONSTRAINT [FK_IngredienteXPlato_Plato]
GO
/****** Object:  ForeignKey [FK_PlatoXEvento_Evento]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[PlatoXEvento]  WITH CHECK ADD  CONSTRAINT [FK_PlatoXEvento_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[PlatoXEvento] CHECK CONSTRAINT [FK_PlatoXEvento_Evento]
GO
/****** Object:  ForeignKey [FK_PlatoXEvento_Plato]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[PlatoXEvento]  WITH CHECK ADD  CONSTRAINT [FK_PlatoXEvento_Plato] FOREIGN KEY([id_plato])
REFERENCES [dbo].[Plato] ([id_plato])
GO
ALTER TABLE [dbo].[PlatoXEvento] CHECK CONSTRAINT [FK_PlatoXEvento_Plato]
GO
/****** Object:  ForeignKey [FK_EmpleadoXEvento_Empleado]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[EmpleadoXEvento]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoXEvento_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[EmpleadoXEvento] CHECK CONSTRAINT [FK_EmpleadoXEvento_Empleado]
GO
/****** Object:  ForeignKey [FK_EmpleadoXEvento_Evento]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[EmpleadoXEvento]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoXEvento_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[EmpleadoXEvento] CHECK CONSTRAINT [FK_EmpleadoXEvento_Evento]
GO
/****** Object:  ForeignKey [FK_BebidaXEvento_Bebida]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[BebidaXEvento]  WITH CHECK ADD  CONSTRAINT [FK_BebidaXEvento_Bebida] FOREIGN KEY([id_bebida])
REFERENCES [dbo].[Bebida] ([id_bebida])
GO
ALTER TABLE [dbo].[BebidaXEvento] CHECK CONSTRAINT [FK_BebidaXEvento_Bebida]
GO
/****** Object:  ForeignKey [FK_BebidaXEvento_Evento]    Script Date: 11/23/2017 17:29:25 ******/
ALTER TABLE [dbo].[BebidaXEvento]  WITH CHECK ADD  CONSTRAINT [FK_BebidaXEvento_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[BebidaXEvento] CHECK CONSTRAINT [FK_BebidaXEvento_Evento]
GO
