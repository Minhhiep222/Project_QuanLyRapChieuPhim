using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDon_DAL
    {
        SqlConnectionData SqlConnData = new SqlConnectionData();
        SqlConnection conn;
        SqlCommand cmdHD;
        SqlDataAdapter daHD;
        DataTable dtHD;

        HoaDon_DTO HoaDon_DTO = new HoaDon_DTO();

        public DataTable LayDanhSachHoaDon(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDanhSachRap(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDanhSacNhanVien(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDanhSachKhachHang(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable layDanhSachHoaDonChiTiet(string store, string maVe)
        {
            try
            {
                dtHD = new DataTable();
                // Mở kết nối   ;
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdHD = new SqlCommand();
                // Câu truy vấn lấy danh sách phim
                cmdHD.CommandText = store;
                cmdHD.CommandType = CommandType.StoredProcedure;
                cmdHD.Connection = conn;

                //string mahd = 
                SqlParameter ma = new SqlParameter("@MaHD", maVe);
                cmdHD.Parameters.Add(ma);

                daHD = new SqlDataAdapter(cmdHD);


                daHD.Fill(dtHD);
            }           
            finally
            {
                conn.Close();
            }
            return dtHD;
        }
        public bool ThemHoaDon(HoaDon_DTO HD)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdHD = new SqlCommand();
                cmdHD.CommandText = "sp_insertHoaDon";
                cmdHD.CommandType = CommandType.StoredProcedure;
                cmdHD.Connection = conn;

                SqlParameter mahd = new SqlParameter("@MaHD", HD.MaHD);
                SqlParameter marap = new SqlParameter("@MaRap", HD.MaRap);
                SqlParameter manv = new SqlParameter("@MaNV", HD.MaNV);
                SqlParameter makh = new SqlParameter("@MaKH", HD.MaKH);

                cmdHD.Parameters.Add(mahd);
                cmdHD.Parameters.Add(marap);
                cmdHD.Parameters.Add(manv);
                cmdHD.Parameters.Add(makh);

                check = cmdHD.ExecuteNonQuery();
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
        public bool XoaHoaDon(HoaDon_DTO HD)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdHD = new SqlCommand();
                cmdHD.CommandText = "sp_deleteHoaDon";
                cmdHD.CommandType = CommandType.StoredProcedure;
                cmdHD.Connection = conn;

                SqlParameter mahd = new SqlParameter("@MaHD", HD.MaHD);

                cmdHD.Parameters.Add(mahd);

                check = cmdHD.ExecuteNonQuery();
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
        public bool SuaHoaDon(HoaDon_DTO HD)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdHD = new SqlCommand();
                cmdHD.CommandText = "sp_updateHoaDon";
                cmdHD.CommandType = CommandType.StoredProcedure;
                cmdHD.Connection = conn;

                SqlParameter mahd = new SqlParameter("@MaHD", HD.MaHD);
                SqlParameter marap = new SqlParameter("@MaRap", HD.MaRap);
                SqlParameter manv = new SqlParameter("@MaNV", HD.MaNV);
                SqlParameter makh = new SqlParameter("@MaKH", HD.MaKH);

                cmdHD.Parameters.Add(mahd);
                cmdHD.Parameters.Add(marap);
                cmdHD.Parameters.Add(manv);
                cmdHD.Parameters.Add(makh);


                if (cmdHD.ExecuteNonQuery() > 0)
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
        public DataTable TimKiemHoaDon(HoaDon_DTO HD)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdHD = new SqlCommand();
                cmdHD.CommandText = "sp_TimKiemHoaDon";
                cmdHD.CommandType = CommandType.StoredProcedure;
                cmdHD.Connection = conn;

                SqlParameter mahd = new SqlParameter("@MaHD",HD.MaHD);
                cmdHD.Parameters.Add(mahd);

                daHD = new SqlDataAdapter(cmdHD);
                dtHD = new DataTable();
                daHD.Fill(dtHD);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtHD;
        }

        public string thanhtien(string maHD)
        {
            string tien="";
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdHD = new SqlCommand();
                cmdHD.CommandText = "thanhtien";
                cmdHD.CommandType = CommandType.StoredProcedure;
                cmdHD.Connection = conn;

                SqlParameter mahd = new SqlParameter("@MaHD", maHD);
                cmdHD.Parameters.Add(mahd);

                tien = cmdHD.ExecuteReader().ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return tien;
           
        }
    }
}
