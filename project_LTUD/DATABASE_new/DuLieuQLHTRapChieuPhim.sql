
use QLHTRapChieuPhim
go

--them du lieu cho rap chieu
insert dbo.RAPCHIEU 
values
( N'TDC.Movie', N'RẠP CHIẾU TDC', N'Võ Văn Ngân', N'840340913')

go

-- them du lieu cho phong ban
insert  into PHONGBAN(MaPhongBan, MaRap, TrPhG) 
values
( N'001', N'TDC.Movie', N'N.V.Huy'),
( N'002', N'TDC.Movie', N'N.V.Hiep'),
( N'003', N'TDC.Movie', N'N.V.Toan'),
( N'004', N'TDC.Movie', N'N.V.Ha'),
( N'005', N'TDC.Movie', N'N.V.Huan')
go

--them du lieu cho phong chieu
 insert dbo.PHONGCHIEU 
 values (N'P001',N'TDC.Movie',N'Phòng 1', 36),
		(N'P002',N'TDC.Movie',N'Phòng 2', 36),
		(N'P003',N'TDC.Movie',N'Phòng 3', 36),
		(N'P004',N'TDC.Movie',N'Phòng 4', 36),
		(N'P005',N'TDC.Movie',N'Phòng 5', 36)
go


--them du lieu cho nhan vien
insert dbo.NHANVIEN (MaNV, CCCD, HoNV, TenNV, Diachi, SDT, Ngaysinh, Gioitinh, Luong, MaPhong)
values  (N'TT1691', N'040204002911',N'Nguyễn',N'Minh Huy',N'TP Thủ Đức', N'0336533806', '20121201', N'Nam', 1000000, N'P001'),
		(N'TT1692', N'040204002912',N'Nguyễn',N'Minh Hưng',N'TP Thủ Đức', N'0336533806','19991201', N'Nam', 2000000, N'P002' ),
		(N'TT1693', N'040204002913',N'Nguyễn',N'Minh Tuấn',N'TP Thủ Đức', N'0336533806','20001201', N'Nam', 3000000, N'P001'),
		(N'TT1694', N'040204002914',N'Nguyễn',N'Minh Toàn',N'TP Thủ Đức', N'0336533806','20151201', N'Nam', 4000000, N'P003'),
		(N'TT1695', N'040204002915',N'Nguyễn',N'Minh Thái',N'Long AN', N'0336533806', '20051201', N'Nam', 5000000, N'P001'),
		(N'TT1696', N'040204002916',N'Nguyễn',N'Minh Thái',N'Long AN', N'0336533806', '20051201', N'Nam', 6000000, N'P001')
go

--them du lieu cho khach hang
insert dbo.KHACHHANG
values  (N'KH1691',N'Minh Hiệp',N'TP Thủ Đức',N'Nam', N'0336533812','20040101'),
		(N'KH1692',N'Minh Tuấn',N'Bình Phước ',N'Nữ', N'0336533832','20020101'),
		(N'KH1693',N'Minh Huy',N'TP Thủ Đức',N'Nam', N'0336533843','20060101'),
		(N'KH1694',N'Minh Thuận',N'TP Long An',N'Nam', N'0336533841','20030101'),
		(N'KH1695',N'Minh Toàn',N'TP Thủ Đức',N'Nam', N'0336533815','20080101'),
		(N'KH1697',N'Minh Hỏ',N'TP Thủ Đức',N'Nam', N'0336533816','20080101'),
		(N'KH1696',N'Minh Hạnh',N'TP Thủ Đức',N'Nam', N'0336533892','20040101'),
		(N'KH1698',N'Minh Tèo',N'Bình Phước ',N'Nữ', N'0336533831','20020101'),
		(N'KH1699',N'Minh Bo',N'TP Thủ Đức',N'Nam', N'0336533809','20060101'),
		(N'KH1610',N'Minh Anh',N'TP Long An',N'Nam', N'0336533820','20030101'),
		(N'KH1611',N'Minh Thư',N'TP Thủ Đức',N'Nam', N'0336533895','20080101'),
		(N'KH1612',N'Minh Bi',N'TP Thủ Đức',N'Nam', N'0336533863','20080101')
