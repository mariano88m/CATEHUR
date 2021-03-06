USE [CATEHUR]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[Vajilla]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[Catering]    Script Date: 11/01/2017 19:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catering](
	[id_Catering] [int] IDENTITY(1,1) NOT NULL,
	[NombreCatering] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Catering] PRIMARY KEY CLUSTERED 
(
	[id_Catering] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[DDVVV]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[Idioma]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[EstadoEvento]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[Ingrediente]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[TipoMenu]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[Permiso]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[Plato]    Script Date: 11/01/2017 19:20:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plato](
	[id_plato] [int] IDENTITY(1,1) NOT NULL,
	[nombrePlato] [nvarchar](max) NOT NULL,
	[id_tipoMenu] [int] NOT NULL,
	[ManoDeObra] [money] NOT NULL,
 CONSTRAINT [PK_Plato] PRIMARY KEY CLUSTERED 
(
	[id_plato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Per_Per]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/01/2017 19:20:43 ******/
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
	[id_permiso] [int] NOT NULL,
	[DadoDeBaja] [int] NULL,
	[DDVVH] [bigint] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoMenuXCatering]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[IdiomaControl]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[Cliente]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[PlatoXCatering]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[UsuarioPermiso]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[IngredienteXPlato]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[Bitacora]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[Evento]    Script Date: 11/01/2017 19:20:43 ******/
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
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[id_evento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlatoXEvento]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  Table [dbo].[EmpleadoXEvento]    Script Date: 11/01/2017 19:20:43 ******/
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
/****** Object:  ForeignKey [FK_Plato_TipoMenu]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[Plato]  WITH CHECK ADD  CONSTRAINT [FK_Plato_TipoMenu] FOREIGN KEY([id_tipoMenu])
REFERENCES [dbo].[TipoMenu] ([id_TipoMenu])
GO
ALTER TABLE [dbo].[Plato] CHECK CONSTRAINT [FK_Plato_TipoMenu]
GO
/****** Object:  ForeignKey [FK_Per_Per_Permiso]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[Per_Per]  WITH CHECK ADD  CONSTRAINT [FK_Per_Per_Permiso] FOREIGN KEY([Cod_Padre])
REFERENCES [dbo].[Permiso] ([ID])
GO
ALTER TABLE [dbo].[Per_Per] CHECK CONSTRAINT [FK_Per_Per_Permiso]
GO
/****** Object:  ForeignKey [FK_Per_Per_Permiso1]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[Per_Per]  WITH CHECK ADD  CONSTRAINT [FK_Per_Per_Permiso1] FOREIGN KEY([Cod_Hijo])
REFERENCES [dbo].[Permiso] ([ID])
GO
ALTER TABLE [dbo].[Per_Per] CHECK CONSTRAINT [FK_Per_Per_Permiso1]
GO
/****** Object:  ForeignKey [FK_Usuario_Empleado]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Empleado]
GO
/****** Object:  ForeignKey [FK_TipoMenuXCatering_Catering]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[TipoMenuXCatering]  WITH CHECK ADD  CONSTRAINT [FK_TipoMenuXCatering_Catering] FOREIGN KEY([id_Catering])
REFERENCES [dbo].[Catering] ([id_Catering])
GO
ALTER TABLE [dbo].[TipoMenuXCatering] CHECK CONSTRAINT [FK_TipoMenuXCatering_Catering]
GO
/****** Object:  ForeignKey [FK_TipoMenuXCatering_TipoMenu]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[TipoMenuXCatering]  WITH CHECK ADD  CONSTRAINT [FK_TipoMenuXCatering_TipoMenu] FOREIGN KEY([id_TipoMenu])
REFERENCES [dbo].[TipoMenu] ([id_TipoMenu])
GO
ALTER TABLE [dbo].[TipoMenuXCatering] CHECK CONSTRAINT [FK_TipoMenuXCatering_TipoMenu]
GO
/****** Object:  ForeignKey [FK_Control_Language]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[IdiomaControl]  WITH CHECK ADD  CONSTRAINT [FK_Control_Language] FOREIGN KEY([LANG_ID])
REFERENCES [dbo].[Idioma] ([LANG_ID])
GO
ALTER TABLE [dbo].[IdiomaControl] CHECK CONSTRAINT [FK_Control_Language]
GO
/****** Object:  ForeignKey [FK_Cliente_Localidad]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Localidad] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidad] ([id_localidad])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Localidad]
GO
/****** Object:  ForeignKey [FK_PlatoXCatering_Catering]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[PlatoXCatering]  WITH CHECK ADD  CONSTRAINT [FK_PlatoXCatering_Catering] FOREIGN KEY([id_catering])
REFERENCES [dbo].[Catering] ([id_Catering])
GO
ALTER TABLE [dbo].[PlatoXCatering] CHECK CONSTRAINT [FK_PlatoXCatering_Catering]
GO
/****** Object:  ForeignKey [FK_PlatoXCatering_Plato]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[PlatoXCatering]  WITH CHECK ADD  CONSTRAINT [FK_PlatoXCatering_Plato] FOREIGN KEY([id_plato])
REFERENCES [dbo].[Plato] ([id_plato])
GO
ALTER TABLE [dbo].[PlatoXCatering] CHECK CONSTRAINT [FK_PlatoXCatering_Plato]
GO
/****** Object:  ForeignKey [FK_UsuarioPermiso_Permiso]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[UsuarioPermiso]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPermiso_Permiso] FOREIGN KEY([ID])
REFERENCES [dbo].[Permiso] ([ID])
GO
ALTER TABLE [dbo].[UsuarioPermiso] CHECK CONSTRAINT [FK_UsuarioPermiso_Permiso]
GO
/****** Object:  ForeignKey [FK_UsuarioPermiso_Usuario]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[UsuarioPermiso]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPermiso_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[UsuarioPermiso] CHECK CONSTRAINT [FK_UsuarioPermiso_Usuario]
GO
/****** Object:  ForeignKey [FK_IngredienteXPlato_Ingrediente]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[IngredienteXPlato]  WITH CHECK ADD  CONSTRAINT [FK_IngredienteXPlato_Ingrediente] FOREIGN KEY([id_ingrediente])
REFERENCES [dbo].[Ingrediente] ([id_ingrediente])
GO
ALTER TABLE [dbo].[IngredienteXPlato] CHECK CONSTRAINT [FK_IngredienteXPlato_Ingrediente]
GO
/****** Object:  ForeignKey [FK_IngredienteXPlato_Plato]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[IngredienteXPlato]  WITH CHECK ADD  CONSTRAINT [FK_IngredienteXPlato_Plato] FOREIGN KEY([id_plato])
REFERENCES [dbo].[Plato] ([id_plato])
GO
ALTER TABLE [dbo].[IngredienteXPlato] CHECK CONSTRAINT [FK_IngredienteXPlato_Plato]
GO
/****** Object:  ForeignKey [FK_Bitacora_Usuario]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
/****** Object:  ForeignKey [FK_Evento_Catering]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Catering] FOREIGN KEY([id_catering])
REFERENCES [dbo].[Catering] ([id_Catering])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Catering]
GO
/****** Object:  ForeignKey [FK_Evento_Cliente]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_Cliente]
GO
/****** Object:  ForeignKey [FK_Evento_EstadoEvento]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[Evento]  WITH CHECK ADD  CONSTRAINT [FK_Evento_EstadoEvento] FOREIGN KEY([id_estado])
REFERENCES [dbo].[EstadoEvento] ([id_estado])
GO
ALTER TABLE [dbo].[Evento] CHECK CONSTRAINT [FK_Evento_EstadoEvento]
GO
/****** Object:  ForeignKey [FK_PlatoXEvento_Evento]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[PlatoXEvento]  WITH CHECK ADD  CONSTRAINT [FK_PlatoXEvento_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[PlatoXEvento] CHECK CONSTRAINT [FK_PlatoXEvento_Evento]
GO
/****** Object:  ForeignKey [FK_PlatoXEvento_Plato]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[PlatoXEvento]  WITH CHECK ADD  CONSTRAINT [FK_PlatoXEvento_Plato] FOREIGN KEY([id_plato])
REFERENCES [dbo].[Plato] ([id_plato])
GO
ALTER TABLE [dbo].[PlatoXEvento] CHECK CONSTRAINT [FK_PlatoXEvento_Plato]
GO
/****** Object:  ForeignKey [FK_EmpleadoXEvento_Empleado]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[EmpleadoXEvento]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoXEvento_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[EmpleadoXEvento] CHECK CONSTRAINT [FK_EmpleadoXEvento_Empleado]
GO
/****** Object:  ForeignKey [FK_EmpleadoXEvento_Evento]    Script Date: 11/01/2017 19:20:43 ******/
ALTER TABLE [dbo].[EmpleadoXEvento]  WITH CHECK ADD  CONSTRAINT [FK_EmpleadoXEvento_Evento] FOREIGN KEY([id_evento])
REFERENCES [dbo].[Evento] ([id_evento])
GO
ALTER TABLE [dbo].[EmpleadoXEvento] CHECK CONSTRAINT [FK_EmpleadoXEvento_Evento]
GO
