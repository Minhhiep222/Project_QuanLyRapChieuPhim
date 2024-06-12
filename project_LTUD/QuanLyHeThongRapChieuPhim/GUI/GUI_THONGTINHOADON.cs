using BUS;
using DTO;
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

namespace GUI
{
    public partial class frmNhapThongTinHoaDon : Form
    {
        HoaDon_BUS hoadon_BUS = new HoaDon_BUS();
        HoaDon_DTO hoadon_DTO = new HoaDon_DTO();
        public static frmNhapThongTinHoaDon instance;
        public static frmNhapThongTinHoaDon Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmNhapThongTinHoaDon();
                }
                return instance;
            }
        }
        public frmNhapThongTinHoaDon()
        {
            InitializeComponent();
        }

        DataTable dtHD;

        public DataTable LayDanhSachHoaDon()
        {
            return hoadon_BUS.LAYDANHSACHHOADON();
        }
        public DataTable LayDanhSachRap()
        {
            return hoadon_BUS.LAYDANHSACHRAP();
        }
        public DataTable LayDanhSachNhanVien()
        {
            return hoadon_BUS.LAYDANHSACHNHANVIEN();
        }
        public DataTable LayDanhSachKhachHang()
        {
            return hoadon_BUS.LAYDANHSACHKHACHHANG();
        }

        private void frmNhapThongTinHoaDon_Load(object sender, EventArgs e)
        {
            ctxmenuThem.Enabled = false;
            ctxmenuXoa.Enabled = false;
            
            dataGridHoaDon.DataSource = LayDanhSachHoaDon();
            //lấy mã Rap
            cbMaRap.DataSource = LayDanhSachRap();
            cbMaRap.ValueMember = "MaRap";
            cbMaRap.DisplayMember = "MaRap";
            // lấy mã nhân viên
            cbMaNhanVien.DataSource = LayDanhSachNhanVien();
            cbMaNhanVien.ValueMember = "MaNV";
            cbMaNhanVien.DisplayMember = "MaNV";
            //lấy mã khách hàng
            cbMaKhachHang.DataSource = LayDanhSachKhachHang();
            cbMaKhachHang.ValueMember = "MaKH";
            cbMaKhachHang.DisplayMember = "MaKH";
        }
        public bool kTraMaHoaDon(string mave)
        {
            DataGridViewRow row;
            DataGridViewCell cell;
            for (int i = 0; i < dataGridHoaDon.Rows.Count - 1; i++)
            {
                row = dataGridHoaDon.Rows[i];
                cell = row.Cells[0];
                if (mave == cell.Value.ToString())
                {
                    MessageBox.Show("Mã hóa đơn" + txtMaHoaDon.Text + " đã tồn tại, vui lòng nhập mã khác");
                    txtMaHoaDon.Focus();
                    return false;
                }
            }
            return true;
        }
        bool kTra()
        {
            if (txtMaHoaDon.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn");
                txtMaHoaDon.Focus();
                return false;
            }

            return true;
        }
        public void lamMoi()
        {
            //làm mới các textbox
            txtMaHoaDon.Text = "";
            cbMaRap.Text = "";
            cbMaNhanVien.Text = "";
            cbMaKhachHang.Text = "";
            txtMaHoaDon.ReadOnly = false;

            //load lại form 
            dataGridHoaDon.DataSource = LayDanhSachHoaDon();
        }

        private void dataGridHoaDon_Click(object sender, EventArgs e)
        {
            //bắt sự kiện mã khách hàng
            txtMaHoaDon.ReadOnly = true;

            //vị trí mà bạn select
            int i;

            //gán cho vị trí dòng mà bạn chọn
            i = dataGridHoaDon.CurrentRow.Index;

            //lấy giá trị truyền lên các text box
            txtMaHoaDon.Text = dataGridHoaDon.Rows[i].Cells[0].Value.ToString();
            cbMaRap.Text = dataGridHoaDon.Rows[i].Cells[1].Value.ToString();
            cbMaNhanVien.Text = dataGridHoaDon.Rows[i].Cells[2].Value.ToString();
            cbMaKhachHang.Text = dataGridHoaDon.Rows[i].Cells[3].Value.ToString(); 
        }
        public void them(HoaDon_DTO HD)
        {
            //check thêm thành công
            bool check = false;
            if (kTra() == true && kTraMaHoaDon(txtMaHoaDon.Text) == true)
            {
                try
                {
                    HD.MaHD = txtMaHoaDon.Text;
                    HD.MaRap = cbMaRap.Text;
                    HD.MaNV = cbMaNhanVien.Text;
                    HD.MaKH = cbMaKhachHang.Text;
                    check = hoadon_BUS.THEMHOADON(HD);
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
        public void xoa(HoaDon_DTO HD)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa rạp này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    HD.MaHD = txtMaHoaDon.Text;
                    check = hoadon_BUS.XOAHOADON(HD);
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
        public void sua(HoaDon_DTO HD)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa rạp này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    HD.MaHD = txtMaHoaDon.Text;
                    HD.MaRap = cbMaRap.Text;
                    HD.MaNV = cbMaNhanVien.Text;
                    HD.MaKH = cbMaKhachHang.Text;
                    check = hoadon_BUS.SUAHOADON(HD);

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
        public DataTable timkiem(HoaDon_DTO HD)
        {
            try
            {
                HD.MaHD = txtMaHoaDon.Text;
                dtHD = hoadon_BUS.TIMKIEMHOADON(HD);
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
            finally
            {
                lamMoi();
            }
            dataGridHoaDon.DataSource = dtHD;
            return dtHD;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them(hoadon_DTO);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa(hoadon_DTO);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            sua(hoadon_DTO);
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            timkiem(hoadon_DTO);
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

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHoaDon.TextLength > 10)
            {
                MessageBox.Show("Mã rạp chỉ được 10 kí tự, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHoaDon.Clear();
                txtMaHoaDon.Focus();
            }
        }

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            GUI_reportHoaDon chitiet = new GUI_reportHoaDon();
            chitiet.Show();
        }
    }
}
