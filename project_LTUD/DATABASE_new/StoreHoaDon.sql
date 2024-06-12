use QLHTRapChieuPhim

--method lấy danh sách hóa đơn
GO
create proc sp_layDSHoaDon
as
	select * from dbo.HOADON
go

--method insert
go
create proc sp_insertHoaDon(@MaHD nvarchar(10),@MaRap nvarchar(10), @MaNV nvarchar(10), @MaKH nvarchar(10))
as 
	insert dbo.HOADON values(@MaHD,@MaRap, @MaNV, @MaKH)
go
--drop proc sp_insertHoaDon

--method update hóa đơn
create proc sp_updateHoaDon(@MaHD nvarchar(10),@MaRap nvarchar(10), @MaNV nvarchar(10), @MaKH nvarchar(10))
as 
begin
	update dbo.HOADON set MaRap = @MaRap, MaNV=@MaNV, MaKH = @MaKH
	where MaHD = @MaHD
end
go



create proc sp_deleteHoaDon(@MaHD nvarchar(10))
as 
begin
	delete dbo.HOADON 
	where MaHD = @MaHD
end
go

create proc sp_TimKiemHoaDon(@MaHD nvarchar(10))
as
	select * from HOADON WHERE
	MaHD Like '%' + @MaHD + '%'
go

-------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------------

--method lấy danh sách 
GO
create proc sp_layChiTietHoaDon(@MaHD nvarchar(10))
as
	select Count(v.MaVe)*v.GiaVe as ThanhTien,nv.MaNV, R.MaRap, tt.MaHD, kh.TenKH, v.MaVe, v.GiaVe, P.TenPhim, p.MaPhim, v.Ghe, lich.Giochieu, phong.TenPhong
	 
	from dbo.RAPCHIEU as r, dbo.HOADON as tt, dbo.VE as v,
	 dbo.KHACHHANG as kh, dbo.PHIM as p,dbo.NHANVIEN as nv, dbo.LICHCHIEU as lich, dbo.PHONGCHIEU as phong 

	WHERE tt.MaHD = v.MaHD AND TT.MaKH = kh.MaKH AND P.MaPhim = V.MaPhim AND
	r.MaRap = tt.MaRap AND v.MaShow = lich.MaShow AND lich.MaPhong = phong.MaPhong AND nv.MaNV = tt.MaNV AND exists (select TT.MaHD from HOADON Where TT.MaHD = @MaHD)
	
	GROUP BY nv.MaNV, r.MaRap, tt.MaHD, kh.TenKH, v.MaVe, v.GiaVe, P.TenPhim, p.MaPhim, v.Ghe, lich.Giochieu, phong.TenPhong 
	
go

sp_layChiTietHoaDon N'HD02'

go
create proc sp_layChiTietHoaDonTheoMa(@MaHD nvarchar(10))
as
	select nv.MaNV, v.MaVe, v.GiaVe, P.TenPhim, p.MaPhim, v.Ghe, lich.Giochieu, phong.TenPhong
	 
	from dbo.RAPCHIEU as r, dbo.HOADON as tt, dbo.VE as v,
	 dbo.KHACHHANG as kh, dbo.PHIM as p,dbo.NHANVIEN as nv, dbo.LICHCHIEU as lich, dbo.PHONGCHIEU as phong 

	WHERE tt.MaHD = v.MaHD AND TT.MaKH = kh.MaKH AND P.MaPhim = V.MaPhim AND
	r.MaRap = tt.MaRap AND v.MaShow = lich.MaShow AND lich.MaPhong = phong.MaPhong AND nv.MaNV = tt.MaNV AND exists (select TT.MaHD from HOADON Where TT.MaHD = @MaHD)
	
	GROUP BY nv.MaNV, v.MaVe, v.GiaVe, P.TenPhim, p.MaPhim, v.Ghe, lich.Giochieu, phong.TenPhong 
	
go

go
--drop proc sp_layChiTietHoaDon
--lấy vé theo mã hóa đơn
create proc sp_layVeTheoHD(@MaHD nvarchar(10))
as
	select * from VE
	Where exists (select MaVe from HOADON Where VE.MaHD = HOADON.MaHD AND VE.MaHD = @MaHD)
go

exec sp_layVeTheoHD N'HD01'



GO
create proc sp_tinhSoLuongVe
as
	select tt.MaHD ,COUNT(tt.MaHD) as SoLuong
	 
	from dbo.THANHTOAN as tt

	--Where tt.MaHD = hd.MaHD
	
	GROUP BY  tt.MaHD

	
	
go

create proc tongthanhtien(@MaHD nvarchar(10))
as
select sum(v.GiaVe) as tien
	 
	from dbo.RAPCHIEU as r, dbo.HOADON as tt, dbo.VE as v,
	 dbo.KHACHHANG as kh, dbo.PHIM as p,dbo.NHANVIEN as nv, dbo.LICHCHIEU as lich, dbo.PHONGCHIEU as phong 

	WHERE tt.MaHD = v.MaHD AND TT.MaKH = kh.MaKH AND P.MaPhim = V.MaPhim AND
	r.MaRap = tt.MaRap AND v.MaShow = lich.MaShow AND lich.MaPhong = phong.MaPhong AND nv.MaNV = tt.MaNV AND exists (select TT.MaHD from HOADON Where TT.MaHD = @MaHD)
	
go

tongthanhtien N'HD01'


--drop proc sp_layDSThanhToan
select * FROM HOADON