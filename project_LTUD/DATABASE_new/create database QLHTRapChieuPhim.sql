--tao database DoAn
create database QLHTRapChieuPhim
go 
use QLHTRapChieuPhim
go
-- drop database QLHTRapChieuPhim
 

 --drop database DARCP
--tao bảng rạp chiếu
create table RAPCHIEU
(
	MaRap nvarchar(10) not null,TenRap nvarchar(30),DiaChi nvarchar(30),SoDT char(10)
)
go

--tạo bảng phòng ban
create table PHONGBAN
(
	MaPhongBan nvarchar(10) not null,MaRap nvarchar(10) not null, TrPhG nvarchar(10)
)
go

--tạo bảng phòng chiếu
create table PHONGCHIEU
(
	MaPhong nvarchar(10) not null,MaRap nvarchar(10) not null,TenPhong nvarchar(20),Tongsoghe int
)
go


--tạo bảng nhân viên
create table NHANVIEN
(
	MaNV nvarchar(10) not null,CCCD char(12), HoNV nvarchar(10) ,TenNV nvarchar(20),Diachi nvarchar(30)
	,SDT char(10),Ngaysinh date,Gioitinh nvarchar(5),Luong float,MaPhong nvarchar(10)	
)
go

--tạo bảng khách hàng
create table KHACHHANG
(
	MaKH nvarchar(10) not null,TenKH nvarchar(20),Diachi nvarchar(30),GioiTinh nvarchar(5) , SDT char(10),Ngaysinh datetime	
)
go


--tạo bản phim
create table PHIM
(
	MaPhim nvarchar(10)not null,TenPhim nvarchar(30),TheLoai nvarchar(30),HangSX nvarchar(20)
)
go

--tao bang Lịch Chiếu
create table LICHCHIEU
(
  MaShow nvarchar(10) not null, MaPhim nvarchar(10) not null,MaPhong nvarchar(10) not null,Ngaychieu date,Giochieu time
)
go

--tao bang VE
create table VE
(	
	MaVe nvarchar(10) not null, MaShow nvarchar(10), MaPhim nvarchar(10) not null,GiaVe float, MaHD nvarchar(10), Ghe nvarchar(10)
)
go

--tao bảng thanh toán
create table THANHTOAN
(
	MaHD nvarchar(10) , MaKH nvarchar(10),
)
go

--tao bang HoaDon
create table HOADON
(	
	MaHD nvarchar(10) not null, MaRap nvarchar(10), MaNV nvarchar(10), MaKH nvarchar(10)
)
go

create table THELOAI
(
	TheLoai nvarchar(30) not null
)
go
create table SX
(
	hangsx nvarchar(20)
)
go
create table THANHTIEN
(
	ThanhTien float
)
go


-- drop table THANHTIEN


--DROP TABLE HOADON
-- thêm bảng người thay đổi
create table NGUOITHAYDOI
(
	Ten nvarchar(40), DiaChi nvarchar(40), SDT char(10), CCCD char(12)
)
go

create table DayGhe
(
	soghe nvarchar(10) not null
)

insert into DayGhe values
(N'1'), (N'2'), (N'3'),(N'4'), (N'5'), (N'6'),(N'7'), (N'8'), (N'9'), (N'10')
,(N'11'), (N'12'), (N'13'),(N'14'), (N'15'), (N'16'),(N'17'), (N'18'), (N'19'), (N'20')
,(N'21'), (N'22'), (N'23'),(N'24'), (N'25'), (N'26'),(N'27'), (N'28'), (N'29'), (N'30')
go
insert into DayGhe values (N'31'), (N'32'),(N'33'), (N'34'), (N'35'), (N'36')

--drop table DayGhe
go
create proc layghe
as
	select * from DayGhe
go

--create proc 

--drop proc layghe
	
-- them du lieu cho rap chieu

--cap nhat du lie

--drop database DARCP

--tao khoa chinh cho RAPCHIEU
alter table RAPCHIEU add constraint pk_mr primary key (MaRap)
--tao khoa chinh cho PHONGBAN
alter table PHONGBAN add constraint pk_mphongBan primary key (MaPhongBan)
--tạo khóa chính cho ghế
alter table DayGhe add constraint pk_mGhe primary key (soghe)
--tao khoa chinh cho PHONGCHIEU
alter table PHONGCHIEU add constraint pk_mp primary key (MaPhong)
--tao khoa chinh cho NHANVIEN
alter table NHANVIEN add constraint pk_mnv primary key (MaNV)
--tao khoa chinh cho KHACHHANG
alter table KHACHHANG add constraint pk_mkh primary key (MaKH)
--tao khoa chinh cho PHIM
alter table PHIM add constraint pk_mphim primary key (MaPhim)
--tao khoa chinh cho VE
alter table VE add constraint pk_mve primary key (MaVe)
--tao khoa chinh cho LichChieu
alter table LICHCHIEU add constraint pk_mshow primary key (MaShow)
--tạo khóa chính cho hóa đơn
alter table HOADON add constraint pk_msHD primary key (MaHD)
-- Tạo khóa chính cho thể loại
--

--tao khoa ngoai phong ban tham chieu toi rap chieu 
alter table PHONGBAN add constraint fk_mphongban foreign key(MaRap) references RAPCHIEU(MaRap)

--tao khoa ngoai Phongchieu tham chieu toi rap chieu 
alter table PHONGCHIEU add constraint fk_mphongchieu foreign key(MaRap) references RAPCHIEU(MaRap)

--tao khoa ngoai Nhan vien tham chieu toi phong ban
alter table NHANVIEN add constraint fk_mnv foreign key(MaPhong) references PHONGCHIEU(MaPhong)

--tao khoa ngoai Khach hang tham chieu toi rap chieu
--alter table KHACHHANG add constraint fk_kh foreign key(MaVe) references VE(MaVe) 

--tao khoa ngoai Phim tham chieu toi 
--alter table PHIM add constraint fk_mphim foreign key(MaRap) references RAPCHIEU(MaRap)

----tao khoa ngoai Ve tham chieu toi rap chieu Phim
alter table VE add constraint fk_mVe foreign key(MaPhim) references PHIM(MaPhim)

----tao khoa ngoai Ve tham chieu toi ma lichchieu
alter table VE add constraint fk_mVeLC foreign key(MaShow) references LICHCHIEU(MaShow)

--tao khoa ngoai LICH CHIEU tham chieu toi rap rap chieu 
alter table LICHCHIEU add constraint fk_mLich foreign key(MaPhim) references PHIM(MaPhim)
--tao khoa ngoai LICH CHIEU tham chieu toi phong chieu
alter table LICHCHIEU add constraint fk_mPhong foreign key(MaPhong) references PHONGCHIEU(MaPhong)

--tao khoa ngoai LICH CHIEU tham chieu toi rap rap chieu 
alter table HOADON add constraint fk_mRap foreign key(MaRap) references RAPCHIEU(MaRap)
--tao khoa ngoai LICH CHIEU tham chieu toi phong chieu
alter table HOADON add constraint fk_mNVXHD foreign key(MaNV) references NHANVIEN(MaNV)

alter table HOADON add constraint fk_mKHHD foreign key(MaKH) references KHACHHANG(MaKH)

-- Tạo khóa ngoại PHIM tham chiếu tới THE LOAI
--drop database DARCP
--drop database DARCP

-- BẢNG MỚI TẠO
----------------------------------------------------
