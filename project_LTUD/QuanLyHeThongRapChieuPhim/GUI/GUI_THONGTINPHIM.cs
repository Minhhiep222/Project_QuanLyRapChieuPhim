using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmNhapThongTinPhim : Form
    {
        Phim_BUS phim_BUS = new Phim_BUS();
        Phim_DTO phim_DTO = new Phim_DTO();
        public static frmNhapThongTinPhim instance;
        public static frmNhapThongTinPhim Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmNhapThongTinPhim();
                }
                return instance;
            }
        }
        public frmNhapThongTinPhim()
        {
            InitializeComponent();
        }
        DataTable dtPhim;

        public DataTable LayDanhSachPhim()
        {
            return phim_BUS.LAYDANHSACHPHIM();
        }
        public DataTable LayDanhSachTheLoaiPhim()
        {
            return phim_BUS.LAYDANHSACHTHELOAIPHIM();
        }

        private void frmNhapThongTinPhim_Load(object sender, EventArgs e)
        {
            ctxmenuThem.Enabled = false;
            ctxmenuXoa.Enabled = false;
            dataGridPhim.DataSource = LayDanhSachPhim();
            cbTheLoai.DataSource = LayDanhSachTheLoaiPhim();
            cbTheLoai.ValueMember = "TheLoai";
            cbTheLoai.DisplayMember = "TheLoai";
        }
        public void lamMoi()
        {
            //làm mới các textbox
            txtMaPhim.Text = "";
            txtTenPhim.Text = "";
            txtHangSanXuat.Text = "";
            txtMaPhim.ReadOnly = false;

            //load lại form 
            dataGridPhim.DataSource = LayDanhSachPhim();
        }
        bool ktra()
        {

            if (txtMaPhim.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Phim");
                txtMaPhim.Focus();
                return false;
            }
            if (txtTenPhim.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên Phim");
                txtTenPhim.Focus();
                return false;
            }
            if (txtHangSanXuat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập HangSanXuat");
                txtHangSanXuat.Focus();
                return false;
            }
            return true;
        }
        public bool kiemTraMaPhim(string maPhim)
        {

            DataGridViewRow row;
            DataGridViewCell cell;
            for (int i = 0; i < dataGridPhim.Rows.Count - 1; i++)
            {
                row = dataGridPhim.Rows[i];
                cell = row.Cells[0];

                if (maPhim == cell.Value.ToString())
                {
                    MessageBox.Show("Mã Phong " + txtMaPhim.Text + " đã tồn tại vui lòng nhập mã khác");
                    txtMaPhim.Focus();
                    return false;
                }

            }
            return true;
        }
        public void them(Phim_DTO phim)
        {
            //check thêm thành công
            bool check = false;
            if (ktra() == true && kiemTraMaPhim(txtMaPhim.Text) == true)
            {
                try
                {
                    phim.MaPhim = txtMaPhim.Text;
                    phim.TenPhim = txtTenPhim.Text;
                    phim.TheLoai = cbTheLoai.Text;
                    phim.HangSX = txtHangSanXuat.Text;
                    check = phim_BUS.THEMPHIM(phim);
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
                        lamMoi();
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them(phim_DTO);
        }
        public void xoa(Phim_DTO phim)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa rạp này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    phim.MaPhim = txtMaPhim.Text;
                    check = phim_BUS.XOAPHIM(phim);
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
                        lamMoi();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa(phim_DTO);
        }
        public void sua(Phim_DTO phim)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa rạp này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    phim.MaPhim = txtMaPhim.Text;
                    phim.TenPhim = txtTenPhim.Text;
                    phim.TheLoai = cbTheLoai.Text;
                    phim.HangSX = txtHangSanXuat.Text;
                    check = phim_BUS.SUAPHIM(phim);
                   
                    if (check == true)
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (check == true)
                    {
                        lamMoi();
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sua(phim_DTO);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }
        public DataTable timkiem(Phim_DTO phim)
        {
            try
            {
                phim.MaPhim = txtMaPhim.Text;
                dtPhim = phim_BUS.TIMKIEMPHIM(phim);
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
            finally
            {
                lamMoi();
            }
            dataGridPhim.DataSource = dtPhim;
            return dtPhim;
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            timkiem(phim_DTO);
        }

        private void dataGridPhim_Click(object sender, EventArgs e)
        {
            //bắt sự kiện mã khách hàng
            txtMaPhim.ReadOnly = true;

            //vị trí mà bạn select
            int i;

            //gán cho vị trí dòng mà bạn chọn
            i = dataGridPhim.CurrentRow.Index;

            //lấy giá trị truyền lên các text box
            txtMaPhim.Text = dataGridPhim.Rows[i].Cells[0].Value.ToString();
            txtTenPhim.Text = dataGridPhim.Rows[i].Cells[1].Value.ToString();
            cbTheLoai.Text = dataGridPhim.Rows[i].Cells[2].Value.ToString();
            txtHangSanXuat.Text = dataGridPhim.Rows[i].Cells[3].Value.ToString();
        }

        private void txtMaPhim_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhim.TextLength > 10)
            {
                MessageBox.Show("Mã rạp chỉ được 10 kí tự, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPhim.Clear();
                txtMaPhim.Focus();
            }
        }

        private void txtTenPhim_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keycode = e.KeyChar;
            int c = (int)keycode;
            if ((c >= 33) && (c <= 64) || (c >= 91) && (c <= 96))
            {
                MessageBox.Show("Chỉ được nhập chữ cái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtTheLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keycode = e.KeyChar;
            int c = (int)keycode;
            if ((c >= 33) && (c <= 64) || (c >= 91) && (c <= 96))
            {
                MessageBox.Show("Chỉ được nhập chữ cái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtHangSanXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keycode = e.KeyChar;
            int c = (int)keycode;
            if ((c >= 33) && (c <= 64) || (c >= 91) && (c <= 96))
            {
                MessageBox.Show("Chỉ được nhập chữ cái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
