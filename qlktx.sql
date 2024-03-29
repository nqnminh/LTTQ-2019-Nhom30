USE [QLKTX]
GO
/****** Object:  Table [dbo].[tblHdong]    Script Date: 12/4/2019 10:01:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHdong](
	[MaHopdong] [int] IDENTITY(1,1) NOT NULL,
	[MaSV] [nchar](10) NOT NULL,
	[Thoihan] [date] NULL,
 CONSTRAINT [PK_tblHdong] PRIMARY KEY CLUSTERED 
(
	[MaHopdong] ASC,
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblHoadon]    Script Date: 12/4/2019 10:01:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoadon](
	[Mahoadon] [int] IDENTITY(1,1) NOT NULL,
	[Maphong] [nchar](10) NOT NULL,
	[Sodienthangtruoc] [int] NULL,
	[Sodienthangsau] [int] NULL,
	[Sonuocthangtruoc] [int] NULL,
	[Sonuocthangsau] [int] NULL,
	[Tongtien] [int] NULL,
 CONSTRAINT [PK_tblHoadon] PRIMARY KEY CLUSTERED 
(
	[Mahoadon] ASC,
	[Maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblKhu]    Script Date: 12/4/2019 10:01:00 AM ******/
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
/****** Object:  Table [dbo].[tblLoaits]    Script Date: 12/4/2019 10:01:00 AM ******/
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
/****** Object:  Table [dbo].[tblNhanvien]    Script Date: 12/4/2019 10:01:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanvien](
	[Manv] [nchar](10) NOT NULL,
	[Matkhau] [nvarchar](50) NULL,
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
/****** Object:  Table [dbo].[tblPhong]    Script Date: 12/4/2019 10:01:00 AM ******/
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
/****** Object:  Table [dbo].[tblQuydinh]    Script Date: 12/4/2019 10:01:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQuydinh](
	[Makhu] [nchar](10) NULL,
	[Giadien] [int] NULL,
	[Gianuoc] [int] NULL,
	[Giaphong] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSinhvien]    Script Date: 12/4/2019 10:01:00 AM ******/
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
/****** Object:  Table [dbo].[tblTaisan]    Script Date: 12/4/2019 10:01:00 AM ******/
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
SET IDENTITY_INSERT [dbo].[tblHdong] ON 

INSERT [dbo].[tblHdong] ([MaHopdong], [MaSV], [Thoihan]) VALUES (1, N'1101      ', CAST(0x3E400B00 AS Date))
INSERT [dbo].[tblHdong] ([MaHopdong], [MaSV], [Thoihan]) VALUES (5, N'1102      ', CAST(0xAC410B00 AS Date))
INSERT [dbo].[tblHdong] ([MaHopdong], [MaSV], [Thoihan]) VALUES (6, N'1101      ', CAST(0xDA410B00 AS Date))
SET IDENTITY_INSERT [dbo].[tblHdong] OFF
SET IDENTITY_INSERT [dbo].[tblHoadon] ON 

