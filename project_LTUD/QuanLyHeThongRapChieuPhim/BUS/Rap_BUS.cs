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
    public class Rap_BUS
    {
        Rap_DAL rap_DAL = new Rap_DAL();
        public DataTable LAYDANHSACHRAP()
        {
            return rap_DAL.LayDanhSachRap("sp_layDSRapChieu");
        }
        public bool THEMRAP(Rap_DTO rap)
        {
            return rap_DAL.ThemRap(rap);
        }
        public bool XOARAP(Rap_DTO rap)
        {
            return rap_DAL.XoaRap(rap);
        }
        public bool SUARAP(Rap_DTO rap)
        {
            return rap_DAL.SuaRap(rap);
        }
        public DataTable TIMKIEMRAP(Rap_DTO rap)
        {
            return rap_DAL.TimKiemRap(rap);
        }
    }
}
