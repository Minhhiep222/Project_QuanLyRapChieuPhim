using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
using DAO;

namespace BUS
{
    public class Phim_BUS
    {
        Phim_DAL phim_DAL =new Phim_DAL();
        public DataTable LAYDANHSACHPHIM()
        {
            return phim_DAL.LayDanhSachPhim("sp_layDSPhim");
        }
        public DataTable LAYDANHSACHTHELOAIPHIM()
        {
            return phim_DAL.LayDanhSachPhim("sp_layDSTheLoai");
        }
        public bool THEMPHIM(Phim_DTO phim)
        {
            return phim_DAL.ThemPhim(phim);
        }
        public bool XOAPHIM(Phim_DTO phim)
        {
            return phim_DAL.XoaPhim(phim);
        }
        public bool SUAPHIM(Phim_DTO phim)
        {
            return phim_DAL.SuaPhim(phim);
        }
        public DataTable TIMKIEMPHIM(Phim_DTO phim)
        {
            return phim_DAL.TimKiemPhim(phim);
        }
    }
    
}
