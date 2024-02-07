CREATE DATABASE hybrid;

-- drop database hybrid;
-- use QLTHUVIEN;
use hybrid;
CREATE TABLE nhomquyen(
	manhomquyen INT PRIMARY KEY,
	ten NVARCHAR(50)
)

CREATE TABLE taikhoan(
	mataikhoan uniqueidentifier PRIMARY KEY,
	manhomquyen INT,
	hoten NVARCHAR(255),
	email NVARCHAR(255),
	matkhau NVARCHAR(255),
	sodienthoai NVARCHAR(15),
	anhdaidien NVARCHAR(255),
	daxoa TINYINT,
	FOREIGN KEY (manhomquyen) REFERENCES nhomquyen(manhomquyen)
)

-- cài đặt khóa chính taikhoan
ALTER TABLE taikhoan
ADD CONSTRAINT defaultUUID DEFAULT NEWID() FOR mataikhoan;

CREATE TABLE lophoc(
	malophoc uniqueidentifier PRIMARY KEY,
	magiangvien uniqueidentifier,
	ten NVARCHAR(255),
	mota NVARCHAR(500),
	anhdaidien NVARCHAR(255),
	daxoa TINYINT,
	FOREIGN KEY (magiangvien) REFERENCES taikhoan(mataikhoan)
)

ALTER TABLE lophoc
ADD CONSTRAINT defaultLophocUUID DEFAULT NEWID() FOR malophoc;

CREATE TABLE thamgialophoc(
	malophoc uniqueidentifier,
	mataikhoan uniqueidentifier,
	FOREIGN KEY (malophoc) REFERENCES lophoc(malophoc),
	FOREIGN KEY (mataikhoan) REFERENCES taikhoan(mataikhoan)
)

CREATE TABLE nhomchat(
	manhomchat uniqueidentifier PRIMARY KEY,
	malophoc uniqueidentifier,
	ten NVARCHAR(255),
	FOREIGN KEY (malophoc) REFERENCES lophoc(malophoc)
)

ALTER TABLE nhomchat
ADD CONSTRAINT defaultNhomChatUUID DEFAULT NEWID() FOR malophoc;

CREATE TABLE tinnhan(
	matinnhan uniqueidentifier PRIMARY KEY,
	manhomchat uniqueidentifier,
	mataikhoan uniqueidentifier,
	noidung NVARCHAR(300) ,
	thoigiangui DATETIME,
	antinnhan TINYINT,
	FOREIGN KEY (manhomchat) REFERENCES nhomchat(manhomchat),
	FOREIGN KEY (mataikhoan) REFERENCES taikhoan(mataikhoan)
)
ALTER TABLE tinnhan
ADD CONSTRAINT defaultTinNhantUUID DEFAULT NEWID() FOR matinnhan;

CREATE TABLE chuong(
	machuong uniqueidentifier PRIMARY KEY,
	malophoc uniqueidentifier,
	ten NVARCHAR(100),
	thoigiantao DATETIME,
	daxoa TINYINT,
	FOREIGN KEY (malophoc) REFERENCES lophoc(malophoc)
)

ALTER TABLE chuong
ADD CONSTRAINT defaultChuongUUID DEFAULT NEWID() FOR machuong;

CREATE TABLE hoclieu(
	mahoclieu uniqueidentifier PRIMARY KEY,
	machuong uniqueidentifier,
	tieude NVARCHAR(100),
	noidung NVARCHAR(300),
	daxoa TINYINT,
	FOREIGN KEY (machuong) REFERENCES chuong(machuong)
)

ALTER TABLE hoclieu
ADD CONSTRAINT defaultHocLieuUUID DEFAULT NEWID() FOR mahoclieu;

CREATE TABLE filehoclieu(
	mahoclieu uniqueidentifier,
	tenfile NVARCHAR(100),
	id_file varchar(255),
	FOREIGN KEY (mahoclieu) REFERENCES hoclieu(mahoclieu)
)

CREATE TABLE banbe(
	manguoiketban uniqueidentifier,
	manguoiduocketban uniqueidentifier,
	thoigianketban DATETIME,
	trangthaiketban TINYINT,
	FOREIGN KEY (manguoiketban) REFERENCES taikhoan(mataikhoan),
	FOREIGN KEY (manguoiduocketban) REFERENCES taikhoan(mataikhoan),
	PRIMARY KEY (manguoiketban, manguoiduocketban)
)

CREATE TABLE tinnhanbanbe(
	matinnhan uniqueidentifier PRIMARY KEY,
	manguoigui uniqueidentifier,
	manguoinhan uniqueidentifier,
	noidung NVARCHAR(300),
	thoigiangui DATETIME,
	daxoa TINYINT,
	FOREIGN KEY (manguoigui,manguoinhan) REFERENCES banbe(manguoiketban,manguoiduocketban)
)

ALTER TABLE tinnhanbanbe
ADD CONSTRAINT defaultTinhanbbUUID DEFAULT NEWID() FOR matinnhan;

