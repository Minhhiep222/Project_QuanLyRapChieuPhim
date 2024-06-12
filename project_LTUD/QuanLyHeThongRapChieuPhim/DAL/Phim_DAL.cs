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
    public class Phim_DAL
    {
        SqlConnectionData SqlConnData = new SqlConnectionData();
        SqlConnection conn;
        SqlCommand cmdPhim;
        SqlDataAdapter daPhim;
        DataTable dtPhim;

        Phim_DTO phim_DTO = new Phim_DTO();

        public DataTable LayDanhSachPhim(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDanhSachTheLoai(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public bool ThemPhim(Phim_DTO phim)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdPhim = new SqlCommand();
                cmdPhim.CommandText = "sp_insertPhim";
                cmdPhim.CommandType = CommandType.StoredProcedure;
                cmdPhim.Connection = conn;
                SqlParameter MaPhim = new SqlParameter("@MaPhim", phim.MaPhim);
                SqlParameter tenPhim = new SqlParameter("@TenPhim", phim.TenPhim);
                SqlParameter TheLoai = new SqlParameter("@TheLoai", phim.TheLoai);
                SqlParameter Hangsx = new SqlParameter("@HangSX", phim.HangSX);
                //truyền tham số
                cmdPhim.Parameters.Add(MaPhim);
                cmdPhim.Parameters.Add(tenPhim);
                cmdPhim.Parameters.Add(TheLoai);
                cmdPhim.Parameters.Add(Hangsx);


                

                check = cmdPhim.ExecuteNonQuery();
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
        public bool XoaPhim(Phim_DTO phim)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdPhim = new SqlCommand();
                cmdPhim.CommandText = "sp_deletePhim";
                cmdPhim.CommandType = CommandType.StoredProcedure;
                cmdPhim.Connection = conn;

                SqlParameter maphim = new SqlParameter("@MaPhim", phim.MaPhim);

                cmdPhim.Parameters.Add(maphim);

                check = cmdPhim.ExecuteNonQuery();
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
        public bool SuaPhim(Phim_DTO phim)
        {

            try
            {

                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdPhim = new SqlCommand();
                cmdPhim.CommandText = "sp_updatePhim";
                cmdPhim.CommandType = CommandType.StoredProcedure;
                cmdPhim.Connection = conn;

                // tham số muốn sửa 
                SqlParameter maPhim = new SqlParameter("@MaPhim", phim.MaPhim);
                cmdPhim.Parameters.Add(maPhim);
                SqlParameter tenPhim = new SqlParameter("@TenPhim",phim.TenPhim);
                cmdPhim.Parameters.Add(tenPhim);
                SqlParameter TheLoai = new SqlParameter("@TheLoai", phim.TheLoai);
                cmdPhim.Parameters.Add(TheLoai);
                SqlParameter hangSX = new SqlParameter("@HangSX", phim.HangSX);
                cmdPhim.Parameters.Add(hangSX);

                if (cmdPhim.ExecuteNonQuery() > 0)
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
        public DataTable TimKiemPhim(Phim_DTO phim)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                cmdPhim = new SqlCommand();
                cmdPhim.CommandText = "sp_TimKiemPhim";
                cmdPhim.CommandType = CommandType.StoredProcedure;
                cmdPhim.Connection = conn;

                SqlParameter maphim = new SqlParameter("@MaPhim", phim.MaPhim);
                cmdPhim.Parameters.Add(maphim);

                daPhim = new SqlDataAdapter(cmdPhim);
                dtPhim = new DataTable();
                daPhim.Fill(dtPhim);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtPhim;
        }
    }
}
