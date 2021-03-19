CREATE DATABASE SHOP_GIAC_UI
GO

USE SHOP_GIAC_UI
GO
-- Staff(id, tên, sdt, chức vụ, địa chỉ)
-- Client(mã, tên, sdt, địa chỉ)
-- Category(Mã dm, tên)
-- Items (Mã,tên, giá, danh mục)
-- Bill(id, Mã khách hàng, ngày nhập, Tổng tiền, mã nhân viên)
-- BillDetails(id, mã hàng, đơn giá, số lượng, thành tiền)
-- Account(id, username, password, mã nhân viên)

CREATE TABLE NHANVIEN(
	ID_NV INT IDENTITY(1,1) PRIMARY KEY,
	TenNV NVARCHAR(30) NOT NULL,
	ChuVu NVARCHAR(30) NOT NULL DEFAULT N'Nhân viên', -- Nhân viên, Admin
	SDT DECIMAL(10,0) NOT NULL,
	NgaySinh DATE,
	DiaChi NVARCHAR(100),
	AnhDD NVARCHAR(100)
)
GO

CREATE TABLE ACCOUNT(
	ID_AC INT IDENTITY (1,1) PRIMARY KEY,
	UserName NVARCHAR(100) NOT NULL,
	PassWord NVARCHAR(100) NOT NULL,
	ID_NV INT,
	FOREIGN KEY (ID_NV) REFERENCES dbo.NHANVIEN (ID_NV)
)
GO

CREATE TABLE KHACHHANG(
	ID_KH INT IDENTITY (1,1) PRIMARY KEY,
	TenKH NVARCHAR(30) NOT NULL,
	SDT DECIMAL(10,0) NOT NULL,
	DiaChi NVARCHAR(100)
)
GO

CREATE TABLE DANHMUCHANG(
	ID_DM INT IDENTITY (1,1) PRIMARY KEY,
	TenDM NVARCHAR(30) NOT NULL	
)
GO 

CREATE TABLE HANGHOA(
	ID_HH INT IDENTITY PRIMARY KEY,
	TenHH NVARCHAR(30) NOT NULL,
	DonGia DECIMAL(18,0) NOT NULL,
	ID_DM INT,
	FOREIGN KEY (ID_DM) REFERENCES dbo.DANHMUCHANG (ID_DM)
)
GO

CREATE TABLE HOADON(
	ID_HD INT IDENTITY (1,1) PRIMARY KEY,
	NgayNhap DATE NOT NULL,
	NgayKetThuc DATE,
	ID_KH INT,
	ID_NV INT,
	TongTien DECIMAL(18,0),
	Express NVARCHAR(10),
	ChietKhau varchar(10),
	TrangThaiGiac nvarchar(100),
	TrangThaiTT NVARCHAR(100),
	FOREIGN KEY (ID_KH) REFERENCES dbo.KHACHHANG (ID_KH),
	FOREIGN KEY (ID_NV) REFERENCES dbo.NHANVIEN (ID_NV)
)
GO


CREATE TABLE CHITIETHD(
	ID_CTHD INT IDENTITY(1,1) PRIMARY KEY,
	ID_HD INT,
	ID_H INT,
	SoLuong INT,
	ThanhTien DECIMAL(18,0),
	CHECK (SoLuong > 0),
	FOREIGN KEY (ID_H) REFERENCES dbo.HANGHOA (ID_HH),
	FOREIGN KEY (ID_HD) REFERENCES dbo.HOADON (ID_HD)
)
GO

-- Insert

insert into KHACHHANG values(N'Phạm Hồng Phước',1234567890,N'123 Lã Xuân Oai')
insert into KHACHHANG values(N'Trương Ngọc Nhi',1234567890,N'04 Lý Thái Tổ')
insert into KHACHHANG values(N'Hồ Ngọc Hà',1234567890,N'999 đường 3 tháng 2')
insert into KHACHHANG values(N'Võ Vũ Trường Giang',1234567890,N'100 Nguyễn Thị Minh Khai')
insert into KHACHHANG values(N'Nguyễn Văn Cường',1234567890,N'200 Cách Mạng Tháng 8')


