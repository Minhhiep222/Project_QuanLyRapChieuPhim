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
    public partial class frmNhapThongTinRap : Form
    {
        Rap_BUS rap_BUS = new Rap_BUS();
        Rap_DTO rap_DTO = new Rap_DTO();
        public static frmNhapThongTinRap instance;
        public static frmNhapThongTinRap Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmNhapThongTinRap();
                }
                return instance;
            }
        }
        public frmNhapThongTinRap()
        {
            InitializeComponent();
        }
        //SqlConnectionData connection = new SqlConnectionData();

        DataTable dtRap;
        /// <summary>
        /// Menthod lấy danh sách rạp
        /// </summary>
        /// <returns></returns>
        public DataTable LayDanhSachRap()
        {
            return rap_BUS.LAYDANHSACHRAP();
        }
        /// <summary>
        /// Menthod load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNhapThongTinRap_Load(object sender, EventArgs e)
        {
            //btnXoa.Enabled = false;
            //btnThem.Enabled = false;
            //btnSua.Enabled = false;
            ctxmenuThem.Enabled = false;
            ctxmenuXoa.Enabled = false;
            dataGridRap.DataSource = LayDanhSachRap();
        }
        /// <summary>
        /// Menthod kiểm tra các texbox
        /// </summary>
        /// <returns></returns>
        bool kTra()
        {
            char[] sdt = txtSĐT.Text.ToCharArray();
            if (txtMaRap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã rạp");
                txtMaRap.Focus();
                return false;
            }
            if (txtTenRap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên rạp");
                txtTenRap.Focus();
                return false;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ rạp");
                txtDiaChi.Focus();
                return false;
            }
            if (txtSĐT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập sđt rạp");
                txtSĐT.Focus();
                return false;
            }
            if (sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số");
                txtSĐT.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Menthod kiểm tra mã rạp
        /// </summary>
        /// <param name="marap"></param>
        /// <returns></returns>
        public bool kTraMaRap(string marap)
        {
            DataGridViewRow row;
            DataGridViewCell cell;
            for (int i = 0; i < dataGridRap.Rows.Count - 1; i++)
            {
                row = dataGridRap.Rows[i];
                cell = row.Cells[0];
                if (marap == cell.Value.ToString())
                {
                    MessageBox.Show("Mã rạp" + txtMaRap.Text + " đã tồn tại, vui lòng nhập mã khác");
                    txtMaRap.Focus();
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Menthod làm mới danh sách rạp
        /// </summary>
        public void lamMoi()
        {
            txtMaRap.Text = "";
            txtTenRap.Text = "";
            txtDiaChi.Text = "";
            txtSĐT.Text = "";
            dataGridRap.DataSource = LayDanhSachRap();
        }
        /// <summary>
        /// Menthod thêm rạp chiếu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            them(rap_DTO);
        }
        public void them(Rap_DTO rap)
        {
            //check thêm thành công
            bool check = false;
            if (kTra() == true && kTraMaRap(txtMaRap.Text) == true)
            {
                try
                {
                    rap.MaRap = txtMaRap.Text;
                    rap.TenRap = txtTenRap.Text;
                    rap.DiaChi = txtDiaChi.Text;
                    rap.Sdt = txtSĐT.Text;
                    check = rap_BUS.THEMRAP(rap);
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
        /// <summary>
        /// Menthod lấy rạp lên textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridRap_Click(object sender, EventArgs e)
        {
            txtMaRap.ReadOnly = true;
            int i = dataGridRap.CurrentRow.Index;
            txtMaRap.Text = dataGridRap.Rows[i].Cells[0].Value.ToString();
            txtTenRap.Text = dataGridRap.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridRap.Rows[i].Cells[2].Value.ToString();
            txtSĐT.Text = dataGridRap.Rows[i].Cells[3].Value.ToString();
        }
        /// <summary>
        /// Menthod xóa rạp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa(rap_DTO);
        }
        public void xoa(Rap_DTO rap)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa rạp này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    rap.MaRap = txtMaRap.Text;
                    check = rap_BUS.XOARAP(rap);
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
        /// <summary>
        /// Menthod sửa rạp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            sua(rap_DTO);   
        }
        public void sua(Rap_DTO rap)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa rạp này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    rap.MaRap = txtMaRap.Text;
                    rap.TenRap = txtTenRap.Text;
                    rap.DiaChi = txtDiaChi.Text;
                    rap.Sdt = txtSĐT.Text;
                    check = rap_BUS.SUARAP(rap);
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Menthod làm mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaRap.ReadOnly = false;
            lamMoi();
        }
        /// <summary>
        /// Menthod tìm kiếm rạp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timkiem(rap_DTO);   
        }
        public DataTable timkiem(Rap_DTO rap)
        {
            try
            {
                rap.MaRap = txtMaRap.Text;
                dtRap = rap_BUS.TIMKIEMRAP(rap);
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
            finally
            {
                lamMoi();
            }
            dataGridRap.DataSource = dtRap;
            return dtRap;
        }
        /// <summary>
        /// Menthod thay đổi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            //frmDungNutThayDoi thaydoi = new frmDungNutThayDoi();
            //thaydoi.Show();
        }
        private void txtMaRap_TextChanged(object sender, EventArgs e)
        {
            if (txtMaRap.TextLength > 10)
            {
                MessageBox.Show("Mã rạp chỉ được 10 kí tự, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaRap.Clear();
                txtMaRap.Focus();
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

        private void txtSĐT_TextChanged(object sender, EventArgs e)
        {
            if (txtSĐT.TextLength > 10)
            {
                MessageBox.Show("Số điện thoại chỉ được 10 kí tự, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSĐT.Clear();
                txtSĐT.Focus();
            }
        }

        private void txtTenRap_KeyPress(object sender, KeyPressEventArgs e)
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
