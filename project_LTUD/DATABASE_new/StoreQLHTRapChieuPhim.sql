use QLHTRapChieuPhim
go
--tạo method select 
create proc sp_layDSRapChieu
as
	select * from RAPCHIEU
go

--tạo method select 
create proc sp_layDSPhongBan
as
	select * from PHONGBAN
go

--tạo method select 
create proc sp_layDSPhongChieu
as
	select * from PHONGCHIEU
go

--tạo method select 
create proc sp_layDSNhanVien
as
	select * from NHANVIEN	
go

--tạo method select 
create proc sp_layDSKhachHang
as
	select * from KHACHHANG
go

--tạo method select 
create proc sp_layDSPhim
as
	select * from PHIM
go

--tạo method select 
create proc sp_layDSLichChieu
as
	select * from LICHCHIEU
go

--tạo method select 
create proc sp_layDSVE
as
	select * from VE
go

create proc sp_layDSThanhToan
as
	select * from THANHTOAN
go

-- STORE MỚI TẠO
---------------------------------------------------------------------
-- Store

create proc sp_layDSTheLoai
as
	select * from THELOAI
go

create proc sp_LaySX
as
	select * from SX
go

create proc sp_ThanhTien
as
	select sum(GiaVe) as ThanhTien
	from VE
go



--method insert
create proc sp_insertRapChieu(@MaRap nvarchar(10),@TenRap nvarchar(30),@DiaChi nvarchar(30),@SoDT char(10))
as 
	insert dbo.RAPCHIEU values(@MaRap,@TenRap,@DiaChi,@SoDT)
go

--method insert
create proc sp_insertPhongBan(@MaPhongBan nvarchar(10),@MaRap nvarchar(10), @TrPhG nvarchar(10))
as 
	insert dbo.PHONGBAN values(@MaPhongBan,@MaRap,@TrPhG)
go

--method insert
create proc sp_insertPhongChieu(@MaPhong nvarchar(10),@MaRap nvarchar(10),@TenPhong nvarchar(20),@Tongsoghe int)
as 
	insert dbo.PHONGCHIEU values(@MaPhong,@MaRap,@TenPhong,@Tongsoghe)
go

--method insert
create proc sp_insertNhanVien(@MaNV nvarchar(10),@CCCD char(12), @HoNV nvarchar(10) ,@TenNV nvarchar(20), @Diachi nvarchar(30)
	,@SDT char(10),@Ngaysinh datetime,@Gioitinh nvarchar(5),@Luong float,@MaPhong nvarchar(10))
as 
	insert dbo.NHANVIEN values(@MaNV,@CCCD,@HoNV,@TenNV,@Diachi,@SDT,@Ngaysinh,@Gioitinh,@Luong,@MaPhong)
go


--method insert
create proc sp_insertKhachHang(@MaKH nvarchar(10),@TenKH nvarchar(20),@Diachi nvarchar(30),@GioiTinh nvarchar(5),@SDT char(10),@Ngaysinh datetime)
as 
	insert dbo.KHACHHANG values(@MaKH,@TenKH,@Diachi,@GioiTinh,@SDT, @Ngaysinh)
go

--method insert
create proc sp_insertPhim(@MaPhim nvarchar(10),@TenPhim nvarchar(30),@TheLoai nvarchar(30),@HangSX nvarchar(20))
as 
	insert dbo.PHIM values(@MaPhim,@TenPhim,@TheLoai,@HangSX)
go

--method insert
create proc sp_insertLichChieu(@MaShow nvarchar(10), @MaPhim nvarchar(10),@MaPhong nvarchar(10),@Ngaychieu date,@Giochieu time)
as 
	insert dbo.LICHCHIEU values(@MaShow,@MaPhim,@MaPhong,@Ngaychieu,@Giochieu)
go

