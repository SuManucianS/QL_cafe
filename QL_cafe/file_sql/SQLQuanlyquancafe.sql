CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

CREATE TABLE BoPhan
(
	IDBoPhan VARCHAR(10) PRIMARY KEY,
	TenBoPhan NVARCHAR(50) NOT NULL
	UNIQUE(TenBoPhan)
)

CREATE TABLE NhanVien
(
	IDNhanVien VARCHAR(10) PRIMARY KEY,
	TenNhanVien NVARCHAR(50) NOT NULL,
	GioiTinh BIT,
	NgaySinh DATETIME NULL CHECK(YEAR(GETDATE()) - YEAR(NgaySinh) > 18),
	SoDienThoai VARCHAR(10) CHECK (SoDienThoai LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
--	TenDangNhapNV VARCHAR(50) NOT NULL,
--	MatKhauNV VARCHAR(100) NOT NULL,
	NgayVaoLam DATETIME NULL,
	NgayNghiLam DATETIME NULL,
--	IDBoPhan VARCHAR(10) NOT NULL
--	CONSTRAINT fr_nhanvien_Bo FOREIGN KEY (IDBoPhan) REFERENCES dbo.BoPhan (IDBoPhan)
)
-- add comnlum trang thai lam viec 
ALTER TABLE NhanVien
ADD bTrangthai BIT 



CREATE TABLE Account
(
	Tendangnhan VARCHAR(50) PRIMARY KEY,
	MatKhau VARCHAR(100) NOT NULL,
	IDNhanVien VARCHAR(10) NOT NULL,
	IDBoPhan VARCHAR(10) NOT NULL
	CONSTRAINT fr_acc_nhanvien FOREIGN KEY (IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien),
	CONSTRAINT fr_acc_bophan FOREIGN KEY (IDBoPhan) REFERENCES dbo.BoPhan (IDBoPhan)
) 

CREATE TABLE LoaiDoUong
(
	IDLoaiDoUong VARCHAR(10) PRIMARY KEY,
	TenLoaiDoUong NVARCHAR(50) NOT NULL
	UNIQUE (TenLoaiDoUong)
)

CREATE TABLE DoUong
(
	IDDoUong VARCHAR(10) PRIMARY KEY,
	TenDoUong NVARCHAR(50) NOT NULL,
	DonGia INT NOT NULL,
	IDLoaiDoUong VARCHAR(10) NOT NULL
	UNIQUE (TenDoUong)
	CONSTRAINT fk_douong_Loaidouong FOREIGN KEY (IDLoaiDoUong) REFERENCES dbo.LoaiDoUong(IDLoaiDoUong)
)

CREATE TABLE HoaDon
(
	IDHoaDon VARCHAR(10) PRIMARY KEY,
	ThoiGianTao DATETIME, ---=GETDATE()
	IDNhanVien VARCHAR(10) NOT NULL
	CONSTRAINT fp_hoadon_nhavvien FOREIGN KEY (IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien)
)

CREATE TABLE ChiTietHoaDon
(
	IDHoaDon VARCHAR(10) NOT NULL,
	IDDoUong VARCHAR(10) NOT NULL,
	SoLuongBan INT,
	DonGiaBan INT NOT NULL
	UNIQUE (IDHoaDon,IDDoUong)
	CONSTRAINT fr_cthoadon_HoaDon FOREIGN KEY (IDHoaDon) REFERENCES dbo.HoaDon(IDHoaDon),
	CONSTRAINT fk_cthoadon_DoUong FOREIGN KEY (IDDoUong) REFERENCES dbo.DoUong(IDDoUong),
	CONSTRAINT fkchitethoadon PRIMARY KEY (IDHoaDon,IDDoUong)
)

CREATE TABLE ChiTietPhaChe
(
	IDHoaDon VARCHAR(10) NOT NULL,
	IDDoUong VARCHAR(10) NOT NULL,
	IDNhanVien VARCHAR(10) NOT NULL,
	SoLuongPhaChe INT NOT NULL,
	GhiChu NVARCHAR(100) NULL,
	TrangThaiPhaChe INT --Số nguyên 0, 1, 2

	UNIQUE (IDHoaDon,IDDoUong)
	CONSTRAINT fr_ctphache_HoaDon FOREIGN KEY (IDHoaDon) REFERENCES dbo.HoaDon(IDHoaDon),
	CONSTRAINT fk_ctphache_DoUong FOREIGN KEY (IDDoUong) REFERENCES dbo.DoUong(IDDoUong),
	CONSTRAINT fk_ctphache_nhanvien FOREIGN KEY (IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien),
	CONSTRAINT fkchitietphache PRIMARY KEY (IDHoaDon,IDDoUong)
)

CREATE TABLE ChiTietGiaoHang
(	
	IDHoaDon VARCHAR(10) NOT NULL,
	IDDoUong VARCHAR(10) NOT NULL,
	IDNhanVien VARCHAR(10) NOT NULL,
	SoLuongGiao INT NOT NULL,
	GhiChu NVARCHAR(100) NULL,
	TrangThaiGiao INT --Só nguyên 0,1,2
	UNIQUE (IDHoaDon,IDDoUong)
	CONSTRAINT fr_ctgiaohang_HoaDon FOREIGN KEY (IDHoaDon) REFERENCES dbo.HoaDon(IDHoaDon),
	CONSTRAINT fk_ctgiaohang_DoUong FOREIGN KEY (IDDoUong) REFERENCES dbo.DoUong(IDDoUong),
	CONSTRAINT fk_ctgiaohang_nhanvien FOREIGN KEY (IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien),
	CONSTRAINT fkchitietgiaohang PRIMARY KEY (IDHoaDon,IDDoUong)
)