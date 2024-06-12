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
    public class PhongChieu_DAL
    {
        SqlConnectionData SqlConnData = new SqlConnectionData();
        SqlConnection conn;
        SqlCommand cmdPhongChieu;
        SqlDataAdapter daPhongChieu;
        DataTable dtPhongChieu;

        PhongChieu_DTO phongChieu_DTO = new PhongChieu_DTO();

        public DataTable LayDanhSachPhongChieu(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDanhSachRap(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public bool ThemPhongChieu(PhongChieu_DTO phongchieu)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdPhongChieu = new SqlCommand();
                cmdPhongChieu.CommandText = "sp_insertPhongChieu";
                cmdPhongChieu.CommandType = CommandType.StoredProcedure;
                cmdPhongChieu.Connection = conn;
                SqlParameter MaPhong = new SqlParameter("@MaPhong", phongchieu.MaPhong);
                SqlParameter MaRap = new SqlParameter("@MaRap", phongchieu.MaRap);
                SqlParameter TenPhong = new SqlParameter("@TenPhong", phongchieu.TenPhong);
                SqlParameter TongSoGhe = new SqlParameter("@Tongsoghe", phongchieu.TongSoGhe);


                //truyền tham số
                cmdPhongChieu.Parameters.Add(MaPhong);
                cmdPhongChieu.Parameters.Add(MaRap);
                cmdPhongChieu.Parameters.Add(TenPhong);
                cmdPhongChieu.Parameters.Add(TongSoGhe);
                




                check = cmdPhongChieu.ExecuteNonQuery();
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
        public bool XoaPhongChieu(PhongChieu_DTO phongchieu)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdPhongChieu = new SqlCommand();
                cmdPhongChieu.CommandText = "sp_deletePhongChieu";
                cmdPhongChieu.CommandType = CommandType.StoredProcedure;
                cmdPhongChieu.Connection = conn;

                SqlParameter maphong = new SqlParameter("@MaPhong", phongchieu.MaPhong);

                cmdPhongChieu.Parameters.Add(maphong);

                check = cmdPhongChieu.ExecuteNonQuery();
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
        public bool SuaPhongChieu(PhongChieu_DTO phongchieu)
        {

            try
            {

                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdPhongChieu = new SqlCommand();
                cmdPhongChieu.CommandText = "sp_updatePhongChieu";
                cmdPhongChieu.CommandType = CommandType.StoredProcedure;
                cmdPhongChieu.Connection = conn;
                SqlParameter MaPhong = new SqlParameter("@MaPhong", phongchieu.MaPhong);
                SqlParameter MaRap = new SqlParameter("@MaRap", phongchieu.MaRap);
                SqlParameter TenPhong = new SqlParameter("@TenPhong", phongchieu.TenPhong);
                SqlParameter TongSoGhe = new SqlParameter("@Tongsoghe", phongchieu.TongSoGhe);


                //truyền tham số
                cmdPhongChieu.Parameters.Add(MaPhong);
                cmdPhongChieu.Parameters.Add(MaRap);
                cmdPhongChieu.Parameters.Add(TenPhong);
                cmdPhongChieu.Parameters.Add(TongSoGhe);

        

                if (cmdPhongChieu.ExecuteNonQuery() > 0)
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
        public DataTable TimKiemPhongChieu(PhongChieu_DTO phongchieu)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdPhongChieu = new SqlCommand();
                cmdPhongChieu.CommandText = "sp_TimKiemPhongChieu";
                cmdPhongChieu.CommandType = CommandType.StoredProcedure;
                cmdPhongChieu.Connection = conn;

                SqlParameter maphong = new SqlParameter("@MaPhong", phongchieu.MaPhong);
                cmdPhongChieu.Parameters.Add(maphong);

                daPhongChieu = new SqlDataAdapter(cmdPhongChieu);
                dtPhongChieu = new DataTable();
                daPhongChieu.Fill(dtPhongChieu);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtPhongChieu;
        }
    }
}
