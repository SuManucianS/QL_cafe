USE QuanLyQuanCafe
GO

--I. Bảng bộ phận
--1.1 (v1). View danh sách
Select * from BoPhan
CREATE Proc sp_bophan
AS
SELECT IDBoPhan, TenBoPhan
FROM     dbo.BoPhan
GO
EXECUTE sp_bophan
--1.2. Proc them bo phan(p1)
CREATE PROCEDURE Pro_ThemBoPhan 
	@id VARCHAR(10),
	@tenbophan NVARCHAR(50)
AS
BEGIN 
	INSERT INTO dbo.BoPhan( IDBoPhan, TenBoPhan )
	VALUES  ( @id, @tenbophan )
END
GO

EXECUTE dbo.Pro_ThemBoPhan @id = 'BP001', @tenbophan = N'Adimin';
EXECUTE dbo.Pro_ThemBoPhan @id = 'BP002', @tenbophan = N'Nhân viên Order';
EXECUTE dbo.Pro_ThemBoPhan @id = 'BP003', @tenbophan = N'Nhân viên pha chế';
GO

--1.3. proc xoa bo phan theo id (p21)
CREATE PROCEDURE Pro_XoaBoPhan
	@id VARCHAR(10)
AS
BEGIN
	DELETE dbo.BoPhan WHERE IDBoPhan = @id
END
GO
--1.4. proc sửa tên bộ phân theo id(p2)
CREATE PROC Proc_SuaBoPhan
	@id VARCHAR(10),
	@tenbophan NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.BoPhan 
	SET TenBoPhan = @tenbophan
	WHERE IDBoPhan = @id
END
GO
------------------------------------------------------
--II.Bảng nhân viên.
--2.1. View danh sách nhân viên(v2)

ALTER PROC sp_DSNhanVien
AS
SELECT dbo.NhanVien.IDNhanVien , dbo.NhanVien.TenNhanVien , dbo.NhanVien.GioiTinh, dbo.NhanVien.NgaySinh , dbo.NhanVien.SoDienThoai, 
                  dbo.NhanVien.NgayVaoLam , dbo.NhanVien.bTrangthai, BoPhan.TenBoPhan
FROM     dbo.Account INNER JOIN
                  dbo.BoPhan ON dbo.Account.IDBoPhan = dbo.BoPhan.IDBoPhan INNER JOIN
                  dbo.NhanVien ON dbo.Account.IDNhanVien = dbo.NhanVien.IDNhanVien
WHERE	BoPhan.IDBoPhan NOT IN ('BP001')
EXECUTE sp_DSNhanVien
GO
SELECT * FROM dbo.View_DSNhanVien
GO

--2.2. Proc Them nhân viên (p3)
CREATE PROC Proc_ThemNhanVien
	@id VARCHAR(10),
	@tennhanvien NVARCHAR(50),
	@gioitinh BIT,
	@ngaysinh DATETIME,
	@sodienthoai VARCHAR(10),
	@ngayvaolam DATETIME
AS
BEGIN
	INSERT INTO dbo.NhanVien
	        ( IDNhanVien , TenNhanVien ,GioiTinh ,NgaySinh ,SoDienThoai  ,NgayVaoLam , NgayNghiLam)
	VALUES  ( @id , @tennhanvien , @gioitinh ,  @ngaysinh ,  @sodienthoai , @ngayvaolam, NULL)
END
GO

EXECUTE dbo.Proc_ThemNhanVien @id = 'NV001', @tennhanvien = N'Ngọc Ánh', @gioitinh = 0, @ngaysinh = '1995-05-02', @sodienthoai = '0396821221', @ngayvaolam = '2012-02-04' 
EXECUTE dbo.Proc_ThemNhanVien @id = 'NV002', @tennhanvien = N'Nguyễn Đức Anh', @gioitinh = 1, @ngaysinh = '1998-05-02', @sodienthoai = '0396874141', @ngayvaolam = '2017-02-02' 
EXECUTE dbo.Proc_ThemNhanVien @id = 'NV003', @tennhanvien = N'Trần Thị Nhung', @gioitinh = 0, @ngaysinh = '2000-05-02', @sodienthoai = '0393874441', @ngayvaolam = '2020-02-02' 
EXECUTE dbo.Proc_ThemNhanVien @id = 'NV004', @tennhanvien = N'Hồ Văn An', @gioitinh = 1, @ngaysinh = '1999-11-02', @sodienthoai = '0388874141', @ngayvaolam = '2029-02-02' 
EXECUTE dbo.Proc_ThemNhanVien @id = 'NV005', @tennhanvien = N'Vũ Thị Thanh Thư', @gioitinh = 0, @ngaysinh = '1998-01-15', @sodienthoai = '0396824141', @ngayvaolam = '2020-02-02' 
GO