INSERT [dbo].[tblHoadon] ([Mahoadon], [Maphong], [Sodienthangtruoc], [Sodienthangsau], [Sonuocthangtruoc], [Sonuocthangsau], [Tongtien]) VALUES (1, N'101       ', 0, 5, 0, 6, NULL)
INSERT [dbo].[tblHoadon] ([Mahoadon], [Maphong], [Sodienthangtruoc], [Sodienthangsau], [Sonuocthangtruoc], [Sonuocthangsau], [Tongtien]) VALUES (2, N'201       ', 0, 4, 0, 7, NULL)
SET IDENTITY_INSERT [dbo].[tblHoadon] OFF
INSERT [dbo].[tblKhu] ([Makhu], [Tenkhu], [Manv]) VALUES (N'01        ', N'A', N'Test1     ')
INSERT [dbo].[tblKhu] ([Makhu], [Tenkhu], [Manv]) VALUES (N'02        ', N'B', N'Test2     ')
INSERT [dbo].[tblKhu] ([Makhu], [Tenkhu], [Manv]) VALUES (N'03        ', N'C', N'Test3     ')
INSERT [dbo].[tblLoaits] ([Mataisan], [Tentaisan]) VALUES (N'01        ', N'Quạt trần')
INSERT [dbo].[tblLoaits] ([Mataisan], [Tentaisan]) VALUES (N'02        ', N'Bóng đèn')
INSERT [dbo].[tblLoaits] ([Mataisan], [Tentaisan]) VALUES (N'03        ', N'Nóng lạnh')
INSERT [dbo].[tblLoaits] ([Mataisan], [Tentaisan]) VALUES (N'04        ', N'Tủ áo')
INSERT [dbo].[tblNhanvien] ([Manv], [Matkhau], [Hoten], [Sodienthoai], [Quyenhan], [Ghichu]) VALUES (N'Admin     ', N'202cb962ac5975b964b7152d234b70', N'Admin', 0, 0, N'Admin')
INSERT [dbo].[tblNhanvien] ([Manv], [Matkhau], [Hoten], [Sodienthoai], [Quyenhan], [Ghichu]) VALUES (N'kkk       ', N'202cb962ac5975b964b7152d234b70', N'adaaa', 2, 1, N'không')
INSERT [dbo].[tblNhanvien] ([Manv], [Matkhau], [Hoten], [Sodienthoai], [Quyenhan], [Ghichu]) VALUES (N'Test1     ', N'202cb962ac5975b964b7152d234b70', N'Nguyễn Phương Linh a', 945934932, 1, N'NV')
INSERT [dbo].[tblNhanvien] ([Manv], [Matkhau], [Hoten], [Sodienthoai], [Quyenhan], [Ghichu]) VALUES (N'Test2     ', N'202cb962ac59075b964b07152d234b70', N'Nguyễn Phước Lâm', 123445123, 1, N'Nv')
INSERT [dbo].[tblNhanvien] ([Manv], [Matkhau], [Hoten], [Sodienthoai], [Quyenhan], [Ghichu]) VALUES (N'Test3     ', N'202cb962ac59075b964b07152d234b70                  ', N'AA', 434, 1, N'ko')
INSERT [dbo].[tblNhanvien] ([Manv], [Matkhau], [Hoten], [Sodienthoai], [Quyenhan], [Ghichu]) VALUES (N'Test4     ', N'202cb962ac59075b964b07152d234b70                  ', N'Tôn Ngộ Không', 5, 1, N'ko')
INSERT [dbo].[tblPhong] ([Maphong], [Slmax], [Sldango], [Makhu], [Loaiphong]) VALUES (N'101       ', 6, 5, N'01        ', 0)
INSERT [dbo].[tblPhong] ([Maphong], [Slmax], [Sldango], [Makhu], [Loaiphong]) VALUES (N'102       ', 6, 1, N'01        ', 0)
INSERT [dbo].[tblPhong] ([Maphong], [Slmax], [Sldango], [Makhu], [Loaiphong]) VALUES (N'201       ', 6, 3, N'02        ', 1)
INSERT [dbo].[tblQuydinh] ([Makhu], [Giadien], [Gianuoc], [Giaphong]) VALUES (N'01        ', 3, 9, 8)
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1101      ', N'Nguyễn Quốc Minh', CAST(0x4D220B00 AS Date), 0, N'Đô lương -Nghệ AN', 969645661, CAST(0x71400B00 AS Date), NULL, N'101       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1102      ', N'Nguyễn Văn Chiên', CAST(0xC7210B00 AS Date), 0, N'Đô lương- Nghệ An', 956945965, CAST(0xBF3F0B00 AS Date), NULL, N'101       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1103      ', N'Nguyên Khắc Nam', CAST(0x3C200B00 AS Date), 0, N'Đô lương-Nghê an', 764653656, CAST(0x4C3F0B00 AS Date), NULL, N'101       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1104      ', N'Trần Xuân Mạnh', CAST(0x4D1F0B00 AS Date), 0, N'Yên Thành-Nghệ an', 54032432, CAST(0xFF3F0B00 AS Date), NULL, N'101       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1105      ', N'Kiều Linh Chi', CAST(0xC6210B00 AS Date), 1, N'Nam Đàn-Nghệ An', 45640434, CAST(0x5D400B00 AS Date), NULL, N'201       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1106      ', N'Trần Thị Ánh', CAST(0x50210B00 AS Date), 1, N'Quỳ Châu-Nghệ An', 875565434, CAST(0x7B400B00 AS Date), NULL, N'201       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1107      ', N'TRần Văn Hòa', CAST(0xAD210B00 AS Date), 0, N'Anh Sơn-Nghệ An', 98494855, CAST(0x843F0B00 AS Date), NULL, N'101       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1109      ', N'Trần Xuân Mạnh', CAST(0x4D1F0B00 AS Date), 0, N'Yên Thành-Nghệ an', 54032432, CAST(0x72400B00 AS Date), N'aaa', N'201       ')
INSERT [dbo].[tblSinhvien] ([MaSV], [Hoten], [Ngaysinh], [Gioitinh], [Hokhau], [Sodienthoai], [Ngaydk], [Ghichu], [Maphong]) VALUES (N'1114      ', N'Ti ki ta ka', CAST(0x72400B00 AS Date), 1, N'không', 9966, CAST(0x74400B00 AS Date), N'ko', N'102       ')
SET IDENTITY_INSERT [dbo].[tblTaisan] ON 

INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (2, N'02        ', N'101       ', 30)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (3, N'02        ', N'101       ', 3)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (4, N'03        ', N'101       ', 1)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (5, N'04        ', N'101       ', 2)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (6, N'01        ', N'201       ', 2)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (7, N'02        ', N'201       ', 3)
INSERT [dbo].[tblTaisan] ([Id], [Mataisan], [Maphong], [Soluong]) VALUES (8, N'03        ', N'201       ', 1)
SET IDENTITY_INSERT [dbo].[tblTaisan] OFF
ALTER TABLE [dbo].[tblHdong]  WITH CHECK ADD  CONSTRAINT [FK_tblHdong_tblSinhvien2] FOREIGN KEY([MaSV])
REFERENCES [dbo].[tblSinhvien] ([MaSV])
GO
ALTER TABLE [dbo].[tblHdong] CHECK CONSTRAINT [FK_tblHdong_tblSinhvien2]
GO
ALTER TABLE [dbo].[tblHoadon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoadon_tblPhong] FOREIGN KEY([Maphong])
REFERENCES [dbo].[tblPhong] ([Maphong])
GO
ALTER TABLE [dbo].[tblHoadon] CHECK CONSTRAINT [FK_tblHoadon_tblPhong]
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
ALTER TABLE [dbo].[tblQuydinh]  WITH CHECK ADD  CONSTRAINT [FK_tblQuydinh_tblKhu] FOREIGN KEY([Makhu])
REFERENCES [dbo].[tblKhu] ([Makhu])
GO
ALTER TABLE [dbo].[tblQuydinh] CHECK CONSTRAINT [FK_tblQuydinh_tblKhu]
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
