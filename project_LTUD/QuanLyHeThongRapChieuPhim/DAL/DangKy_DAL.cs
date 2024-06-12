using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DangKy_DAL
    {
        SqlConnectionData sqlData = new SqlConnectionData();
        SqlConnection conn;
        SqlCommand cmdDangKy;
        DangKy_DTO dangky_DTO = new DangKy_DTO();
        /// <summary>
        /// Menthod lấy danh sách đăng ký
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public DataTable LayDanhSachDangKy(string store)
        {
            return sqlData.LayDS(store);
        }
        public bool themDSDangKy(DangKy_DTO dangky)
        {
            int check = 0;
            try
            {
                // Kết nối database
                conn = sqlData.KetNoi();
                conn.Open();
                cmdDangKy = new SqlCommand();
                // Store thêm tài khoản đăng ký
                cmdDangKy.CommandText = "sp_insertTaiKhoan";
                cmdDangKy.CommandType = CommandType.StoredProcedure;
                cmdDangKy.Connection = conn;
                // Parameter
                SqlParameter maTK = new SqlParameter("@MaTK", dangky.MaTK);
                SqlParameter tenTk = new SqlParameter("@TenTK", dangky.TenTK);
                SqlParameter matkhau = new SqlParameter("@MatKhau", dangky.MatKhau);
                SqlParameter maquyen = new SqlParameter("@MaQuyen", dangky.MaQuyen);
                // Add Paramenter
                cmdDangKy.Parameters.Add(maTK);
                cmdDangKy.Parameters.Add(tenTk);
                cmdDangKy.Parameters.Add(matkhau);
                cmdDangKy.Parameters.Add(maquyen);
                // Check thêm thành công
                check = cmdDangKy.ExecuteNonQuery();
                if (check != 0)
                {
                    return true;
                }

            }
            catch (Exception u)
            {
                Console.WriteLine(u.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool xoaDSDangKy(DangKy_DTO dangky)
        {
            int check = 0;
            try
            {
                // Kết nối database
                conn = sqlData.KetNoi();
                conn.Open();
                cmdDangKy = new SqlCommand();
                // Store thêm tài khoản đăng ký
                cmdDangKy.CommandText = "sp_deleteTaiKhoan";
                cmdDangKy.CommandType = CommandType.StoredProcedure;
                cmdDangKy.Connection = conn;
                // Parameter
                SqlParameter maTK = new SqlParameter("@MaTK", dangky.MaTK);
                // Add Paramenter
                cmdDangKy.Parameters.Add(maTK);
                // Check thêm thành công
                check = cmdDangKy.ExecuteNonQuery();
                if (check != 0)
                {
                    return true;
                }

            }
            catch (Exception u)
            {
                Console.WriteLine(u.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool SuaDangKy(DangKy_DTO dangky)
        {
            try
            {
                // Kết nối database
                conn = sqlData.KetNoi();
                conn.Open();
                cmdDangKy = new SqlCommand();
                // Store thêm tài khoản đăng ký
                cmdDangKy.CommandText = "sp_updateTaiKhoan";
                cmdDangKy.CommandType = CommandType.StoredProcedure;
                cmdDangKy.Connection = conn;
                // Parameter
                SqlParameter maTK = new SqlParameter("@MaTK", dangky.MaTK);
                SqlParameter tenTk = new SqlParameter("@TenTK", dangky.TenTK);
                SqlParameter matkhau = new SqlParameter("@MatKhau", dangky.MatKhau);
                SqlParameter maquyen = new SqlParameter("@MaQuyen", dangky.MaQuyen);
                // Add Paramenter
                cmdDangKy.Parameters.Add(maTK);
                cmdDangKy.Parameters.Add(tenTk);
                cmdDangKy.Parameters.Add(matkhau);
                cmdDangKy.Parameters.Add(maquyen);
                // Check sủa thành công
                if (cmdDangKy.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception u)
            {
                Console.WriteLine(u.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
