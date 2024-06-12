namespace GUI
{
    partial class frmNhapThongTinHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridHoaDon = new System.Windows.Forms.DataGridView();
            this.btn_Lammoi = new System.Windows.Forms.Button();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.btn_thayDoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.cbMaRap = new System.Windows.Forms.ComboBox();
            this.cbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.cbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmenuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_chitiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHoaDon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 117;
            this.label1.Text = "Mã Rạp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.03077F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(541, 55);
            this.label7.TabIndex = 115;
            this.label7.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // dataGridHoaDon
            // 
            this.dataGridHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridHoaDon.Location = new System.Drawing.Point(0, 455);
            this.dataGridHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridHoaDon.Name = "dataGridHoaDon";
            this.dataGridHoaDon.RowHeadersWidth = 56;
            this.dataGridHoaDon.RowTemplate.Height = 24;
            this.dataGridHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHoaDon.Size = new System.Drawing.Size(1269, 218);
            this.dataGridHoaDon.TabIndex = 114;
            this.dataGridHoaDon.Click += new System.EventHandler(this.dataGridHoaDon_Click);
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lammoi.Location = new System.Drawing.Point(1024, 153);
            this.btn_Lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(199, 57);
            this.btn_Lammoi.TabIndex = 113;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.BackColor = System.Drawing.Color.White;
            this.btn_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timkiem.Location = new System.Drawing.Point(1024, 59);
            this.btn_Timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(199, 57);
            this.btn_Timkiem.TabIndex = 112;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = false;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // btn_thayDoi
            // 
            this.btn_thayDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_thayDoi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_thayDoi.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_thayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thayDoi.Location = new System.Drawing.Point(31, 351);
            this.btn_thayDoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thayDoi.Name = "btn_thayDoi";
            this.btn_thayDoi.Size = new System.Drawing.Size(199, 57);
            this.btn_thayDoi.TabIndex = 110;
            this.btn_thayDoi.Text = "Thay Đổi";
            this.btn_thayDoi.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(269, 351);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(199, 57);
            this.btnThem.TabIndex = 109;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(532, 351);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(199, 57);
            this.btnXoa.TabIndex = 108;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(780, 351);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(199, 57);
            this.btnSua.TabIndex = 111;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(1024, 351);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(199, 57);
            this.btnThoat.TabIndex = 107;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 30);
            this.label2.TabIndex = 106;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 30);
            this.label4.TabIndex = 105;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 30);
            this.label3.TabIndex = 104;
            this.label3.Text = "Mã Hóa Đơn";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.Color.White;
            this.txtMaHoaDon.Location = new System.Drawing.Point(269, 74);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaHoaDon.Multiline = true;
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(709, 27);
            this.txtMaHoaDon.TabIndex = 102;
            this.txtMaHoaDon.TextChanged += new System.EventHandler(this.txtMaHoaDon_TextChanged);
            // 
            // cbMaRap
            // 
            this.cbMaRap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaRap.FormattingEnabled = true;
            this.cbMaRap.Location = new System.Drawing.Point(269, 144);
            this.cbMaRap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaRap.Name = "cbMaRap";
            this.cbMaRap.Size = new System.Drawing.Size(709, 24);
            this.cbMaRap.TabIndex = 118;
            // 
            // cbMaKhachHang
            // 
            this.cbMaKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKhachHang.FormattingEnabled = true;
            this.cbMaKhachHang.Location = new System.Drawing.Point(269, 284);
            this.cbMaKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaKhachHang.Name = "cbMaKhachHang";
            this.cbMaKhachHang.Size = new System.Drawing.Size(708, 24);
            this.cbMaKhachHang.TabIndex = 119;
            // 
            // cbMaNhanVien
            // 
            this.cbMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNhanVien.FormattingEnabled = true;
            this.cbMaNhanVien.Location = new System.Drawing.Point(268, 206);
            this.cbMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaNhanVien.Name = "cbMaNhanVien";
            this.cbMaNhanVien.Size = new System.Drawing.Size(709, 24);
            this.cbMaNhanVien.TabIndex = 120;
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
            // 
            // ctxmenuXoa
            // 
            this.ctxmenuXoa.Name = "ctxmenuXoa";
            this.ctxmenuXoa.Size = new System.Drawing.Size(119, 26);
            this.ctxmenuXoa.Text = "Xóa";
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
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_chitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chitiet.Location = new System.Drawing.Point(1024, 264);
            this.btn_chitiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.Size = new System.Drawing.Size(199, 57);
            this.btn_chitiet.TabIndex = 113;
            this.btn_chitiet.Text = "In Chi Tiết";
            this.btn_chitiet.UseVisualStyleBackColor = false;
            this.btn_chitiet.Click += new System.EventHandler(this.btn_chitiet_Click);
            // 
            // frmNhapThongTinHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1269, 673);
            this.ControlBox = false;
            this.Controls.Add(this.cbMaNhanVien);
            this.Controls.Add(this.cbMaKhachHang);
            this.Controls.Add(this.cbMaRap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridHoaDon);
            this.Controls.Add(this.btn_chitiet);
            this.Controls.Add(this.btn_Lammoi);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.btn_thayDoi);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaHoaDon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNhapThongTinHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin hóa đơn";
            this.Load += new System.EventHandler(this.frmNhapThongTinHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHoaDon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridHoaDon;
        private System.Windows.Forms.Button btn_Lammoi;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.Button btn_thayDoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.ComboBox cbMaRap;
        private System.Windows.Forms.ComboBox cbMaKhachHang;
        private System.Windows.Forms.ComboBox cbMaNhanVien;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuThem;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuXoa;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuSua;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_chitiet;
    }
}