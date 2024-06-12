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
    public class PhongBan_BUS
    {
        PhongBan_DAL phongban_DAL = new PhongBan_DAL();
        public DataTable LAYDANHSACHPHONGBAN()
        {
            return phongban_DAL.LayDanhSachPhongBan("sp_layDSPhongBan");
        }
        public DataTable LAYDANHSACHRAP()
        {
            return phongban_DAL.LayDanhSachPhongBan("sp_layDSRapChieu");
        }

        public bool THEMPHONGBAN(PhongBan_DTO phongban)
        {
            return phongban_DAL.ThemPhongBan(phongban);
        }
        public bool XOAPHONGBAN(PhongBan_DTO phongban)
        {
            return phongban_DAL.XoaPhongBan(phongban);
        }
        public bool SUAPHONGBAN(PhongBan_DTO phongban)
        {
            return phongban_DAL.SuaPhongBan(phongban);
        }
        public DataTable TIMKIEMPHONGBAN(PhongBan_DTO phongban)
        {
            return phongban_DAL.TimKiemPhongBan(phongban);
        }
    }
}
