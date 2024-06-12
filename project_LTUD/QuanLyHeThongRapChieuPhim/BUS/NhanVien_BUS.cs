using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NhanVien_BUS
    {
        NhanVien_DAL NhanVien_DAL = new NhanVien_DAL();
        public DataTable LAYDANHSACHNHANVIEN()
        {
            return NhanVien_DAL.LayDSNHANVIEN("sp_layDSNhanVien");
        }
        public DataTable LAYDANHSACHPHONGCHIEU()
        {
            return NhanVien_DAL.LayDSNHANVIEN("sp_layDSPhongChieu");
        }
        public bool THEMNHANVIEN(NhanVien_DTO NhanVien)
        {
            return NhanVien_DAL.Them(NhanVien);
        }
        public bool XOANHANVIEN(NhanVien_DTO NhanVien)
        {
            return NhanVien_DAL.Xoa(NhanVien);
        }
        public bool SUANHANVIEN(NhanVien_DTO NhanVien)
        {
            return NhanVien_DAL.Sua(NhanVien);
        }
        public DataTable TIMKIEMNHANVIEN(NhanVien_DTO NhanVien)
        {
            return NhanVien_DAL.TimKiem(NhanVien);
        }
    }
}