--2.3. Proc Sua nhan viên (p4)
CREATE PROC Proc_SuaNhanVien
	@id VARCHAR(10),
	@tennhanvien NVARCHAR(50),
	@gioitinh BIT,
	@ngaysinh DATETIME,
	@sodienthoai VARCHAR(10),
	@ngayvaolam DATETIME
AS
BEGIN
	UPDATE dbo.NhanVien SET 
	TenNhanVien = @tennhanvien,
	GioiTinh = @gioitinh,
	NgaySinh = @ngaysinh,
	SoDienThoai=@sodienthoai,
	NgayVaoLam = @ngayvaolam,
	NgayNghiLam = NULL
	WHERE IDNhanVien = @id
END
GO

--2.4.Proc Xoa nhan vien (p5)
CREATE PROC Proc_XoaNhanVien
@id NVARCHAR(10)
AS
BEGIN
	UPDATE dbo.NhanVien SET NgayNghiLam = GETDATE() WHERE IDNhanVien =@id
END
GO

--2.5. Proc Tim nhan vien theo ten(p6)
CREATE PROC Proc_TimNhanVien
	@tennhanvien NVARCHAR(50)
AS
BEGIN
	SELECT * FROM dbo.View_DSNhanVien
	WHERE [Tên Nhân Viên] LIKE '%@tennhanvien%'

END
GO

--III. bảng account

--3.1.Proc Thêm account cho nhan viên. (p7)
CREATE PROC Proc_ThemAccount
	@tendangnhap VARCHAR(50),
	@matkhau VARCHAR(100),
	@idnhanvien VARCHAR(10),
	@idbophan VARCHAR(10)
AS
BEGIN
	INSERT INTO dbo.Account
	        ( Tendangnhan , MatKhau ,IDNhanVien ,IDBoPhan )
	VALUES  ( @tendangnhap , -- Tendangnhan - varchar(50)
	          @matkhau , -- MatKhau - varchar(100)
	          @idnhanvien , -- IDNhanVien - varchar(10)
	          @idbophan  -- IDBoPhan - varchar(10)
	        )
END
GO

EXEC dbo.Proc_ThemAccount @tendangnhap = 'admin', -- varchar(50)
    @matkhau = 'admin', -- varchar(100)
    @idnhanvien = 'NV001', -- varchar(10)
    @idbophan = 'BP001'; -- varchar(10);

EXEC dbo.Proc_ThemAccount @tendangnhap = 'nhanvien1', -- varchar(50)
    @matkhau = '123', -- varchar(100)
    @idnhanvien = 'NV002', -- varchar(10)
    @idbophan = 'BP002'; -- varchar(10)

EXEC dbo.Proc_ThemAccount @tendangnhap = 'nhanvien2', -- varchar(50)
    @matkhau = '123', -- varchar(100)
    @idnhanvien = 'NV003', -- varchar(10)
    @idbophan = 'BP002'; -- varchar(10);

EXEC dbo.Proc_ThemAccount @tendangnhap = 'nhanvien3', -- varchar(50)
    @matkhau = '123', -- varchar(100)
    @idnhanvien = 'NV004', -- varchar(10)
    @idbophan = 'BP003'; -- varchar(10);

EXEC dbo.Proc_ThemAccount @tendangnhap = 'nhanvien4', -- varchar(50)
    @matkhau = '123', -- varchar(100)
    @idnhanvien = 'NV005', -- varchar(10)
    @idbophan = 'BP003'; -- varchar(10);
GO

--3.2. Proc Dang nhap (p8)
Alter PROC Proc_DangNhap
	@tendangnhap VARCHAR(50),
	@matkhau VARCHAR(100)
