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
    public partial class GUI_THONGTINLICHCHIEU : Form
    {
        LichChieu_BUS lichchieu_BUS = new LichChieu_BUS();
        LichChieu_DTO lichchieu_DTO = new LichChieu_DTO();
        public static GUI_THONGTINLICHCHIEU instance;
        public static GUI_THONGTINLICHCHIEU Instance
        {
            get
            {
                //Đảm bảo luôn chỉ có duy nhất 1 instance của Form2 được khởi tạo
                if (instance == null || instance.IsDisposed)
                {
                    instance = new GUI_THONGTINLICHCHIEU();
                }
                return instance;
            }
        }
        public GUI_THONGTINLICHCHIEU()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Lay du lieu len tu database
        /// </summary>
        DataTable dtLichChieu;
        /// <summary>
        /// Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GUI_THONGTINLICHCHIEU_Load(object sender, EventArgs e)
        {
            //btnThem.Enabled = false;
            //btnXoa.Enabled = false;
            //btnSua.Enabled = false;
            //ctxmenuThem.Enabled = false;
            //ctxmenuXoa.Enabled = false;

            dataGridLichChieu.DataSource = LayDanhSachLichChieu();
            cbMaPhim.DataSource = LayDanhSachPhim();
            cbMaPhim.ValueMember = "MaPhim";
            cbMaPhim.DisplayMember = "MaPhim";
            cbMaPhong.DataSource = LayDanhSachPhong();
            cbMaPhong.ValueMember = "MaPhong";
            cbMaPhong.DisplayMember = "MaPhong";
        }
        /// <summary>
        /// Menthod lấy danh sách lịch chiếu
        /// </summary>
        /// <returns></returns>
        public DataTable LayDanhSachLichChieu()
        {
            return lichchieu_BUS.LayDSMASHOW();
        }
        /// <summary>
        /// Menthod lấy danh sách phim
        /// </summary>
        /// <returns></returns>
        public DataTable LayDanhSachPhim()
        {
            return lichchieu_BUS.LayDSMAPHIM();
        }
        ///// <summary>
        ///// Menthod lay danh sach phong
        ///// </summary>
        ///// <returns></returns>
        public DataTable LayDanhSachPhong()
        {
            return lichchieu_BUS.LayDSMAPHONG();
        }

        /// <summary>
        /// Ham kiem tra
        /// </summary>
        /// <returns></returns>
        bool ktra()
        {
            if (txtMaShow.Text == "")
            {
                MessageBox.Show("Ban can nhap ma show");
                txtMaShow.Focus();
                return false;
            }
            if (dateNgayChieu.Value >= DateTime.Now)
            {
                MessageBox.Show("Ban can chon ngay chieu");
                dateNgayChieu.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// Ham kiem tra ma Show
        /// </summary>
        /// <param name="maShow"></param>
        /// <returns></returns>
        public bool ktraMaShow(string maShow)
        {
            DataGridViewRow row;
            DataGridViewCell cell;
            for (int i = 0; i < dataGridLichChieu.Rows.Count - 1; i++)
            {
                row = dataGridLichChieu.Rows[i];
                cell = row.Cells[0];

                if (maShow == cell.Value.ToString())
                {
                    MessageBox.Show("Mã Show " + txtMaShow.Text + " đã tồn tại vui lòng nhập mã khác");
                    txtMaShow.Focus();
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Ham lam moi cac textbox
        /// </summary>
        public void lamMoi()
        {
            // Lam moi cac textbox
            txtMaShow.Text = "";
            // Load lai form
            dataGridLichChieu.DataSource = LayDanhSachLichChieu();
        }

        /// <summary>
        /// Menthod them lich chieu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            them(lichchieu_DTO);
        }
        public void them(LichChieu_DTO lichchieu)
        {
            //check thêm thành công
            bool check = false;
            if (ktra() == true && ktraMaShow(txtMaShow.Text) == true)
            {
                try
                {
                    lichchieu.MaShow = txtMaShow.Text;
                    lichchieu.MaPhim = cbMaPhim.Text;
                    lichchieu.MaPhong = cbMaPhong.Text;
                    lichchieu.NgayChieu = dateNgayChieu.Value;
                    lichchieu.GioChieu = timeGioChieu.Value;
                    check = lichchieu_BUS.THEMLICHCHIEU(lichchieu);
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
        /// Menthod xoa lich chieu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa(lichchieu_DTO);
        }
        public void xoa(LichChieu_DTO lichchieu)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa lịch chiếu này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    lichchieu.MaShow = txtMaShow.Text;
                    check = lichchieu_BUS.XOALICHCHIEU(lichchieu);
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
        /// Sua lich chieu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            sua(lichchieu_DTO);
        }
        public void sua(LichChieu_DTO lichchieu)
        {
            bool check = false;
            DialogResult kq = MessageBox.Show("Bạn có muốn sủa lịch chiếu này không", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    lichchieu.MaShow = txtMaShow.Text;
                    lichchieu.MaPhim = cbMaPhim.Text;
                    lichchieu.MaPhong = cbMaPhong.Text;
                    lichchieu.NgayChieu = dateNgayChieu.Value;
                    lichchieu.GioChieu = timeGioChieu.Value;
                    check = lichchieu_BUS.SUALICHCHIEU(lichchieu);
                    if (check == true)
                    {
                        MessageBox.Show("Sửa thành công!");
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
                        lamMoi();
                    }
                }
            }
        }
        /// <summary>
        /// Menthod lam moi cac textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaShow.ReadOnly = false;
            lamMoi();
        }
        /// <summary>
        /// Menthod tim kiem lich chieu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timkiem(lichchieu_DTO);
        }
        public DataTable timkiem(LichChieu_DTO lichchieu)
        {
            try
            {
                lichchieu.MaShow = txtMaShow.Text;
                dtLichChieu = lichchieu_BUS.TIMKIEMLICHCHIEU(lichchieu);
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
            finally
            {
                lamMoi();
            }
            dataGridLichChieu.DataSource = dtLichChieu;
            return dtLichChieu;
        }
        /// <summary>
        /// Menthod thay doi lich chieu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>=
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            //frmDungNutThayDoi thaydoi = new frmDungNutThayDoi();
            //thaydoi.Show(); 
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

        private void txtMaShow_TextChanged(object sender, EventArgs e)
        {
            if (txtMaShow.TextLength > 10)
            {
                MessageBox.Show("Mã show chỉ được 10 kí tự, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaShow.Clear();
                txtMaShow.Focus();
            }
        }


        /// <summary>
        /// Lay tu datagrid len cac textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridLichChieu_Click(object sender, EventArgs e)
        {
            txtMaShow.ReadOnly = true;
            int i = dataGridLichChieu.CurrentRow.Index;
            txtMaShow.Text = dataGridLichChieu.Rows[i].Cells[0].Value.ToString();
            cbMaPhim.Text = dataGridLichChieu.Rows[i].Cells[1].Value.ToString();
            cbMaPhong.Text = dataGridLichChieu.Rows[i].Cells[2].Value.ToString();
            dateNgayChieu.Text = dataGridLichChieu.Rows[i].Cells[3].Value.ToString();
            timeGioChieu.Text = dataGridLichChieu.Rows[i].Cells[4].Value.ToString();
        }
    }
}
