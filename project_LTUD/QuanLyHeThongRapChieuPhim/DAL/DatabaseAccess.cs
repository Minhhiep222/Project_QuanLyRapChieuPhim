using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{

    public class DatabaseAccess
    {
        SqlConnectionData SqlConnData = new SqlConnectionData();
        public string CheckLogicDTO(TaiKhoan_DTO taikhoan)
        {
            string user = null;
            //kết nối tới cơ sở dữ liệu
            SqlConnection conn = SqlConnData.KetNoi();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_Logic";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", taikhoan.TenTK);
            cmd.Parameters.AddWithValue("@pass", taikhoan.MatKhau);
            //Kiểm tra quyền 
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            //kiểm tra
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }
            return user;

        }
    }
}