AS
BEGIN
	SELECT  dbo.Account.Tendangnhan, Account.MatKhau, NhanVien.bTrangthai, Account.IDNhanVien, Account.IDBoPhan
	FROM Account, NhanVien
	WHERE Account.IDNhanVien = NhanVien.IDNhanVien AND Tendangnhan = @tendangnhap AND MatKhau = @matkhau AND NhanVien.bTrangthai = 1
END
GO

EXECUTE dbo.Proc_DangNhap @tendangnhap = 'admin', -- varchar(50)
    @matkhau = 'admin' -- varchar(100)
GO


--3.3. Proc Cấp lại mật khẩu (p9)
CREATE PROC Proc_UpdateMatKhau
	@tendangnhap VARCHAR(50),
	@matkhau VARCHAR(100)
AS
BEGIN
	UPDATE dbo.Account SET
	MatKhau = @matkhau
	WHERE Tendangnhan = @tendangnhap
END

EXECUTE Proc_UpdateMatKhau 'Su', '89c67618f1bc34e3391da15103d3d5750846a053897484eba857540d32a07c10'
Select * from Account
GO

--IV. Bảng loại đồ uống
--4.1. Proc Thêm loại đồ uống (p10)
CREATE PROC Proc_ThemLoaiDoUong
	@id VARCHAR(10),
	@tendouong NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.LoaiDoUong ( IDLoaiDoUong, TenLoaiDoUong )
	VALUES  ( @id, @tendouong)
END
GO

EXECUTE dbo.Proc_ThemLoaiDoUong @id = 'LDU001',  @tendouong = N'Cà Phê'
EXECUTE dbo.Proc_ThemLoaiDoUong @id = 'LDU002',  @tendouong = N'Siro đá bào'
EXECUTE dbo.Proc_ThemLoaiDoUong @id = 'LDU003',  @tendouong = N'Yogurt đá bào'
EXECUTE dbo.Proc_ThemLoaiDoUong @id = 'LDU004',  @tendouong = N'Trà sữa - Hồng trà'
EXECUTE dbo.Proc_ThemLoaiDoUong @id = 'LDU005',  @tendouong = N'Giải Khát'
GO

--4.2.Proc Sửa loại đồ uống (p11)
CREATE PROC Proc_SuaLoaiDoUong
	@id VARCHAR(10),
	@tendouong NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.LoaiDoUong SET
	TenLoaiDoUong = @tendouong
	WHERE IDLoaiDoUong = @id
END
GO
--4.3. Xóa loại đồ uống (p12)
CREATE PROC Proc_XoaLoaiDoUong
	@id VARCHAR(10)	
AS
BEGIN
	DELETE dbo.LoaiDoUong WHERE IDLoaiDoUong = @id
END
GO
--4.4. View danh sach loai do uong (v3)
CREATE VIEW View_DSLoaiDoUong
AS
SELECT * FROM dbo.LoaiDoUong
GO

 
--V. Đồ uống
--5.1. Proc Thêm đồ uống.(p13)
CREATE PROC Proc_ThemDoUong
	@id VARCHAR(10),
	@tendouong NVARCHAR(50),
	@dongia INT,
	@idloaidouong VARCHAR(10)
AS
BEGIN
	INSERT INTO dbo.DoUong(IDDoUong ,TenDoUong ,DonGia ,IDLoaiDoUong)
	VALUES  ( @id , @tendouong , @dongia , @idloaidouong)
END
GO

EXECUTE dbo.Proc_ThemDoUong @id = 'DU001', @tendouong = N'Cà Phê Đá',  @dongia = 10000, @idloaidouong = 'LDU001'
EXECUTE dbo.Proc_ThemDoUong @id = 'DU002', @tendouong = N'Cà Phê Sữa Đá',  @dongia = 15000, @idloaidouong = 'LDU001' 
EXECUTE dbo.Proc_ThemDoUong @id = 'DU003', @tendouong = N'Cà Phê Sữa CaCao',  @dongia = 20000, @idloaidouong = 'LDU001'
EXECUTE dbo.Proc_ThemDoUong @id = 'DU004', @tendouong = N'Bạc Xíu Đá',  @dongia = 15000, @idloaidouong = 'LDU001' 

