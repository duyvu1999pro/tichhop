GO
CREATE PROCEDURE InsertSANPHAM
@MaSP INT,
@TenSP nvarchar(100),
@ThanhPhan nvarchar(100),
@CongDung nvarchar(100),
@LieuLuong nvarchar(255),
@DonVi nvarchar(100),
@DangThuoc nvarchar(100),
@HinhAnh nchar(255),
@MoTa nvarchar(255),
@GiaBan INT,
@MaDM int

AS
BEGIN
INSERT INTO SANPHAM(MaSP,TenSP,ThanhPhan,CongDung,LieuLuong,DonVi,GiaBan,DangThuoc,HinhAnh,MoTa,MaDM) 
VALUES ( @MaSP, @TenSP,@ThanhPhan,@CongDung,@LieuLuong,@DonVi,@GiaBan,@DangThuoc,@HinhAnh,@MoTa,@MaDM);
END
----------------------
GO

CREATE PROCEDURE UpdateSANPHAM
@id INT,
@TenSP nvarchar(100),
@ThanhPhan nvarchar(100),
@CongDung nvarchar(100),
@LieuLuong nvarchar(255),
@DonVi nvarchar(100),
@DangThuoc nvarchar(100),
@HinhAnh nchar(255),
@MoTa nvarchar(255),
@GiaBan INT
AS
BEGIN
UPDATE SANPHAM SET TenSP=@TenSP,ThanhPhan=@ThanhPhan,CongDung=@CongDung,LieuLuong=@LieuLuong,
DonVi=@DonVi,DangThuoc=@DangThuoc,HinhAnh=@HinhAnh,MoTa=@MoTa,GiaBan=@GiaBan
WHERE MaSP = @id ;
END
----------------------
GO
CREATE PROCEDURE DeleteSANPHAM
@id INT
AS
BEGIN
DELETE FROM SANPHAM
WHERE MaSP= @id ;
END