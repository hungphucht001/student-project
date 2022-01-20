
namespace QUANLY_TOUR.GUI.CrystalReport.FormCR
{
    partial class fCRDoanhThu
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
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.btnXemDoanhThu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpNgayBD.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(18, 17);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(176, 34);
            this.dtpNgayBD.TabIndex = 0;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtpNgayKT.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(1200, 17);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(176, 34);
            this.dtpNgayKT.TabIndex = 1;
            // 
            // btnXemDoanhThu
            // 
            this.btnXemDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXemDoanhThu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXemDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnXemDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnXemDoanhThu.Location = new System.Drawing.Point(582, 9);
            this.btnXemDoanhThu.Name = "btnXemDoanhThu";
            this.btnXemDoanhThu.Size = new System.Drawing.Size(237, 50);
            this.btnXemDoanhThu.TabIndex = 2;
            this.btnXemDoanhThu.Text = "Xem Doanh Thu";
            this.btnXemDoanhThu.UseVisualStyleBackColor = false;
            this.btnXemDoanhThu.Click += new System.EventHandler(this.btnXemDoanhThu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXemDoanhThu);
            this.panel2.Controls.Add(this.dtpNgayKT);
            this.panel2.Controls.Add(this.dtpNgayBD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 69);
            this.panel2.TabIndex = 14;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 69);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1400, 747);
            this.crystalReportViewer1.TabIndex = 15;
            // 
            // fCRDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "fCRDoanhThu";
            this.Text = "fCRDoanhThu";
            this.Load += new System.EventHandler(this.fCRDoanhThu_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Button btnXemDoanhThu;
        private System.Windows.Forms.Panel panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}