EXECUTE dbo.Proc_ThemDoUong @id = 'DU005', @tendouong = N'Siro đá bào Nho',  @dongia = 10000, @idloaidouong = 'LDU002'
EXECUTE dbo.Proc_ThemDoUong @id = 'DU006', @tendouong = N'Siro đá bào Đào',  @dongia = 10000, @idloaidouong = 'LDU002'  
EXECUTE dbo.Proc_ThemDoUong @id = 'DU007', @tendouong = N'Siro đá bào Cam',  @dongia = 10000, @idloaidouong = 'LDU002'  
EXECUTE dbo.Proc_ThemDoUong @id = 'DU008', @tendouong = N'Siro đá bào Dâu',  @dongia = 10000, @idloaidouong = 'LDU002'  
EXECUTE dbo.Proc_ThemDoUong @id = 'DU009', @tendouong = N'Siro đá bào Kiwi',  @dongia = 10000, @idloaidouong = 'LDU002'  
EXECUTE dbo.Proc_ThemDoUong @id = 'DU0010', @tendouong = N'Siro đá bào Việt Quất',  @dongia = 10000, @idloaidouong = 'LDU002'

EXECUTE dbo.Proc_ThemDoUong @id = 'DU0011', @tendouong = N'Yogurt đá bào Nho',  @dongia = 15000, @idloaidouong = 'LDU003'
EXECUTE dbo.Proc_ThemDoUong @id = 'DU0012', @tendouong = N'Yogurt đá bào Đào',  @dongia = 15000, @idloaidouong = 'LDU003'  
EXECUTE dbo.Proc_ThemDoUong @id = 'DU0013', @tendouong = N'Yogurt đá bào Cam',  @dongia = 15000, @idloaidouong = 'LDU003'  
EXECUTE dbo.Proc_ThemDoUong @id = 'DU0014', @tendouong = N'Yogurt đá bào Dâu',  @dongia = 15000, @idloaidouong = 'LDU003' 

EXECUTE dbo.Proc_ThemDoUong @id = 'DU0015', @tendouong = N'Nho',  @dongia = 15000, @idloaidouong = 'LDU004'
EXECUTE dbo.Proc_ThemDoUong @id = 'DU0016', @tendouong = N'Trà Đào',  @dongia = 20000, @idloaidouong = 'LDU004'  
EXECUTE dbo.Proc_ThemDoUong @id = 'DU0017', @tendouong = N'Bạc Hà',  @dongia = 15000, @idloaidouong = 'LDU004'  
EXECUTE dbo.Proc_ThemDoUong @id = 'DU0018', @tendouong = N'Socola',  @dongia = 15000, @idloaidouong = 'LDU004'  

EXECUTE dbo.Proc_ThemDoUong @id = 'DU0019', @tendouong = N'7 up',  @dongia = 15000, @idloaidouong = 'LDU005'
EXECUTE dbo.Proc_ThemDoUong @id = 'DU0020', @tendouong = N'Pepsi',  @dongia = 15000, @idloaidouong = 'LDU005'  
EXECUTE dbo.Proc_ThemDoUong @id = 'DU0021', @tendouong = N'Coca',  @dongia = 15000, @idloaidouong = 'LDU005'  
EXECUTE dbo.Proc_ThemDoUong @id = 'DU0022', @tendouong = N'String',  @dongia = 15000, @idloaidouong = 'LDU005'      

GO

--5.2. proc Sửa ddood uống (p14)
CREATE PROC Proc_SuaDoUong
	@id VARCHAR(10),
	@tendouong NVARCHAR(50),
	@dongia INT,
	@idloaidouong VARCHAR(10)
AS
BEGIN
	UPDATE dbo.DoUong SET
	TenDoUong = @tendouong,
	DonGia = @dongia,
	IDLoaiDoUong = @idloaidouong
	WHERE IDDoUong = @id
END
GO
--5.3.Proc Xoa đò uống (p15)
CREATE PROC Proc_XoaDoUong
	@id VARCHAR(10)
AS
BEGIN
	DELETE dbo.DoUong WHERE IDDoUong = @id
END
GO
--5.4. View danh sach do uong (V4)
CREATE VIEW View_DSDoUong
AS
SELECT dbo.DoUong.IDDoUong, dbo.DoUong.TenDoUong, dbo.DoUong.DonGia, dbo.LoaiDoUong.TenLoaiDoUong
FROM     dbo.DoUong INNER JOIN
                  dbo.LoaiDoUong ON dbo.DoUong.IDLoaiDoUong = dbo.LoaiDoUong.IDLoaiDoUong
