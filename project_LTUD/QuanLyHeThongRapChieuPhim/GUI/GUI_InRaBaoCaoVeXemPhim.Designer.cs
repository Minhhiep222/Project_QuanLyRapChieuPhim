
namespace GUI
{
    partial class GUI_InRaBaoCaoVeXemPhim
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
            this.crystalReportViewerThongTinVe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTongThanhTien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewerThongTinVe
            // 
            this.crystalReportViewerThongTinVe.ActiveViewIndex = -1;
            this.crystalReportViewerThongTinVe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerThongTinVe.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerThongTinVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerThongTinVe.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerThongTinVe.Name = "crystalReportViewerThongTinVe";
            this.crystalReportViewerThongTinVe.Size = new System.Drawing.Size(1264, 716);
            this.crystalReportViewerThongTinVe.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.comboBox1.Font = new System.Drawing.Font("MV Boli", 12F);
            this.comboBox1.ForeColor = System.Drawing.Color.Red;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 34);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("MV Boli", 13F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(210, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xem thông tin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTongThanhTien
            // 
            this.btnTongThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTongThanhTien.Font = new System.Drawing.Font("MV Boli", 13F);
            this.btnTongThanhTien.ForeColor = System.Drawing.Color.Red;
            this.btnTongThanhTien.Location = new System.Drawing.Point(210, 206);
            this.btnTongThanhTien.Name = "btnTongThanhTien";
            this.btnTongThanhTien.Size = new System.Drawing.Size(196, 104);
            this.btnTongThanhTien.TabIndex = 3;
            this.btnTongThanhTien.Text = "Xem thông tin tổng thành tiền giá vé";
            this.btnTongThanhTien.UseVisualStyleBackColor = false;
            this.btnTongThanhTien.Click += new System.EventHandler(this.btnTongThanhTien_Click);
            // 
            // frmInRaBaoCaoVeXemPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1264, 716);
            this.Controls.Add(this.btnTongThanhTien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.crystalReportViewerThongTinVe);
            this.Name = "frmInRaBaoCaoVeXemPhim";
            this.Text = "frmInRaBaoCaoVeXemPhim";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInRaBaoCaoVeXemPhim_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerThongTinVe;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTongThanhTien;
    }
}