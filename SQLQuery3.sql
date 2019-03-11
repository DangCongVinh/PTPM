USE [QuanLyShopBanGiay]
GO
/****** Object:  Database [QuanLyShopBanGiay]    Script Date: 18/01/2018 07:59:47 ******/
CREATE DATABASE [QuanLyShopBanGiay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyShopBanGiay', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyShopBanGiay.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyShopBanGiay_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyShopBanGiay_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyShopBanGiay] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyShopBanGiay].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyShopBanGiay] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyShopBanGiay] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyShopBanGiay] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyShopBanGiay]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 18/01/2018 07:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[DisplayName] [nvarchar](100) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Ca] [int] NULL,
	[TYPE] [int] NULL,
	[SoDienThoai] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Catarogry]    Script Date: 18/01/2018 07:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catarogry](
	[ID_LoaiGiay] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiGiay] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_LoaiGiay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 18/01/2018 07:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[ID_CTHD] [int] IDENTITY(1,1) NOT NULL,
	[ID_HD] [int] NOT NULL,
	[ID_GIAY] [nvarchar](100) NOT NULL,
	[DISCOUNT] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_HD] ASC,
	[ID_GIAY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 18/01/2018 07:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[ID_HD] [int] IDENTITY(1,1) NOT NULL,
	[NGAYTAO] [date] NOT NULL,
	[USERNAME] [nvarchar](100) NOT NULL,
	[TONGTIEN] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_HD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPhamKhuyenMai]    Script Date: 18/01/2018 07:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPhamKhuyenMai](
	[Ten_SPKM] [nvarchar](100) NOT NULL,
	[Gia_banle] [bigint] NOT NULL,
	[Soluong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Ten_SPKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongTinGiay]    Script Date: 18/01/2018 07:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinGiay](
	[ID_Giay] [nvarchar](100) NOT NULL,
	[TenSanPham] [nvarchar](100) NOT NULL,
	[Gia] [bigint] NOT NULL,
	[ID_LoaiGiay] [int] NULL,
	[Status] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Giay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[CIRCLE]    Script Date: 18/01/2018 07:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[CIRCLE]
AS
select  count(id_cthd) AS [SOLUONG],TenLoaiGiay,NGAYTAO from HOADON a, CHITIETHOADON b, Catarogry c
where a.ID_HD = b.ID_HD and b.ID_LOAIGIAY = c.ID_LoaiGiay-- and MONTH(NGAYTAO) = 1
group by TenLoaiGiay,NGAYTAO
GO
/****** Object:  View [dbo].[COLUM]    Script Date: 18/01/2018 07:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[COLUM]
AS
SELECT COUNT(B.ID_HD) AS [SOLUONG],NGAYTAO FROM HOADON A, CHITIETHOADON B 
WHERE   A.ID_HD=B.ID_HD AND NGAYTAO > '1/1/2018' AND NGAYTAO <'1/2/2018'
GROUP BY NGAYTAO
GO
/****** Object:  View [dbo].[ReportBills]    Script Date: 18/01/2018 07:59:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ReportBills] 
AS
SELECT A.ID_HD, NGAYTAO, A.USERNAME, B.ID_GIAY,TENLOAIGIAY, GIA, DISCOUNT,TONGTIEN
FROM HOADON A, CHITIETHOADON B, Catarogry C , Account D, ThongTinGiay E
WHERE A.ID_HD = B.ID_HD AND A.USERNAME=D.UserName AND E.ID_Giay= B.ID_GIAY AND E.ID_LoaiGiay=C.ID_LoaiGiay

GO
INSERT [dbo].[Account] ([DisplayName], [UserName], [Password], [Ca], [TYPE], [SoDienThoai]) VALUES (N'asd', N'a', N'a', 1, 0, N'123')
INSERT [dbo].[Account] ([DisplayName], [UserName], [Password], [Ca], [TYPE], [SoDienThoai]) VALUES (N'Tr?n Vi?t D?ng', N'dungtran9x225', N'toiyeuem182', 0, 1, N'0168.213.0203')
INSERT [dbo].[Account] ([DisplayName], [UserName], [Password], [Ca], [TYPE], [SoDienThoai]) VALUES (N'Nguy?n Th? Thu Dung', N'thudung1507', N'toiyeuem182', 2, 0, N'097.359.9053')
SET IDENTITY_INSERT [dbo].[Catarogry] ON 

INSERT [dbo].[Catarogry] ([ID_LoaiGiay], [TenLoaiGiay]) VALUES (1, N'ADDIDAS')
INSERT [dbo].[Catarogry] ([ID_LoaiGiay], [TenLoaiGiay]) VALUES (2, N'NIKEN')
INSERT [dbo].[Catarogry] ([ID_LoaiGiay], [TenLoaiGiay]) VALUES (3, N'Convert')
INSERT [dbo].[Catarogry] ([ID_LoaiGiay], [TenLoaiGiay]) VALUES (10, N'Thý?ng ð?nh')
INSERT [dbo].[Catarogry] ([ID_LoaiGiay], [TenLoaiGiay]) VALUES (13, N'Gucci')
SET IDENTITY_INSERT [dbo].[Catarogry] OFF
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] ON 

INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (1, 27, N'hh', 5)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (2, 28, N'kk', 5)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (4, 29, N'ATG5K', 5)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (3, 29, N'HT6KJ', 5)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (5, 30, N'qq', 10)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (6, 34, N'A1', 0)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (7, 35, N'A2', 0)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (8, 36, N'A3', 0)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (9, 37, N'A4', 0)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (10, 38, N'A5', 0)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (11, 40, N'AAA', 3)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (12, 41, N'A9', 5)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (13, 42, N'A8', 5)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (14, 43, N'A6', 10)
INSERT [dbo].[CHITIETHOADON] ([ID_CTHD], [ID_HD], [ID_GIAY], [DISCOUNT]) VALUES (15, 43, N'A7', 10)
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] OFF
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (27, CAST(N'2018-01-15' AS Date), N'dungtran9x225', 142500)
INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (28, CAST(N'2018-01-15' AS Date), N'dungtran9x225', 95000)
INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (29, CAST(N'2018-01-15' AS Date), N'dungtran9x225', 950000)
INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (30, CAST(N'2018-01-15' AS Date), N'dungtran9x225', 180000)
INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (34, CAST(N'2018-01-05' AS Date), N'dungtran9x225', 300000)
INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (35, CAST(N'2018-01-02' AS Date), N'dungtran9x225', 300000)
INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (36, CAST(N'2018-01-08' AS Date), N'dungtran9x225', 300000)
INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (37, CAST(N'2018-01-14' AS Date), N'dungtran9x225', 300000)
INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (38, CAST(N'2018-01-13' AS Date), N'dungtran9x225', 300000)
INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (40, CAST(N'2018-01-15' AS Date), N'dungtran9x225', 291000)
INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (41, CAST(N'2018-01-15' AS Date), N'dungtran9x225', 285000)
INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (42, CAST(N'2018-01-18' AS Date), N'dungtran9x225', 285000)
INSERT [dbo].[HOADON] ([ID_HD], [NGAYTAO], [USERNAME], [TONGTIEN]) VALUES (43, CAST(N'2018-01-18' AS Date), N'dungtran9x225', 540000)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
INSERT [dbo].[SanPhamKhuyenMai] ([Ten_SPKM], [Gia_banle], [Soluong]) VALUES (N'Dây giày', 15000, 100)
INSERT [dbo].[SanPhamKhuyenMai] ([Ten_SPKM], [Gia_banle], [Soluong]) VALUES (N'Lót Giay', 10000, 100)
INSERT [dbo].[SanPhamKhuyenMai] ([Ten_SPKM], [Gia_banle], [Soluong]) VALUES (N'V? cao', 15000, 100)
INSERT [dbo].[SanPhamKhuyenMai] ([Ten_SPKM], [Gia_banle], [Soluong]) VALUES (N'V? lùn', 20000, 200)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'0145', N'1', 150000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'1', N'1', 10, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'12', N'12', 12, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'123', N'123', 123, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'1234', N'1234', 1234, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'13', N'12', 1, 2, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'134', N'1', 100000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'2', N'2', 10, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A', N'ÁDS', 23234, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A1', N'ÁDSD', 234234, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A10', N'A10', 300000, 2, 0)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A11', N'A11', 300000, 2, 0)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A12', N'A12', 300000, 2, 0)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A2', N'4234', 4234234, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A3', N'A2', 300000, 2, 0)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A36TD', N'500000', 400000, 3, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A4', N'A3', 300000, 2, 0)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A5', N'A4', 300000, 2, 0)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A6', N'A5', 300000, 2, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A7', N'A7', 300000, 2, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A8', N'A8', 300000, 2, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'A9', N'A9', 300000, 2, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'AAA', N'AAA', 300000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'AH5TD', N'AK', 500000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'ATG5K', N'AL', 500000, 3, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'ð', N'd', 100000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'f', N'f', 500000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'g', N'g', 500000, 2, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'h', N'h', 500000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'hh', N'h', 150000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'HT6KJ', N'AK', 500000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'j', N'j', 500000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'k', N'k', 100000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'kk', N'kk', 100000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'l', N'l', 100000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'qq', N'qq', 200000, 13, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N's', N's', 100000, 1, 1)
INSERT [dbo].[ThongTinGiay] ([ID_Giay], [TenSanPham], [Gia], [ID_LoaiGiay], [Status]) VALUES (N'u', N'u', 150000, 1, 1)
---------Xóa khóa ngo?i
--ALTER TABLE 
select*from Catarogry



