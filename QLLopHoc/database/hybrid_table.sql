USE [hybrid]
GO
/****** Object:  Table [dbo].[bailambaitap]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bailambaitap](
	[mabailam] [uniqueidentifier] NOT NULL,
	[mataikhoan] [uniqueidentifier] NULL,
	[mabaitap] [uniqueidentifier] NULL,
	[noidung] [nvarchar](4000) NULL,
	[thoigiannopbai] [datetime] NULL,
	[nhanxet] [nvarchar](300) NULL,
	[diem] [float] NULL,
	[noptre] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[mabailam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bailamkiemtra]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bailamkiemtra](
	[mabailam] [uniqueidentifier] NOT NULL,
	[mataikhoan] [uniqueidentifier] NULL,
	[madekiemtra] [uniqueidentifier] NULL,
	[diem] [float] NULL,
	[thoigiannop] [datetime] NULL,
	[noptre] [tinyint] NULL,
	[socaudung] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[mabailam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[baitap]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[baitap](
	[mabaitap] [uniqueidentifier] NOT NULL,
	[machuong] [uniqueidentifier] NULL,
	[tieude] [nvarchar](100) NULL,
	[noidungbaitap] [nvarchar](500) NULL,
	[noidungdapan] [nvarchar](4000) NULL,
	[thoigiantao] [datetime] NULL,
	[thoigianketthuc] [datetime] NULL,
	[congkhaidapan] [tinyint] NULL,
	[daxoa] [tinyint] NULL,
	[thoigianbatdau] [datetime] NULL,
	[nopbu] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[mabaitap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[banbe]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[banbe](
	[manguoiketban] [uniqueidentifier] NOT NULL,
	[manguoiduocketban] [uniqueidentifier] NOT NULL,
	[thoigianketban] [datetime] NULL,
	[trangthaiketban] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[manguoiketban] ASC,
	[manguoiduocketban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cauhoi]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cauhoi](
	[macauhoi] [uniqueidentifier] NOT NULL,
	[mataikhoan] [uniqueidentifier] NULL,
	[noidung] [nvarchar](300) NULL,
	[daxoa] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[macauhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cautraloi]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cautraloi](
	[macautraloi] [uniqueidentifier] NOT NULL,
	[macauhoi] [uniqueidentifier] NULL,
	[noidung] [nvarchar](300) NULL,
	[lacautraloidung] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[macautraloi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chitietbaikiemtra]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietbaikiemtra](
	[madekiemtra] [uniqueidentifier] NULL,
	[macauhoi] [uniqueidentifier] NULL,
	[thutu] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chitietbailamkiemtra]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietbailamkiemtra](
	[mabailamkiemtra] [uniqueidentifier] NULL,
	[macauhoi] [uniqueidentifier] NULL,
	[dapanchon] [uniqueidentifier] NULL,
	[thutu] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chuong]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chuong](
	[machuong] [uniqueidentifier] NOT NULL,
	[malophoc] [uniqueidentifier] NULL,
	[ten] [nvarchar](100) NULL,
	[thoigiantao] [datetime] NULL,
	[daxoa] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[machuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dekiemtra]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dekiemtra](
	[madekiemtra] [uniqueidentifier] NOT NULL,
	[machuong] [uniqueidentifier] NULL,
	[tieude] [nvarchar](50) NULL,
	[thoigiantao] [datetime] NULL,
	[thoigianbatdau] [datetime] NULL,
	[thoigianketthuc] [datetime] NULL,
	[troncauhoi] [tinyint] NULL,
	[xemdiem] [tinyint] NULL,
	[xemdapan] [tinyint] NULL,
	[daxoa] [tinyint] NULL,
	[hinhphat] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[madekiemtra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[filebailambaitap]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[filebailambaitap](
	[mabailam] [uniqueidentifier] NULL,
	[tenfile] [nvarchar](100) NULL,
	[id_file] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[filebaitap]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[filebaitap](
	[mabaitap] [uniqueidentifier] NULL,
	[lafiledapan] [tinyint] NULL,
	[tenfile] [nvarchar](100) NULL,
	[id_file] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[filehoclieu]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[filehoclieu](
	[mahoclieu] [uniqueidentifier] NULL,
	[tenfile] [nvarchar](100) NULL,
	[id_file] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[hoclieu]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hoclieu](
	[mahoclieu] [uniqueidentifier] NOT NULL,
	[machuong] [uniqueidentifier] NULL,
	[tieude] [nvarchar](100) NULL,
	[noidung] [nvarchar](300) NULL,
	[daxoa] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[mahoclieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lophoc]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lophoc](
	[malophoc] [uniqueidentifier] NOT NULL,
	[magiangvien] [uniqueidentifier] NULL,
	[ten] [nvarchar](255) NULL,
	[mota] [nvarchar](500) NULL,
	[anhdaidien] [nvarchar](255) NULL,
	[daxoa] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[malophoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[luuvetbailamkiemtra]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[luuvetbailamkiemtra](
	[email] [nvarchar](50) NULL,
	[madekiemtra] [uniqueidentifier] NULL,
	[macauhoi] [uniqueidentifier] NULL,
	[madapanchon] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhomchat]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhomchat](
	[manhomchat] [uniqueidentifier] NOT NULL,
	[malophoc] [uniqueidentifier] NULL,
	[ten] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[manhomchat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhomquyen]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhomquyen](
	[manhomquyen] [int] NOT NULL,
	[ten] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[manhomquyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taikhoan](
	[mataikhoan] [uniqueidentifier] NOT NULL,
	[manhomquyen] [int] NULL,
	[hoten] [nvarchar](255) NULL,
	[email] [nvarchar](255) NULL,
	[matkhau] [nvarchar](255) NULL,
	[sodienthoai] [nvarchar](15) NULL,
	[anhdaidien] [nvarchar](255) NULL,
	[daxoa] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[mataikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [taikhoan_cons_uniq] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thamgialophoc]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thamgialophoc](
	[malophoc] [uniqueidentifier] NULL,
	[mataikhoan] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tinnhan]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tinnhan](
	[matinnhan] [uniqueidentifier] NOT NULL,
	[manhomchat] [uniqueidentifier] NULL,
	[mataikhoan] [uniqueidentifier] NULL,
	[noidung] [nvarchar](300) NULL,
	[thoigiangui] [datetime] NULL,
	[antinnhan] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[matinnhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tinnhanbanbe]    Script Date: 2/27/2024 2:10:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tinnhanbanbe](
	[matinnhan] [uniqueidentifier] NOT NULL,
	[manguoigui] [uniqueidentifier] NULL,
	[manguoinhan] [uniqueidentifier] NULL,
	[noidung] [nvarchar](300) NULL,
	[thoigiangui] [datetime] NULL,
	[daxoa] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[matinnhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[bailambaitap] ADD  CONSTRAINT [defaultBailamnUUID]  DEFAULT (newid()) FOR [mabailam]
GO
ALTER TABLE [dbo].[bailamkiemtra] ADD  CONSTRAINT [defaultBailamktUUID]  DEFAULT (newid()) FOR [mabailam]
GO
ALTER TABLE [dbo].[baitap] ADD  CONSTRAINT [defaultBaitapUUID]  DEFAULT (newid()) FOR [mabaitap]
GO
ALTER TABLE [dbo].[cauhoi] ADD  CONSTRAINT [defaultCauhoiUUID]  DEFAULT (newid()) FOR [macauhoi]
GO
ALTER TABLE [dbo].[cautraloi] ADD  CONSTRAINT [defaultCautlUUID]  DEFAULT (newid()) FOR [macautraloi]
GO
ALTER TABLE [dbo].[chuong] ADD  CONSTRAINT [defaultChuongUUID]  DEFAULT (newid()) FOR [machuong]
GO
ALTER TABLE [dbo].[dekiemtra] ADD  CONSTRAINT [defaultDektUUID]  DEFAULT (newid()) FOR [madekiemtra]
GO
ALTER TABLE [dbo].[hoclieu] ADD  CONSTRAINT [defaultHocLieuUUID]  DEFAULT (newid()) FOR [mahoclieu]
GO
ALTER TABLE [dbo].[lophoc] ADD  CONSTRAINT [defaultLophocUUID]  DEFAULT (newid()) FOR [malophoc]
GO
ALTER TABLE [dbo].[nhomchat] ADD  CONSTRAINT [defaultNhomChatUUID]  DEFAULT (newid()) FOR [malophoc]
GO
ALTER TABLE [dbo].[taikhoan] ADD  CONSTRAINT [defaultUUID]  DEFAULT (newid()) FOR [mataikhoan]
GO
ALTER TABLE [dbo].[tinnhan] ADD  CONSTRAINT [defaultTinNhantUUID]  DEFAULT (newid()) FOR [matinnhan]
GO
ALTER TABLE [dbo].[tinnhanbanbe] ADD  CONSTRAINT [defaultTinhanbbUUID]  DEFAULT (newid()) FOR [matinnhan]
GO
ALTER TABLE [dbo].[bailambaitap]  WITH CHECK ADD FOREIGN KEY([mabaitap])
REFERENCES [dbo].[baitap] ([mabaitap])
GO
ALTER TABLE [dbo].[bailambaitap]  WITH CHECK ADD FOREIGN KEY([mataikhoan])
REFERENCES [dbo].[taikhoan] ([mataikhoan])
GO
ALTER TABLE [dbo].[bailamkiemtra]  WITH CHECK ADD FOREIGN KEY([mataikhoan])
REFERENCES [dbo].[taikhoan] ([mataikhoan])
GO
ALTER TABLE [dbo].[baitap]  WITH CHECK ADD FOREIGN KEY([machuong])
REFERENCES [dbo].[chuong] ([machuong])
GO
ALTER TABLE [dbo].[banbe]  WITH CHECK ADD FOREIGN KEY([manguoiduocketban])
REFERENCES [dbo].[taikhoan] ([mataikhoan])
GO
ALTER TABLE [dbo].[banbe]  WITH CHECK ADD FOREIGN KEY([manguoiketban])
REFERENCES [dbo].[taikhoan] ([mataikhoan])
GO
ALTER TABLE [dbo].[cauhoi]  WITH CHECK ADD FOREIGN KEY([mataikhoan])
REFERENCES [dbo].[taikhoan] ([mataikhoan])
GO
ALTER TABLE [dbo].[cautraloi]  WITH CHECK ADD FOREIGN KEY([macauhoi])
REFERENCES [dbo].[cauhoi] ([macauhoi])
GO
ALTER TABLE [dbo].[chitietbaikiemtra]  WITH CHECK ADD FOREIGN KEY([macauhoi])
REFERENCES [dbo].[cauhoi] ([macauhoi])
GO
ALTER TABLE [dbo].[chitietbaikiemtra]  WITH CHECK ADD FOREIGN KEY([madekiemtra])
REFERENCES [dbo].[dekiemtra] ([madekiemtra])
GO
ALTER TABLE [dbo].[chitietbailamkiemtra]  WITH CHECK ADD FOREIGN KEY([mabailamkiemtra])
REFERENCES [dbo].[bailamkiemtra] ([mabailam])
GO
ALTER TABLE [dbo].[chitietbailamkiemtra]  WITH CHECK ADD FOREIGN KEY([macauhoi])
REFERENCES [dbo].[cauhoi] ([macauhoi])
GO
ALTER TABLE [dbo].[chuong]  WITH CHECK ADD FOREIGN KEY([malophoc])
REFERENCES [dbo].[lophoc] ([malophoc])
GO
ALTER TABLE [dbo].[dekiemtra]  WITH CHECK ADD FOREIGN KEY([machuong])
REFERENCES [dbo].[chuong] ([machuong])
GO
ALTER TABLE [dbo].[filebailambaitap]  WITH CHECK ADD FOREIGN KEY([mabailam])
REFERENCES [dbo].[bailambaitap] ([mabailam])
GO
ALTER TABLE [dbo].[filebaitap]  WITH CHECK ADD FOREIGN KEY([mabaitap])
REFERENCES [dbo].[baitap] ([mabaitap])
GO
ALTER TABLE [dbo].[filehoclieu]  WITH CHECK ADD FOREIGN KEY([mahoclieu])
REFERENCES [dbo].[hoclieu] ([mahoclieu])
GO
ALTER TABLE [dbo].[hoclieu]  WITH CHECK ADD FOREIGN KEY([machuong])
REFERENCES [dbo].[chuong] ([machuong])
GO
ALTER TABLE [dbo].[lophoc]  WITH CHECK ADD FOREIGN KEY([magiangvien])
REFERENCES [dbo].[taikhoan] ([mataikhoan])
GO
ALTER TABLE [dbo].[nhomchat]  WITH CHECK ADD FOREIGN KEY([malophoc])
REFERENCES [dbo].[lophoc] ([malophoc])
GO
ALTER TABLE [dbo].[taikhoan]  WITH CHECK ADD FOREIGN KEY([manhomquyen])
REFERENCES [dbo].[nhomquyen] ([manhomquyen])
GO
ALTER TABLE [dbo].[thamgialophoc]  WITH CHECK ADD FOREIGN KEY([malophoc])
REFERENCES [dbo].[lophoc] ([malophoc])
GO
ALTER TABLE [dbo].[thamgialophoc]  WITH CHECK ADD FOREIGN KEY([mataikhoan])
REFERENCES [dbo].[taikhoan] ([mataikhoan])
GO
ALTER TABLE [dbo].[tinnhan]  WITH CHECK ADD FOREIGN KEY([manhomchat])
REFERENCES [dbo].[nhomchat] ([manhomchat])
GO
ALTER TABLE [dbo].[tinnhan]  WITH CHECK ADD FOREIGN KEY([mataikhoan])
REFERENCES [dbo].[taikhoan] ([mataikhoan])
GO
ALTER TABLE [dbo].[tinnhanbanbe]  WITH CHECK ADD FOREIGN KEY([manguoigui], [manguoinhan])
REFERENCES [dbo].[banbe] ([manguoiketban], [manguoiduocketban])
GO
