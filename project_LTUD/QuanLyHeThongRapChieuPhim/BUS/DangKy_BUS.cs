using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAL;

namespace BUS
{
    public class DangKy_BUS
    {
        
        DangKy_DAL dangky_DAL = new DangKy_DAL();
       
        SqlConnectionData conn = new SqlConnectionData();
        public DataTable LAYDANHSACHDANGKY()
        {
            return dangky_DAL.LayDanhSachDangKy("sp_LayDSTaiKhoan");
        }
        public bool THEMDSDANGKY(DangKy_DTO dangky)
        {
            return dangky_DAL.themDSDangKy(dangky);
        }
        public bool XOADSDANGKY(DangKy_DTO dangky)
        {
            return dangky_DAL.xoaDSDangKy(dangky);
        }
        public bool SUADSDANGKY(DangKy_DTO dangky)
        {
            return dangky_DAL.SuaDangKy(dangky);
        }

        public SqlConnection ketnoi()
        {
            return conn.KetNoi();
        }
        
    }
}
