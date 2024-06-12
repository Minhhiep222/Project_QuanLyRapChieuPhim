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
    public partial class frmNhapThongTinNhanVien : Form
    {
        NhanVien_BUS nhanvien_BUS = new NhanVien_BUS();
        NhanVien_DTO nhanvien_DTO = new NhanVien_DTO();
        public static frmNhapThongTinNhanVien instance;
        public static frmNhapThongTinNhanVien Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmNhapThongTinNhanVien();
                }
                return instance;
            }
        }
        public frmNhapThongTinNhanVien()
        {
            InitializeComponent();
        }
        DataTable dtNV;

        public DataTable LayDanhSachNhanVien()
        {
            return nhanvien_BUS.LAYDANHSACHNHANVIEN();
        }
        public DataTable LayDanhSachPhongChieu()
        {
            return nhanvien_BUS.LAYDANHSACHPHONGCHIEU();
        }

        private void frmNhapThongTinNhanVien_Load(object sender, EventArgs e)
        {
            ctxmenuThem.Enabled = false;
            ctxmenuXoa.Enabled = false;
            dataGridNhanVien.DataSource = LayDanhSachNhanVien();
            cbMaPhong.DataSource = LayDanhSachPhongChieu();
            cbMaPhong.ValueMember = "MaPhong";
            cbMaPhong.DisplayMember = "MaPhong";
        }
        public void lamMoi()
        {
            //làm mới các textbox
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtHoNV.Text = "";
            txtNamSinh.Text = "";
            txtCCCD.Text = "";
            txtLuong.Text = "";
            cbMaPhong.Text = "";
            txtSĐT.Text = "";
            txtDiaChi.Text = "";
            txtMaNV.ReadOnly = false;
            radioBtnNu.Checked = false;
            radioBtnNam.Checked = false;
            //load lại form 
            dataGridNhanVien.DataSource = LayDanhSachNhanVien();
        }
        bool ktra()
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Nhân Viên");
                txtMaNV.Focus();
                return false;
            }
            if (txtCCCD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập CCCD");
                txtCCCD.Focus();
                return false;
            }
            if (txtHoNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Họ Nhân Viên");
                txtHoNV.Focus();
                return false;
            }
            if (txtTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên Nhân Viên");
                txtTenNV.Focus();
                return false;
            }
            if (txtLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Lương");
                txtLuong.Focus();
                return false;
            }
            if (cbMaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã Phòng");
                cbMaPhong.Focus();
                return false;
            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhân viên");
                txtDiaChi.Focus();
                return false;
            }
            if (txtSĐT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhân viên");
                txtSĐT.Focus();
                return false;
            }
            if (txtNamSinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Vui lòng nhập chọn ngày sinh nhân viên");
                txtNamSinh.Focus();
                return false;

            }
            if (radioBtnNu.Checked == false && radioBtnNam.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính nhân viên");
                return false;
            }

            return true;
        }
        public bool kiemTraMaNV(string maNV)
        {

            DataGridViewRow row;
            DataGridViewCell cell;
            for (int i = 0; i < dataGridNhanVien.Rows.Count - 1; i++)
            {
                row = dataGridNhanVien.Rows[i];
                cell = row.Cells[0];

                if (maNV == cell.Value.ToString())
                {
                    MessageBox.Show("Mã Nhân Viên " + txtMaNV.Text + " đã tồn tại vui lòng nhập mã khác");
                    txtMaNV.Focus();
                    return false;
                }

            }
            return true;
        }
        public void them(NhanVien_DTO NV)
        {
            //check thêm thành công  
            bool check = false;
            if (ktra() == true && kiemTraMaNV(txtMaNV.Text) == true)
            {
                try
                {
                    NV.MaNV = txtMaNV.Text;
                    NV.CCCD = txtCCCD.Text;
                    NV.HoNV = txtHoNV.Text;
                    NV.Tennv = txtTenNV.Text;
                    NV.Diachi = txtDiaChi.Text;
                    NV.MaPhong = cbMaPhong.Text;
                    NV.Luong = txtLuong.Text;
                    string gioitinh = "";
                    if (radioBtnNam.Checked == true)
                    {
                        gioitinh = "Nam";
                    }
                    if (radioBtnNu.Checked == true)
                    {
                        gioitinh = "Nữ";
                    }

                    NV.GioiTinh = gioitinh;
                    NV.SDT = txtSĐT.Text;
                    NV.Ngaysinh = txtNamSinh.Value;


                    check = nhanvien_BUS.THEMNHANVIEN(NV);
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
        public void xoa(NhanVien_DTO NV)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa rạp này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    NV.MaNV = txtMaNV.Text;
                    check = nhanvien_BUS.XOANHANVIEN(NV);
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
        public void sua(NhanVien_DTO NV)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa rạp này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    NV.MaNV = txtMaNV.Text;
                    NV.CCCD = txtCCCD.Text;
                    NV.HoNV = txtHoNV.Text;
                    NV.Tennv = txtTenNV.Text;
                    NV.Diachi = txtDiaChi.Text;
                    NV.MaPhong = cbMaPhong.Text;
                    NV.Luong = txtLuong.Text;
                    string gioitinh = "";
                    if (radioBtnNam.Checked == true)
                    {
                        gioitinh = "Nam";
                    }
                    if (radioBtnNu.Checked == true)
                    {
                        gioitinh = "Nữ";
                    }

                    NV.GioiTinh = gioitinh;
                    NV.SDT = txtSĐT.Text;
                    NV.Ngaysinh = txtNamSinh.Value;


                    check = nhanvien_BUS.SUANHANVIEN(NV);

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
        public DataTable timkiem(NhanVien_DTO NV)
        {
            try
            {
                NV.MaNV = txtMaNV.Text;
                dtNV = nhanvien_BUS.TIMKIEMNHANVIEN(NV);
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
            finally
            {
                lamMoi();
            }
            dataGridNhanVien.DataSource = dtNV;
            return dtNV;
        }

        private void btn_thayDoi_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them(nhanvien_DTO);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa(nhanvien_DTO);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sua(nhanvien_DTO);
        }

        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            timkiem(nhanvien_DTO);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridNhanVien_Click(object sender, EventArgs e)
        {
            //bắt sự kiện mã khách hàng
            txtMaNV.ReadOnly = true;

            //vị trí mà bạn select
            int i;

            //gán cho vị trí dòng mà bạn chọn
            i = dataGridNhanVien.CurrentRow.Index;

            //lấy giá trị truyền lên các text box
            txtMaNV.Text = dataGridNhanVien.Rows[i].Cells[0].Value.ToString();
            txtCCCD.Text = dataGridNhanVien.Rows[i].Cells[1].Value.ToString();
            txtHoNV.Text = dataGridNhanVien.Rows[i].Cells[2].Value.ToString();
            txtTenNV.Text = dataGridNhanVien.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dataGridNhanVien.Rows[i].Cells[4].Value.ToString();
            txtSĐT.Text = dataGridNhanVien.Rows[i].Cells[5].Value.ToString();
            txtNamSinh.Text = dataGridNhanVien.Rows[i].Cells[6].Value.ToString();

            if (dataGridNhanVien.Rows[i].Cells[7].Value.ToString() == "Nam")
            {
                radioBtnNam.Checked = true;
            }
            if (dataGridNhanVien.Rows[i].Cells[7].Value.ToString() == "Nữ")
            {
                radioBtnNu.Checked = true;
            }

            txtLuong.Text = dataGridNhanVien.Rows[i].Cells[8].Value.ToString();
            cbMaPhong.Text = dataGridNhanVien.Rows[i].Cells[9].Value.ToString();
        }

        private void txtSĐT_TextChanged(object sender, EventArgs e)
        {
            if (txtSĐT.TextLength > 10)
            {
                MessageBox.Show("Số điện thoại chỉ được 10 kí tự, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSĐT.Clear();
                txtSĐT.Focus();
            }
        }

        private void txtSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtHoNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keycode = e.KeyChar;
            int c = (int)keycode;
            if ((c >= 33) && (c <= 64) || (c >= 91) && (c <= 96))
            {
                MessageBox.Show("Chỉ được nhập chữ cái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keycode = e.KeyChar;
            int c = (int)keycode;
            if ((c >= 33) && (c <= 64) || (c >= 91) && (c <= 96))
            {
                MessageBox.Show("Chỉ được nhập chữ cái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập số ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            if (txtCCCD.TextLength > 12)
            {
                MessageBox.Show("Số CCCD chỉ được 12 kí tự, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCCCD.Clear();
                txtCCCD.Focus();
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNV.TextLength > 10)
            {
                MessageBox.Show("Mã rạp chỉ được 10 kí tự, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Clear();
                txtMaNV.Focus();
            }
        }
    }
}
