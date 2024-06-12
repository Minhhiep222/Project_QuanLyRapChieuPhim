
namespace GUI
{
    partial class GUI_BaoCaoPhimVaPhong
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
            this.crystalReportViewerPhongChieu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.btnPhongChieu = new System.Windows.Forms.Button();
            this.cbPhongChieu = new System.Windows.Forms.ComboBox();
            this.btnHangSX = new System.Windows.Forms.Button();
            this.cbSX = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // crystalReportViewerPhongChieu
            // 
            this.crystalReportViewerPhongChieu.ActiveViewIndex = -1;
            this.crystalReportViewerPhongChieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerPhongChieu.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerPhongChieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerPhongChieu.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerPhongChieu.Name = "crystalReportViewerPhongChieu";
            this.crystalReportViewerPhongChieu.Size = new System.Drawing.Size(982, 547);
            this.crystalReportViewerPhongChieu.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(51, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thể loại phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(59, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Phòng chiếu";
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbTheLoai.ForeColor = System.Drawing.Color.Red;
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(3, 193);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(192, 37);
            this.cbTheLoai.TabIndex = 17;
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTheLoai.ForeColor = System.Drawing.Color.Red;
            this.btnTheLoai.Location = new System.Drawing.Point(222, 172);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(185, 60);
            this.btnTheLoai.TabIndex = 16;
            this.btnTheLoai.Text = "In thông tin thể loại phim";
            this.btnTheLoai.UseVisualStyleBackColor = false;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // btnPhongChieu
            // 
            this.btnPhongChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPhongChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPhongChieu.ForeColor = System.Drawing.Color.Red;
            this.btnPhongChieu.Location = new System.Drawing.Point(222, 65);
            this.btnPhongChieu.Name = "btnPhongChieu";
            this.btnPhongChieu.Size = new System.Drawing.Size(185, 60);
            this.btnPhongChieu.TabIndex = 15;
            this.btnPhongChieu.Text = "In thông tin phòng chiếu";
            this.btnPhongChieu.UseVisualStyleBackColor = false;
            this.btnPhongChieu.Click += new System.EventHandler(this.btnPhongChieu_Click);
            // 
            // cbPhongChieu
            // 
            this.cbPhongChieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbPhongChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbPhongChieu.ForeColor = System.Drawing.Color.Red;
            this.cbPhongChieu.FormattingEnabled = true;
            this.cbPhongChieu.Location = new System.Drawing.Point(3, 83);
            this.cbPhongChieu.Name = "cbPhongChieu";
            this.cbPhongChieu.Size = new System.Drawing.Size(192, 37);
            this.cbPhongChieu.TabIndex = 14;
            // 
            // btnHangSX
            // 
            this.btnHangSX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHangSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHangSX.ForeColor = System.Drawing.Color.Red;
            this.btnHangSX.Location = new System.Drawing.Point(222, 283);
            this.btnHangSX.Name = "btnHangSX";
            this.btnHangSX.Size = new System.Drawing.Size(185, 60);
            this.btnHangSX.TabIndex = 13;
            this.btnHangSX.Text = "In thông tin phim của Việt Nam";
            this.btnHangSX.UseVisualStyleBackColor = false;
            this.btnHangSX.Click += new System.EventHandler(this.btnHangSX_Click);
            // 
            // cbSX
            // 
            this.cbSX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbSX.ForeColor = System.Drawing.Color.Red;
            this.cbSX.FormattingEnabled = true;
            this.cbSX.Location = new System.Drawing.Point(3, 301);
            this.cbSX.Name = "cbSX";
            this.cbSX.Size = new System.Drawing.Size(192, 37);
            this.cbSX.TabIndex = 21;
            // 
            // frmBaoCaoPhimVaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(982, 547);
            this.Controls.Add(this.cbSX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTheLoai);
            this.Controls.Add(this.btnTheLoai);
            this.Controls.Add(this.btnPhongChieu);
            this.Controls.Add(this.cbPhongChieu);
            this.Controls.Add(this.btnHangSX);
            this.Controls.Add(this.crystalReportViewerPhongChieu);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "frmBaoCaoPhimVaPhong";
            this.Text = "frmBaoCaoPhimVaPhong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBaoCaoPhimVaPhong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerPhongChieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.Button btnTheLoai;
        private System.Windows.Forms.Button btnPhongChieu;
        private System.Windows.Forms.ComboBox cbPhongChieu;
        private System.Windows.Forms.Button btnHangSX;
        private System.Windows.Forms.ComboBox cbSX;
    }
}