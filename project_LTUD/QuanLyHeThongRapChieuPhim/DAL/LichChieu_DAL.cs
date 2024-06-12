using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class LichChieu_DAL
    {
        SqlConnectionData SqlConnData = new SqlConnectionData();
        SqlConnection conn;
        SqlCommand cmdLichChieu;
        SqlDataAdapter daLichChieu;
        DataTable dtLichChieu;

        LichChieu_DTO lichchieu_DTO = new LichChieu_DTO();
        public DataTable LayDSMaShow(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDSMaPhim(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDSMaPhong(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public bool ThemLichChieu(LichChieu_DTO lichchieu)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdLichChieu = new SqlCommand();
                cmdLichChieu.CommandText = "sp_insertLichChieu";
                cmdLichChieu.CommandType = CommandType.StoredProcedure;
                cmdLichChieu.Connection = conn;

                SqlParameter mashow = new SqlParameter("@MaShow", lichchieu.MaShow);
                SqlParameter maphim = new SqlParameter("@MaPhim", lichchieu.MaPhim);
                SqlParameter maphong = new SqlParameter("@MaPhong", lichchieu.MaPhong);
                SqlParameter ngaychieu = new SqlParameter("@Ngaychieu", lichchieu.NgayChieu);
                SqlParameter giochieu = new SqlParameter("@giochieu", lichchieu.GioChieu);

                cmdLichChieu.Parameters.Add(mashow);
                cmdLichChieu.Parameters.Add(maphim);
                cmdLichChieu.Parameters.Add(maphong);
                cmdLichChieu.Parameters.Add(ngaychieu);
                cmdLichChieu.Parameters.Add(giochieu);
                check = cmdLichChieu.ExecuteNonQuery();
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
        public bool XoaLichChieu(LichChieu_DTO lichchieu)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdLichChieu = new SqlCommand();
                cmdLichChieu.CommandText = "sp_deleteLichChieu";
                cmdLichChieu.CommandType = CommandType.StoredProcedure;
                cmdLichChieu.Connection = conn;

                SqlParameter mashow = new SqlParameter("@MaShow", lichchieu.MaShow);

                cmdLichChieu.Parameters.Add(mashow);

                check = cmdLichChieu.ExecuteNonQuery();
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
        public bool SuaLichChieu(LichChieu_DTO lichchieu)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdLichChieu = new SqlCommand();
                cmdLichChieu.CommandText = "sp_updateLichChieu";
                cmdLichChieu.CommandType = CommandType.StoredProcedure;
                cmdLichChieu.Connection = conn;

                SqlParameter mashow = new SqlParameter("@MaShow", lichchieu.MaShow);
                SqlParameter maphim = new SqlParameter("@MaPhim", lichchieu.MaPhim);
                SqlParameter maphong = new SqlParameter("@MaPhong", lichchieu.MaPhong);
                SqlParameter ngaychieu = new SqlParameter("@Ngaychieu", lichchieu.NgayChieu);
                SqlParameter giochieu = new SqlParameter("@giochieu", lichchieu.GioChieu);

                cmdLichChieu.Parameters.Add(mashow);
                cmdLichChieu.Parameters.Add(maphim);
                cmdLichChieu.Parameters.Add(maphong);
                cmdLichChieu.Parameters.Add(ngaychieu);
                cmdLichChieu.Parameters.Add(giochieu);
                if (cmdLichChieu.ExecuteNonQuery() > 0)
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
        public DataTable TimKiemLichChieu(LichChieu_DTO lichchieu)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdLichChieu = new SqlCommand();
                cmdLichChieu.CommandText = "sp_TimThongTinKiemLichChieu";
                cmdLichChieu.CommandType = CommandType.StoredProcedure;
                cmdLichChieu.Connection = conn;

                SqlParameter mashow = new SqlParameter("@MaShow", lichchieu.MaShow);
                cmdLichChieu.Parameters.Add(mashow);

                daLichChieu = new SqlDataAdapter(cmdLichChieu);
                dtLichChieu = new DataTable();
                daLichChieu.Fill(dtLichChieu);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtLichChieu;
        }
    }
}