--method insert
create proc sp_insertVe(@MaVe nvarchar(10), @MaShow nvarchar(10), @MaPhim nvarchar(10),@GiaVe float, @MaHD nvarchar(10),@Ghe nvarchar(10))
as 
	insert dbo.VE values(@MaVe,@MaShow,@MaPhim,@GiaVe,@MaHD ,@Ghe)
go

--method insert


--method insert
--create proc sp_insertNguoiThayDoi(@Ten nvarchar(40),@DiaChi nvarchar(40),@SDT int,@CCCD int, @ThoiGian dateTime)
--as 
--	insert dbo.NGUOITHAYDOI values(@Ten,@DiaChi,@SDT,@CCCD, @ThoiGian)
--go


-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------

--method update rạp chiếu
create proc sp_updateRapChieu(@MaRap nvarchar(10),@TenRap nvarchar(30),@DiaChi nvarchar(30),@SoDT char(10))
as 
begin
	update RAPCHIEU set TenRap=@TenRap,DiaChi=@DiaChi,SoDT=@SoDT where MaRap = @MaRap
end
go

--method update phòng ban
create proc sp_updatePhongBan(@MaPhongBan nvarchar(10),@MaRap nvarchar(10), @TrPhG nvarchar(10))
as 
begin
	update dbo.PHONGBAN set MaRap=@MaRap,TrPhG=@TrPhG where MaPhongBan = @MaPhongBan
end
go

--method update phòng chiếu
create proc sp_updatePhongChieu(@MaPhong nvarchar(10),@MaRap nvarchar(10),@TenPhong nvarchar(20),@Tongsoghe int)
as 
begin
	update dbo.PHONGCHIEU set MaRap=@MaRap,TenPhong=@TenPhong,Tongsoghe=@Tongsoghe where MaPhong = @MaPhong
end
go

--method update nhân viên
create proc sp_updateNhanVien(@MaNV nvarchar(10), @HoNV nvarchar(10) ,@TenNV nvarchar(20), @Diachi nvarchar(30)
	,@SDT char(10),@Ngaysinh datetime,@Gioitinh char(5),@Luong float,@MaPhong char(10))
as 
begin
	update dbo.NHANVIEN set HoNV=@HoNV,TenNV=@TenNV,Diachi=@Diachi,SDT=@SDT,Ngaysinh=@Ngaysinh,Gioitinh=@Gioitinh,Luong=@Luong,MaPhong=@MaPhong
	where MaNV = @MaNV
end
go


--method update khách hàng
create proc sp_updateKhachHang(@MaKH nvarchar(10),@TenKH nvarchar(20),@Diachi nvarchar(30),@GioiTinh nvarchar(5),@SDT char(10),@Ngaysinh date)
as 
begin
	update dbo.KHACHHANG set TenKH=@TenKH,Diachi=@Diachi,  GioiTinh=@GioiTinh , SDT=@SDT, Ngaysinh= @Ngaysinh
	where MaKH = @MaKH
end	
go

--method update phim
create proc sp_updatePhim(@MaPhim nvarchar(10),@TenPhim nvarchar(30),@TheLoai nvarchar(30),@HangSX nvarchar(20))
as 
begin
	update dbo.PHIM set TenPhim=@TenPhim,TheLoai=@TheLoai,HangSX=@HangSX
	where MaPhim = @MaPhim
end
go

--method update lịch chiếu
create proc sp_updateLichChieu(@MaShow nvarchar(10), @MaPhim nvarchar(10),@MaPhong nvarchar(10),@Ngaychieu date,@Giochieu time)
as 
begin
	update dbo.LICHCHIEU set MaPhim=@MaPhim,MaPhong=@MaPhong,Ngaychieu=@Ngaychieu,Giochieu=@Giochieu
	where MaShow = @MaShow
end
go

