
use QLHTRapChieuPhim

go
create table taikhoan
(
	MaTK nvarchar(50),
	TenTK nvarchar(50),
	MatKhau nvarchar(20),
	MaQuyen nvarchar(10)
		
)

-- drop table taikhoan

insert into dbo.taikhoan values
(N'TK01', N'user', N'123', N'user01'),
(N'TK02', N'udmin', N'123',N'admin01')
-- store
go
create proc sp_LayDSTaiKhoan
as
	select * from taikhoan
go

create proc sp_insertTaiKhoan(@MaTK nvarchar(10), @TenTK nvarchar(50), @MatKhau nvarchar(20), @MaQuyen nvarchar(20))
as
	insert dbo.taikhoan values(@MaTK, @TenTK, @MatKhau, @MaQuyen)
go

create proc sp_deleteTaiKhoan(@MaTK nvarchar(10))
as
	begin
		delete taikhoan where MaTK = @MaTK
	end
go

create proc sp_updateTaiKhoan(@MaTK nvarchar(10), @TenTK nvarchar(50), @MatKhau nvarchar(20), @MaQuyen nvarchar(20))
as
	begin
		update dbo.taikhoan set TenTK =  @TenTK, MatKhau = @MatKhau,MaQuyen = @MaQuyen where MaTK = @MaTK
	end
go

create proc sp_Logic(@user nvarchar(50), @pass nvarchar(20))
as
begin 
	SELECT * FROM dbo.taikhoan WHERE TenTK = @user AND MatKhau = @pass
end


--create table quyen
--(
--	MaQuyen nvarchar(10), 
--	TenQuen nvarchar(50)
--)

--insert into dbo.quyen values
--(N'user01', N'user'),
--(N'admin01', N'admin')


--go
