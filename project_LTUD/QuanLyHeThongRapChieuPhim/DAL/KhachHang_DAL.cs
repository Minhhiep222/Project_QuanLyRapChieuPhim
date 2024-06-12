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
    public class KhachHang_DAL
    {
        SqlConnectionData SqlConnData = new SqlConnectionData();
        SqlConnection conn;
        SqlCommand cmdKhachHang;
        SqlDataAdapter daKhachHang;
        DataTable dtKhachHang;

        KhachHang_DTO khachHang_DTO = new KhachHang_DTO();

        public DataTable LayDSKHACHHANG(string store)
        {
            return SqlConnData.LayDS(store);
        }

        public bool themKhachHang(KhachHang_DTO khachhang)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                //mở kết nối 
                conn.Open();
                cmdKhachHang = new SqlCommand();
                //truy vấn dữ liệu thêm khách hànhg
                cmdKhachHang.CommandText = "sp_insertKhachHang";
                cmdKhachHang.CommandType = CommandType.StoredProcedure;
                cmdKhachHang.Connection = conn;
                //parameter 
                SqlParameter ma = new SqlParameter("@MaKH", khachhang.MaKH);
                SqlParameter ten = new SqlParameter("@TenKH", khachhang.TenKH);
                SqlParameter diachi = new SqlParameter("@Diachi", khachhang.Diachi);
                SqlParameter gioitinh = null;
                if (khachhang.GioiTinh == "Nam")
                {
                    gioitinh = new SqlParameter("@GioiTinh", "Nam");
                }
                if (khachhang.GioiTinh == "Nữ")
                {
                    gioitinh = new SqlParameter("@GioiTinh", "Nữ");
                }
                SqlParameter sdt = new SqlParameter("@SDT", khachhang.SDT);
                SqlParameter ngaysinh = new SqlParameter("@Ngaysinh", khachhang.Ngaysinh);
                //thêm dữ liệu
                cmdKhachHang.Parameters.Add(ma);
                cmdKhachHang.Parameters.Add(ten);
                cmdKhachHang.Parameters.Add(diachi);
                cmdKhachHang.Parameters.Add(gioitinh);
                cmdKhachHang.Parameters.Add(sdt);
                cmdKhachHang.Parameters.Add(ngaysinh);
                //check xóa dữ liệu
                check = cmdKhachHang.ExecuteNonQuery();
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
        public bool XoaKhachHang(KhachHang_DTO khachhang)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                //mở kết nối 
                conn.Open();
                cmdKhachHang = new SqlCommand();
                //câu truy vấn xóa khách hàng bằng mã khách hàng
                cmdKhachHang.CommandText = "sp_deleteKhachHang";
                cmdKhachHang.CommandType = CommandType.StoredProcedure;
                //kết nối 
                cmdKhachHang.Connection = conn;
                //thêm tham số cần xóa
                //prapare
                SqlParameter makh = new SqlParameter("@MaKH", khachhang.MaKH);
                cmdKhachHang.Parameters.Add(makh);
                //check xóa dữ liệu
                check = cmdKhachHang.ExecuteNonQuery();
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
        public bool SuaKhachHang(KhachHang_DTO khachhang)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                //mở kết nối 
                conn.Open();
                cmdKhachHang = new SqlCommand();
                //truy vấn dữ liệu thêm khách hànhg
                cmdKhachHang.CommandText = "sp_updateKhachHang";
                cmdKhachHang.CommandType = CommandType.StoredProcedure;
                cmdKhachHang.Connection = conn;
                //parameter 
                SqlParameter ma = new SqlParameter("@MaKH", khachhang.MaKH);
                SqlParameter ten = new SqlParameter("@TenKH", khachhang.TenKH);
                SqlParameter diachi = new SqlParameter("@Diachi", khachhang.Diachi);
                SqlParameter gioitinh = null;
                if (khachhang.GioiTinh == "Nam")
                {
                    gioitinh = new SqlParameter("@GioiTinh", "Nam");
                }
                if (khachhang.GioiTinh == "Nữ")
                {
                    gioitinh = new SqlParameter("@GioiTinh", "Nữ");
                }
                SqlParameter sdt = new SqlParameter("@SDT", khachhang.SDT);
                SqlParameter ngaysinh = new SqlParameter("@Ngaysinh", khachhang.Ngaysinh);
                //thêm dữ liệu
                cmdKhachHang.Parameters.Add(ma);
                cmdKhachHang.Parameters.Add(ten);
                cmdKhachHang.Parameters.Add(diachi);
                cmdKhachHang.Parameters.Add(gioitinh);
                cmdKhachHang.Parameters.Add(sdt);
                cmdKhachHang.Parameters.Add(ngaysinh);
                //trả về kết quả
                if (cmdKhachHang.ExecuteNonQuery() > 0)
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
        public DataTable TimKiemKhachHang(KhachHang_DTO khachhang)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                //khởi tạo
                cmdKhachHang = new SqlCommand();
                //câu truy vấn tìm kiếm khách hàng
                cmdKhachHang.CommandText = "sp_TimKiemThongTinKhachHang";
                //
                cmdKhachHang.CommandType = CommandType.StoredProcedure;
                //kết nối
                cmdKhachHang.Connection = conn;
                //lấy dữ liệu
                SqlParameter ma = new SqlParameter("@MaKH", khachhang.MaKH);
                //truyền tham số
                cmdKhachHang.Parameters.Add(ma);

                daKhachHang = new SqlDataAdapter(cmdKhachHang);
                dtKhachHang = new DataTable();
                daKhachHang.Fill(dtKhachHang);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtKhachHang;
        }
    }
}