INSERT INTO dbo.NHANVIEN VALUES  
( N'Hà Nhật Huy',  N'Admin', 1234567890,'2000-05-25',N'160 Lã Xuân Oai','h1.png'),
( N'Nguyễn Đức Hùng',  N'nhanvien', 1234567890,'2000-05-25',N'160 Lã Xuân Oai','h3.png'),
( N'Đoàn Trí Linh',  N'ketoan', 1234567890,'2000-05-25',N'160 Lã Xuân Oai','h2.png'),
( N'Cao Hoài Nhiên',  N'xuong', 1234567890,'2000-05-25',N'160 Lã Xuân Oai','h4.png')

SELECT * FROM dbo.NHANVIEN

INSERT INTO dbo.ACCOUNT( UserName, PassWord, ID_NV )VALUES  
( N'admin',  N'1',  1),
( N'nhanvien',  N'2',  2),
( N'ketoan',  N'3',  3),
( N'xuong',  N'4',  4)

insert into DANHMUCHANG values(N'Quần')
insert into DANHMUCHANG values(N'Áo')
insert into DANHMUCHANG values(N'Mền')
insert into DANHMUCHANG values(N'Khăn')
insert into DANHMUCHANG values(N'Các vật dụng khác')

select * from DANHMUCHANG

insert into HANGHOA values(N'Áo Sơ mi',40000,2)
insert into HANGHOA values(N'Áo Vest',90000,2)
insert into HANGHOA values(N'Áo Ghi-lê',40000,2)
insert into HANGHOA values(N'Áo khoát',60000,2)
insert into HANGHOA values(N'Áo ấm',60000,2)
insert into HANGHOA values(N'Áo thun',30000,2)
insert into HANGHOA values(N'Áo đầm',75000,2)
insert into HANGHOA values(N'Áo cưới',120000,2)
insert into HANGHOA values(N'Áo dài',60000,2)

insert into HANGHOA values(N'Quần tây',50000,1)
insert into HANGHOA values(N'Quần sọt',60000,1)
insert into HANGHOA values(N'Quần lót',20000,1)
insert into HANGHOA values(N'Quần thun',30000,1)


insert into HANGHOA values(N'Bọc mền',50000,3)
insert into HANGHOA values(N'Mền len - mỏng',60000,3)
insert into HANGHOA values(N'Mền len - dày',20000,3)
insert into HANGHOA values(N'Drap trải giường',30000,3)
insert into HANGHOA values(N'Áo gối',20000,3)
insert into HANGHOA values(N'Ruột gối',30000,3)

insert into HANGHOA values(N'Khăn tắm - trung bình',50000,4)
insert into HANGHOA values(N'Khắn tắm - lớn',60000,4)
insert into HANGHOA values(N'Khăn bàn',20000,4)
insert into HANGHOA values(N'Khăn bàn - lớn',30000,4)
insert into HANGHOA values(N'Khăn tay',20000,4)

insert into HANGHOA values(N'Vớ',10000,5)
insert into HANGHOA values(N'Thảm',150000,5)
insert into HANGHOA values(N'Giày',100000,5)
insert into HANGHOA values(N'Màn cửa',200000,5)
insert into HANGHOA values(N'Cà vạt',20000,5)

GO


-- Trigger

CREATE TRIGGER TG_Update_TongTien ON dbo.CHITIETHD FOR INSERT,UPDATE
AS 
BEGIN 
	DECLARE @ThanhTien DECIMAL(18,0) = 0
	SELECT @ThanhTien = Inserted.ThanhTien 
	FROM Inserted
	IF(@ThanhTien < 0)
	BEGIN
		ROLLBACK TRAN
	END
	UPDATE dbo.HOADON SET dbo.HOADON.TongTien = dbo.HOADON.TongTien + @ThanhTien
	FROM Inserted cthd
	WHERE cthd.ID_HD = dbo.HOADON.ID_HD
