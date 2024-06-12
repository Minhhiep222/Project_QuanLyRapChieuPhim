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
    public partial class GUI_reportHoaDon : Form
    {
        DangKy_BUS DangKy = new DangKy_BUS();
        public GUI_reportHoaDon()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private void GUI_reportHoaDon_Load(object sender, EventArgs e)
        {
            cbo_MaHD.DataSource = layDanhSach("sp_layDSHoaDon");
            cbo_MaHD.ValueMember = "MaHD";
            cbo_MaHD.DisplayMember = "MaHD";


            dt = layDanhSachHoaDon("sp_layChiTietHoaDon");
            cpt_chitiet rp = new cpt_chitiet();
            rp.SetDataSource(dt);
            cpt_hoadon.ReportSource = rp;
             

        }

        public DataTable layDanhSachHoaDon(string store)
        {
            try
            {
                dt = new DataTable();
                // Mở kết nối   ;
                conn = DangKy.ketnoi();
                conn.Open();
                cmd = new SqlCommand();
                // Câu truy vấn lấy danh sách phim
                cmd.CommandText = store;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                //string mahd = 
                SqlParameter ma = new SqlParameter("@MaHD", cbo_MaHD.Text);
                cmd.Parameters.Add(ma);

                da = new SqlDataAdapter(cmd);


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

        public DataTable layDanhSach(string store)
        {
            try
            {
                dt = new DataTable();
                // Mở kết nối
                conn = DangKy.ketnoi();
                conn.Open();
                cmd = new SqlCommand();
                // Câu truy vấn lấy danh sách phim
                cmd.CommandText = store;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                da = new SqlDataAdapter(cmd);


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

        private void btn_inchitiet_Click(object sender, EventArgs e)
        {
            
            dt = layDanhSachHoaDon("sp_layChiTietHoaDon");
            cpt_chitiet rp = new cpt_chitiet();
            rp.SetDataSource(dt);
            cpt_hoadon.ReportSource = rp;
        }
    }
}
