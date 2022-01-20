
namespace QUANLY_TOUR.GUI
{
    partial class fQuanLyKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnXuat = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSua_KH = new System.Windows.Forms.Button();
            this.btnThem_KH = new System.Windows.Forms.Button();
            this.btnLamMoi_KH = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1381, 1055);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel11);
            this.groupBox2.Controls.Add(this.panel12);
            this.groupBox2.Controls.Add(this.panel10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(1361, 1035);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvKhachHang);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(10, 108);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1341, 851);
            this.panel11.TabIndex = 3;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AllowUserToResizeRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowTemplate.Height = 24;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(1341, 851);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvKhachHang_MouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_KhachHang";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SDT";
            this.Column3.HeaderText = "Số điện thoại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DiaChi";
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgaySinh";
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GioiTinh";
            this.Column6.HeaderText = "Giới tính";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnXuat);
            this.panel12.Controls.Add(this.btnXoaKH);
            this.panel12.Controls.Add(this.btnSua_KH);
            this.panel12.Controls.Add(this.btnThem_KH);
            this.panel12.Controls.Add(this.btnLamMoi_KH);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(10, 959);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1341, 66);
            this.panel12.TabIndex = 2;
            // 
            // btnXuat
            // 
            this.btnXuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXuat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.ImageIndex = 4;
            this.btnXuat.ImageList = this.imageList1;
            this.btnXuat.Location = new System.Drawing.Point(799, 11);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(70, 50);
            this.btnXuat.TabIndex = 11;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-refresh-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-plus-+-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-edit-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-delete-48.png");
            this.imageList1.Images.SetKeyName(4, "printer.png");
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaKH.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXoaKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKH.FlatAppearance.BorderSize = 0;
            this.btnXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKH.ForeColor = System.Drawing.Color.White;
            this.btnXoaKH.ImageIndex = 3;
            this.btnXoaKH.ImageList = this.imageList1;
            this.btnXoaKH.Location = new System.Drawing.Point(717, 11);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(70, 50);
            this.btnXoaKH.TabIndex = 10;
            this.btnXoaKH.UseVisualStyleBackColor = false;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnSua_KH
            // 
            this.btnSua_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua_KH.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua_KH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua_KH.FlatAppearance.BorderSize = 0;
            this.btnSua_KH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua_KH.ForeColor = System.Drawing.Color.White;
            this.btnSua_KH.ImageIndex = 2;
            this.btnSua_KH.ImageList = this.imageList1;
            this.btnSua_KH.Location = new System.Drawing.Point(635, 11);
            this.btnSua_KH.Name = "btnSua_KH";
            this.btnSua_KH.Size = new System.Drawing.Size(70, 50);
            this.btnSua_KH.TabIndex = 9;
            this.btnSua_KH.UseVisualStyleBackColor = false;
            this.btnSua_KH.Click += new System.EventHandler(this.btnSua_KH_Click);
            // 
            // btnThem_KH
            // 
            this.btnThem_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem_KH.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem_KH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem_KH.FlatAppearance.BorderSize = 0;
            this.btnThem_KH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem_KH.ForeColor = System.Drawing.Color.White;
            this.btnThem_KH.ImageIndex = 1;
            this.btnThem_KH.ImageList = this.imageList1;
            this.btnThem_KH.Location = new System.Drawing.Point(553, 11);
            this.btnThem_KH.Name = "btnThem_KH";
            this.btnThem_KH.Size = new System.Drawing.Size(70, 50);
            this.btnThem_KH.TabIndex = 8;
            this.btnThem_KH.UseVisualStyleBackColor = false;
            this.btnThem_KH.Click += new System.EventHandler(this.btnThem_KH_Click);
            // 
            // btnLamMoi_KH
            // 
            this.btnLamMoi_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoi_KH.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLamMoi_KH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi_KH.FlatAppearance.BorderSize = 0;
            this.btnLamMoi_KH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi_KH.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi_KH.ImageIndex = 0;
            this.btnLamMoi_KH.ImageList = this.imageList1;
            this.btnLamMoi_KH.Location = new System.Drawing.Point(471, 11);
            this.btnLamMoi_KH.Name = "btnLamMoi_KH";
            this.btnLamMoi_KH.Size = new System.Drawing.Size(70, 50);
            this.btnLamMoi_KH.TabIndex = 7;
            this.btnLamMoi_KH.UseVisualStyleBackColor = false;
            this.btnLamMoi_KH.Click += new System.EventHandler(this.btnLamMoi_KH_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.txtSearch);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(10, 37);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1341, 71);
            this.panel10.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(515, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(460, 34);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // fQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 1055);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "fQuanLyKhachHang";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.fQuanLyKhachHang_Load);
            this.Click += new System.EventHandler(this.fQuanLyKhachHang_Click);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSua_KH;
        private System.Windows.Forms.Button btnThem_KH;
        private System.Windows.Forms.Button btnLamMoi_KH;
        private System.Windows.Forms.Button btnXuat;
    }
}