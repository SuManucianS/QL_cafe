CREATE DATABASE QuanLyQuanCafe
ON(
	Name = QuanLyQuanCafe,
	FileName = 'D:\TAI LIEU HOC TAP\PHAN TICH THIET KE HE THONG THONG TIN\SLIDE BAO CAO\QuanLyQuanCafe.mdf'
  )

USE QuanLyQuanCafe

CREATE TABLE BoPhan
(
	IDBoPhan VARCHAR(10) PRIMARY KEY NOT NULL,
	TenBoPhan NVARCHAR(50)
)
	
SELECT * FROM BoPhan

--Xử lý bộ phận
CREATE PROC pr_ThemBP(@IDBoPhan VARCHAR(10),@TenBoPhan NVARCHAR(50))
AS
BEGIN
	INSERT INTO BoPhan(IDBoPhan,TenBoPhan)
	VALUES(@IDBoPhan,@TenBoPhan)
END
--Xử lý bộ phận

CREATE TABLE NhanVien
(
	IDNhanVien int IDENTITY (001,1) NOT NULL PRIMARY KEY,
	TenNhanVien NVARCHAR(50),
	TenDangNhapNV VARCHAR(50),
	MatKhauNV VARCHAR(25),
	IDBoPhan VARCHAR(10) NOT NULL
	CONSTRAINT fr_nhanvien_Bo FOREIGN KEY (IDBoPhan) REFERENCES dbo.BoPhan (IDBoPhan)
)

SELECT * FROM NhanVien
SELECT * FROM BoPhan

CREATE TABLE LoaiDoUong
(
	IDLoaiDoUong VARCHAR(10) PRIMARY KEY,
	TenLoaiDoUong NVARCHAR(50)
)

SELECT * FROM LoaiDoUong

--Xử lý loại đồ uống
CREATE PROC pr_ThemLoaiDoUong(@IDLoaiDoUong VARCHAR(10),@TenLoaiDoUong NVARCHAR(50))
AS
BEGIN
	INSERT INTO LoaiDoUong(IDLoaiDoUong,TenLoaiDoUong)
	VALUES(@IDLoaiDoUong,@TenLoaiDoUong)
END
--Xử lý loại đồ uống

CREATE TABLE DoUong
(
	IDDoUong VARCHAR(10) PRIMARY KEY,
	TenDoUong NVARCHAR(50),
	DonGia INT,
	IDLoaiDoUong VARCHAR(10) NOT NULL
	CONSTRAINT fk_douong_Loaidouong FOREIGN KEY (IDLoaiDoUong) REFERENCES dbo.LoaiDoUong(IDLoaiDoUong)
)
	
SELECT * FROM LoaiDoUong
SELECT * FROM DoUong

--View đồ uống
CREATE VIEW vw_DoUong
AS
	SELECT IDDoUong AS [Mã đồ uống],TenDoUong AS [Tên đồ uống],DonGia AS [Đơn giá(VNĐ)],IDLoaiDoUong AS [Mã loại đồ uống]
	FROM DoUong
	Where IDLoaiDoUong != 'DAV'
--View do uong


--View đồ ăn vặt
CREATE VIEW vw_DoAnVat
AS
	SELECT IDDoUong AS [Mã đồ ăn],TenDoUong AS [Tên đồ ăn],DonGia AS [Đơn giá(VNĐ)],IDLoaiDoUong AS [Mã loại đồ ăn]
	FROM DoUong
	Where IDLoaiDoUong = 'DAV'
--View đồ ăn vặt
	
CREATE TABLE HoaDon
(
	IDHoaDon int IDENTITY (1,1) NOT NULL PRIMARY KEY,
	ThoiGianTao DATETIME,
	IDNhanVien int NOT NULL
	CONSTRAINT fp_hoadon_nhavvien FOREIGN KEY (IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien)
)

SELECT * FROM HoaDon

--Xử lý hóa đơn
SELECT TOP 1 IDHoaDon,ThoiGianTao,IDNhanVien
FROM HoaDon
ORDER BY ThoiGianTao DESC

SELECT ThoiGianTao AS [Thời gian tạo],HoaDon.IDHoaDon AS [Mã hóa đơn],TenDoUong AS [Tên đồ uống],SoLuongBan AS [Số lượng],DonGiaBan AS [Đơn giá],SUM(SoLuongBan*DonGiaBan) AS [Thành tiền]
FROM HoaDon,ChiTietHoaDon,DoUong
WHERE HoaDon.IDHoaDon = ChiTietHoaDon.IDHoaDon AND ChiTietHoaDon.IDDoUong = DoUong.IDDoUong
GROUP BY ThoiGianTao,HoaDon.IDHoaDon,TenDoUong,SoLuongBan,DonGiaBan
ORDER BY ThoiGianTao DESC

SELECT *
FROM HoaDon,ChiTietHoaDon
WHERE HoaDon.IDHoaDon = ChiTietHoaDon.IDHoaDon
ORDER BY ThoiGianTao DESC

