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
    public partial class frmNhapThongTinPhongBan : Form
    {
        PhongBan_BUS phongban_BUS = new PhongBan_BUS();
        PhongBan_DTO phongban_DTO = new PhongBan_DTO();
        public static frmNhapThongTinPhongBan instance;
        public static frmNhapThongTinPhongBan Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmNhapThongTinPhongBan();
                }
                return instance;
            }
        }
        public frmNhapThongTinPhongBan()
        {
            InitializeComponent();
        }
        DataTable dtPhongBan;

        public DataTable LayDanhSachPhongBan()
        {
            return phongban_BUS.LAYDANHSACHPHONGBAN();
        }
        public DataTable LayDanhSachRap()
        {
            return phongban_BUS.LAYDANHSACHRAP();
        }
        private void frmNhapThongTinPhongBan_Load(object sender, EventArgs e)
        {
            ctxmenuThem.Enabled = false;
            ctxmenuXoa.Enabled = false;
            dataGridPhongBan.DataSource = LayDanhSachPhongBan();
            cbMaRap.DataSource = LayDanhSachRap();
            cbMaRap.ValueMember = "MaRap";
            cbMaRap.DisplayMember = "MaRap";
        }
        public void lamMoi()
        {
            //làm mới các textbox
            txtMaPhongBan.Text = "";
            cbMaRap.Text = "";
            txtTruongPhong.Text = "";

            //load lại form 
            dataGridPhongBan.DataSource = LayDanhSachPhongBan();
        }
        bool ktra()
        {
            if (txtMaPhongBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Phòng Ban");
                txtMaPhongBan.Focus();
                return false;
            }
            if (cbMaRap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Rạp");
                cbMaRap.Focus();
                return false;
            }

            if (txtTruongPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Trưởng Phòng");
                txtTruongPhong.Focus();
                return false;
            }
            return true;
        }
        public bool kiemTraMaPhongBan(string maPhongBan)
        {

            DataGridViewRow row;
            DataGridViewCell cell;
            for (int i = 0; i < dataGridPhongBan.Rows.Count - 1; i++)
            {
                row = dataGridPhongBan.Rows[i];
                cell = row.Cells[0];

                if (maPhongBan == cell.Value.ToString())
                {
                    MessageBox.Show("Mã khách hàng " + txtMaPhongBan.Text + " đã tồn tại vui lòng nhập mã khác");
                    txtMaPhongBan.Focus();
                    return false;
                }

            }
            return true;
        }

        private void frmNhapThongTinPhongBan_Click(object sender, EventArgs e)
        {

        }

        private void dataGridPhongBan_Click(object sender, EventArgs e)
        {
            //bắt sự kiện mã khách hàng
            txtMaPhongBan.ReadOnly = true;

            //vị trí mà bạn select
            int i;

            //gán cho vị trí dòng mà bạn chọn
            i = dataGridPhongBan.CurrentRow.Index;

            //lấy giá trị truyền lên các text box
            txtMaPhongBan.Text = dataGridPhongBan.Rows[i].Cells[0].Value.ToString();
            cbMaRap.Text = dataGridPhongBan.Rows[i].Cells[1].Value.ToString();
            txtTruongPhong.Text = dataGridPhongBan.Rows[i].Cells[2].Value.ToString();

        }
        public void them(PhongBan_DTO phongban)
        {
            //check thêm thành công
            bool check = false;
            if (ktra() == true && kiemTraMaPhongBan(txtMaPhongBan.Text) == true)
            {
                try
                {
                    phongban.MaPhongBan = txtMaPhongBan.Text;
                    phongban.MaRap = cbMaRap.Text;
                    phongban.TruongPhong = txtTruongPhong.Text;
                    check = phongban_BUS.THEMPHONGBAN(phongban);
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
        public void xoa(PhongBan_DTO phongban)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa rạp này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    phongban.MaPhongBan = txtMaPhongBan.Text;
                    check = phongban_BUS.XOAPHONGBAN(phongban);
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
        public void sua(PhongBan_DTO phongban)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa rạp này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    phongban.MaPhongBan = txtMaPhongBan.Text;
                    phongban.MaRap = cbMaRap.Text;
                    phongban.TruongPhong = txtTruongPhong.Text;
                    check = phongban_BUS.SUAPHONGBAN(phongban);

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
        public DataTable timkiem(PhongBan_DTO phongban)
        {
            try
            {
                phongban.MaPhongBan = txtMaPhongBan.Text;
                dtPhongBan = phongban_BUS.TIMKIEMPHONGBAN(phongban);
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
            finally
            {
                lamMoi();
            }
            dataGridPhongBan.DataSource = dtPhongBan;
            return dtPhongBan;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them(phongban_DTO);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa(phongban_DTO);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sua(phongban_DTO);
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            timkiem(phongban_DTO);
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtTruongPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keycode = e.KeyChar;
            int c = (int)keycode;
            if ((c >= 33) && (c <= 64) || (c >= 91) && (c <= 96))
            {
                MessageBox.Show("Chỉ được nhập chữ cái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtMaPhongBan_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPhongBan.TextLength > 10)
            {
                MessageBox.Show("Mã rạp chỉ được 10 kí tự, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPhongBan.Clear();
                txtMaPhongBan.Focus();
            }
        }
    }
}
