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
    public class LichChieu_BUS
    {
        LichChieu_DAL lichchieu_DAL = new LichChieu_DAL();
        public DataTable LayDSMASHOW()
        {
            return lichchieu_DAL.LayDSMaShow("sp_layDSLichChieu");
        }
        public DataTable LayDSMAPHIM()
        {
            return lichchieu_DAL.LayDSMaPhim("sp_layDSPhim");
        }
        public DataTable LayDSMAPHONG()
        {
            return lichchieu_DAL.LayDSMaPhong("sp_layDSPhongChieu");
        }
        public bool THEMLICHCHIEU(LichChieu_DTO lichchieu)
        {
            return lichchieu_DAL.ThemLichChieu(lichchieu);
        }
        public bool XOALICHCHIEU(LichChieu_DTO lichchieu)
        {
            return lichchieu_DAL.XoaLichChieu(lichchieu);
        }
        public bool SUALICHCHIEU(LichChieu_DTO lichchieu)
        {
            return lichchieu_DAL.SuaLichChieu(lichchieu);
        }
        public DataTable TIMKIEMLICHCHIEU(LichChieu_DTO lichchieu)
        {
            return lichchieu_DAL.TimKiemLichChieu(lichchieu);
        }
    }
}
