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
    public class Ve_DAL
    {
        SqlConnectionData SqlConnData = new SqlConnectionData();
        SqlConnection conn;
        SqlCommand cmdVe;
        SqlDataAdapter daVe;
        DataTable dtVe;

        Ve_DTO ve_DTO = new Ve_DTO();
        public DataTable LayDSVe(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDSLichChieu(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDSPhim(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDSKhachHang(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDSHoaDon(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDSGhe(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public bool ThemVe(Ve_DTO ve)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdVe = new SqlCommand();
                cmdVe.CommandText = "sp_insertVe";
                cmdVe.CommandType = CommandType.StoredProcedure;
                cmdVe.Connection = conn;

                SqlParameter mave = new SqlParameter("@MaVe", ve.MaVe);
                SqlParameter mashow = new SqlParameter("@MaShow", ve.MaShow);
                SqlParameter maphim = new SqlParameter("@MaPhim", ve.MaPhim);
                SqlParameter giave = new SqlParameter("@GiaVe", ve.GiaVe);
                SqlParameter mahd = new SqlParameter("@MaHD", ve.MaHD);
                SqlParameter ghe = new SqlParameter("@Ghe", ve.Ghe);

                cmdVe.Parameters.Add(mave);
                cmdVe.Parameters.Add(mashow);
                cmdVe.Parameters.Add(maphim);
                cmdVe.Parameters.Add(giave);
                cmdVe.Parameters.Add(mahd);
                cmdVe.Parameters.Add(ghe);
                check = cmdVe.ExecuteNonQuery();
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
        public bool XoaVe(Ve_DTO ve)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdVe = new SqlCommand();
                cmdVe.CommandText = "sp_deleteVe";
                cmdVe.CommandType = CommandType.StoredProcedure;
                cmdVe.Connection = conn;

                SqlParameter mave = new SqlParameter("@MaVe", ve.MaVe);
                cmdVe.Parameters.Add(mave);

                check = cmdVe.ExecuteNonQuery();
                if (check != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool SuaVe(Ve_DTO ve)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdVe = new SqlCommand();
                cmdVe.CommandText = "sp_updateVe";
                cmdVe.CommandType = CommandType.StoredProcedure;
                cmdVe.Connection = conn;

                SqlParameter mave = new SqlParameter("@MaVe", ve.MaVe);
                SqlParameter mashow = new SqlParameter("@MaShow", ve.MaShow);
                SqlParameter maphim = new SqlParameter("@MaPhim", ve.MaPhim);
                SqlParameter giave = new SqlParameter("@GiaVe", ve.GiaVe);
                SqlParameter mahd = new SqlParameter("@MaHD", ve.MaHD);
                SqlParameter ghe = new SqlParameter("@Ghe", ve.Ghe);
                 
                cmdVe.Parameters.Add(mave);
                cmdVe.Parameters.Add(mashow);
                cmdVe.Parameters.Add(maphim);
                cmdVe.Parameters.Add(giave);
                cmdVe.Parameters.Add(mahd);
                cmdVe.Parameters.Add(ghe);
                if(cmdVe.ExecuteNonQuery() > 0)
                {
                    return true;    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public DataTable TimKiemVe(Ve_DTO ve)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdVe = new SqlCommand();
                cmdVe.CommandText = "sp_TimKiemVe";
                cmdVe.CommandType = CommandType.StoredProcedure;
                cmdVe.Connection = conn;

                SqlParameter mave = new SqlParameter("@MaVe", ve.MaVe);
                cmdVe.Parameters.Add(mave);

                daVe = new SqlDataAdapter(cmdVe);
                dtVe = new DataTable();
                daVe.Fill(dtVe);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtVe;
        }
    }
}
