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
    public partial class GUI_InRaBaoCaoVeXemPhim : Form
    {
        DangKy_BUS DangKy = new DangKy_BUS();
        public GUI_InRaBaoCaoVeXemPhim()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private void frmInRaBaoCaoVeXemPhim_Load(object sender, EventArgs e)
        {
            dt = layDanhSach("inDanhSachVeXemPhim");
            CrystalReportThongTinVe rp = new CrystalReportThongTinVe();
            rp.SetDataSource(dt);
            crystalReportViewerThongTinVe.ReportSource = rp;
            comboBox1.DataSource = layDanhSach("sp_layDSVE");
            comboBox1.ValueMember = "MaVe";
            comboBox1.DisplayMember = "MaVe";
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

        private void button1_Click(object sender, EventArgs e)
        {
            dt = layDanhSachTungVe("inDanhSachTungVe");
            CrystalReportThongTinVe rp = new CrystalReportThongTinVe();
            rp.SetDataSource(dt);
            crystalReportViewerThongTinVe.ReportSource = rp;
        }
        public DataTable layDanhSachTungVe(string store)
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
                cmd.Parameters.AddWithValue("@MaVe", comboBox1.SelectedValue.ToString());
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
        public DataTable layThanhTien(string store)
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

        private void btnTongThanhTien_Click(object sender, EventArgs e)
        {
            dt = layThanhTien("sp_ThanhTien");
            CrystalReportThanhTien rp = new CrystalReportThanhTien();
            rp.SetDataSource(dt);
            crystalReportViewerThongTinVe.ReportSource = rp;
        }
    }
}
