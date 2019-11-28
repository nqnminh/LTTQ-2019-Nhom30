USE [QLKTX]
GO
ALTER TABLE [dbo].[tblTaisan] DROP CONSTRAINT [FK_tblTaisan_tblPhong]
GO
ALTER TABLE [dbo].[tblTaisan] DROP CONSTRAINT [FK_tblTaisan_tblLoaits]
GO
ALTER TABLE [dbo].[tblSinhvien] DROP CONSTRAINT [FK_tblSinhvien_tblPhong]
GO
ALTER TABLE [dbo].[tblPhong] DROP CONSTRAINT [FK_tblPhong_tblKhu1]
GO
ALTER TABLE [dbo].[tblKhu] DROP CONSTRAINT [FK_tblKhu_tblNhanvien]
GO
ALTER TABLE [dbo].[tblHopdong] DROP CONSTRAINT [FK_tblHopdong_tblSinhvien]
GO
ALTER TABLE [dbo].[tblHoadon] DROP CONSTRAINT [FK_tblHoadon_tblPhong]
GO
/****** Object:  Table [dbo].[tblTaisan]    Script Date: 11/28/2019 10:22:13 AM ******/
DROP TABLE [dbo].[tblTaisan]
GO
/****** Object:  Table [dbo].[tblSinhvien]    Script Date: 11/28/2019 10:22:13 AM ******/
DROP TABLE [dbo].[tblSinhvien]
GO
/****** Object:  Table [dbo].[tblPhong]    Script Date: 11/28/2019 10:22:13 AM ******/
DROP TABLE [dbo].[tblPhong]
GO
/****** Object:  Table [dbo].[tblNhanvien]    Script Date: 11/28/2019 10:22:13 AM ******/
DROP TABLE [dbo].[tblNhanvien]
GO
/****** Object:  Table [dbo].[tblLoaits]    Script Date: 11/28/2019 10:22:13 AM ******/
DROP TABLE [dbo].[tblLoaits]
GO
/****** Object:  Table [dbo].[tblKhu]    Script Date: 11/28/2019 10:22:13 AM ******/
DROP TABLE [dbo].[tblKhu]
GO
/****** Object:  Table [dbo].[tblHopdong]    Script Date: 11/28/2019 10:22:13 AM ******/
DROP TABLE [dbo].[tblHopdong]
GO
/****** Object:  Table [dbo].[tblHoadon]    Script Date: 11/28/2019 10:22:13 AM ******/
DROP TABLE [dbo].[tblHoadon]
GO
/****** Object:  Table [dbo].[tblHoadon]    Script Date: 11/28/2019 10:22:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoadon](
	[Mahoadon] [nchar](10) NOT NULL,
	[Maphong] [nchar](10) NOT NULL,
	[Sodienthangtruoc] [int] NULL,
	[Sodienthangsau] [int] NULL,
	[Sonuocthangtruoc] [int] NULL,
	[Sonuocthangsau] [int] NULL,
	[Gianuoc] [int] NULL,
	[Giadien] [int] NULL,
	[Tongtien] [int] NULL,
 CONSTRAINT [PK_tblHoadon] PRIMARY KEY CLUSTERED 
(
	[Mahoadon] ASC,
	[Maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHopdong]    Script Date: 11/28/2019 10:22:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHopdong](
	[Mahopdong] [nchar](10) NOT NULL,
	[Masv] [nchar](10) NULL,
	[Maphong] [nchar](10) NULL,
	[Thoihan] [date] NULL,
 CONSTRAINT [PK_tblHopdong] PRIMARY KEY CLUSTERED 
(
	[Mahopdong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblKhu]    Script Date: 11/28/2019 10:22:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhu](
	[Makhu] [nchar](10) NOT NULL,
	[Tenkhu] [nvarchar](50) NULL,
	[Manv] [nchar](10) NULL,
 CONSTRAINT [PK_tblKhu] PRIMARY KEY CLUSTERED 
(
	[Makhu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblLoaits]    Script Date: 11/28/2019 10:22:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaits](
	[Mataisan] [nchar](10) NOT NULL,
	[Tentaisan] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblLoaits] PRIMARY KEY CLUSTERED 
(
	[Mataisan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblNhanvien]    Script Date: 11/28/2019 10:22:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanvien](
	[Manv] [nchar](10) NOT NULL,
	[Matkhau] [nchar](50) NULL,
	[Hoten] [nvarchar](50) NULL,
	[Sodienthoai] [int] NULL,
	[Quyenhan] [bit] NULL,
	[Ghichu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblNhanvien] PRIMARY KEY CLUSTERED 
(
	[Manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPhong]    Script Date: 11/28/2019 10:22:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhong](
	[Maphong] [nchar](10) NOT NULL,
	[Slmax] [int] NULL,
	[Sldango] [int] NULL,
	[Makhu] [nchar](10) NULL,
	[Loaiphong] [bit] NULL,
 CONSTRAINT [PK_tblPhong] PRIMARY KEY CLUSTERED 
(
	[Maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSinhvien]    Script Date: 11/28/2019 10:22:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSinhvien](
	[MaSV] [nchar](10) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[Gioitinh] [bit] NULL,
	[Hokhau] [nvarchar](150) NULL,
	[Sodienthoai] [int] NULL,
	[Ngaydk] [date] NULL,
	[Ghichu] [nvarchar](250) NULL,
	[Maphong] [nchar](10) NULL,
 CONSTRAINT [PK_tblSinhvien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTaisan]    Script Date: 11/28/2019 10:22:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTaisan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Mataisan] [nchar](10) NULL,
	[Maphong] [nchar](10) NULL,
	[Soluong] [int] NULL,
 CONSTRAINT [PK_tblTaisan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tblHopdong] ([Mahopdong], [Masv], [Maphong], [Thoihan]) VALUES (N'001       ', N'1101      ', N'101       ', CAST(0xCC410B00 AS Date))
INSERT [dbo].[tblHopdong] ([Mahopdong], [Masv], [Maphong], [Thoihan]) VALUES (N'002       ', N'1102      ', N'101       ', CAST(0x2D410B00 AS Date))
INSERT [dbo].[tblHopdong] ([Mahopdong], [Masv], [Maphong], [Thoihan]) VALUES (N'003       ', N'1103      ', N'101       ', CAST(0xB9400B00 AS Date))
INSERT [dbo].[tblHopdong] ([Mahopdong], [Masv], [Maphong], [Thoihan]) VALUES (N'004       ', N'1104      ', N'101       ', CAST(0x6D410B00 AS Date))
INSERT [dbo].[tblHopdong] ([Mahopdong], [Masv], [Maphong], [Thoihan]) VALUES (N'005       ', N'1105      ', N'201       ', CAST(0xCB410B00 AS Date))
INSERT [dbo].[tblHopdong] ([Mahopdong], [Masv], [Maphong], [Thoihan]) VALUES (N'006       ', N'1106      ', N'201       ', CAST(0xE9410B00 AS Date))
INSERT [dbo].[tblHopdong] ([Mahopdong], [Masv], [Maphong], [Thoihan]) VALUES (N'007       ', N'1107      ', N'101       ', CAST(0xF2400B00 AS Date))
INSERT [dbo].[tblKhu] ([Makhu], [Tenkhu], [Manv]) VALUES (N'01        ', N'A', N'Test1     ')
INSERT [dbo].[tblKhu] ([Makhu], [Tenkhu], [Manv]) VALUES (N'02        ', N'B', N'Test2     ')
INSERT [dbo].[tblLoaits] ([Mataisan], [Tentaisan]) VALUES (N'01        ', N'Quạt trần')
INSERT [dbo].[tblLoaits] ([Mataisan], [Tentaisan]) VALUES (N'02        ', N'Bóng đèn')
INSERT [dbo].[tblLoaits] ([Mataisan], [Tentaisan]) VALUES (N'03        ', N'Nóng lạnh')
INSERT [dbo].[tblLoaits] ([Mataisan], [Tentaisan]) VALUES (N'04        ', N'Tủ áo')
INSERT [dbo].[tblNhanvien] ([Manv], [Matkhau], [Hoten], [Sodienthoai], [Quyenhan], [Ghichu]) VALUES (N'admin     ', N'21232f297a57a5a743894a0e4a801fc3                  ', N'admin', 0, 0, N'admin')
INSERT [dbo].[tblNhanvien] ([Manv], [Matkhau], [Hoten], [Sodienthoai], [Quyenhan], [Ghichu]) VALUES (N'Test1     ', N'0cc175b9c0f1b6a831c399e269772661                  ', N'Nguyễn Phương Linh', 945934932, 1, N'NV')
INSERT [dbo].[tblNhanvien] ([Manv], [Matkhau], [Hoten], [Sodienthoai], [Quyenhan], [Ghichu]) VALUES (N'Test2     ', N'0cc175b9c0f1b6a831c399e269772661                  ', N'Nguyễn Phước Lâm', 123445123, 1, N'Nv')
INSERT [dbo].[tblPhong] ([Maphong], [Slmax], [Sldango], [Makhu], [Loaiphong]) VALUES (N'101       ', 6, 5, N'01        ', 0)
INSERT [dbo].[tblPhong] ([Maphong], [Slmax], [Sldango], [Makhu], [Loaiphong]) VALUES (N'201       ', 6, 2, N'02        ', 1)
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1101      ', N'Nguyễn Quốc Minh', CAST(0x6C220B00 AS Date), 0, N'Đô lương -Nghệ AN', 969645661, CAST(0x7B400B00 AS Date), NULL, N'101       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1102      ', N'Nguyễn Văn Chiên', CAST(0xC7210B00 AS Date), 0, N'Đô lương- Nghệ An', 956945965, CAST(0xBF3F0B00 AS Date), NULL, N'101       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1103      ', N'Nguyên Khắc Nam', CAST(0x3C200B00 AS Date), 0, N'Đô lương-Nghê an', 764653656, CAST(0x4C3F0B00 AS Date), NULL, N'101       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1104      ', N'Trần Xuân Mạnh', CAST(0x4D1F0B00 AS Date), 0, N'Yên Thành-Nghệ an', 54032432, CAST(0xFF3F0B00 AS Date), NULL, N'101       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1105      ', N'Kiều Linh Chi', CAST(0xC6210B00 AS Date), 1, N'Nam Đàn-Nghệ An', 45640434, CAST(0x5D400B00 AS Date), NULL, N'201       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1106      ', N'Trần Thị Ánh', CAST(0x50210B00 AS Date), 1, N'Quỳ Châu-Nghệ An', 875565434, CAST(0x7B400B00 AS Date), NULL, N'201       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1107      ', N'TRần Văn Hòa', CAST(0xAD210B00 AS Date), 0, N'Anh Sơn-Nghệ An', 98494855, CAST(0x843F0B00 AS Date), NULL, N'101       ')
SET IDENTITY_INSERT [dbo].[tblTaisan] ON 

INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (2, N'01        ', N'101       ', 2)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (3, N'02        ', N'101       ', 3)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (4, N'03        ', N'101       ', 1)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (5, N'04        ', N'101       ', 2)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (6, N'01        ', N'201       ', 2)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (7, N'02        ', N'201       ', 3)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (8, N'03        ', N'201       ', 1)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (9, N'04        ', N'201       ', 2)
SET IDENTITY_INSERT [dbo].[tblTaisan] OFF
ALTER TABLE [dbo].[tblHoadon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadon_tblPhong] FOREIGN KEY([Maphong])
REFERENCES [dbo].[tblPhong] ([Maphong])
GO
ALTER TABLE [dbo].[tblHoadon] CHECK CONSTRAINT [FK_tblHoadon_tblPhong]
GO
ALTER TABLE [dbo].[tblHopdong]  WITH CHECK ADD  CONSTRAINT [FK_tblHopdong_tblSinhvien] FOREIGN KEY([Masv])
REFERENCES [dbo].[tblSinhvien] ([MaSV])
GO
ALTER TABLE [dbo].[tblHopdong] CHECK CONSTRAINT [FK_tblHopdong_tblSinhvien]
GO
ALTER TABLE [dbo].[tblKhu]  WITH CHECK ADD  CONSTRAINT [FK_tblKhu_tblNhanvien] FOREIGN KEY([Manv])
REFERENCES [dbo].[tblNhanvien] ([Manv])
GO
ALTER TABLE [dbo].[tblKhu] CHECK CONSTRAINT [FK_tblKhu_tblNhanvien]
GO
ALTER TABLE [dbo].[tblPhong]  WITH CHECK ADD  CONSTRAINT [FK_tblPhong_tblKhu1] FOREIGN KEY([Makhu])
REFERENCES [dbo].[tblKhu] ([Makhu])
GO
ALTER TABLE [dbo].[tblPhong] CHECK CONSTRAINT [FK_tblPhong_tblKhu1]
GO
ALTER TABLE [dbo].[tblSinhvien]  WITH CHECK ADD  CONSTRAINT [FK_tblSinhvien_tblPhong] FOREIGN KEY([Maphong])
REFERENCES [dbo].[tblPhong] ([Maphong])
GO
ALTER TABLE [dbo].[tblSinhvien] CHECK CONSTRAINT [FK_tblSinhvien_tblPhong]
GO
ALTER TABLE [dbo].[tblTaisan]  WITH CHECK ADD  CONSTRAINT [FK_tblTaisan_tblLoaits] FOREIGN KEY([Mataisan])
REFERENCES [dbo].[tblLoaits] ([Mataisan])
GO
ALTER TABLE [dbo].[tblTaisan] CHECK CONSTRAINT [FK_tblTaisan_tblLoaits]
GO
ALTER TABLE [dbo].[tblTaisan]  WITH CHECK ADD  CONSTRAINT [FK_tblTaisan_tblPhong] FOREIGN KEY([Maphong])
REFERENCES [dbo].[tblPhong] ([Maphong])
GO
ALTER TABLE [dbo].[tblTaisan] CHECK CONSTRAINT [FK_tblTaisan_tblPhong]
GO
