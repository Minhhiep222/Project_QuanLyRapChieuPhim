using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDon_BUS
    {
        HoaDon_DAL hoadon_DAL = new HoaDon_DAL();
        public DataTable LAYDANHSACHHOADON()
        {
            return hoadon_DAL.LayDanhSachHoaDon("sp_layDSHoaDon");
        }
        
        public DataTable LAYDANHSACHHOADONCHITIETHOADON(string ma)
        {
            return hoadon_DAL.layDanhSachHoaDonChiTiet("sp_layChiTietHoaDonTheoMa", ma);
        }
        public DataTable TONGTEN(string ma)
        {
            return hoadon_DAL.layDanhSachHoaDonChiTiet("tongthanhtien", ma);
        }
        public DataTable LAYDANHSACHRAP()
        {
            return hoadon_DAL.LayDanhSachHoaDon("sp_layDSRapChieu");
        }
        public DataTable LAYDANHSACHNHANVIEN()
        {
            return hoadon_DAL.LayDanhSachHoaDon("sp_layDSNhanVien");
        }
        public DataTable LAYDANHSACHKHACHHANG()
        {
            return hoadon_DAL.LayDanhSachHoaDon("sp_layDSKhachHang");
        }

        public bool THEMHOADON(HoaDon_DTO HoaDon)
        {
            return hoadon_DAL.ThemHoaDon(HoaDon);
        }
        public bool XOAHOADON(HoaDon_DTO HoaDon)
        {
            return hoadon_DAL.XoaHoaDon(HoaDon);
        }
        public bool SUAHOADON(HoaDon_DTO HoaDon)
        {
            return hoadon_DAL.SuaHoaDon(HoaDon);
        }
        public DataTable TIMKIEMHOADON(HoaDon_DTO HoaDon)
        {
            return hoadon_DAL.TimKiemHoaDon(HoaDon);
        }

        public string THANHTIEN(string ma)
        {
           return hoadon_DAL.thanhtien(ma);
        }
    }
}
