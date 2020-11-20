USE [master]
GO
/****** Object:  Database [Negocio]    Script Date: 20/11/2020 14:43:47 ******/
CREATE DATABASE [Negocio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Negocio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Negocio.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Negocio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Negocio_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Negocio] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Negocio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Negocio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Negocio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Negocio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Negocio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Negocio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Negocio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Negocio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Negocio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Negocio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Negocio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Negocio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Negocio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Negocio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Negocio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Negocio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Negocio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Negocio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Negocio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Negocio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Negocio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Negocio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Negocio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Negocio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Negocio] SET  MULTI_USER 
GO
ALTER DATABASE [Negocio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Negocio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Negocio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Negocio] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Negocio] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Negocio] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Negocio] SET QUERY_STORE = OFF
GO
USE [Negocio]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 20/11/2020 14:43:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[PassCliente] [varchar](50) NOT NULL,
	[FechaAlta] [datetime] NOT NULL,
	[UsuarioID] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 20/11/2020 14:43:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NombreProducto] [varchar](50) NOT NULL,
	[StockProducto] [int] NOT NULL,
	[CantVendidos] [int] NOT NULL,
	[CategoriaProducto] [varchar](20) NOT NULL,
	[PrecioProducto] [real] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 20/11/2020 14:43:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL,
	[ApellidoUsuario] [varchar](50) NOT NULL,
	[DniUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([IdCliente], [PassCliente], [FechaAlta], [UsuarioID]) VALUES (CAST(1 AS Numeric(18, 0)), N'616706C4D6F7BDF68B30893F860CBB2B', CAST(N'2020-11-20T13:06:08.097' AS DateTime), CAST(1 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(1 AS Numeric(18, 0)), N'Salchicha rancia', 5, 2, N'Congelados', 15.2)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(2 AS Numeric(18, 0)), N'Leche', 37, 3, N'Congelados', 30.7)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(3 AS Numeric(18, 0)), N'Snack', 35, 0, N'Congelados', 20)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(4 AS Numeric(18, 0)), N'6Pack Duff', 70, 0, N'Congelados', 60)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(5 AS Numeric(18, 0)), N'Cereal', 10, 0, N'Congelados', 50.65)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(6 AS Numeric(18, 0)), N'Harina 000', 19, 1, N'Congelados', 20)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(7 AS Numeric(18, 0)), N'Lavandina', 10, 0, N'Perfumeria', 45)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(8 AS Numeric(18, 0)), N'Trapos', 59, 1, N'Perfumeria', 25.53)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(9 AS Numeric(18, 0)), N'Jabon liquido', 30, 0, N'Perfumeria', 35)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(10 AS Numeric(18, 0)), N'Jabon en polvo', 19, 1, N'Perfumeria', 30)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(11 AS Numeric(18, 0)), N'Pañuelos', 25, 0, N'Perfumeria', 55)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(12 AS Numeric(18, 0)), N'Esponjas', 20, 0, N'Perfumeria', 15)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(13 AS Numeric(18, 0)), N'Jabones', 15, 0, N'Bebidas', 20.5)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(14 AS Numeric(18, 0)), N'Pañales', 15, 0, N'Bebidas', 20.99)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(15 AS Numeric(18, 0)), N'Desodorante', 15, 0, N'Bebidas', 60.25)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(16 AS Numeric(18, 0)), N'Antitranspirante', 17, 3, N'Bebidas', 50.5)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(17 AS Numeric(18, 0)), N'Fosforos', 11, 2, N'Bebidas', 25.35)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(18 AS Numeric(18, 0)), N'Sprite 600ml', 10, 0, N'Bebidas', 50)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(19 AS Numeric(18, 0)), N'Coke 600ml', 5, 0, N'Bebidas', 60)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(20 AS Numeric(18, 0)), N'Sprite', 20, 0, N'Bebidas', 50)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(21 AS Numeric(18, 0)), N'Soda', 3, 0, N'Bebidas', 20)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(22 AS Numeric(18, 0)), N'Cepita', 30, 0, N'Bebidas', 45)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(23 AS Numeric(18, 0)), N'Jugo manzana 500ml', 5, 0, N'Bebidas', 23)
INSERT [dbo].[Productos] ([IdProducto], [NombreProducto], [StockProducto], [CantVendidos], [CategoriaProducto], [PrecioProducto]) VALUES (CAST(24 AS Numeric(18, 0)), N'Jugo Pomelo', 5, 0, N'Bebidas', 30)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IdUsuario], [NombreUsuario], [ApellidoUsuario], [DniUsuario]) VALUES (CAST(1 AS Numeric(18, 0)), N'Federico', N'Gutierrez', 42000844)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [UsuarioID] FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [UsuarioID]
GO
USE [master]
GO
ALTER DATABASE [Negocio] SET  READ_WRITE 
GO
