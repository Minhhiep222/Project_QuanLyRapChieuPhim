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
    public class KhachHang_BUS

    {      
        KhachHang_DAL khachang_DAL = new KhachHang_DAL();
        
        public DataTable LayDSKHACHHANG()
        {
            return khachang_DAL.LayDSKHACHHANG("sp_layDSKhachHang");
        }
        public bool themKHACHHANG(KhachHang_DTO khachhang)
        {
            return khachang_DAL.themKhachHang(khachhang);
        }
        public bool XOAKHACHHANG(KhachHang_DTO khachhang)
        {
            return khachang_DAL.XoaKhachHang(khachhang);
        }
        public bool SUAKHACHHANG(KhachHang_DTO khachhang)
        {
            return khachang_DAL.SuaKhachHang(khachhang);
        }
        public DataTable TIMKIEMKHACHHANG(KhachHang_DTO khachhang)
        {
            return khachang_DAL.TimKiemKhachHang(khachhang);
        }
    }
}
