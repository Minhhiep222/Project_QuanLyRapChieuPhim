
namespace GUI
{
    partial class frmNhapThongTinVe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bthThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmenuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.dataGridVe = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaShow = new System.Windows.Forms.ComboBox();
            this.cbMaPhim = new System.Windows.Forms.ComboBox();
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChonGhe = new System.Windows.Forms.Button();
            this.txtGhe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_ThemHoaDon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMaRap = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_baocao = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbo_MaHD = new System.Windows.Forms.ComboBox();
            this.dgv_ChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgv_Thanhtien = new System.Windows.Forms.DataGridView();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thanhtien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.BackColor = System.Drawing.Color.White;
            this.txtGiaVe.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaVe.ForeColor = System.Drawing.Color.Red;
            this.txtGiaVe.Location = new System.Drawing.Point(167, 183);
            this.txtGiaVe.Multiline = true;
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(246, 45);
            this.txtGiaVe.TabIndex = 0;
            this.txtGiaVe.TextChanged += new System.EventHandler(this.txtGiaVe_TextChanged);
            this.txtGiaVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaVe_KeyPress);
            // 
            // txtMaVe
            // 
            this.txtMaVe.BackColor = System.Drawing.Color.White;
            this.txtMaVe.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVe.ForeColor = System.Drawing.Color.Red;
            this.txtMaVe.Location = new System.Drawing.Point(167, 63);
            this.txtMaVe.Multiline = true;
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(246, 40);
            this.txtMaVe.TabIndex = 0;
            this.txtMaVe.Leave += new System.EventHandler(this.txtMaVe_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(51, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(444, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(55, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá vé";
            // 
            // bthThoat
            // 
            this.bthThoat.BackColor = System.Drawing.Color.White;
            this.bthThoat.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthThoat.ForeColor = System.Drawing.Color.Red;
            this.bthThoat.Location = new System.Drawing.Point(717, 561);
            this.bthThoat.Name = "bthThoat";
            this.bthThoat.Size = new System.Drawing.Size(160, 44);
            this.bthThoat.TabIndex = 2;
            this.bthThoat.Text = "Thoát";
            this.bthThoat.UseVisualStyleBackColor = false;
            this.bthThoat.Click += new System.EventHandler(this.bthThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Window;
            this.btnSua.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.Location = new System.Drawing.Point(616, 360);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(153, 57);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Window;
            this.btnXoa.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.Location = new System.Drawing.Point(424, 360);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(153, 57);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.Window;
            this.btnThem.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.Location = new System.Drawing.Point(235, 360);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(153, 57);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.bthThem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmenuThem,
            this.ctxmenuXoa,
            this.ctxmenuSua,
            this.ctxmenuThoat});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 108);
            // 
            // ctxmenuThem
            // 
            this.ctxmenuThem.Name = "ctxmenuThem";
            this.ctxmenuThem.Size = new System.Drawing.Size(119, 26);
            this.ctxmenuThem.Text = "Thêm";
            this.ctxmenuThem.Click += new System.EventHandler(this.bthThem_Click);
            // 
            // ctxmenuXoa
            // 
            this.ctxmenuXoa.Name = "ctxmenuXoa";
            this.ctxmenuXoa.Size = new System.Drawing.Size(119, 26);
            this.ctxmenuXoa.Text = "Xóa";
            this.ctxmenuXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // ctxmenuSua
            // 
            this.ctxmenuSua.Name = "ctxmenuSua";
            this.ctxmenuSua.Size = new System.Drawing.Size(119, 26);
            this.ctxmenuSua.Text = "Sửa";
            // 
            // ctxmenuThoat
            // 
            this.ctxmenuThoat.Name = "ctxmenuThoat";
            this.ctxmenuThoat.Size = new System.Drawing.Size(119, 26);
            this.ctxmenuThoat.Text = "Thoát";
            this.ctxmenuThoat.Click += new System.EventHandler(this.bthThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.btnTimKiem.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimKiem.Location = new System.Drawing.Point(594, 263);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(185, 46);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLamMoi.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Red;
            this.btnLamMoi.Location = new System.Drawing.Point(594, 190);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(185, 49);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThayDoi.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoi.ForeColor = System.Drawing.Color.Red;
            this.btnThayDoi.Location = new System.Drawing.Point(50, 360);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(157, 57);
            this.btnThayDoi.TabIndex = 5;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = false;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // dataGridVe
            // 
            this.dataGridVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVe.BackgroundColor = System.Drawing.Color.White;
            this.dataGridVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVe.GridColor = System.Drawing.Color.White;
            this.dataGridVe.Location = new System.Drawing.Point(6, 468);
            this.dataGridVe.Name = "dataGridVe";
            this.dataGridVe.RowHeadersWidth = 51;
            this.dataGridVe.RowTemplate.Height = 24;
            this.dataGridVe.Size = new System.Drawing.Size(936, 196);
            this.dataGridVe.TabIndex = 6;
            this.dataGridVe.Click += new System.EventHandler(this.dataGridVe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã show";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(464, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã HD";
            // 
            // cbMaShow
            // 
            this.cbMaShow.BackColor = System.Drawing.Color.White;
            this.cbMaShow.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaShow.ForeColor = System.Drawing.Color.Red;
            this.cbMaShow.FormattingEnabled = true;
            this.cbMaShow.Location = new System.Drawing.Point(167, 123);
            this.cbMaShow.Name = "cbMaShow";
            this.cbMaShow.Size = new System.Drawing.Size(246, 37);
            this.cbMaShow.TabIndex = 11;
            // 
            // cbMaPhim
            // 
            this.cbMaPhim.BackColor = System.Drawing.Color.White;
            this.cbMaPhim.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaPhim.ForeColor = System.Drawing.Color.Red;
            this.cbMaPhim.FormattingEnabled = true;
            this.cbMaPhim.Location = new System.Drawing.Point(585, 124);
            this.cbMaPhim.Name = "cbMaPhim";
            this.cbMaPhim.Size = new System.Drawing.Size(194, 37);
            this.cbMaPhim.TabIndex = 12;
            // 
            // cbMaHD
            // 
            this.cbMaHD.BackColor = System.Drawing.Color.White;
            this.cbMaHD.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaHD.ForeColor = System.Drawing.Color.Red;
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(585, 63);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(194, 37);
            this.cbMaHD.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Forte", 22.15385F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(399, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 45);
            this.label7.TabIndex = 15;
            this.label7.Text = "Thêm Vé";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnChonGhe
            // 
            this.btnChonGhe.BackColor = System.Drawing.Color.White;
            this.btnChonGhe.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonGhe.ForeColor = System.Drawing.Color.Red;
            this.btnChonGhe.Location = new System.Drawing.Point(81, 258);
            this.btnChonGhe.Name = "btnChonGhe";
            this.btnChonGhe.Size = new System.Drawing.Size(159, 45);
            this.btnChonGhe.TabIndex = 16;
            this.btnChonGhe.Text = "Chọn ghế";
            this.btnChonGhe.UseVisualStyleBackColor = false;
            this.btnChonGhe.Click += new System.EventHandler(this.btnChonGhe_Click);
            // 
            // txtGhe
            // 
            this.txtGhe.BackColor = System.Drawing.Color.White;
            this.txtGhe.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhe.ForeColor = System.Drawing.Color.Red;
            this.txtGhe.Location = new System.Drawing.Point(260, 264);
            this.txtGhe.Multiline = true;
            this.txtGhe.Name = "txtGhe";
            this.txtGhe.Size = new System.Drawing.Size(153, 45);
            this.txtGhe.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGiaVe);
            this.groupBox1.Controls.Add(this.txtGhe);
            this.groupBox1.Controls.Add(this.txtMaVe);
            this.groupBox1.Controls.Add(this.btnThayDoi);
            this.groupBox1.Controls.Add(this.btnChonGhe);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMaHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbMaPhim);
            this.groupBox1.Controls.Add(this.cbMaShow);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.dataGridVe);
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 850);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vé";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btn_ThemHoaDon);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbMaNhanVien);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtMaHoaDon);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbMaKhachHang);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbMaRap);
            this.groupBox2.Location = new System.Drawing.Point(12, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1851, 196);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(766, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(523, 71);
            this.label14.TabIndex = 19;
            this.label14.Text = "Thông tin hóa đơn";
            // 
            // btn_ThemHoaDon
            // 
            this.btn_ThemHoaDon.BackColor = System.Drawing.Color.White;
            this.btn_ThemHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ThemHoaDon.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_ThemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHoaDon.Location = new System.Drawing.Point(1637, 139);
            this.btn_ThemHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemHoaDon.Name = "btn_ThemHoaDon";
            this.btn_ThemHoaDon.Size = new System.Drawing.Size(160, 42);
            this.btn_ThemHoaDon.TabIndex = 131;
            this.btn_ThemHoaDon.Text = "Thêm";
            this.btn_ThemHoaDon.UseVisualStyleBackColor = false;
            this.btn_ThemHoaDon.Click += new System.EventHandler(this.btn_ThemHoaDon_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(632, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 26);
            this.label9.TabIndex = 125;
            this.label9.Text = "Mã Rạp";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cbMaNhanVien
            // 
            this.cbMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNhanVien.FormattingEnabled = true;
            this.cbMaNhanVien.Location = new System.Drawing.Point(1196, 96);
            this.cbMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaNhanVien.Name = "cbMaNhanVien";
            this.cbMaNhanVien.Size = new System.Drawing.Size(185, 24);
            this.cbMaNhanVien.TabIndex = 128;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1418, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 24);
            this.label10.TabIndex = 124;
            this.label10.Text = "Mã Khách Hàng";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.Color.White;
            this.txtMaHoaDon.Location = new System.Drawing.Point(453, 96);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHoaDon.Multiline = true;
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(153, 25);
            this.txtMaHoaDon.TabIndex = 121;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(999, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 26);
            this.label11.TabIndex = 123;
            this.label11.Text = "Mã Nhân Viên";
            // 
            // cbMaKhachHang
            // 
            this.cbMaKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKhachHang.FormattingEnabled = true;
            this.cbMaKhachHang.Location = new System.Drawing.Point(1637, 98);
            this.cbMaKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaKhachHang.Name = "cbMaKhachHang";
            this.cbMaKhachHang.Size = new System.Drawing.Size(160, 24);
            this.cbMaKhachHang.TabIndex = 127;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(275, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 25);
            this.label12.TabIndex = 122;
            this.label12.Text = "Mã Hóa Đơn";
            // 
            // cbMaRap
            // 
            this.cbMaRap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaRap.FormattingEnabled = true;
            this.cbMaRap.Location = new System.Drawing.Point(790, 96);
            this.cbMaRap.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaRap.Name = "cbMaRap";
            this.cbMaRap.Size = new System.Drawing.Size(158, 24);
            this.cbMaRap.TabIndex = 126;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_ThanhTien);
            this.groupBox3.Controls.Add(this.dgv_Thanhtien);
            this.groupBox3.Controls.Add(this.btn_baocao);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.bthThoat);
            this.groupBox3.Controls.Add(this.cbo_MaHD);
            this.groupBox3.Controls.Add(this.dgv_ChiTietHoaDon);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(966, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(897, 850);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết";
            // 
            // btn_baocao
            // 
            this.btn_baocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_baocao.Font = new System.Drawing.Font("MV Boli", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baocao.ForeColor = System.Drawing.Color.Red;
            this.btn_baocao.Location = new System.Drawing.Point(6, 520);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(185, 49);
            this.btn_baocao.TabIndex = 18;
            this.btn_baocao.Text = "IN CHI TIẾT";
            this.btn_baocao.UseVisualStyleBackColor = false;
            this.btn_baocao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(507, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "Thành tiền";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 458);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 31);
            this.label15.TabIndex = 18;
            this.label15.Text = "Mã Hóa Đơn";
            // 
            // cbo_MaHD
            // 
            this.cbo_MaHD.FormattingEnabled = true;
            this.cbo_MaHD.Location = new System.Drawing.Point(188, 458);
            this.cbo_MaHD.Name = "cbo_MaHD";
            this.cbo_MaHD.Size = new System.Drawing.Size(121, 24);
            this.cbo_MaHD.TabIndex = 19;
            this.cbo_MaHD.SelectedIndexChanged += new System.EventHandler(this.cbo_MaHD_SelectedIndexChanged);
            // 
            // dgv_ChiTietHoaDon
            // 
            this.dgv_ChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietHoaDon.GridColor = System.Drawing.Color.White;
            this.dgv_ChiTietHoaDon.Location = new System.Drawing.Point(0, 122);
            this.dgv_ChiTietHoaDon.Name = "dgv_ChiTietHoaDon";
            this.dgv_ChiTietHoaDon.RowHeadersWidth = 51;
            this.dgv_ChiTietHoaDon.RowTemplate.Height = 24;
            this.dgv_ChiTietHoaDon.Size = new System.Drawing.Size(909, 315);
            this.dgv_ChiTietHoaDon.TabIndex = 18;
            this.dgv_ChiTietHoaDon.Click += new System.EventHandler(this.dgv_ChiTietHoaDon_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Forte", 22.15385F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(318, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(294, 45);
            this.label13.TabIndex = 16;
            this.label13.Text = "Chi tiết hóa đơn";
            // 
            // dgv_Thanhtien
            // 
            this.dgv_Thanhtien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Thanhtien.Location = new System.Drawing.Point(683, 468);
            this.dgv_Thanhtien.Name = "dgv_Thanhtien";
            this.dgv_Thanhtien.RowHeadersWidth = 56;
            this.dgv_Thanhtien.RowTemplate.Height = 24;
            this.dgv_Thanhtien.Size = new System.Drawing.Size(10, 10);
            this.dgv_Thanhtien.TabIndex = 21;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(683, 455);
            this.txt_ThanhTien.Multiline = true;
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.Size = new System.Drawing.Size(194, 34);
            this.txt_ThanhTien.TabIndex = 22;
            // 
            // frmNhapThongTinVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1870, 845);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNhapThongTinVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin vé";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapThongTinVe_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thanhtien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bthThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuThem;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuXoa;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuSua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuThoat;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataGridVe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaHD;
        private System.Windows.Forms.ComboBox cbMaPhim;
        private System.Windows.Forms.ComboBox cbMaShow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChonGhe;
        private System.Windows.Forms.TextBox txtGhe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMaNhanVien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMaKhachHang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMaRap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_ChiTietHoaDon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_ThemHoaDon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbo_MaHD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_baocao;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgv_Thanhtien;
        private System.Windows.Forms.TextBox txt_ThanhTien;
    }
}