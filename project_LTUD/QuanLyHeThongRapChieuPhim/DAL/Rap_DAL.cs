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
    public class Rap_DAL
    {
        SqlConnectionData SqlConnData = new SqlConnectionData();
        SqlConnection conn;
        SqlCommand cmdRap;
        SqlDataAdapter daRap;
        DataTable dtRap;
        Ve_DTO ve_DTO = new Ve_DTO();
        public DataTable LayDanhSachRap(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public bool ThemRap(Rap_DTO rap)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdRap = new SqlCommand();
                cmdRap.CommandText = "sp_insertRapChieu";
                cmdRap.CommandType = CommandType.StoredProcedure;
                cmdRap.Connection = conn;

                SqlParameter marap = new SqlParameter("@MaRap", rap.MaRap);
                SqlParameter tenrap = new SqlParameter("@TenRap", rap.TenRap);
                SqlParameter diachi = new SqlParameter("@DiaChi", rap.DiaChi);
                SqlParameter sdt = new SqlParameter("@SoDT", rap.Sdt);

                cmdRap.Parameters.Add(marap);
                cmdRap.Parameters.Add(tenrap);
                cmdRap.Parameters.Add(diachi);
                cmdRap.Parameters.Add(sdt);

                check = cmdRap.ExecuteNonQuery();
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
        public bool XoaRap(Rap_DTO rap)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdRap = new SqlCommand();
                cmdRap.CommandText = "sp_deleteRapChieu";
                cmdRap.CommandType = CommandType.StoredProcedure;
                cmdRap.Connection = conn;

                SqlParameter marap = new SqlParameter("@MaRap", rap.MaRap);

                cmdRap.Parameters.Add(marap);

                check = cmdRap.ExecuteNonQuery();
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
        public bool SuaRap(Rap_DTO rap)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdRap = new SqlCommand();
                cmdRap.CommandText = "sp_updateRapChieu";
                cmdRap.CommandType = CommandType.StoredProcedure;
                cmdRap.Connection = conn;

                SqlParameter marap = new SqlParameter("@MaRap", rap.MaRap);
                SqlParameter tenrap = new SqlParameter("@TenRap", rap.TenRap);
                SqlParameter diachi = new SqlParameter("@DiaChi", rap.DiaChi);
                SqlParameter sdt = new SqlParameter("@SoDT", rap.Sdt);

                cmdRap.Parameters.Add(marap);
                cmdRap.Parameters.Add(tenrap);
                cmdRap.Parameters.Add(diachi);
                cmdRap.Parameters.Add(sdt);

                if (cmdRap.ExecuteNonQuery() > 0)
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
        public DataTable TimKiemRap(Rap_DTO rap)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdRap = new SqlCommand();
                cmdRap.CommandText = "sp_TimKiemRap";
                cmdRap.CommandType = CommandType.StoredProcedure;
                cmdRap.Connection = conn;

                SqlParameter mave = new SqlParameter("@MaRap", rap.MaRap);
                cmdRap.Parameters.Add(mave);

                daRap = new SqlDataAdapter(cmdRap);
                dtRap = new DataTable();
                daRap.Fill(dtRap);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtRap;
        }
    }
}
