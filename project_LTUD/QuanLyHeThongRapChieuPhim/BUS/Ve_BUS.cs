using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class Ve_BUS
    {
        Ve_DAL ve_DAL = new Ve_DAL();

        public DataTable LayDSVE()
        {
            return ve_DAL.LayDSVe("sp_layDSVE");
        }
        public DataTable LayDSLICHCHIEU()
        {
            return ve_DAL.LayDSLichChieu("sp_layDSLichChieu");
        }
        public DataTable LayDSPHIM()
        {
            return ve_DAL.LayDSPhim("sp_layDSPhim");
        }
        public DataTable LayDSKHACHHANG()
        {
            return ve_DAL.LayDSKhachHang("sp_layDSKhachHang");
        }
        public DataTable LayDSHOADON()
        {
            return ve_DAL.LayDSHoaDon("sp_layDSHoaDon");
        }
        public bool THEMVE(Ve_DTO ve)
        {
            return ve_DAL.ThemVe(ve);
        }
        public bool XOAVE(Ve_DTO ve)
        {
            return ve_DAL.XoaVe(ve);
        }
        public bool SUAVE(Ve_DTO ve)
        {
            return ve_DAL.SuaVe(ve);
        }
        public DataTable TIMKIEMVE(Ve_DTO ve)
        {
            return ve_DAL.TimKiemVe(ve);
        }

        public DataTable LaySoGhe()
        {
            return ve_DAL.LayDSGhe("layghe");
        }
    }
}
