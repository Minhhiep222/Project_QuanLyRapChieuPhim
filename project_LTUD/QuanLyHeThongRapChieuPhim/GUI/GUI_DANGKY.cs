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
using DTO;
using BUS;

namespace GUI
{
    public partial class GUI_DANGKI : Form
    {
        DangKy_DTO dangky_DTO = new DangKy_DTO();
        DangKy_BUS dangky_BUS = new DangKy_BUS();
        public GUI_DANGKI()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Menthod form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            dataGridDangKy.DataSource = layDanhSach();
        }
        /// <summary>
        /// Menthod lấy danh sách đăng ký
        /// </summary>
        /// <returns></returns>
        public DataTable layDanhSach()
        {
            return dangky_BUS.LAYDANHSACHDANGKY();
        }
        public void LamMoi()
        {
            txtMaTK.ReadOnly = false;
            txtMaTK.Clear();
            txtTenTK.Clear();
            txtMatKhau.Clear();
            txtMaQuyen.Clear();
            dataGridDangKy.DataSource = layDanhSach();
        }

        /// <summary>
        /// Mrnthod kiểm tra các textbox
        /// </summary>
        /// <returns></returns>
        bool kTra()
        {
            char[] ktra;
            if(txtMaTK.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã tài khoản.");
                txtMaTK.Focus();
                return false;
            }
            if (txtTenTK.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên tài khoản.");
                txtTenTK.Focus();
                return false;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu.");
                txtMatKhau.Focus();
                return false;
            }
            if (txtMaQuyen.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã quyền.");
                txtMaQuyen.Focus();
                return false;
            }
            ktra = txtMaTK.Text.ToCharArray();
            if (ktra.Length <= 3)
            {
                MessageBox.Show("Mã tài khoản phải hơn 3 kí tự");
                txtMaTK.Focus();
                return false;
            }
            ktra = txtTenTK.Text.ToCharArray();
            if(ktra.Length <= 3)
            {
                MessageBox.Show("Tên tài khoản phải hơn 3 kí tự");
                txtTenTK.Focus();
                return false;
            }
            ktra = txtMatKhau.Text.ToCharArray();
            if (ktra.Length <= 3)
            {
                MessageBox.Show("Mật khẩu phải hơn 3 kí tự");
                txtMatKhau.Focus();
                return false;
            }
            ktra = txtMaQuyen.Text.ToCharArray();
            if (ktra.Length <= 3)
            {
                MessageBox.Show("Mã quyền phải hơn 3 kí tự");
                txtMaQuyen.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// menthod kiểm tra mã tài khoản
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public bool kKtraMaTK(string ma)
        {
            DataGridViewRow row;
            DataGridViewCell cell;
            for (int i = 0; i < dataGridDangKy.Rows.Count - 1; i++)
            {
                row = dataGridDangKy.Rows[i];
                cell = row.Cells[0];
                if (ma == cell.Value.ToString())
                {
                    MessageBox.Show("Mã rạp" + txtMaTK.Text + " đã tồn tại, vui lòng nhập mã khác");
                    txtMaTK.Focus();
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Menthod thêm danh sách đăng ký
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            them(dangky_DTO);
        }
        public void them(DangKy_DTO dangky)
        {
            bool check = false;
            if(kTra() == true && kKtraMaTK(txtMaTK.Text) == true)
            {
                try
                {
                    dangky.MaTK = txtMaTK.Text;
                    dangky.TenTK = txtTenTK.Text;
                    dangky.MatKhau = txtMatKhau.Text;
                    dangky.MaQuyen = txtMaQuyen.Text;
                    check = dangky_BUS.THEMDSDANGKY(dangky);
                    if (check == true)
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
                catch (Exception u)
                {
                    MessageBox.Show(u.Message);
                }
                finally
                {
                    //load lại form khi thêm thành công
                    if (check == true)
                    {
                        LamMoi();
                    }
                }
            }
        }
        /// <summary>
        /// Menthod xóa danh sách rạp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa(dangky_DTO);
        }
        public void xoa(DangKy_DTO dangky)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa tài khoản này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    dangky.MaTK = txtMaTK.Text;
                    check = dangky_BUS.XOADSDANGKY(dangky);
                    if (check == true)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
                catch (Exception u)
                {
                    MessageBox.Show(u.Message);
                }
                finally
                {
                    if (check == true)
                    {
                        LamMoi();
                    }
                }
            }
        }
        /// <summary>
        /// Menthod sửa tài khoản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            sua(dangky_DTO);
        }
        public void sua(DangKy_DTO dangky)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa tài khoản này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    dangky.MaTK = txtMaTK.Text;
                    dangky.TenTK = txtTenTK.Text;
                    dangky.MatKhau = txtMatKhau.Text;
                    dangky.MaQuyen = txtMaQuyen.Text;
                    check = dangky_BUS.SUADSDANGKY(dangky);
                    if (check == true)
                    {
                        MessageBox.Show("Su thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!");
                    }
                }
                catch (Exception u)
                {
                    MessageBox.Show(u.Message);
                }
                finally
                {
                    if (check == true)
                    {
                        LamMoi();
                    }
                }
            }
        }
        // Menthod thoát form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridDangKy_Click(object sender, EventArgs e)
        {
            txtMaTK.ReadOnly = true;
            int i = dataGridDangKy.CurrentRow.Index;
            txtMaTK.Text = dataGridDangKy.Rows[i].Cells[0].Value.ToString();
            txtTenTK.Text = dataGridDangKy.Rows[i].Cells[1].Value.ToString();
            txtMatKhau.Text = dataGridDangKy.Rows[i].Cells[2].Value.ToString();
            txtMaQuyen.Text = dataGridDangKy.Rows[i].Cells[3].Value.ToString();
        }
    }
}
