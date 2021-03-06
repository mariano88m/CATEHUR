USE [CATEHUR]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 10/04/2017 19:42:59 ******/
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
/****** Object:  Table [dbo].[Empleado]    Script Date: 10/04/2017 19:42:59 ******/
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
/****** Object:  Table [dbo].[DDVVV]    Script Date: 10/04/2017 19:42:59 ******/
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
/****** Object:  Table [dbo].[Permiso]    Script Date: 10/04/2017 19:42:59 ******/
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
/****** Object:  Table [dbo].[Per_Per]    Script Date: 10/04/2017 19:42:59 ******/
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
/****** Object:  Table [dbo].[IdiomaControl]    Script Date: 10/04/2017 19:42:59 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/04/2017 19:42:59 ******/
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
/****** Object:  Table [dbo].[UsuarioPermiso]    Script Date: 10/04/2017 19:42:59 ******/
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
/****** Object:  Table [dbo].[Bitacora]    Script Date: 10/04/2017 19:42:59 ******/
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
/****** Object:  ForeignKey [FK_Per_Per_Permiso]    Script Date: 10/04/2017 19:42:59 ******/
ALTER TABLE [dbo].[Per_Per]  WITH CHECK ADD  CONSTRAINT [FK_Per_Per_Permiso] FOREIGN KEY([Cod_Padre])
REFERENCES [dbo].[Permiso] ([ID])
GO
ALTER TABLE [dbo].[Per_Per] CHECK CONSTRAINT [FK_Per_Per_Permiso]
GO
/****** Object:  ForeignKey [FK_Per_Per_Permiso1]    Script Date: 10/04/2017 19:42:59 ******/
ALTER TABLE [dbo].[Per_Per]  WITH CHECK ADD  CONSTRAINT [FK_Per_Per_Permiso1] FOREIGN KEY([Cod_Hijo])
REFERENCES [dbo].[Permiso] ([ID])
GO
ALTER TABLE [dbo].[Per_Per] CHECK CONSTRAINT [FK_Per_Per_Permiso1]
GO
/****** Object:  ForeignKey [FK_Control_Language]    Script Date: 10/04/2017 19:42:59 ******/
ALTER TABLE [dbo].[IdiomaControl]  WITH CHECK ADD  CONSTRAINT [FK_Control_Language] FOREIGN KEY([LANG_ID])
REFERENCES [dbo].[Idioma] ([LANG_ID])
GO
ALTER TABLE [dbo].[IdiomaControl] CHECK CONSTRAINT [FK_Control_Language]
GO
/****** Object:  ForeignKey [FK_Usuario_Empleado]    Script Date: 10/04/2017 19:42:59 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Empleado]
GO
/****** Object:  ForeignKey [FK_UsuarioPermiso_Permiso]    Script Date: 10/04/2017 19:42:59 ******/
ALTER TABLE [dbo].[UsuarioPermiso]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPermiso_Permiso] FOREIGN KEY([ID])
REFERENCES [dbo].[Permiso] ([ID])
GO
ALTER TABLE [dbo].[UsuarioPermiso] CHECK CONSTRAINT [FK_UsuarioPermiso_Permiso]
GO
/****** Object:  ForeignKey [FK_UsuarioPermiso_Usuario]    Script Date: 10/04/2017 19:42:59 ******/
ALTER TABLE [dbo].[UsuarioPermiso]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPermiso_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[UsuarioPermiso] CHECK CONSTRAINT [FK_UsuarioPermiso_Usuario]
GO
/****** Object:  ForeignKey [FK_Bitacora_Usuario]    Script Date: 10/04/2017 19:42:59 ******/
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
