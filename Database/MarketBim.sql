USE [MarketBim]
GO
/****** Object:  Table [dbo].[Kategoriler]    Script Date: 23.5.2022 10:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoriler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAd] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Markalar]    Script Date: 23.5.2022 10:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Markalar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KategoriId] [int] NOT NULL,
	[MarkaAd] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 23.5.2022 10:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BarkodNo] [nvarchar](50) NULL,
	[KategoriId] [int] NOT NULL,
	[MarkaId] [int] NOT NULL,
	[UrunAd] [nvarchar](max) NULL,
	[Miktar] [int] NULL,
	[Gramaj] [nvarchar](50) NULL,
	[AlisFiyat] [decimal](18, 2) NULL,
	[SatisFiyat] [decimal](18, 2) NULL,
	[RafOmru] [nvarchar](50) NULL,
	[Tarih] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yetkiler]    Script Date: 23.5.2022 10:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetkiler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yoneticiler]    Script Date: 23.5.2022 10:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yoneticiler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[AuthorityId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Kategoriler] ON 

INSERT [dbo].[Kategoriler] ([Id], [KategoriAd]) VALUES (1, N'Gida')
INSERT [dbo].[Kategoriler] ([Id], [KategoriAd]) VALUES (2, N'Içecek')
INSERT [dbo].[Kategoriler] ([Id], [KategoriAd]) VALUES (3, N'Kuruyemis')
INSERT [dbo].[Kategoriler] ([Id], [KategoriAd]) VALUES (1001, N'Elektronik')
SET IDENTITY_INSERT [dbo].[Kategoriler] OFF
GO
SET IDENTITY_INSERT [dbo].[Markalar] ON 

INSERT [dbo].[Markalar] ([Id], [KategoriId], [MarkaAd]) VALUES (1, 1, N'Eti')
INSERT [dbo].[Markalar] ([Id], [KategoriId], [MarkaAd]) VALUES (2, 2, N'Coca Cola')
INSERT [dbo].[Markalar] ([Id], [KategoriId], [MarkaAd]) VALUES (3, 1, N'Nestle')
SET IDENTITY_INSERT [dbo].[Markalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([Id], [BarkodNo], [KategoriId], [MarkaId], [UrunAd], [Miktar], [Gramaj], [AlisFiyat], [SatisFiyat], [RafOmru], [Tarih]) VALUES (2002, N'G100', 1, 1, N'Burçak', 15, N'130 Gram', CAST(2.50 AS Decimal(18, 2)), CAST(5.50 AS Decimal(18, 2)), N'2 Yýl', N'18.4.2022 11:33:32')
INSERT [dbo].[Urunler] ([Id], [BarkodNo], [KategoriId], [MarkaId], [UrunAd], [Miktar], [Gramaj], [AlisFiyat], [SatisFiyat], [RafOmru], [Tarih]) VALUES (3002, N'E101', 4, 5, N'A4 tech mouse', 12, N'150 gram', CAST(55.00 AS Decimal(18, 2)), CAST(110.00 AS Decimal(18, 2)), N'2 yýl', N'23.5.2022 09:31:21')
SET IDENTITY_INSERT [dbo].[Urunler] OFF
GO
SET IDENTITY_INSERT [dbo].[Yetkiler] ON 

INSERT [dbo].[Yetkiler] ([Id], [Name]) VALUES (1, N'tüm yetki')
INSERT [dbo].[Yetkiler] ([Id], [Name]) VALUES (2, N'ürün yetkisi')
INSERT [dbo].[Yetkiler] ([Id], [Name]) VALUES (3, N'kategori yetkisi')
SET IDENTITY_INSERT [dbo].[Yetkiler] OFF
GO
SET IDENTITY_INSERT [dbo].[Yoneticiler] ON 

INSERT [dbo].[Yoneticiler] ([Id], [Username], [Password], [AuthorityId]) VALUES (1, N'admin', N'12345', 1)
INSERT [dbo].[Yoneticiler] ([Id], [Username], [Password], [AuthorityId]) VALUES (1003, N'admin2', N'12345', 2)
INSERT [dbo].[Yoneticiler] ([Id], [Username], [Password], [AuthorityId]) VALUES (1004, N'admin3', N'12345', 3)
SET IDENTITY_INSERT [dbo].[Yoneticiler] OFF
GO
