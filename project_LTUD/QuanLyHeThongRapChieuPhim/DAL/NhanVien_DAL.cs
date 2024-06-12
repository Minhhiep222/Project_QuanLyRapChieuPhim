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
    public class NhanVien_DAL
    {
        SqlConnectionData SqlConnData = new SqlConnectionData();
        SqlConnection conn;
        SqlCommand cmdNV;
        SqlDataAdapter daNV;
        DataTable dtNV;

        NhanVien_DTO nhanvien_DTO = new NhanVien_DTO();

        public DataTable LayDSNHANVIEN(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public DataTable LayDanhSachPhongChieu(string store)
        {
            return SqlConnData.LayDS(store);
        }
        public bool Them(NhanVien_DTO NV)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                //mở kết nối 
                conn.Open();

                cmdNV = new SqlCommand();
                //truy vấn dữ liệu thêm khách hànhg
                cmdNV.CommandText = "sp_insertNhanVien";

                cmdNV.CommandType = CommandType.StoredProcedure;

                cmdNV.Connection = conn;

                //parameter 
                SqlParameter ma = new SqlParameter("@MaNV", NV.MaNV);
                SqlParameter cccd = new SqlParameter("@CCCD", NV.CCCD);
                SqlParameter ho = new SqlParameter("@HoNV", NV.HoNV);
                SqlParameter ten = new SqlParameter("@TenNV", NV.Tennv);
                SqlParameter diachi = new SqlParameter("@Diachi", NV.Diachi);
                SqlParameter sdt = new SqlParameter("@SDT", NV.SDT);
                SqlParameter gioitinh = null;
                if (NV.GioiTinh == "Nam")
                {
                    gioitinh = new SqlParameter("@GioiTinh", "Nam");
                }
                if (NV.GioiTinh == "Nữ")
                {
                    gioitinh = new SqlParameter("@GioiTinh", "Nữ");
                }

                SqlParameter ngaysinh = new SqlParameter("@Ngaysinh", NV.Ngaysinh);
                SqlParameter luong = new SqlParameter("@Luong", NV.Luong);
                SqlParameter maphong = new SqlParameter("@MaPhong", NV.MaPhong);

                //thêm dữ liệu
                cmdNV.Parameters.Add(ma);
                cmdNV.Parameters.Add(cccd);
                cmdNV.Parameters.Add(ho);
                cmdNV.Parameters.Add(ten);
                cmdNV.Parameters.Add(sdt);
                cmdNV.Parameters.Add(diachi);
                cmdNV.Parameters.Add(gioitinh);
                cmdNV.Parameters.Add(ngaysinh);
                cmdNV.Parameters.Add(luong);
                cmdNV.Parameters.Add(maphong);

               
              
                //check xóa dữ liệu
                check = cmdNV.ExecuteNonQuery();
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
        public bool Xoa(NhanVien_DTO NV)
        {
            int check = 0;
            try
            {
                conn = SqlConnData.KetNoi();
                //mở kết nối 
                conn.Open();
                cmdNV = new SqlCommand();
                //câu truy vấn xóa khách hàng bằng mã khách hàng
                cmdNV.CommandText = "sp_deleteNhanVien";
                cmdNV.CommandType = CommandType.StoredProcedure;
                //kết nối 
                cmdNV.Connection = conn;
                //thêm tham số cần xóa
                //prapare
                SqlParameter manv = new SqlParameter("@MaNV", NV.MaNV);
                cmdNV.Parameters.Add(manv);
                //check xóa dữ liệu
                check = cmdNV.ExecuteNonQuery();
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
        public bool Sua(NhanVien_DTO NV)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                //mở kết nối 
                conn.Open();
                cmdNV = new SqlCommand();
                //truy vấn dữ liệu thêm khách hànhg
                cmdNV.CommandText = "sp_updateNhanVien";

                cmdNV.CommandType = CommandType.StoredProcedure;

                cmdNV.Connection = conn;

                //parameter 
                SqlParameter ma = new SqlParameter("@MaNV", NV.MaNV);
                SqlParameter cccd = new SqlParameter("@CCCD", NV.CCCD);
                SqlParameter ho = new SqlParameter("@HoNV", NV.HoNV);
                SqlParameter ten = new SqlParameter("@TenNV", NV.Tennv);
                SqlParameter diachi = new SqlParameter("@Diachi", NV.Diachi);
                SqlParameter sdt = new SqlParameter("@SDT", NV.SDT);
                SqlParameter gioitinh = null;
                if (NV.GioiTinh == "Nam")
                {
                    gioitinh = new SqlParameter("@GioiTinh", "Nam");
                }
                if (NV.GioiTinh == "Nữ")
                {
                    gioitinh = new SqlParameter("@GioiTinh", "Nữ");
                }

                SqlParameter ngaysinh = new SqlParameter("@Ngaysinh", NV.Ngaysinh);
                SqlParameter luong = new SqlParameter("@Luong", NV.Luong);
                SqlParameter maphong = new SqlParameter("@MaPhong", NV.MaPhong);

                //thêm dữ liệu
                cmdNV.Parameters.Add(ma);
                cmdNV.Parameters.Add(cccd);
                cmdNV.Parameters.Add(ho);
                cmdNV.Parameters.Add(ten);
                cmdNV.Parameters.Add(sdt);
                cmdNV.Parameters.Add(diachi);
                cmdNV.Parameters.Add(gioitinh);
                cmdNV.Parameters.Add(ngaysinh);
                cmdNV.Parameters.Add(luong);
                cmdNV.Parameters.Add(maphong);
                //trả về kết quả
                if (cmdNV.ExecuteNonQuery() > 0)
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
        public DataTable TimKiem(NhanVien_DTO NV)
        {
            try
            {
                conn = SqlConnData.KetNoi();
                conn.Open();
                //khởi tạo
                cmdNV = new SqlCommand();
                //câu truy vấn tìm kiếm khách hàng
                cmdNV.CommandText = "sp_TimKiemNhanVien";
                //
                cmdNV.CommandType = CommandType.StoredProcedure;
                //kết nối
                cmdNV.Connection = conn;
                //lấy dữ liệu
                SqlParameter ma = new SqlParameter("@MaNV", NV.MaNV);
                //truyền tham số
                cmdNV.Parameters.Add(ma);

                daNV = new SqlDataAdapter(cmdNV);
                dtNV = new DataTable();
                daNV.Fill(dtNV);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtNV;
        }
    }
}
