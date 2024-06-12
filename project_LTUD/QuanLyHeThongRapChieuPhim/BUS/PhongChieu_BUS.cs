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
    public class PhongChieu_BUS
    {
        PhongChieu_DAL phongchieu_DAL = new PhongChieu_DAL();
        public DataTable LAYDANHSACHPHONGCHIEU()
        {
            return phongchieu_DAL.LayDanhSachPhongChieu("sp_layDSPhongChieu");
        }
        public DataTable LAYDANHSACHRAP()
        {
            return phongchieu_DAL.LayDanhSachPhongChieu("sp_layDSRapChieu");
        }
        public bool THEMPHONGCHIEU(PhongChieu_DTO phongchieu)
        {
            return phongchieu_DAL.ThemPhongChieu(phongchieu);
        }
        public bool XOAPHONGCHIEU(PhongChieu_DTO phongchieu)
        {
            return phongchieu_DAL.XoaPhongChieu(phongchieu);
        }
        public bool SUAPHONGCHIEU(PhongChieu_DTO phongchieu)
        {
            return phongchieu_DAL.SuaPhongChieu(phongchieu);
        }
        public DataTable TIMKIEMPHONGCHIEU(PhongChieu_DTO phongchieu)
        {
            return phongchieu_DAL.TimKiemPhongChieu(phongchieu);
        }
    }
}
