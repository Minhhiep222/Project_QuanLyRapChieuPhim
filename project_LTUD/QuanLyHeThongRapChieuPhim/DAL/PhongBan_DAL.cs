using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace DAO
{
    public class PhongBan_DAL
    {
        SqlConnectionData SqlConnData = new SqlConnectionData();
        SqlConnection conn;
        SqlCommand cmdPhongBan;
        SqlDataAdapter daPhongBan;
        DataTable dtPhongBan;

        PhongBan_DTO phongBan_DTO = new PhongBan_DTO();

        public DataTable LayDanhSachPhongBan(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDanhSachRap(string store)
        {
            return SqlConnData.LayDS(store);
        }

        public bool ThemPhongBan(PhongBan_DTO phongban)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdPhongBan = new SqlCommand();
                cmdPhongBan.CommandText = "sp_insertPhongBan";
                cmdPhongBan.CommandType = CommandType.StoredProcedure;
                cmdPhongBan.Connection = conn;
                //lấy dữ liệu
                SqlParameter MaPhongBan = new SqlParameter("@MaPhongBan", phongban.MaPhongBan);
                SqlParameter MaRap = new SqlParameter("@MaRap", phongban.MaRap);
                SqlParameter TruongPhong = new SqlParameter("@TrPhG", phongban.TruongPhong);

                //truyền tham số
                cmdPhongBan.Parameters.Add(MaPhongBan);
                cmdPhongBan.Parameters.Add(MaRap);
                cmdPhongBan.Parameters.Add(TruongPhong);

                check = cmdPhongBan.ExecuteNonQuery();
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
        public bool XoaPhongBan(PhongBan_DTO phongban)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdPhongBan = new SqlCommand();
                cmdPhongBan.CommandText = "sp_deletePhongBan";
                cmdPhongBan.CommandType = CommandType.StoredProcedure;
                cmdPhongBan.Connection = conn;

                SqlParameter maphong = new SqlParameter("@MaPhongBan", phongban.MaPhongBan);

                cmdPhongBan.Parameters.Add(maphong);

                check = cmdPhongBan.ExecuteNonQuery();
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
        public bool SuaPhongBan(PhongBan_DTO phongban)
        {

            try
            {

                conn = SqlConnData.KetNoi();
                conn.Open();

                cmdPhongBan = new SqlCommand();
                cmdPhongBan.CommandText = "sp_updatePhongBan";
                cmdPhongBan.CommandType = CommandType.StoredProcedure;
                cmdPhongBan.Connection = conn;
                //lấy dữ liệu
                SqlParameter MaPhongBan = new SqlParameter("@MaPhongBan", phongban.MaPhongBan);
                SqlParameter MaRap = new SqlParameter("@MaRap", phongban.MaRap);
                SqlParameter TruongPhong = new SqlParameter("@TrPhG", phongban.TruongPhong);

                //truyền tham số
                cmdPhongBan.Parameters.Add(MaPhongBan);
                cmdPhongBan.Parameters.Add(MaRap);
                cmdPhongBan.Parameters.Add(TruongPhong);
        
                if (cmdPhongBan.ExecuteNonQuery() > 0)
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
        public DataTable TimKiemPhongBan(PhongBan_DTO phongban)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdPhongBan = new SqlCommand();
                cmdPhongBan.CommandText = "sp_TimKiemPhongBan";
                cmdPhongBan.CommandType = CommandType.StoredProcedure;
                cmdPhongBan.Connection = conn;
              

                SqlParameter maphong = new SqlParameter("@MaPhongBan", phongban.MaPhongBan);
                cmdPhongBan.Parameters.Add(maphong);

                daPhongBan = new SqlDataAdapter(cmdPhongBan);
                dtPhongBan = new DataTable();
                daPhongBan.Fill(dtPhongBan);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtPhongBan;
        }
    }
}