GO

	
--VI.Hóa đơn
--6.1. Proctạo hóa đơn (p16)

CREATE PROC Proc_ThemHoaDon
	@id VARCHAR(10),
	@thoigiantao DATETIME,
	@idnhanvien VARCHAR(10)
AS
BEGIN
    INSERT INTO dbo.HoaDon( IDHoaDon, ThoiGianTao, IDNhanVien )
    VALUES  ( @id, @thoigiantao, @idnhanvien)
END
GO

EXEC dbo.Proc_ThemHoaDon @id = 'HD001', -- varchar(10)
    @thoigiantao = '2020-05-02 16:10:50', -- datetime
    @idnhanvien = 'NV002' -- varchar(10)

EXEC dbo.Proc_ThemHoaDon @id = 'HD002', -- varchar(10)
    @thoigiantao = '2020-05-02 17:14:50', -- datetime
    @idnhanvien = 'NV002' -- varchar(10)
GO

--VII. CHi tiet hoa don
--7.1.  Proc them chi tiet hoa don (p17)
CREATE PROC Proc_ThemChiTietHoaDon
	@idhoadon VARCHAR(10),
	@iddouong VARCHAR(10),
	@soluongban INT,
	@dongiaban INT
AS
BEGIN
	INSERT INTO dbo.ChiTietHoaDon( IDHoaDon ,IDDoUong ,SoLuongBan ,DonGiaBan)
	VALUES  ( @idhoadon , @iddouong , @soluongban , @dongiaban )
END
GO

EXECUTE dbo.Proc_ThemChiTietHoaDon @idhoadon = 'HD001', @iddouong = 'DU001',  @soluongban = 3, @dongiaban = 10000 
EXECUTE dbo.Proc_ThemChiTietHoaDon @idhoadon = 'HD001', @iddouong = 'DU003',  @soluongban = 2, @dongiaban = 20000 
EXECUTE dbo.Proc_ThemChiTietHoaDon @idhoadon = 'HD001', @iddouong = 'DU0019',  @soluongban = 4, @dongiaban = 15000 

EXECUTE dbo.Proc_ThemChiTietHoaDon @idhoadon = 'HD002', @iddouong = 'DU0011',  @soluongban = 3, @dongiaban = 15000 
EXECUTE dbo.Proc_ThemChiTietHoaDon @idhoadon = 'HD002', @iddouong = 'DU003',  @soluongban = 2, @dongiaban = 20000 
EXECUTE dbo.Proc_ThemChiTietHoaDon @idhoadon = 'HD002', @iddouong = 'DU0019',  @soluongban = 4, @dongiaban = 15000 
GO

--7.3. View danh sach chi tiet hoa don(v5)
CREATE VIEW View_DSChiTietHoaDon
AS
SELECT dbo.HoaDon.IDHoaDon, dbo.ChiTietHoaDon.IDDoUong, dbo.DoUong.TenDoUong, dbo.ChiTietHoaDon.SoLuongBan, dbo.ChiTietHoaDon.DonGiaBan, dbo.HoaDon.IDNhanVien, dbo.HoaDon.ThoiGianTao
FROM     dbo.DoUong INNER JOIN
                  dbo.ChiTietHoaDon ON dbo.DoUong.IDDoUong = dbo.ChiTietHoaDon.IDDoUong INNER JOIN
                  dbo.HoaDon ON dbo.ChiTietHoaDon.IDHoaDon = dbo.HoaDon.IDHoaDon
GO

--7.2. PROC Tim chi tiet hoa don theo id(p23)
CREATE PROC Proc_TimChiTietHoaDon
@idhoadon VARCHAR(10)
AS
BEGIN
    SELECT * FROM dbo.View_DSChiTietHoaDon
	WHERE IDHoaDon LIKE '%'+ @idhoadon+ '%';
END
GO

--EXECUTE dbo.Proc_TimChiTietHoaDon @idhoadon = '001'

