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
    public partial class frmNhapThongTinPhongChieu : Form
    {
        PhongChieu_BUS phongchieu_BUS = new PhongChieu_BUS();
        PhongChieu_DTO phongchieu_DTO = new PhongChieu_DTO();
        public static frmNhapThongTinPhongChieu instance;
        public static frmNhapThongTinPhongChieu Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmNhapThongTinPhongChieu();
                }
                return instance;
            }
        }
        public frmNhapThongTinPhongChieu()
        {
            InitializeComponent();
        }
        DataTable dtPhongChieu;

        public DataTable LayDanhSachPhongChieu()
        {
            return phongchieu_BUS.LAYDANHSACHPHONGCHIEU();
        }
        public DataTable LayDanhSachRap()
        {
            return phongchieu_BUS.LAYDANHSACHRAP();
        }
        private void frmNhapThongTinPhongChieu_Load(object sender, EventArgs e)
        {
            ctxmenuThem.Enabled = false;
            ctxmenuXoa.Enabled = false;
            dataGridPhongChieu.DataSource = LayDanhSachPhongChieu();
            cbMaRap.DataSource = LayDanhSachRap();
            cbMaRap.ValueMember = "MaRap";
            cbMaRap.DisplayMember = "MaRap";
        }
        public void lamMoi()
        {
            //làm mới các textbox
            txtMaPhong.Text = "";
            cbMaRap.Text = "";
            txtTenPhong.Text = "";
            txtTongSoGhe.Text = "";

            //load lại form 
            dataGridPhongChieu.DataSource = LayDanhSachPhongChieu();
        }
        bool ktra()
        {

            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Phòng");
                txtMaPhong.Focus();
                return false;
            }
            if (cbMaRap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Rạp");
                cbMaRap.Focus();
                return false;
            }

            if (txtTenPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tên Phòng");
                txtTenPhong.Focus();
                return false;
            }
            if (txtTongSoGhe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Tổng Số Ghế");
                txtTongSoGhe.Focus();
                return false;
            }
            return true;
        }
        public bool kiemTraMaPhong(string maPhong)
        {

            DataGridViewRow row;
            DataGridViewCell cell;
            for (int i = 0; i < dataGridPhongChieu.Rows.Count - 1; i++)
            {
                row = dataGridPhongChieu.Rows[i];
                cell = row.Cells[0];

                if (maPhong == cell.Value.ToString())
                {
                    MessageBox.Show("Mã Phong " + txtMaPhong.Text + " đã tồn tại vui lòng nhập mã khác");
                    txtMaPhong.Focus();
                    return false;
                }

            }
            return true;
        }

        private void dataGridPhongChieu_Click(object sender, EventArgs e)
        {
            //bắt sự kiện mã khách hàng
            txtMaPhong.ReadOnly = true;

            //vị trí mà bạn select
            int i;

            //gán cho vị trí dòng mà bạn chọn
            i = dataGridPhongChieu.CurrentRow.Index;

            //lấy giá trị truyền lên các text box
            txtMaPhong.Text = dataGridPhongChieu.Rows[i].Cells[0].Value.ToString();
            cbMaRap.Text = dataGridPhongChieu.Rows[i].Cells[1].Value.ToString();
            txtTenPhong.Text = dataGridPhongChieu.Rows[i].Cells[2].Value.ToString();
            txtTongSoGhe.Text = dataGridPhongChieu.Rows[i].Cells[3].Value.ToString();
        }
        public void them(PhongChieu_DTO phongchieu)
        {
            //check thêm thành công
            bool check = false;
            if (ktra() == true && kiemTraMaPhong(txtMaPhong.Text) == true)
            {
                try
                {
                    phongchieu.MaPhong= txtMaPhong.Text;
                    phongchieu.MaRap = cbMaRap.Text;
                    phongchieu.TenPhong = txtTenPhong.Text;
                    phongchieu.TongSoGhe = txtTongSoGhe.Text;
                    check = phongchieu_BUS.THEMPHONGCHIEU(phongchieu);
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
        public void xoa(PhongChieu_DTO phongChieu)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa rạp này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    phongChieu.MaPhong = txtMaPhong.Text;
                    check = phongchieu_BUS.XOAPHONGCHIEU(phongChieu);
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
        public void sua(PhongChieu_DTO phongchieu)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa rạp này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    phongchieu.MaPhong = txtMaPhong.Text;
                    phongchieu.MaRap = cbMaRap.Text;
                    phongchieu.TenPhong = txtTenPhong.Text;
                    phongchieu.TongSoGhe = txtTongSoGhe.Text;
                    check = phongchieu_BUS.SUAPHONGCHIEU(phongchieu);

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
        public DataTable timkiem(PhongChieu_DTO phongchieu)
        {
            try
            {
                phongchieu.MaPhong = txtMaPhong.Text;
                dtPhongChieu = phongchieu_BUS.TIMKIEMPHONGCHIEU(phongchieu);
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
            finally
            {
                lamMoi();
            }
            dataGridPhongChieu.DataSource = dtPhongChieu;
            return dtPhongChieu;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them(phongchieu_DTO);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa(phongchieu_DTO);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sua(phongchieu_DTO);
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            timkiem(phongchieu_DTO);
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            lamMoi();
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

        private void txtTenPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keycode = e.KeyChar;
            int c = (int)keycode;
            if ((c >= 33) && (c <= 64) || (c >= 91) && (c <= 96))
            {
                MessageBox.Show("Chỉ được nhập chữ cái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhong.TextLength > 10)
            {
                MessageBox.Show("Mã rạp chỉ được 10 kí tự, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPhong.Clear();
                txtMaPhong.Focus();
            }
        }

        private void txtTongSoGhe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtTongSoGhe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
