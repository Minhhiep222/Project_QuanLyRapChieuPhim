
namespace GUI
{
    partial class GUI_THONGTINLICHCHIEU
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
            this.timeGioChieu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaPhim = new System.Windows.Forms.ComboBox();
            this.dataGridLichChieu = new System.Windows.Forms.DataGridView();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dateNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctxmenuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.ctxmenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmenuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMaShow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLichChieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeGioChieu
            // 
            this.timeGioChieu.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeGioChieu.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeGioChieu.Location = new System.Drawing.Point(251, 270);
            this.timeGioChieu.Margin = new System.Windows.Forms.Padding(4);
            this.timeGioChieu.Name = "timeGioChieu";
            this.timeGioChieu.Size = new System.Drawing.Size(720, 42);
            this.timeGioChieu.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(237, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(817, 80);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nhập thông tin lịch chiếu";
            // 
            // cbMaPhim
            // 
            this.cbMaPhim.BackColor = System.Drawing.Color.White;
            this.cbMaPhim.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaPhim.ForeColor = System.Drawing.Color.Red;
            this.cbMaPhim.FormattingEnabled = true;
            this.cbMaPhim.Location = new System.Drawing.Point(251, 148);
            this.cbMaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaPhim.Name = "cbMaPhim";
            this.cbMaPhim.Size = new System.Drawing.Size(254, 37);
            this.cbMaPhim.TabIndex = 31;
            // 
            // dataGridLichChieu
            // 
            this.dataGridLichChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLichChieu.BackgroundColor = System.Drawing.Color.White;
            this.dataGridLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLichChieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridLichChieu.GridColor = System.Drawing.Color.White;
            this.dataGridLichChieu.Location = new System.Drawing.Point(0, 439);
            this.dataGridLichChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridLichChieu.Name = "dataGridLichChieu";
            this.dataGridLichChieu.RowHeadersWidth = 51;
            this.dataGridLichChieu.RowTemplate.Height = 24;
            this.dataGridLichChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLichChieu.Size = new System.Drawing.Size(1269, 234);
            this.dataGridLichChieu.TabIndex = 30;
            this.dataGridLichChieu.Click += new System.EventHandler(this.dataGridLichChieu_Click);
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThayDoi.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoi.ForeColor = System.Drawing.Color.Red;
            this.btnThayDoi.Location = new System.Drawing.Point(140, 318);
            this.btnThayDoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(180, 53);
            this.btnThayDoi.TabIndex = 29;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Red;
            this.btnTimKiem.Location = new System.Drawing.Point(987, 156);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(180, 62);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLamMoi.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Red;
            this.btnLamMoi.Location = new System.Drawing.Point(987, 249);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(180, 63);
            this.btnLamMoi.TabIndex = 27;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dateNgayChieu
            // 
            this.dateNgayChieu.CalendarForeColor = System.Drawing.Color.Red;
            this.dateNgayChieu.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dateNgayChieu.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dateNgayChieu.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dateNgayChieu.CalendarTrailingForeColor = System.Drawing.Color.Red;
            this.dateNgayChieu.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayChieu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateNgayChieu.Location = new System.Drawing.Point(251, 206);
            this.dateNgayChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateNgayChieu.Name = "dateNgayChieu";
            this.dateNgayChieu.Size = new System.Drawing.Size(720, 42);
            this.dateNgayChieu.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctxmenuThoat
            // 
            this.ctxmenuThoat.Name = "ctxmenuThoat";
            this.ctxmenuThoat.Size = new System.Drawing.Size(119, 26);
            this.ctxmenuThoat.Text = "Thoát";
            // 
            // ctxmenuSua
            // 
            this.ctxmenuSua.Name = "ctxmenuSua";
            this.ctxmenuSua.Size = new System.Drawing.Size(119, 26);
            this.ctxmenuSua.Text = "Sửa";
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.BackColor = System.Drawing.Color.White;
            this.cbMaPhong.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaPhong.ForeColor = System.Drawing.Color.Red;
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(717, 147);
            this.cbMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(254, 37);
            this.cbMaPhong.TabIndex = 33;
            // 
            // ctxmenuXoa
            // 
            this.ctxmenuXoa.Name = "ctxmenuXoa";
            this.ctxmenuXoa.Size = new System.Drawing.Size(119, 26);
            this.ctxmenuXoa.Text = "Xóa";
            // 
            // contextMenuStrip1
            // 
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
            // txtMaShow
            // 
            this.txtMaShow.BackColor = System.Drawing.Color.White;
            this.txtMaShow.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaShow.ForeColor = System.Drawing.Color.Red;
            this.txtMaShow.Location = new System.Drawing.Point(251, 79);
            this.txtMaShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaShow.Multiline = true;
            this.txtMaShow.Name = "txtMaShow";
            this.txtMaShow.Size = new System.Drawing.Size(720, 45);
            this.txtMaShow.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(101, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 37);
            this.label6.TabIndex = 21;
            this.label6.Text = "Giờ chiếu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(81, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 37);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ngày chiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(563, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mã phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(105, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mã phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(112, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 25;
            this.label1.Text = "MaShow";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(325, 318);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 53);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(512, 318);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 53);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Location = new System.Drawing.Point(699, 318);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 53);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnThoat.Location = new System.Drawing.Point(884, 318);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 53);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // GUI_THONGTINLICHCHIEU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1269, 673);
            this.ControlBox = false;
            this.Controls.Add(this.timeGioChieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaPhim);
            this.Controls.Add(this.dataGridLichChieu);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dateNgayChieu);
            this.Controls.Add(this.cbMaPhong);
            this.Controls.Add(this.txtMaShow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "GUI_THONGTINLICHCHIEU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Lịch Chiếu";
            this.Load += new System.EventHandler(this.GUI_THONGTINLICHCHIEU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLichChieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timeGioChieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaPhim;
        private System.Windows.Forms.DataGridView dataGridLichChieu;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DateTimePicker dateNgayChieu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.TextBox txtMaShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuThoat;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuSua;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuXoa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuThem;
    }
}