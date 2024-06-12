use QLHTRapChieuPhim
go

create proc inDanhSachVeXemPhim
as	
	select VE.MaVe,Ghe, PHIM.TenPhim, VE.GiaVe
	from VE 
	inner join PHIM on PHIM.MaPhim = VE.MaPhim

go
--drop proc inDanhSachVeXemPhim

create proc inDanhSachTungVe(@MaVe nvarchar(10))
as	
	select VE.MaVe,Ghe,  PHIM.TenPhim, VE.GiaVe
	from VE 
	inner join PHIM on PHIM.MaPhim = VE.MaPhim
	
	where MaVe = @MaVe
go
exec inDanhSachTungVe N'V001'
go
-- drop proc inDanhSachTungVe

--------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------

create PROCEDURE inDanhSachMaPhong(@MaPhong nvarchar(10))
as
begin
	select PHIM.*, LICHCHIEU.MaPhong, Ngaychieu, Giochieu
	from PHIM inner join LICHCHIEU on PHIM.MaPhim = LICHCHIEU.MaPhim
	where @MaPhong = MaPhong
end
go

create proc inDanhSachHangSX(@HangSX nvarchar(30))
as
	begin
		select * from PHIM where HangSX = @HangSX
	end
go

create proc inDanhSachTheLoai(@TheLoai nvarchar(30))
as
	begin
		select * from PHIM where TheLoai = @TheLoai
	end
go

-- drop proc inDanhSachMaPhong
-- drop proc inDanhSachPhim
-- drop proc inDanhSachHangSX
-- drop proc inDanhSachTheLoai

exec inDanhSachMaPhong N'P002'
exec inDanhSachHangSX N'Việt Nam'
exec inDanhSachTheLoai N'Hài'