--VII.chi tiet pha che
--8.0. View chi tiet pha che (v6)
CREATE VIEW View_DSChiTietPhaChe
AS
SELECT dbo.ChiTietPhaChe.IDHoaDon, dbo.ChiTietPhaChe.IDDoUong, dbo.DoUong.TenDoUong, dbo.ChiTietPhaChe.SoLuongPhaChe, dbo.ChiTietPhaChe.GhiChu, dbo.ChiTietPhaChe.TrangThaiPhaChe, dbo.HoaDon.ThoiGianTao
FROM     dbo.DoUong INNER JOIN
                  dbo.ChiTietPhaChe ON dbo.DoUong.IDDoUong = dbo.ChiTietPhaChe.IDDoUong INNER JOIN
                  dbo.HoaDon ON dbo.ChiTietPhaChe.IDHoaDon = dbo.HoaDon.IDHoaDon
GO

SELECT * FROM dbo.View_DSChiTietPhaChe
GO


--8.1.Proc them Chi tiet pha che (p18)
CREATE PROC Proc_ThemChiTietPhaChe
	@idhoadon VARCHAR(10),
	@iddouong VARCHAR(10),
	@idnhanvien VARCHAR(10),
	@soluongphache INT,
	@ghichu NVARCHAR(100),
	@trangthai INT
AS
BEGIN
    INSERT INTO dbo.ChiTietPhaChe
            ( IDHoaDon ,IDDoUong ,IDNhanVien ,SoLuongPhaChe ,GhiChu ,TrangThaiPhaChe)
    VALUES  ( @idhoadon ,  @iddouong ,   @idnhanvien ,  @soluongphache ,  @ghichu ,  @trangthai)
END
GO
EXECUTE dbo.Proc_ThemChiTietPhaChe @idhoadon = 'HD001',  @iddouong = 'DU001',@idnhanvien = 'NV004', @soluongphache = 3, @ghichu = N'Ít đá', @trangthai = 0
EXECUTE dbo.Proc_ThemChiTietPhaChe @idhoadon = 'HD001',  @iddouong = 'DU003',@idnhanvien = 'NV004', @soluongphache = 2, @ghichu = N'', @trangthai = 0 
EXECUTE dbo.Proc_ThemChiTietPhaChe @idhoadon = 'HD001',  @iddouong = 'DU0019',@idnhanvien = 'NV004', @soluongphache = 4, @ghichu = N'', @trangthai = 0  

EXECUTE dbo.Proc_ThemChiTietPhaChe @idhoadon = 'HD002',  @iddouong = 'DU0011',@idnhanvien = 'NV005', @soluongphache = 3, @ghichu = N'Ít đá', @trangthai = 0 
EXECUTE dbo.Proc_ThemChiTietPhaChe @idhoadon = 'HD002',  @iddouong = 'DU003',@idnhanvien = 'NV005', @soluongphache = 2, @ghichu = N'Ít đường', @trangthai = 0 
EXECUTE dbo.Proc_ThemChiTietPhaChe @idhoadon = 'HD002',  @iddouong = 'DU0019',@idnhanvien = 'NV005', @soluongphache = 4, @ghichu = N'Ít đá', @trangthai = 0 
GO

--8.2.Proc Update trang thái chi tiết pha chế (p19)
CREATE PROC Proc_UpdateTrangThaiPhaChe
	@idhoadon VARCHAR(10),
	@iddouong VARCHAR(10),
	@trangthai INT
AS
BEGIN
    UPDATE dbo.ChiTietPhaChe 
	SET TrangThaiPhaChe = @trangthai
	WHERE IDHoaDon = @idhoadon AND IDDoUong =@iddouong
END
GO

--EXECUTE dbo.Proc_UpdateTrangThaiPhaChe @idhoadon = 'HD001',  @iddouong = 'DU001',  @trangthai = 1
--GO
--8.3. PROC Tim chi tiet pha che theo id(p24)
CREATE PROC Proc_TimChiTietPhaChe
	@idhoadon VARCHAR(10)
AS
BEGIN
    SELECT * FROM dbo.View_DSChiTietPhaChe
	WHERE IDHoaDon LIKE '%'+ @idhoadon+ '%';
END
GO
EXECUTE dbo.Proc_TimChiTietPhaChe @idhoadon = '002'
GO


--IX. Chi Tiet giao hang

