using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;

namespace GUI
{
    public partial class QLRCP : Form
    {
        public string hienthi = "";
        public QLRCP()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// construct có tham số
        /// </summary>
        /// <param name="result"></param>
        public QLRCP(string result)
        {
            InitializeComponent();

            ///kiểm tra kết quả đănng nhập
            if(result == "Đăng Nhập Thành Công!")
            {
                toolMenuStrip_DangNhap.Text = "Đăng xuất";
                thôngTinPhimToolStripMenuItem.Enabled = true;
                
            }
            ///cho kết quả đăng nhập bằng kết quả hiển thị
            hienthi = result;
           
        }

        /// <summary>
        /// Method thông tin rạp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nhậpThôngTinRạpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapThongTinRap rap = new frmNhapThongTinRap();
            rap.MdiParent = this;
            checkFrom(rap);
        }


        /// <summary>
        /// Method thông tin vé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nhậpTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapThongTinVe ve = new frmNhapThongTinVe();
            ve.MdiParent = this;
            checkFrom(ve);
        }

        /// <summary>
        /// Method thông tin khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nhậpThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapThongTinKhachHang khachhang = new frmNhapThongTinKhachHang();
            khachhang.MdiParent = this;
            checkFrom(khachhang);
        }


        /// <summary>
        /// Method lịch chiếu phim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nhậpThôngTinLịchChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_THONGTINLICHCHIEU lichchieu = new GUI_THONGTINLICHCHIEU();
            lichchieu.MdiParent = this;
            checkFrom(lichchieu);
        }


        /// <summary>
        /// From load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QLRCP_Load(object sender, EventArgs e)
        {

            if(hienthi == "Đăng Nhập Thành Công!")
            {
                thôngTinPhimToolStripMenuItem.Enabled = true;
                
                báoCáoThôngTinVéXemPhimToolStripMenuItem.Enabled = true;
                báoCáoToolStripMenuItem.Enabled = true;
            }
            else{
                thôngTinPhimToolStripMenuItem.Enabled = false;
                
                báoCáoThôngTinVéXemPhimToolStripMenuItem.Enabled = false;
                báoCáoToolStripMenuItem.Enabled = false;
            }
            
            if(toolMenuStrip_DangNhap.Text == "Đăng Nhập")
            {
                thôngTinPhimToolStripMenuItem.Enabled = false;
                
                báoCáoThôngTinVéXemPhimToolStripMenuItem.Enabled = false;
                báoCáoToolStripMenuItem.Enabled = false;


            }   

        }

        /// <summary>
        /// Method thông tin phòng ban
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nhậpThôngTinPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapThongTinPhongBan phongban = new frmNhapThongTinPhongBan();
            phongban.MdiParent = this;
            checkFrom(phongban);
        }
     
        private void thôngTinPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// method thong tin nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nhậpThToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapThongTinNhanVien nhanVien = new frmNhapThongTinNhanVien();
            nhanVien.MdiParent = this;
            checkFrom(nhanVien);
        }

        /// <summary>
        /// method thông tin phim 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nhậpThôngTinPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapThongTinPhim phim = new frmNhapThongTinPhim();
            phim.MdiParent = this;
            checkFrom(phim);
        }

        /// <summary>
        /// method phòng chiếu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nhậpThôngTinPhòngChiếuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNhapThongTinPhongChieu phongchieu = new frmNhapThongTinPhongChieu();
            phongchieu.MdiParent = this;
            ///kiểm tra form 
            checkFrom(phongchieu);
            
        }

        /// <summary>
        /// method đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolMenuStrip_DangNhap_Click(object sender, EventArgs e)
        {
            
            //this.Hide();
            if(toolMenuStrip_DangNhap.Text == "Đăng Nhập")
            {
                ///kiểm tra form đã tồn tại hay chưa
                
                GUI_THONGTINDANGNHAP dangnhap = new GUI_THONGTINDANGNHAP();  
                dangnhap.ShowDialog();

                this.Hide();

                
                

            }
            else if(toolMenuStrip_DangNhap.Text == "Đăng xuất")
            {
                this.Hide();
                QLRCP home = new QLRCP();
                home.Show();

                
            }
            else
            {
                this.Show();
                toolMenuStrip_DangNhap.Text = "Đăng Nhập";
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// method thoát 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Thoát_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
               
                this.Close();

            }
        }
        /// <summary>
        /// Medthod check form co ton tai hay khong
        /// </summary>
        /// <param name="from"></param>
        public void checkFrom(Form from)
        {
            ///kiểm tra form đã tồn tại hay chưa
            ///nếu chưa thì show 
            if (Application.OpenForms[from.Name] == null)
            {
                from.Show();
            }
            else
            {   ///active tới form đã show
                Application.OpenForms[from.Name].Activate();

            }            
        }

        /// <summary>
        /// method đăng ký người dùng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolMenuStrip_DangKy_Click(object sender, EventArgs e)
        {
            GUI_DANGKI dangky = new GUI_DANGKI();
            dangky.MdiParent = this;
            checkFrom(dangky);
        }

        /// <summary>
        /// method đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QLRCP_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.No)
            {

                this.Close();

            }
        }

        private void báoCáoThôngTinVéXemPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_InRaBaoCaoVeXemPhim baocao = new GUI_InRaBaoCaoVeXemPhim();
            baocao.MdiParent = this;
            checkFrom(baocao);
        }

        private void nhậpThôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapThongTinHoaDon hoaDon = new frmNhapThongTinHoaDon();
            hoaDon.MdiParent = this;
            checkFrom(hoaDon);
        }

        private void báoCáoThôngTinPhimVàPhòngChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_BaoCaoPhimVaPhong pvspc = new GUI_BaoCaoPhimVaPhong();
            pvspc.MdiParent = this;
            checkFrom(pvspc);
        }
    }
}