go
--thêm dữ liệu cho phim
insert dbo.PHIM
values 
(N'M001',N'Doraemon', N'Hoạt Hình', N'Nhật Bản'),
(N'M002',N'Lưỡi gươm diệt quỷ', N'Kinh dị', N'Thái Lan'),
(N'M003',N'Naruto', N'Hoạt Hình', N'Nhật Bản'),
(N'M004',N'Sengoku', N'Hoạt Hình', N'Việt Nam'),
(N'M005',N'Oán hồn', N'Kinh dị', N'Indonesia'),
(N'M006',N'Chú hề', N'Hài', N'Việt Nam'),
(N'M007',N'Chiến đấu hết mình', N'Hành động', N'Trung Quốc'),
(N'M008',N'Kẻ hủy diệt', N'Hành động', N'Mỹ'),
(N'M009',N'Siêu lừa', N'Hài', N'Việt Nam'),
(N'M0010',N'Ông ta là ai', N'Hài', N'Hàn Quốc'),
(N'M0011',N'Người đó là ai', N'Tình cảm', N'Hàn Quốc'),
(N'M0012',N'Ai là người thương em', N'Tình cảm', N'Việt Nam'),
(N'M0013',N'Tới từ địa ngục', N'Kinh dị', N'Thái Lan'),
(N'M0014',N'Cô gái Minh Thư', N'Tình cảm', N'Việt Nam'),
(N'M0015',N'Siêu lừa gặp siêu lầy', N'Hài', N'Việt Nam')
go

--thêm dữ liệu cho lịch chiếu
insert dbo.LICHCHIEU 
values 
(N'L01',N'M001', N'P001', '20231111','11:00'),
(N'L02',N'M001', N'P002', '20231111','20:15'),
(N'L03',N'M002', N'P002', '20231111','10:00'),
(N'L04',N'M002', N'P005', '20231111','12:00'),
(N'L05',N'M003', N'P003', '20231111','21:30'),
(N'L06',N'M004', N'P001', '20231111','14:45'),
(N'L07',N'M005', N'P005', '20231111','19:00'),
(N'L08',N'M005', N'P002', '20231111','15:15'),
(N'L09',N'M006', N'P003', '20231111','19:00'),
(N'L010',N'M006', N'P002', '20231111','17:15'),
(N'L011',N'M007', N'P003', '20231111','12:00'),
(N'L012',N'M007', N'P001', '20231111','17:15'),
(N'L013',N'M008', N'P001', '20231111','20:30'),
(N'L014',N'M008', N'P004', '20231111','12:45'),
(N'L015',N'M009', N'P004', '20231111','15:30'),
(N'L016',N'M0010', N'P004', '20231111','19:45'),
(N'L017',N'M0010', N'P005', '20231111','21:45'),
(N'L018',N'M0011', N'P005', '20231111','15:30'),
(N'L019',N'M0011', N'P003', '20231111','15:00'),
(N'L020',N'M0012', N'P001', '20231111','22:45')
go

--thêm dữ liệu cho vé
insert dbo.VE 
values 
(N'V001',N'L01', N'M001',  85000, N'HD01',N'1'),
(N'V002',N'L04', N'M002',  85000, N'HD02',N'5'),
(N'V003',N'L02', N'M001',  85000, N'HD03',N'7'),
(N'V004',N'L03', N'M002',  85000, N'HD01',N'4'),
(N'V005',N'L05', N'M003',  85000, N'HD03',N'15'),
(N'V006',N'L020', N'M0012',  85000, N'HD01',N'6'),
(N'V007',N'L018', N'M0011',  85000, N'HD02',N'7'),
(N'V008',N'L07', N'M005',  85000, N'HD03',N'11'),
(N'V009',N'L010', N'M006',  85000, N'HD01',N'19'),
(N'V0010',N'L017', N'M0010',  85000, N'HD03',N'31')
go

--insert dbo.THANHTOAN
--values 
--(N'HD01',N'KH1691'),
--(N'HD02',N'KH1693'),
--(N'HD03',N'KH1694')
--go

--thêm dữ liệu cho hóa đơn
insert dbo.HOADON
values 
(N'HD01', N'TDC.Movie',N'TT1691' ,N'KH1691'),
(N'HD04', N'TDC.Movie',N'TT1691' ,N'KH1692'),
(N'HD02', N'TDC.Movie',N'TT1691' ,N'KH1693'),
(N'HD03', N'TDC.Movie',N'TT1691' ,N'KH1694')
go



-- DỮ LIỆU MỚI THAY ĐỔI
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------



-- Thêm dữ liệu cho thể loại
insert dbo.THELOAI
values 
(N'Hoạt hình'),
(N'Kinh dị'),
(N'Hài'),
(N'Hành động'),
(N'Tình cảm')
go

-- Thêm dữ liệu cho sản xuất
insert dbo.SX values (N'Việt Nam')


