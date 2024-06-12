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
    public partial class frmNhapThongTinVe : Form
    {
        Ve_BUS ve_BUS = new Ve_BUS();
        Ve_DTO ve_DTO = new Ve_DTO();
        HoaDon_BUS hoadon_BUS = new HoaDon_BUS();
        HoaDon_DTO hoadon_DTO = new HoaDon_DTO();
        List<Button> dsghe;
        //ở đây ta sử dụng một phương thức tĩnh để kiểm soát instance của Form khi khởi tạo
        public static frmNhapThongTinVe instance;
        public static frmNhapThongTinVe Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frmNhapThongTinVe();
                }
                return instance;
            }
        }
        public frmNhapThongTinVe()
        {
            InitializeComponent();
            dsghe = new List<Button>();
        }
        DataTable dtVe;
        /// <summary>
        /// Menthod lấy danh sách vé
        /// </summary>
        /// <returns></returns>
        public DataTable LayDanhSachVe()
        {
            return ve_BUS.LayDSVE();
        }
        /// <summary>
        /// Menthod lấy mashow lên combobox
        /// </summary>
        /// <returns></returns>
        public DataTable LayDanhSachMaShow()
        {
            return ve_BUS.LayDSLICHCHIEU();
        }
        /// <summary>
        /// Menthod lấy maphim lên combobox
        /// </summary>
        /// <returns></returns>
        public DataTable LayDanhMaPhim()
        {
            return ve_BUS.LayDSPHIM();
        }
        /// <summary>
        /// Menthod lấy maKH lên combobox
        /// </summary>
        /// <returns></returns>
        public DataTable LayDanhMaKH()
        {
            return ve_BUS.LayDSKHACHHANG();
        }
        /// <summary>
        /// Menthod lấy maHD lên combobox
        /// </summary>
        /// <returns></returns>
        public DataTable LayDanhMaHD()
        {
            return ve_BUS.LayDSHOADON();
        }



        public DataTable LayDanhSachHoaDon()
        {
            return hoadon_BUS.LAYDANHSACHHOADONCHITIETHOADON(cbo_MaHD.Text);
            
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
        /// <summary>
        /// Menthod load thông tin vé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNhapThongTinVe_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            ctxmenuThem.Enabled = false;
            ctxmenuXoa.Enabled = false;

            txtGhe.ReadOnly = true;

            dataGridVe.DataSource = LayDanhSachVe();

            cbMaShow.DataSource = LayDanhSachMaShow();
            cbMaShow.ValueMember = "MaShow";
            cbMaShow.DisplayMember = "MaShow";

            cbMaPhim.DataSource = LayDanhMaPhim();
            cbMaPhim.ValueMember = "MaPhim";
            cbMaPhim.DisplayMember = "MaPhim";

            cbMaHD.DataSource = LayDanhMaHD();
            cbMaHD.ValueMember = "MaHD";                                    
            cbMaHD.DisplayMember = "MaHD";

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

            //lấy mã hóa đơn
            cbo_MaHD.DataSource = LayDanhMaHD();
            cbo_MaHD.ValueMember = "MaHD";
            cbo_MaHD.DisplayMember = "MaHD";

            dgv_ChiTietHoaDon.DataSource = LayDanhSachHoaDon();

           
            

        }
        /// <summary>
        /// Menthod kiểm tra các textbox
        /// </summary>
        /// <returns></returns>
        bool kTra()
        {
            if (txtMaVe.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã vé");
                txtMaVe.Focus();
                return false;
            }
            if (txtGiaVe.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giá vé");
                txtGiaVe.Focus();
                return false;
            }
            if (txtGhe.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ghe");
                txtGhe.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Menthod kiểm tra mã vé
        /// </summary>
        /// <param name="mave"></param>
        /// <returns></returns>
        public bool kTraMaVe(string mave)
        {
            DataGridViewRow row;
            DataGridViewCell cell;
            for (int i = 0; i < dataGridVe.Rows.Count - 1; i++)
            {
                row = dataGridVe.Rows[i];
                cell = row.Cells[0];
                if (mave == cell.Value.ToString())
                {
                    MessageBox.Show("Mã vé " + txtMaVe.Text + " đã tồn tại, vui lòng nhập mã khác");
                    txtMaVe.Focus();
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Menthod làm mới các textbox
        /// </summary>
        public void lamMoi()
        {
            txtMaVe.Text = "";
            txtGiaVe.Text = "";
            txtGhe.Text = "";
            dataGridVe.DataSource = LayDanhSachVe();
        }
        /// <summary>
        /// Mrnthod thêm danh sách vé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bthThem_Click(object sender, EventArgs e)
        {
            them(ve_DTO);
            dgv_ChiTietHoaDon.DataSource = hoadon_BUS.LAYDANHSACHHOADONCHITIETHOADON(cbMaHD.Text);
        }
        public void them(Ve_DTO ve)
        {
            //check thêm thành công
            bool check = false;
            if (kTra() == true && kTraMaVe(txtMaVe.Text) == true)
            {
                try
                {
                    ve.MaVe = txtMaVe.Text;
                    ve.MaShow = cbMaShow.Text;
                    ve.MaPhim = cbMaPhim.Text;
                    ve.GiaVe = txtGiaVe.Text;
                    ve.MaHD = cbMaHD.Text;
                    ve.Ghe = txtGhe.Text;
                    check = ve_BUS.THEMVE(ve);
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
        /// Menthod lấy vé lên các textbox và combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridVe_Click(object sender, EventArgs e)
        {
            txtMaVe.ReadOnly = true;
            int i = dataGridVe.CurrentRow.Index;

            txtMaVe.Text = dataGridVe.Rows[i].Cells[0].Value.ToString();
            cbMaShow.Text = dataGridVe.Rows[i].Cells[1].Value.ToString();
            cbMaPhim.Text = dataGridVe.Rows[i].Cells[2].Value.ToString();
            txtGiaVe.Text = dataGridVe.Rows[i].Cells[3].Value.ToString();
            cbMaHD.Text = dataGridVe.Rows[i].Cells[4].Value.ToString();
            txtGhe.Text = dataGridVe.Rows[i].Cells[5].Value.ToString();
        }
        /// <summary>
        /// Menthod xóa vé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa(ve_DTO);
            dgv_ChiTietHoaDon.DataSource = hoadon_BUS.LAYDANHSACHHOADONCHITIETHOADON(cbMaHD.Text);
        }
        public void xoa(Ve_DTO ve)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa vé này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    ve.MaVe = txtMaVe.Text;
                    check = ve_BUS.XOAVE(ve);
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
        /// Mrnthod thoát form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bthThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Menthod sửa vé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            sua(ve_DTO);
            dgv_ChiTietHoaDon.DataSource = hoadon_BUS.LAYDANHSACHHOADONCHITIETHOADON(cbMaHD.Text);
        }
        public void sua(Ve_DTO ve)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn sửa vé này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    ve.MaVe = txtMaVe.Text;
                    ve.MaShow = cbMaShow.Text;
                    ve.MaPhim = cbMaPhim.Text;                
                    ve.GiaVe = txtGiaVe.Text;
                    ve.MaHD = cbMaHD.Text;
                    ve.Ghe = txtGhe.Text;
                    check = ve_BUS.SUAVE(ve);
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
        /// <summary>
        /// Menthod tìm kiếm vé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timkiem(ve_DTO);
        }
        public DataTable timkiem(Ve_DTO ve)
        {
            try
            {
                ve.MaVe = txtMaVe.Text;
                dtVe = ve_BUS.TIMKIEMVE(ve);
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
            finally
            {
                lamMoi();
            }
            dataGridVe.DataSource = dtVe;
            return dtVe;
        }
        /// <summary>
        /// Menthod làm mới các textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaVe.ReadOnly = false;
            lamMoi();
        }
        
        private void txtGiaVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập giá tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        
        private void txtMaVe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaVe_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaVe.TextLength > 9)
            {
                MessageBox.Show("Không được quá 1 tỉ, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiaVe.Clear();
                txtGiaVe.Focus();
            }
        }

        
        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            //this.Hide();

            FormGhe ghe = new FormGhe();
            ghe.ShowDialog();

            this.Close();
            

            ghe = null;

            //xacnhan();
            //this.Close();
        }
            




        

        public frmNhapThongTinVe(string ghe)
        {
            InitializeComponent();
            this.txtGhe.Text = ghe;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtMaVe_Leave(object sender, EventArgs e)
        {

        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbo_MaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_ChiTietHoaDon.DataSource = hoadon_BUS.LAYDANHSACHHOADONCHITIETHOADON(cbo_MaHD.Text);

            
            int thanhtien = 0;
            
            dgv_Thanhtien.DataSource = hoadon_BUS.TONGTEN(cbo_MaHD.Text);

            txt_ThanhTien.Text = dgv_Thanhtien.Rows[0].Cells[0].Value.ToString();



        }

        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
            them(hoadon_DTO);
            txtMaHoaDon.Clear();
            cbMaHD.DataSource = LayDanhMaHD();
            cbMaHD.ValueMember = "MaHD";
            cbMaHD.DisplayMember = "MaHD";
        }

        public bool kTraMaHoaDon(string mave)
        {
            DataGridViewRow row;
            DataGridViewCell cell;
            for (int i = 0; i < dgv_ChiTietHoaDon.Rows.Count - 1; i++)
            {
                row = dgv_ChiTietHoaDon.Rows[i];
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

        public void them(HoaDon_DTO HD)
        {
            //check thêm thành công
            bool check = false;
            if (kTraMaHoaDon(txtMaHoaDon.Text) == true)
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

        private void dgv_ChiTietHoaDon_Click(object sender, EventArgs e)
        {
            int i = dgv_ChiTietHoaDon.CurrentRow.Index;

            txtMaVe.Text = dgv_ChiTietHoaDon.Rows[i].Cells[1].Value.ToString();
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            GUI_reportHoaDon baocao = new GUI_reportHoaDon();
            baocao.Show();
        }
    }
    


}
