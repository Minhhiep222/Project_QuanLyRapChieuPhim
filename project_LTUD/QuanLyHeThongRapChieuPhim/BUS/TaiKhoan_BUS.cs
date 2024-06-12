using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    
    public class TaiKhoan_BUS
    {
        TaiKhoanAccess tkAccess = new TaiKhoanAccess();
        public string CheckLogic(TaiKhoan_DTO taikhoan)
        {
            if(taikhoan.TenTK == "")
            {
                return "Yêu cầu tài khoản!";
            }
            if (taikhoan.MatKhau == "")
            {
                return "Yêu cầu mật khẩu!";
            }

            string info = tkAccess.CheckLogic(taikhoan);
            return info;
        }
    }
}