--9.0 View Chi TietGiao Hang (v7)
CREATE VIEW View_DSChiTietGiaoHang
AS
SELECT dbo.ChiTietGiaoHang.IDHoaDon, dbo.ChiTietGiaoHang.IDDoUong, dbo.DoUong.TenDoUong, dbo.DoUong.DonGia, dbo.ChiTietGiaoHang.SoLuongGiao, dbo.ChiTietGiaoHang.IDNhanVien, dbo.ChiTietGiaoHang.GhiChu, 
                  dbo.ChiTietGiaoHang.TrangThaiGiao
FROM     dbo.DoUong INNER JOIN
                  dbo.ChiTietGiaoHang ON dbo.DoUong.IDDoUong = dbo.ChiTietGiaoHang.IDDoUong INNER JOIN
                  dbo.HoaDon ON dbo.ChiTietGiaoHang.IDHoaDon = dbo.HoaDon.IDHoaDon
GO

SELECT * FROM dbo.View_DSChiTietGiaoHang
--9.1.Proc Them chi tiet giao hang (p20)
CREATE PROC Proc_ThemChiTietGiaoHang
	@idhoadon VARCHAR(10),
	@iddouong VARCHAR(10),
	@idnhanvien VARCHAR(10),
	@soluonggiao INT,
	@ghichu NVARCHAR(100),
	@trangthai INT
AS
BEGIN
    INSERT INTO dbo.ChiTietGiaoHang
            ( IDHoaDon ,IDDoUong ,IDNhanVien ,SoLuongGiao ,GhiChu ,TrangThaiGiao)
    VALUES  ( @idhoadon ,@iddouong , @idnhanvien , @soluonggiao , @ghichu ,  @trangthai)
END
GO

EXECUTE dbo.Proc_ThemChiTietGiaoHang @idhoadon = 'HD001',  @iddouong = 'DU001',@idnhanvien = 'NV004', @soluonggiao = 3, @ghichu = N'', @trangthai = 0
EXECUTE dbo.Proc_ThemChiTietGiaoHang @idhoadon = 'HD001',  @iddouong = 'DU003',@idnhanvien = 'NV004', @soluonggiao = 2, @ghichu = N'', @trangthai = 0 
EXECUTE dbo.Proc_ThemChiTietGiaoHang @idhoadon = 'HD001',  @iddouong = 'DU0019',@idnhanvien = 'NV004', @soluonggiao = 4, @ghichu = N'', @trangthai = 0  

EXECUTE dbo.Proc_ThemChiTietGiaoHang @idhoadon = 'HD002',  @iddouong = 'DU0011',@idnhanvien = 'NV005', @soluonggiao = 3, @ghichu = N'', @trangthai = 0 
EXECUTE dbo.Proc_ThemChiTietGiaoHang @idhoadon = 'HD002',  @iddouong = 'DU003',@idnhanvien = 'NV005', @soluonggiao = 2, @ghichu = N'', @trangthai = 0 
EXECUTE dbo.Proc_ThemChiTietGiaoHang @idhoadon = 'HD002',  @iddouong = 'DU0019',@idnhanvien = 'NV005', @soluonggiao = 4, @ghichu = N'', @trangthai = 0 

-- 9.2. Update trang thai chi tiet giao hang(p22)
CREATE PROC Proc_UpdateTrangThaiGiaoHang
	@idhoadon VARCHAR(10),
	@iddouong VARCHAR(10),
	@trangthai INT
AS
BEGIN
    UPDATE dbo.ChiTietGiaoHang 
	SET TrangThaiGiao = @trangthai
	WHERE IDHoaDon = @idhoadon AND IDDoUong =@iddouong
END
GO

--EXECUTE Proc_UpdateTrangThaiGiaoHang @idhoadon = 'HD001',  @iddouong = 'DU001',  @trangthai = 1

--9.3. PROC Tim chi tiet giao hang theo id(p25)

CREATE PROC Proc_TimChiTietGiaoHang
	@idhoadon VARCHAR(10)
AS
BEGIN
    SELECT * FROM dbo.View_DSChiTietGiaoHang
	WHERE IDHoaDon LIKE '%'+ @idhoadon+ '%';
END
GO

EXEC dbo.Proc_TimChiTietGiaoHang @idhoadon = '001' -- varchar(10)

 --Note: 25 proc -- 7 view