
namespace QUANLY_TOUR.GUI
{
    partial class fChinhSuaKhachHang
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChinhSua_KH = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtpNgaySinh_KH = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdKhac_KH = new System.Windows.Forms.RadioButton();
            this.rdNu_KH = new System.Windows.Forms.RadioButton();
            this.rdNam_KH = new System.Windows.Forms.RadioButton();
            this.txtDiaChi_KH = new System.Windows.Forms.TextBox();
            this.lbl11 = new System.Windows.Forms.Label();
            this.txtSDT_KH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtHoTen_KH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(69, 7);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 45);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChinhSua_KH
            // 
            this.btnChinhSua_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChinhSua_KH.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChinhSua_KH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua_KH.FlatAppearance.BorderSize = 0;
            this.btnChinhSua_KH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua_KH.ForeColor = System.Drawing.Color.White;
            this.btnChinhSua_KH.Location = new System.Drawing.Point(298, 7);
            this.btnChinhSua_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChinhSua_KH.Name = "btnChinhSua_KH";
            this.btnChinhSua_KH.Size = new System.Drawing.Size(143, 45);
            this.btnChinhSua_KH.TabIndex = 11;
            this.btnChinhSua_KH.Text = "Lưu";
            this.btnChinhSua_KH.UseVisualStyleBackColor = false;
            this.btnChinhSua_KH.Click += new System.EventHandler(this.btnChinhSua_KH_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(10, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dtpNgaySinh_KH);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 348);
            this.panel7.Margin = new System.Windows.Forms.Padding(5);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel7.Size = new System.Drawing.Size(511, 95);
            this.panel7.TabIndex = 7;
            // 
            // dtpNgaySinh_KH
            // 
            this.dtpNgaySinh_KH.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaySinh_KH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtpNgaySinh_KH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh_KH.Location = new System.Drawing.Point(10, 61);
            this.dtpNgaySinh_KH.Name = "dtpNgaySinh_KH";
            this.dtpNgaySinh_KH.Size = new System.Drawing.Size(491, 34);
            this.dtpNgaySinh_KH.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rdKhac_KH);
            this.panel6.Controls.Add(this.rdNu_KH);
            this.panel6.Controls.Add(this.rdNam_KH);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 261);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel6.Size = new System.Drawing.Size(511, 87);
            this.panel6.TabIndex = 6;
            // 
            // rdKhac_KH
            // 
            this.rdKhac_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdKhac_KH.AutoSize = true;
            this.rdKhac_KH.Location = new System.Drawing.Point(325, 51);
            this.rdKhac_KH.Name = "rdKhac_KH";
            this.rdKhac_KH.Size = new System.Drawing.Size(88, 33);
            this.rdKhac_KH.TabIndex = 3;
            this.rdKhac_KH.TabStop = true;
            this.rdKhac_KH.Text = "Khác";
            this.rdKhac_KH.UseVisualStyleBackColor = true;
            // 
            // rdNu_KH
            // 
            this.rdNu_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdNu_KH.AutoSize = true;
            this.rdNu_KH.Location = new System.Drawing.Point(221, 51);
            this.rdNu_KH.Name = "rdNu_KH";
            this.rdNu_KH.Size = new System.Drawing.Size(65, 33);
            this.rdNu_KH.TabIndex = 2;
            this.rdNu_KH.TabStop = true;
            this.rdNu_KH.Text = "Nữ";
            this.rdNu_KH.UseVisualStyleBackColor = true;
            // 
            // rdNam_KH
            // 
            this.rdNam_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdNam_KH.AutoSize = true;
            this.rdNam_KH.Location = new System.Drawing.Point(97, 51);
            this.rdNam_KH.Name = "rdNam_KH";
            this.rdNam_KH.Size = new System.Drawing.Size(85, 33);
            this.rdNam_KH.TabIndex = 1;
            this.rdNam_KH.TabStop = true;
            this.rdNam_KH.Text = "Nam";
            this.rdNam_KH.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi_KH
            // 
            this.txtDiaChi_KH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDiaChi_KH.Location = new System.Drawing.Point(10, 53);
            this.txtDiaChi_KH.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiaChi_KH.Name = "txtDiaChi_KH";
            this.txtDiaChi_KH.Size = new System.Drawing.Size(491, 34);
            this.txtDiaChi_KH.TabIndex = 1;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl11.Location = new System.Drawing.Point(10, 10);
            this.lbl11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(86, 29);
            this.lbl11.TabIndex = 0;
            this.lbl11.Text = "Địa chỉ";
            // 
            // txtSDT_KH
            // 
            this.txtSDT_KH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSDT_KH.Enabled = false;
            this.txtSDT_KH.Location = new System.Drawing.Point(10, 53);
            this.txtSDT_KH.Margin = new System.Windows.Forms.Padding(5);
            this.txtSDT_KH.Name = "txtSDT_KH";
            this.txtSDT_KH.Size = new System.Drawing.Size(491, 34);
            this.txtSDT_KH.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(10, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số điện thoại";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSDT_KH);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel3.Size = new System.Drawing.Size(511, 87);
            this.panel3.TabIndex = 4;
            // 
            // txtHoTen_KH
            // 
            this.txtHoTen_KH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtHoTen_KH.Location = new System.Drawing.Point(10, 53);
            this.txtHoTen_KH.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoTen_KH.Name = "txtHoTen_KH";
            this.txtHoTen_KH.Size = new System.Drawing.Size(491, 34);
            this.txtHoTen_KH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtHoTen_KH);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel5.Size = new System.Drawing.Size(511, 87);
            this.panel5.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.AutoScroll = true;
            this.panel13.Controls.Add(this.panel7);
            this.panel13.Controls.Add(this.panel6);
            this.panel13.Controls.Add(this.panel4);
            this.panel13.Controls.Add(this.panel3);
            this.panel13.Controls.Add(this.panel5);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 70);
            this.panel13.Margin = new System.Windows.Forms.Padding(5);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(511, 480);
            this.panel13.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDiaChi_KH);
            this.panel4.Controls.Add(this.lbl11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 174);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel4.Size = new System.Drawing.Size(511, 87);
            this.panel4.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChinhSua_KH);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 550);
            this.panel2.Margin = new System.Windows.Forms.Padding(7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 71);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chỉnh sửa khách hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 70);
            this.panel1.TabIndex = 7;
            // 
            // fChinhSuaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 621);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fChinhSuaKhachHang";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa khách hàng";
            this.Load += new System.EventHandler(this.fChinhSuaKhachHang_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnChinhSua_KH;
        private System.Windows.Forms.TextBox txtDiaChi_KH;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.TextBox txtSDT_KH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtHoTen_KH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh_KH;
        private System.Windows.Forms.RadioButton rdKhac_KH;
        private System.Windows.Forms.RadioButton rdNu_KH;
        private System.Windows.Forms.RadioButton rdNam_KH;
    }
}