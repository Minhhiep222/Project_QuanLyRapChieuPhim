using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class GUI_THONGTINDANGNHAP : Form
    {   
        
        TaiKhoan_DTO taikhoan = new TaiKhoan_DTO();
        TaiKhoan_BUS tkbus = new TaiKhoan_BUS();
        public GUI_THONGTINDANGNHAP()
        {
            InitializeComponent();
        }

        public void btn_DangNhap_Click(object sender, EventArgs e)
        {
            taikhoan.TenTK = txt_TK.Text;
            taikhoan.MatKhau = txt_MatKhau.Text;

            string getuser = tkbus.CheckLogic(taikhoan);

            //trả lại kết quả quả nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "Yêu cầu tài khoản!": 
                    MessageBox.Show("Tài khoản không được bỏ trống");
                    return ;
                case "Yêu cầu mật khẩu!":
                    MessageBox.Show("Mật khẩu không được bỏ trống");
                    return;
                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }

            //MessageBox.Show("Đăng Nhập Thành Công!");
            string result = "Đăng Nhập Thành Công!";




            QLRCP home = new QLRCP(result);
            home.Show();

            this.Close();



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                QLRCP home = new QLRCP();
                home.checkFrom(home);

                this.Close();

            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
