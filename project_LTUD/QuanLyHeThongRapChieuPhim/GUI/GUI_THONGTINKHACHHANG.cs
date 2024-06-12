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
    public partial class frmNhapThongTinKhachHang : Form
    {
        KhachHang_BUS khachHang_BUS = new KhachHang_BUS();
        KhachHang_DTO khachHang_DTO = new KhachHang_DTO();

        public frmNhapThongTinKhachHang()           
        {
            InitializeComponent();
        }
        /// <summary>
        /// Kết nối sql
        /// </summary>
        //ket noi SQL
        
         

        DataTable dtKhachHang;

        /// <summary>
        /// From load 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNhapThongTinKhachHang_Load(object sender, EventArgs e)
        {
            //btnThem.Enabled = false;
            //btnXoa.Enabled = false;
            //btnSua.Enabled = false;
            ctxmenuThem.Enabled = false;
            ctxmenuXoa.Enabled = false;
            lamMoi();
        }

        /// <summary>
        /// Method lấy dữ liệu khách hàng
        /// </summary>
        /// <returns></returns>
        public DataTable LayDanhSachKhachHang()
        {
            return khachHang_BUS.LayDSKHACHHANG();
        }

        /// <summary>
        /// Method tìm kiếm khách hàng 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            timkiem(khachHang_DTO);
        }
        public DataTable timkiem(KhachHang_DTO khachhang)
        {
            try
            {
                khachhang.MaKH = txtMaKH.Text;
                dtKhachHang = khachHang_BUS.TIMKIEMKHACHHANG(khachhang);
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
            finally
            {
                //load lại form khi thêm thành công
                lamMoi();
            }
            dataGridKhachHang.DataSource = dtKhachHang;
            return dtKhachHang;
        }

        /// <summary>
        /// Method thêm khách hàng 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            them(khachHang_DTO);

        }

        public void them(KhachHang_DTO khachHang)
        {
            //check thêm thành công
            bool check = false;
            if (ktra() == true && kiemTraMaKH(txtMaKH.Text) == true)
            {
                try
                {   
                    khachHang.MaKH = txtMaKH.Text;
                    khachHang.TenKH = txtTenKH.Text ;
                    khachHang.Diachi = txtDiaChi.Text;
                    string gioitinh = "";
                    if (radioBtnNam.Checked == true)
                    {
                        gioitinh = "Nam";
                    }
                    if (radioBtnNu.Checked == true)
                    {
                        gioitinh = "Nữ";
                    }

                    khachHang.GioiTinh = gioitinh;
                    khachHang.SDT = txtSĐT.Text;
                    khachHang.Ngaysinh = txtNamSinh.Value;
                    
                    check = khachHang_BUS.themKHACHHANG(khachHang);
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
                    MessageBox.Show("Lỗi" + u, "Thông báo");
                }
                finally
                {
                    
                    //load lại form khi thêm thành công
                    if (check == true)
                    {
                        lamMoi();
                        
                    }
                }
                //làm mới from
            }

        }

        /// <summary>
        /// Method lấy dữ liệu khách hàng lên from 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridKhachHang_Click(object sender, EventArgs e)
        {
            //bắt sự kiện mã khách hàng
            //txtMaKH.ReadOnly = true;
            //vị trí mà bạn select
            int i;
            //gán cho vị trí dòng mà bạn chọn
            i = dataGridKhachHang.CurrentRow.Index;

            //lấy giá trị truyền lên các text box
            txtMaKH.Text = dataGridKhachHang.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridKhachHang.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridKhachHang.Rows[i].Cells[2].Value.ToString();
            if (dataGridKhachHang.Rows[i].Cells[3].Value.ToString() == "Nam")
            {
                radioBtnNam.Checked = true;
            }
            if (dataGridKhachHang.Rows[i].Cells[3].Value.ToString() == "Nữ")
            {
                radioBtnNu.Checked = true;
            }
            txtSĐT.Text = dataGridKhachHang.Rows[i].Cells[4].Value.ToString();
            txtNamSinh.Text = dataGridKhachHang.Rows[i].Cells[5].Value.ToString();
        }

        /// <summary>
        /// Method xóa khách hàng người dùng chọn trong data gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa(khachHang_DTO);
        }
        public void xoa(KhachHang_DTO khachhang)
        {
            bool check = false;
            //kiểm tra người dùng có thật sự muốn xóa không
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa Khách Hàng này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                //lấy vị trí mà bạn muốn xóa
                try
                {
                    khachhang.MaKH = txtMaKH.Text;
                    check = khachHang_BUS.XOAKHACHHANG(khachhang);
                    if(check == true)
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
                    //load lại form khi thêm thành công
                    if (check == true)
                    {
                        lamMoi();
                    }
                }
            }
            else
            {
                MessageBox.Show("Cẩn thận!", "Cảnh Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Method sửa thông tin khách hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            sua(khachHang_DTO);
        }
        public void sua(KhachHang_DTO khachHang)
        {
            bool check = false;
            //check xem người dùng có thật sự muốn sửa thông tin người dùng hay không 
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa thông tin khách hàng không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes && ktra() == true)
            {
                try
                {
                    khachHang.MaKH = txtMaKH.Text;
                    khachHang.TenKH = txtTenKH.Text;
                    khachHang.Diachi = txtDiaChi.Text;
                    string gioitinh = "";
                    if (radioBtnNam.Checked == true)
                    {
                        gioitinh = "Nam";
                    }
                    if (radioBtnNu.Checked == true)
                    {
                        gioitinh = "Nữ";
                    }

                    khachHang.GioiTinh = gioitinh;
                    khachHang.SDT = txtSĐT.Text;
                    khachHang.Ngaysinh = txtNamSinh.Value;
                    check = khachHang_BUS.SUAKHACHHANG(khachHang);
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
                    //load lại form khi thêm thành công
                    if (check == true)
                    {
                        lamMoi();
                    }
                }
            }
            else
            {
                MessageBox.Show("Cẩn thận!", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Method thoát from 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Method kiểm tra thông tin nhập khách hàng
        /// </summary>
        /// <returns></returns>
        bool ktra()
        {
            char[] sdt = txtSĐT.Text.ToCharArray();
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã KHÁCH HÀNG");
                txtMaKH.Focus();
                return false;
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên KHÁCH HÀNG");
                txtTenKH.Focus();
                return false;
            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ KHÁCH HÀNG");
                txtDiaChi.Focus();
                return false;
            }
            if (txtSĐT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại KHÁCH HÀNG");
                txtSĐT.Focus();
                return false;
            }
            if (sdt.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số");
                txtSĐT.Focus();
                return false;
            }
            if (txtNamSinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Vui lòng nhập chọn ngày sinh KHÁCH HÀNG");
                txtNamSinh.Focus();
                return false;

            }
            if(radioBtnNu.Checked == false && radioBtnNam.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính KHÁCH HÀNG");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Method làm mới các textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Lammoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }

        /// <summary>
        /// Method làm mới sau khi thực xong một sự kiện trong from
        /// </summary>
        public void lamMoi()
        {
            //làm mới các textbox
            txtTenKH.Text = "";
            txtMaKH.Text = "";
            txtNamSinh.Text = "";
            txtSĐT.Text = "";
            txtDiaChi.Text = "";
            txtMaKH.ReadOnly = false;
            radioBtnNu.Checked = false;
            radioBtnNam.Checked = false;
            //load lại form 
            dataGridKhachHang.DataSource = LayDanhSachKhachHang();
        }

        /// <summary>
        /// Method kiểm tra xem mã khách hàng đã tồn tại hay chưa
        /// </summary>
        /// <param name="maKH"></param>
        /// <returns></returns>
        public bool kiemTraMaKH(string maKH)
        {
           
            DataGridViewRow row ;
            DataGridViewCell cell;
            for (int i=0; i < dataGridKhachHang.Rows.Count - 1; i++)
            {
                 row = dataGridKhachHang.Rows[i];
                 cell = row.Cells[0];

                if (maKH == cell.Value.ToString())
                {
                    MessageBox.Show("Mã khách hàng "+txtMaKH.Text+ " đã tồn tại vui lòng nhập mã khác");
                    txtMaKH.Focus();
                    return false;
                }   
            } 
            return true;
        }

        private void btn_thayDoi_Click(object sender, EventArgs e)
        {
            //frmDungNutThayDoi thaydoi = new frmDungNutThayDoi();
            //thaydoi.Show();
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaKH.TextLength > 10)
            {
                MessageBox.Show("Mã KH chỉ được 10 kí tự, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Clear();
                txtMaKH.Focus();
            }
        }

        private void txtSĐT_TextChanged(object sender, EventArgs e)
        {
            if (txtSĐT.TextLength > 10)
            {
                MessageBox.Show("Sđt chỉ được 10 số, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keycode = e.KeyChar;
            int c = (int)keycode;
            if ((c >= 33) && (c <= 64) || (c >= 91) && (c <= 96))
            {
                MessageBox.Show("Chỉ được nhập chữ cái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamSinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnNam_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
