create database [quanlythuvien]
USE [quanlythuvien]
GO
/****** Object:  Table [dbo].[chitietphieumuon]    Script Date: 5/30/17 11:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chitietphieumuon](
	[SoPhieuMuon] [char](50)  NOT NULL,
	[MaSach] [char](50) NOT NULL,
	[HenTra] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[loaisach]    Script Date: 5/30/17 11:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[loaisach](
	[MaLS] [char](50) NOT NULL,
	[TenLS] [nvarchar](200)  NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[muonsach]    Script Date: 5/30/17 11:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[muonsach](
	[SoPhieuMuon] [char](50) NOT NULL,
	[MaThe] [char](50)NOT  NULL,
	[MaNV] [char](50) NOT  NULL,
	[NgayMuon] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[SoPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 5/30/17 11:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhanvien](
	[MaNV] [char](50) NOT NULL,
	[TenNV] [nvarchar](50)  NULL,
	[DiaChi] [nvarchar](50)  NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [int] NOT NULL,
	[DienThoai] [char](20)  NULL,
	[MatKhau] [char](50)  NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 5/30/17 11:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NXB](
	[MaNXB] [char](50) NOT NULL,
	[TenNXB] [nvarchar](100) NOT NULL,
	[DiaChiNXB] [nvarchar](100) NOT NULL,
	[Website] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phat]    Script Date: 5/30/17 11:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phat](
	[MaSach] [char](50) NOT NULL,
	[MaThe] [char](50)NOT NULL,
	[LyDoPhat] [nvarchar](200) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sach]    Script Date: 5/30/17 11:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sach](
	[MaSach] [char](50) NOT NULL,
	[TenSach] [nvarchar](100)  NULL,
	[TacGia] [nvarchar](50) NULL,
	[MaNXB] [char](50) NOT NULL,
	[MaLS] [char](50) NOT NULL,
	[NamXB] [int] NULL,
	[LanXB] [int] NULL,
	[SoLuong] [int]  NULL,
	[NoiDung] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sinhvien]    Script Date: 5/30/17 11:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sinhvien](
	[MaThe] [char](50) NOT NULL,
	[TenSV] [nvarchar](50)  NULL,
	[Ngaysinh] [datetime]  NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Lop] [nvarchar](50) NULL,
	[Khoa] [nvarchar](50)  NULL,
	[NgayCapThe] [datetime]  NULL,
	[NgayHetHan] [datetime]  NULL,
	[gioitinh] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 5/30/17 11:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[taikhoan](
	[TenTk] [char](50) NOT NULL,
	[MatKhau] [char](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[trasach]    Script Date: 5/30/17 11:38:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[trasach](
	[SoPhieuMuon] [char](50) NOT NULL,
	[MaSach] [char](50) NOT  NULL,
	[MaNV] [char](50) NOT  NULL,
	[NgayTra] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[chitietphieumuon] ([SoPhieuMuon], [MaSach], [HenTra]) VALUES (N'PM002                                             ', N'NN                                                ', CAST(0x463A0B00 AS Date))
INSERT [dbo].[loaisach] ([MaLS], [TenLS]) VALUES (N'CN                                                ', N'Công nghệ')
INSERT [dbo].[loaisach] ([MaLS], [TenLS]) VALUES (N'KT                                                ', N'Kinh tế')
INSERT [dbo].[loaisach] ([MaLS], [TenLS]) VALUES (N'PL                                                ', N'Pháp luật')
INSERT [dbo].[loaisach] ([MaLS], [TenLS]) VALUES (N'TA                                                ', N'Sách Tiếng anh')
INSERT [dbo].[loaisach] ([MaLS], [TenLS]) VALUES (N'TN                                                ', N'Sách Tiếng Nhật')
INSERT [dbo].[loaisach] ([MaLS], [TenLS]) VALUES (N'TV                                                ', N'Tản văn')
INSERT [dbo].[loaisach] ([MaLS], [TenLS]) VALUES (N'VHNN                                              ', N'Văn học nước ngoài')
INSERT [dbo].[loaisach] ([MaLS], [TenLS]) VALUES (N'VHVN                                              ', N'Văn học Việt Nam')
INSERT [dbo].[muonsach] ([SoPhieuMuon], [MaThe], [MaNV], [NgayMuon]) VALUES (N'PM001                                             ', N'14150008                                          ', N'TV01                                              ', CAST(0xED390B00 AS Date))
INSERT [dbo].[muonsach] ([SoPhieuMuon], [MaThe], [MaNV], [NgayMuon]) VALUES (N'PM002                                             ', N'14150008                                          ', N'TV02                                              ', CAST(0x243D0B00 AS Date))
INSERT [dbo].[nhanvien] ([MaNV], [TenNV], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [MatKhau]) VALUES (N'TV01                                              ', N'Lê Văn Hà', N'Hà Nội', NULL, 1, N'01656565656         ', N'11111                                             ')
INSERT [dbo].[nhanvien] ([MaNV], [TenNV], [DiaChi], [NgaySinh], [GioiTinh], [DienThoai], [MatKhau]) VALUES (N'TV02                                              ', N'Nguyễn Kim Thanh', N'Ninh Bình', NULL, 0, N'015565656455        ', N'222222                                            ')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChiNXB], [Website]) VALUES (N'Abpha Book                                        ', N'Công ty Anpha Book', N'Hà Nội', NULL)
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChiNXB], [Website]) VALUES (N'KD                                                ', N'Nhà xuất bản Kim Đồng', N'Hà Nội', NULL)
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChiNXB], [Website]) VALUES (N'NN                                                ', N'Công ty sách Nhã Nam', N'Hà Nội', NULL)
INSERT [dbo].[NXB] ([MaNXB], [TenNXB], [DiaChiNXB], [Website]) VALUES (N'Sp                                                ', N'Nhà xuất bản Đại học Sư Phạm', N'Hà nội', NULL)
INSERT [dbo].[phat] ([MaSach], [MaThe], [LyDoPhat]) VALUES (N'NN                                                ', N'14150008                                          ', N'Quá hạn')
INSERT [dbo].[sach] ([MaSach], [TenSach], [TacGia], [MaNXB], [MaLS], [NamXB], [LanXB], [SoLuong], [NoiDung]) VALUES (N'NN                                                ', N'Ngữ pháp Tiếng Anh thông dụng', N'Nhiều tác giả', N'KD                                                ', N'TA                                                ', 2015, 5, 0, N'Ngữ pháp Tiếng Anh căn bản')
INSERT [dbo].[sach] ([MaSach], [TenSach], [TacGia], [MaNXB], [MaLS], [NamXB], [LanXB], [SoLuong], [NoiDung]) VALUES (N'TN                                                ', N'Giáo trình Tiếng Nhật sơ ấp', N'Nhiều tác giả', N'Sp                                                ', N'Tn                                                ', 2009, 3, 6, N'Giáo trình Tiếng Nhật cho người mới bắt đầu')
INSERT [dbo].[sinhvien] ([MaThe], [TenSV], [Ngaysinh], [DiaChi], [Lop], [Khoa], [NgayCapThe], [NgayHetHan], [gioitinh]) VALUES (N'14150007                                          ', N'Hà Thanh Vân', CAST(0x000086D800000000 AS DateTime), N'Hải Phòng', N'CNH13A', N'Công nghệ hóa học', CAST(0x0000A32500000000 AS DateTime), CAST(0x0000AA4500000000 AS DateTime), 0)
INSERT [dbo].[sinhvien] ([MaThe], [TenSV], [Ngaysinh], [DiaChi], [Lop], [Khoa], [NgayCapThe], [NgayHetHan], [gioitinh]) VALUES (N'14150008                                          ', N'Nguyễn Văn An', CAST(0x0000886600000000 AS DateTime), N'Hà Nội', N'TH13B', N'Công nghệ thông tin', CAST(0x0000A32300000000 AS DateTime), CAST(0x0000A8D800000000 AS DateTime), 1)
INSERT [dbo].[taikhoan] ([TenTk], [MatKhau]) VALUES (N'admin                                             ', N'123456                                            ')
INSERT [dbo].[taikhoan] ([TenTk], [MatKhau]) VALUES (N'user                                              ', N'abc                                               ')
INSERT [dbo].[trasach] ([SoPhieuMuon], [MaSach], [MaNV], [NgayTra]) VALUES (N'PM002                                             ', N'NN                                                ', N'TV02                                              ', CAST(0x213D0B00 AS Date))
ALTER TABLE [dbo].[chitietphieumuon]  WITH CHECK ADD FOREIGN KEY([SoPhieuMuon])
REFERENCES [dbo].[muonsach] ([SoPhieuMuon])
GO
ALTER TABLE [dbo].[muonsach]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[nhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[muonsach]  WITH CHECK ADD FOREIGN KEY([MaThe])
REFERENCES [dbo].[sinhvien] ([MaThe])
GO
ALTER TABLE [dbo].[phat]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[sach] ([MaSach])
GO
ALTER TABLE [dbo].[phat]  WITH CHECK ADD FOREIGN KEY([MaThe])
REFERENCES [dbo].[sinhvien] ([MaThe])
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD FOREIGN KEY([MaLS])
REFERENCES [dbo].[loaisach] ([MaLS])
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
GO
ALTER TABLE [dbo].[trasach]  WITH CHECK ADD FOREIGN KEY([SoPhieuMuon])
REFERENCES [dbo].[muonsach] ([SoPhieuMuon])
GO