END
GO



-- Proc

CREATE PROC	USP_GetListDanhMuc
AS
BEGIN
	select *
	from DANHMUCHANG
END

GO

CREATE PROC	USP_GetListHoaDonThuTien
AS
BEGIN
	SELECT hd.ID_HD,hd.NgayNhap,hd.NgayKetThuc,kh.TenKH, nv.TenNV, hd.TrangThaiGiac, hd.TongTien , hd.TrangThaiTT FROM dbo.HOADON hd, dbo.KHACHHANG kh, dbo.NHANVIEN nv
	WHERE hd.ID_KH = kh.ID_KH AND hd.ID_NV = nv.ID_NV AND hd.TrangThaiGiac = N'Xong'
END
GO

CREATE PROC	USP_timKiemHoaDonThuTienTheoTen
@tenkh nvarchar(30)
AS
BEGIN
	SELECT hd.ID_HD,hd.NgayNhap,hd.NgayKetThuc,kh.TenKH, nv.TenNV, hd.TrangThaiGiac, hd.TongTien , hd.TrangThaiTT FROM dbo.HOADON hd, dbo.KHACHHANG kh, dbo.NHANVIEN nv
	WHERE hd.ID_KH = kh.ID_KH AND hd.ID_NV = nv.ID_NV AND hd.TrangThaiGiac = N'Xong' AND kh.TenKH LIKE N'%' + @tenkh + '%'
END

GO


CREATE PROC	USP_timKiemHoaDonThuTienTheoID
@id int
AS
BEGIN
	SELECT hd.ID_HD,hd.NgayNhap,hd.NgayKetThuc,kh.TenKH, nv.TenNV, hd.TrangThaiGiac, hd.TongTien , hd.TrangThaiTT FROM dbo.HOADON hd, dbo.KHACHHANG kh, dbo.NHANVIEN nv
	WHERE hd.ID_KH = kh.ID_KH AND hd.ID_NV = nv.ID_NV AND hd.TrangThaiGiac = N'Xong' AND hd.ID_HD = @id
END

GO


CREATE PROC	USP_timKiemHoaDonThuTienTheoIDvaTEN
@id int, @tenkh NVARCHAR(30)
AS
BEGIN
	SELECT hd.ID_HD,hd.NgayNhap,hd.NgayKetThuc,kh.TenKH, nv.TenNV, hd.TrangThaiGiac, hd.TongTien , hd.TrangThaiTT FROM dbo.HOADON hd, dbo.KHACHHANG kh, dbo.NHANVIEN nv
	WHERE hd.ID_KH = kh.ID_KH AND hd.ID_NV = nv.ID_NV AND hd.TrangThaiGiac = N'Xong' AND hd.ID_HD = @id AND kh.TenKH LIKE N'%' + @tenkh + '%'
END
GO


create PROC USP_Login 
@username nvarchar(100),
@password nvarchar(100)
AS
BEGIN
	SELECT ID_AC,ACCOUNT.ID_NV,TenNV,AnhDD,ChuVu
	FROM dbo.ACCOUNT INNER JOIN dbo.NHANVIEN ON NHANVIEN.ID_NV = ACCOUNT.ID_NV
	WHERE UserName = @username AND PassWord = @password
END
GO

CREATE PROC USP_GetTotal_NhanVien
AS
BEGIN
	SELECT COUNT(*) FROM dbo.NHANVIEN
END
GO

create proc USP_GetHangTheoDanhMuc
@id_dm int
as
begin
	select *
	from HANGHOA
	where ID_DM = @id_dm
end
GO

Create PROC	USP_TONGDOANHTHU
AS
BEGIN
	SELECT SUM(TongTien) FROM dbo.HOADON WHERE TrangThaiTT = N'Xong'
END
-- TESST






