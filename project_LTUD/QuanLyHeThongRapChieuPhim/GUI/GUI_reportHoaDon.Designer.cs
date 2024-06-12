
namespace GUI
{
    partial class GUI_reportHoaDon
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
            this.cpt_hoadon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbo_MaHD = new System.Windows.Forms.ComboBox();
            this.btn_inchitiet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cpt_hoadon
            // 
            this.cpt_hoadon.ActiveViewIndex = -1;
            this.cpt_hoadon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpt_hoadon.Cursor = System.Windows.Forms.Cursors.Default;
            this.cpt_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpt_hoadon.Location = new System.Drawing.Point(0, 0);
            this.cpt_hoadon.Name = "cpt_hoadon";
            this.cpt_hoadon.Size = new System.Drawing.Size(1126, 718);
            this.cpt_hoadon.TabIndex = 0;
            // 
            // cbo_MaHD
            // 
            this.cbo_MaHD.FormattingEnabled = true;
            this.cbo_MaHD.Location = new System.Drawing.Point(237, 138);
            this.cbo_MaHD.Name = "cbo_MaHD";
            this.cbo_MaHD.Size = new System.Drawing.Size(136, 24);
            this.cbo_MaHD.TabIndex = 1;
            // 
            // btn_inchitiet
            // 
            this.btn_inchitiet.Location = new System.Drawing.Point(237, 206);
            this.btn_inchitiet.Name = "btn_inchitiet";
            this.btn_inchitiet.Size = new System.Drawing.Size(136, 37);
            this.btn_inchitiet.TabIndex = 2;
            this.btn_inchitiet.Text = "In Chi Tiết ";
            this.btn_inchitiet.UseVisualStyleBackColor = true;
            this.btn_inchitiet.Click += new System.EventHandler(this.btn_inchitiet_Click);
            // 
            // GUI_reportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 718);
            this.Controls.Add(this.btn_inchitiet);
            this.Controls.Add(this.cbo_MaHD);
            this.Controls.Add(this.cpt_hoadon);
            this.Name = "GUI_reportHoaDon";
            this.Text = "GUI_reportHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GUI_reportHoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer cpt_hoadon;
        private System.Windows.Forms.ComboBox cbo_MaHD;
        private System.Windows.Forms.Button btn_inchitiet;
    }
}