--method update vé
create proc sp_updateVe(@MaVe nvarchar(10), @MaShow nvarchar(10), @MaPhim nvarchar(10),@GiaVe float, @MaHD nvarchar(10), @Ghe nvarchar(10))
as 
begin
	update dbo.VE set MaShow=@MaShow,MaPhim=@MaPhim,GiaVe=@GiaVe,MaHD=@MaHD,Ghe=@Ghe 
	where MaVe = @MaVe
end
go






-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------

--method delete
create proc sp_deleteRapChieu(@MaRap nvarchar(10))
as 
begin
	delete RAPCHIEU where MaRap = @MaRap
end
go

--method delete phòng ban
create proc sp_deletePhongBan(@MaPhongBan nvarchar(10))
as 
begin
	delete dbo.PHONGBAN where MaPhongBan = @MaPhongBan
end
go

--method delete phòng chiếu
create proc sp_deletePhongChieu(@MaPhong nvarchar(10))
as 
begin
	delete dbo.PHONGCHIEU where MaPhong = @MaPhong
end
go

--method delete nhân viên
create proc sp_deleteNhanVien(@MaNV nvarchar(10))
as 
begin
	delete dbo.NHANVIEN 
	where MaNV = @MaNV
end
go


--method delete khách hàng
create proc sp_deleteKhachHang(@MaKH nvarchar(10))
as 
begin
	delete dbo.KHACHHANG
	where MaKH = @MaKH
end
go



--method update phim
create proc sp_deletePhim(@MaPhim char(10),@TenPhim nvarchar(30),@TheLoai nvarchar(30),@HangSX nvarchar(20))
as 
begin
	delete dbo.PHIM 
	where MaPhim = @MaPhim
end
go

--method delete lịch chiếu
create proc sp_deleteLichChieu(@MaShow nvarchar(10))
as 
begin
	delete dbo.LICHCHIEU 
	where MaShow = @MaShow
end
go

--method delete vé
create proc sp_deleteVe(@MaVe nvarchar(10))
as 
begin
	delete dbo.VE 
	where MaVe = @MaVe
end
go



-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------

create proc sp_TimKiemThongTinKhachHang(@MaKH nvarchar(10))
as
	select * from KHACHHANG WHERE
	MaKH Like '%' + @MaKH + '%'
go
exec sp_TimKiemThongTinKhachHang 'KH1691'
go 

create proc sp_TimThongTinKiemLichChieu(@MaShow nvarchar(10))
as
	select * from LICHCHIEU WHERE
	MaShow Like '%' + @MaShow + '%'
go
exec sp_TimThongTinKiemLichChieu 'L01'
go 

create proc sp_TimKiemRap(@MaRap nvarchar(10))
as
	select * from RAPCHIEU WHERE
	MaRap Like '%' + @MaRap + '%'
go
exec sp_TimKiemRap 'TDC.Movie'

go
create proc sp_TimKiemVe(@MaVe nvarchar(10))
as
	select * from VE WHERE
	MaVe Like '%' + @MaVe + '%'
go
exec sp_TimKiemVe 'V002'
go
create proc sp_TimKiemPhongChieu(@MaPhong nvarchar(10))
as
	select * from PHONGCHIEU WHERE
	MaPhong Like '%' + @MaPhong + '%'
go
exec sp_TimKiemPhongChieu'P001'
go
create proc sp_TimKiemPhim(@MaPhim nvarchar(10))
as
	select * from PHIM WHERE
	MaPhim Like '%' + @MaPhim + '%'
go
exec sp_TimKiemPhim'M001'
go
create proc sp_TimKiemPhongBan(@MaPhongBan nvarchar(10))
as
	select * from PHONGBAN WHERE
	MaPhongBan Like '%' + @MaPhongBan + '%'
go
exec sp_TimKiemPhongBan'001'
go
create proc sp_TimKiemNhanVien(@MaNV nvarchar(10))
as
	select * from NHANVIEN WHERE
	MaNV Like '%' + @MaNV + '%'
go
exec sp_TimKiemNhanVien'TT1691'


