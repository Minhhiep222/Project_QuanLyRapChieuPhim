namespace GUI
{
    partial class frmNhapThongTinPhim
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
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridPhim = new System.Windows.Forms.DataGridView();
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
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.txtHangSanXuat = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmenuThem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 100;
            this.label1.Text = "Tên Phim";
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTenPhim.Location = new System.Drawing.Point(269, 142);
            this.txtTenPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhim.Multiline = true;
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(708, 29);
            this.txtTenPhim.TabIndex = 99;
            this.txtTenPhim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenPhim_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.03077F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(401, 52);
            this.label7.TabIndex = 98;
            this.label7.Text = "THÔNG TIN PHIM";
            // 
            // dataGridPhim
            // 
            this.dataGridPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPhim.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPhim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridPhim.Location = new System.Drawing.Point(0, 455);
            this.dataGridPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridPhim.Name = "dataGridPhim";
            this.dataGridPhim.RowHeadersWidth = 56;
            this.dataGridPhim.RowTemplate.Height = 24;
            this.dataGridPhim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPhim.Size = new System.Drawing.Size(1269, 218);
            this.dataGridPhim.TabIndex = 97;
            this.dataGridPhim.Click += new System.EventHandler(this.dataGridPhim_Click);
            // 
            // btn_Lammoi
            // 
            this.btn_Lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lammoi.Location = new System.Drawing.Point(1024, 193);
            this.btn_Lammoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Lammoi.Name = "btn_Lammoi";
            this.btn_Lammoi.Size = new System.Drawing.Size(199, 57);
            this.btn_Lammoi.TabIndex = 96;
            this.btn_Lammoi.Text = "Làm mới";
            this.btn_Lammoi.UseVisualStyleBackColor = false;
            this.btn_Lammoi.Click += new System.EventHandler(this.btn_Lammoi_Click);
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.BackColor = System.Drawing.Color.White;
            this.btn_Timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Timkiem.Location = new System.Drawing.Point(1024, 60);
            this.btn_Timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(199, 57);
            this.btn_Timkiem.TabIndex = 95;
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
            this.btn_thayDoi.Location = new System.Drawing.Point(31, 352);
            this.btn_thayDoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thayDoi.Name = "btn_thayDoi";
            this.btn_thayDoi.Size = new System.Drawing.Size(199, 57);
            this.btn_thayDoi.TabIndex = 93;
            this.btn_thayDoi.Text = "Thay Đổi";
            this.btn_thayDoi.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(269, 352);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(199, 57);
            this.btnThem.TabIndex = 92;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(532, 352);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(199, 57);
            this.btnXoa.TabIndex = 91;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(780, 352);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(199, 57);
            this.btnSua.TabIndex = 94;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(1024, 352);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(199, 57);
            this.btnThoat.TabIndex = 90;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 30);
            this.label2.TabIndex = 89;
            this.label2.Text = "Hãng Sản Xuất";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 30);
            this.label4.TabIndex = 88;
            this.label4.Text = "Thể Loại";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 30);
            this.label3.TabIndex = 87;
            this.label3.Text = "Mã Phim";
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.BackColor = System.Drawing.Color.White;
            this.txtMaPhim.Location = new System.Drawing.Point(269, 75);
            this.txtMaPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhim.Multiline = true;
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(709, 29);
            this.txtMaPhim.TabIndex = 85;
            this.txtMaPhim.TextChanged += new System.EventHandler(this.txtMaPhim_TextChanged);
            // 
            // txtHangSanXuat
            // 
            this.txtHangSanXuat.BackColor = System.Drawing.Color.White;
            this.txtHangSanXuat.Location = new System.Drawing.Point(269, 286);
            this.txtHangSanXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHangSanXuat.Multiline = true;
            this.txtHangSanXuat.Name = "txtHangSanXuat";
            this.txtHangSanXuat.Size = new System.Drawing.Size(708, 27);
            this.txtHangSanXuat.TabIndex = 84;
            this.txtHangSanXuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHangSanXuat_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 100);
            // 
            // ctxmenuThem
            // 
            this.ctxmenuThem.Name = "ctxmenuThem";
            this.ctxmenuThem.Size = new System.Drawing.Size(116, 24);
            this.ctxmenuThem.Text = "Thêm";
            // 
            // ctxmenuXoa
            // 
            this.ctxmenuXoa.Name = "ctxmenuXoa";
            this.ctxmenuXoa.Size = new System.Drawing.Size(116, 24);
            this.ctxmenuXoa.Text = "Xóa";
            // 
            // ctxmenuSua
            // 
            this.ctxmenuSua.Name = "ctxmenuSua";
            this.ctxmenuSua.Size = new System.Drawing.Size(116, 24);
            this.ctxmenuSua.Text = "Sửa";
            // 
            // ctxmenuThoat
            // 
            this.ctxmenuThoat.Name = "ctxmenuThoat";
            this.ctxmenuThoat.Size = new System.Drawing.Size(116, 24);
            this.ctxmenuThoat.Text = "Thoát";
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(269, 210);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(708, 28);
            this.cbTheLoai.TabIndex = 101;
            // 
            // frmNhapThongTinPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1269, 673);
            this.ControlBox = false;
            this.Controls.Add(this.cbTheLoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridPhim);
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
            this.Controls.Add(this.txtMaPhim);
            this.Controls.Add(this.txtHangSanXuat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhapThongTinPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Thông Tin Phim";
            this.Load += new System.EventHandler(this.frmNhapThongTinPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridPhim;
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
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.TextBox txtHangSanXuat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuThem;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuXoa;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuSua;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuThoat;
        private System.Windows.Forms.ComboBox cbTheLoai;
    }
}