CREATE TABLE baitap(
	mabaitap uniqueidentifier PRIMARY KEY,
	machuong uniqueidentifier ,
	tieude NVARCHAR(100),
	noidungbaitap NVARCHAR(500),
	noidungdapan NVARCHAR(500),
	thoigiantao DATETIME,
	thoihan DATETIME,
	congkhaidapan TINYINT,
	daxoa TINYINT,
	FOREIGN KEY (machuong) REFERENCES chuong(machuong)
)

ALTER TABLE baitap
ADD CONSTRAINT defaultBaitapUUID DEFAULT NEWID() FOR mabaitap;


CREATE TABLE filebaitap(
	mabaitap  uniqueidentifier,
	lafiledapan TINYINT,
	tenfile NVARCHAR(100),
	id_file varchar(255),
	FOREIGN KEY (mabaitap) REFERENCES baitap(mabaitap)
)

CREATE TABLE bailambaitap(
	mabailam uniqueidentifier PRIMARY KEY,
	mataikhoan uniqueidentifier,
	mabaitap uniqueidentifier,
	noidung NVARCHAR(500),
	thoigiannopbai DATETIME,
	nhanxet NVARCHAR(300),
	diem float,
	FOREIGN KEY (mataikhoan) REFERENCES taikhoan(mataikhoan),
	FOREIGN KEY (mabaitap) REFERENCES baitap(mabaitap)
)

ALTER TABLE bailambaitap
ADD CONSTRAINT defaultBailamnUUID DEFAULT NEWID() FOR mabailam;

CREATE TABLE filebailambaitap(
	mabailam  uniqueidentifier,
	tenfile NVARCHAR(100),
	id_file varchar(255),
	FOREIGN KEY (mabailam) REFERENCES bailambaitap(mabailam)
)

CREATE TABLE dekiemtra(
	madekiemtra uniqueidentifier PRIMARY KEY, 
	machuong uniqueidentifier,
	tieude NVARCHAR(50),
	thoigiantao DATETIME,
	thoigianbatdau DATETIME,
	thoigianketthuc DATETIME,
	troncauhoi TINYINT,
	xemdiem TINYINT,
	xemdapan TINYINT,
	daxoa TINYINT,
	FOREIGN KEY (machuong) REFERENCES chuong(machuong)
)

ALTER TABLE dekiemtra
ADD CONSTRAINT defaultDektUUID DEFAULT NEWID() FOR madekiemtra;

CREATE TABLE cauhoi(
	macauhoi uniqueidentifier PRIMARY KEY, 
	mataikhoan uniqueidentifier,
	noidung NVARCHAR(300),
	daxoa TINYINT,
	FOREIGN KEY (mataikhoan) REFERENCES taikhoan(mataikhoan)
)

ALTER TABLE cauhoi
ADD CONSTRAINT defaultCauhoiUUID DEFAULT NEWID() FOR macauhoi;

CREATE TABLE cautraloi(
	macautraloi uniqueidentifier PRIMARY KEY, 
	macauhoi uniqueidentifier ,
	noidung NVARCHAR(300),
	lacautraloidung TINYINT,
	FOREIGN KEY (macauhoi) REFERENCES cauhoi(macauhoi)
)

ALTER TABLE cautraloi
ADD CONSTRAINT defaultCautlUUID DEFAULT NEWID() FOR macautraloi;

CREATE TABLE chitietbaikiemtra(
	madekiemtra uniqueidentifier, 
	macauhoi uniqueidentifier, 
	thutu INT,
	FOREIGN KEY (madekiemtra) REFERENCES dekiemtra(madekiemtra),
	FOREIGN KEY (macauhoi) REFERENCES cauhoi(macauhoi)
)

CREATE TABLE bailamkiemtra(
	mabailam  uniqueidentifier PRIMARY KEY,
	mataikhoan uniqueidentifier ,
	madekiemtra uniqueidentifier,
	diem float,
	thoigiannop DATETIME,
	noptre TINYINT,
	socaudung int,
	FOREIGN KEY (mataikhoan) REFERENCES taikhoan(mataikhoan)
)

ALTER TABLE bailamkiemtra
ADD CONSTRAINT defaultBailamktUUID DEFAULT NEWID() FOR mabailam;

CREATE TABLE chitietbailamkiemtra(
	mabailamkiemtra uniqueidentifier ,
	macauhoi uniqueidentifier ,
	dapanchon uniqueidentifier,
	FOREIGN KEY (mabailamkiemtra) REFERENCES bailamkiemtra(mabailam),
	FOREIGN KEY (macauhoi) REFERENCES cauhoi(macauhoi)
)

ALTER TABLE taikhoan ADD CONSTRAINT taikhoan_cons_uniq UNIQUE (email)
-- lưu vết bài làm kiểm tra 
CREATE TABLE luuvetbailamkiemtra(
	email NVARCHAR(50),
	madekiemtra uniqueidentifier,
	macauhoi uniqueidentifier,
	madapanchon uniqueidentifier,
);