CREATE PROC prThemHD(@IDHoaDon INT,@ThoiGianTao DATETIME)
AS
BEGIN
	INSERT INTO tblTheLoai(sMaloai,sTenloai)
	VALUES(@Matheloai,@Tentheloai)
END

SELECT TenDoUong AS [Tên đồ uống],SoLuongBan AS [Số lượng],DonGiaBan AS [Đơn giá],sum(SoLuongBan*DonGiaBan) AS [Thành Tiền]
FROM DoUong,HoaDon,ChiTietHoaDon
WHERE HoaDon.IDHoaDon = ChiTietHoaDon.IDHoaDon AND ChiTietHoaDon.IDDoUong = DoUong.IDDoUong
GROUP BY TenDoUong,SoLuongBan,DonGiaBan

SELECT TenDoUong AS [Tên đồ uống],DonGia AS [Đơn Giá(VNĐ)]
FROM DoUong
WHERE IDLoaiDoUong = 'B'

CREATE PROC pr_ThemHD(@ThoiGianTao DATETIME, @IDNhanVien INT)
AS
BEGIN
	INSERT INTO HoaDon(ThoiGianTao,IDNhanVien)
	VALUES(@ThoiGianTao,@IDNhanVien)
END

CREATE PROC pr_ThemCTHD(@IDHoaDon INT,@IDDoUong VARCHAR(10),@SoLuongBan INT,@DonGiaBan INT)
AS
BEGIN
	INSERT INTO ChiTietHoaDon(IDHoaDon,IDDoUong,SoLuongBan,DonGiaBan)
	VALUES(@IDHoaDon,@IDDoUong,@SoLuongBan,@DonGiaBan)
END

CREATE PROC pr_UpdateSLTrung(@IDHoaDon INT,@IDDoUong VARCHAR(10),@SoLuongBan INT)
AS
BEGIN
	UPDATE ChiTietHoaDon
	SET SoLuongBan = SoLuongBan + @SoLuongBan
	WHERE IDHoaDon = @IDHoaDon AND IDDoUong = @IDDoUong
END

EXEC pr_UpdateSLTrung '2','B3','7'
SELECT * FROM ChiTietHoaDon
--Xử lý hóa đơn

SELECT * FROM DoUong
SELECT * FROM LoaiDoUong

CREATE TABLE ChiTietHoaDon
(
	IDHoaDon int NOT NULL,
	IDDoUong VARCHAR(10) NOT NULL,
	SoLuongBan INT,
	DonGiaBan INT
	CONSTRAINT fr_cthoadon_HoaDon FOREIGN KEY (IDHoaDon) REFERENCES dbo.HoaDon(IDHoaDon),
	CONSTRAINT fk_cthoadon_DoUong FOREIGN KEY (IDDoUong) REFERENCES dbo.DoUong(IDDoUong),
	CONSTRAINT fkchitethoadon PRIMARY KEY (IDHoaDon,IDDoUong)
)
	
SELECT * FROM HoaDon
SELECT * FROM ChiTietHoaDon

CREATE TABLE NhapHang
(
	IDHoaDon int IDENTITY (1,1) NOT NULL PRIMARY KEY,
	ThoiGianNhap DATETIME,
	IDNhanVien int NOT NULL
	CONSTRAINT fp_hoadon_nhanvien FOREIGN KEY (IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien)
)

CREATE TABLE ChiTietNhap
(
	IDHoaDon int NOT NULL,
	IDNguyenLieu VARCHAR(10) NOT NULL,
	SoLuongNhap INT,
	DonGiaNhap INT
	CONSTRAINT fr_ctnhap FOREIGN KEY (IDHoaDon) REFERENCES dbo.NhapHang(IDHoaDon),
	CONSTRAINT fkchitietnhap PRIMARY KEY (IDHoaDon,IDNguyenLieu)
)

--Chưa chạy
CREATE TABLE ChiTietPhaChe
(
	IDHoaDon int NOT NULL,
	IDDoUong VARCHAR(10) NOT NULL,
	IDNhanVien VARCHAR(10) NOT NULL,
	SoLuongPhaChe INT NOT NULL,
	GhiChu NVARCHAR(100) NULL,
	TrangThaiPhaChe INT --Số nguyên 0, 1, 2
	CONSTRAINT fr_ctphache_HoaDon FOREIGN KEY (IDHoaDon) REFERENCES dbo.HoaDon(IDHoaDon),
	CONSTRAINT fk_ctphache_DoUong FOREIGN KEY (IDDoUong) REFERENCES dbo.DoUong(IDDoUong),
	CONSTRAINT fk_ctphache_nhanvien FOREIGN KEY (IDNhanVien) REFERENCES dbo.NhanVien(IDNhanVien),
	CONSTRAINT fkchitietphache PRIMARY KEY (IDHoaDon,IDDoUong)
)

