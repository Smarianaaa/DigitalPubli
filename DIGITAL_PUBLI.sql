USE [DIGITAL_PUBLI]
GO
/****** Object:  Table [dbo].[Detalle_Imagen]    Script Date: 02/06/2023 04:41:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Imagen](
	[ImgID] [int] IDENTITY(1,1) NOT NULL,
	[nombreImagen] [varchar](500) NULL,
	[img] [varbinary](max) NULL,
	[imgUrl] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ImgID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Proyecto]    Script Date: 02/06/2023 04:41:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Proyecto](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[texto] [varchar](500) NULL,
	[ProyectoID] [int] NULL,
	[UsuarioID] [int] NULL,
	[ImgID] [int] NULL,
	[ResultadoPublicidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proyecto]    Script Date: 02/06/2023 04:41:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyecto](
	[ProyectoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Descripcion] [varchar](500) NULL,
	[Estado] [varchar](20) NULL,
	[Segmentacion] [varchar](100) NULL,
	[UsuarioID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProyectoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 02/06/2023 04:41:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[nombreUsuario] [varchar](15) NULL,
	[Tipo] [varchar](10) NULL,
	[Correo] [varchar](100) NULL,
	[Telefono] [varchar](10) NULL,
	[Celular] [varchar](10) NULL,
	[Direccion] [varchar](100) NULL,
	[Pass] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalle_Proyecto]  WITH CHECK ADD FOREIGN KEY([ImgID])
REFERENCES [dbo].[Detalle_Imagen] ([ImgID])
GO
ALTER TABLE [dbo].[Detalle_Proyecto]  WITH CHECK ADD FOREIGN KEY([ProyectoID])
REFERENCES [dbo].[Proyecto] ([ProyectoID])
GO
ALTER TABLE [dbo].[Detalle_Proyecto]  WITH CHECK ADD FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[usuario] ([UsuarioID])
GO
