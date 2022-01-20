
namespace QUANLY_TOUR.GUI
{
    partial class fQuanLyDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.btnXemDoanhThu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoVe = new System.Windows.Forms.TextBox();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1400, 816);
            this.panel1.TabIndex = 0;
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
            this.dtpNgayKT.Location = new System.Drawing.Point(1180, 17);
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
            this.btnXemDoanhThu.Location = new System.Drawing.Point(572, 9);
            this.btnXemDoanhThu.Name = "btnXemDoanhThu";
            this.btnXemDoanhThu.Size = new System.Drawing.Size(237, 50);
            this.btnXemDoanhThu.TabIndex = 2;
            this.btnXemDoanhThu.Text = "Xem Doanh Thu";
            this.btnXemDoanhThu.UseVisualStyleBackColor = false;
            this.btnXemDoanhThu.Click += new System.EventHandler(this.btnXemDoanhThu_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXemDoanhThu);
            this.panel2.Controls.Add(this.dtpNgayKT);
            this.panel2.Controls.Add(this.dtpNgayBD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1380, 69);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng số vé:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // txtSoVe
            // 
            this.txtSoVe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSoVe.Enabled = false;
            this.txtSoVe.Location = new System.Drawing.Point(217, 17);
            this.txtSoVe.Name = "txtSoVe";
            this.txtSoVe.Size = new System.Drawing.Size(222, 34);
            this.txtSoVe.TabIndex = 7;
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.Location = new System.Drawing.Point(217, 67);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(222, 34);
            this.txtDoanhThu.TabIndex = 8;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowReport.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReport.ForeColor = System.Drawing.Color.White;
            this.btnShowReport.Location = new System.Drawing.Point(1180, 34);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(191, 50);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnShowReport);
            this.panel4.Controls.Add(this.txtDoanhThu);
            this.panel4.Controls.Add(this.txtSoVe);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 688);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1380, 118);
            this.panel4.TabIndex = 12;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgayDK";
            this.Column7.HeaderText = "Ngày Đăng Ký";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Gia";
            this.Column6.HeaderText = "Giá";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HoTen";
            this.Column5.HeaderText = "Nhân Viên";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HoTen";
            this.Column4.HeaderText = "Khách Hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenTour";
            this.Column3.HeaderText = "Tên Tour";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID_Tour";
            this.Column2.HeaderText = "Mã Tour";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_dangkytour";
            this.Column1.HeaderText = "Mã Đăng Ký Tour";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(10, 79);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1380, 609);
            this.dataGridView1.TabIndex = 13;
            // 
            // fQuanLyDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fQuanLyDoanhThu";
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.fQuanLyDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.TextBox txtSoVe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXemDoanhThu;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
    }
}


