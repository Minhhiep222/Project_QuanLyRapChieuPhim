using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;

namespace GUI
{
    public partial class GUI_BaoCaoPhimVaPhong : Form
    {
        DangKy_BUS DangKy = new DangKy_BUS();
        public GUI_BaoCaoPhimVaPhong()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private void frmBaoCaoPhimVaPhong_Load(object sender, EventArgs e)
        {
            cbPhongChieu.DataSource = layDanhSach("sp_layDSPhongChieu");
            cbPhongChieu.ValueMember = "MaPhong";
            cbPhongChieu.DisplayMember = "MaPhong";
            cbTheLoai.DataSource = layDanhSach("sp_layDSTheLoai");
            cbTheLoai.ValueMember = "TheLoai";
            cbTheLoai.DisplayMember = "TheLoai";
            cbSX.DataSource = layDanhSach("sp_LaySX");
            cbSX.ValueMember = "hangsx";
            cbSX.DisplayMember = "hangsx";
        }
        public DataTable layDanhSach(string store)
        {
            try
            {
                // Mở kết nối
                conn = DangKy.ketnoi();
                conn.Open();
                cmd = new SqlCommand();
                // Câu truy vấn lấy danh sách phim
                cmd.CommandText = store;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable layDanhSachPhongChieu(string store)
        {
            try
            {
                // Mở kết nối
                conn = DangKy.ketnoi();
                conn.Open();
                cmd = new SqlCommand();
                // Câu truy vấn lấy danh sách phim
                cmd.CommandText = store;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaPhong", cbPhongChieu.SelectedValue.ToString());
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        private void btnPhongChieu_Click(object sender, EventArgs e)
        {
            dt = layDanhSachPhongChieu("inDanhSachMaPhong");
            CrystalReportPhongChieu rp = new CrystalReportPhongChieu();
            rp.SetDataSource(dt);
            crystalReportViewerPhongChieu.ReportSource = rp;
        }

        public DataTable layDanhSachTheLoai(string store)
        {
            try
            {
                // Mở kết nối
                conn = DangKy.ketnoi();
                conn.Open();
                cmd = new SqlCommand();
                // Câu truy vấn lấy danh sách phim
                cmd.CommandText = store;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@TheLoai", cbTheLoai.SelectedValue.ToString());
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            dt = layDanhSachTheLoai("inDanhSachTheLoai");
            CrystalReportPhim rp = new CrystalReportPhim();
            rp.SetDataSource(dt);
            crystalReportViewerPhongChieu.ReportSource = rp;
        }

        public DataTable layDanhSachHangSX(string store)
        {
            try
            {
                // Mở kết nối
                conn = DangKy.ketnoi();
                conn.Open();
                cmd = new SqlCommand();
                // Câu truy vấn lấy danh sách phim
                cmd.CommandText = store;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@HangSX", cbSX.SelectedValue.ToString());
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        private void btnHangSX_Click(object sender, EventArgs e)
        {
            dt = layDanhSachHangSX("inDanhSachHangSX");
            CrystalReportPhim rp = new CrystalReportPhim();
            rp.SetDataSource(dt);
            crystalReportViewerPhongChieu.ReportSource = rp;
        }
    }
}
