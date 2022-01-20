
namespace QUANLY_TOUR
{
    partial class fQuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnSua_NV = new System.Windows.Forms.Button();
            this.btnXoa_NV = new System.Windows.Forms.Button();
            this.dgvDsNhanVien = new System.Windows.Forms.DataGridView();
            this.ID_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-edit-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-save-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-delete-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-plus-+-48.png");
            this.imageList1.Images.SetKeyName(4, "icons8-refresh-48.png");
            this.imageList1.Images.SetKeyName(5, "printer.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDsNhanVien);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel17);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(1370, 721);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(10, 37);
            this.panel7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1350, 76);
            this.panel7.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.Controls.Add(this.txtSearch);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Location = new System.Drawing.Point(369, 9);
            this.panel12.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(613, 58);
            this.panel12.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(162, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(431, 34);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tìm kiếm:";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.button2);
            this.panel17.Controls.Add(this.button1);
            this.panel17.Controls.Add(this.btnXuat);
            this.panel17.Controls.Add(this.btnSua_NV);
            this.panel17.Controls.Add(this.btnXoa_NV);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(10, 646);
            this.panel17.Margin = new System.Windows.Forms.Padding(5);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1350, 65);
            this.panel17.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(559, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 50);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnXuat
            // 
            this.btnXuat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXuat.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.ImageIndex = 5;
            this.btnXuat.ImageList = this.imageList1;
            this.btnXuat.Location = new System.Drawing.Point(802, 11);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(5);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(70, 50);
            this.btnXuat.TabIndex = 10;
            this.btnXuat.UseVisualStyleBackColor = false;
            // 
            // btnSua_NV
            // 
            this.btnSua_NV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua_NV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua_NV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua_NV.FlatAppearance.BorderSize = 0;
            this.btnSua_NV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua_NV.ForeColor = System.Drawing.Color.White;
            this.btnSua_NV.ImageIndex = 0;
            this.btnSua_NV.ImageList = this.imageList1;
            this.btnSua_NV.Location = new System.Drawing.Point(640, 11);
            this.btnSua_NV.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua_NV.Name = "btnSua_NV";
            this.btnSua_NV.Size = new System.Drawing.Size(70, 50);
            this.btnSua_NV.TabIndex = 7;
            this.btnSua_NV.UseVisualStyleBackColor = false;
            this.btnSua_NV.Click += new System.EventHandler(this.btnSua_NV_Click);
            // 
            // btnXoa_NV
            // 
            this.btnXoa_NV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa_NV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXoa_NV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa_NV.FlatAppearance.BorderSize = 0;
            this.btnXoa_NV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa_NV.ForeColor = System.Drawing.Color.White;
            this.btnXoa_NV.ImageIndex = 2;
            this.btnXoa_NV.ImageList = this.imageList1;
            this.btnXoa_NV.Location = new System.Drawing.Point(721, 11);
            this.btnXoa_NV.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa_NV.Name = "btnXoa_NV";
            this.btnXoa_NV.Size = new System.Drawing.Size(70, 50);
            this.btnXoa_NV.TabIndex = 8;
            this.btnXoa_NV.UseVisualStyleBackColor = false;
            this.btnXoa_NV.Click += new System.EventHandler(this.btnXoa_NV_Click_1);
            // 
            // dgvDsNhanVien
            // 
            this.dgvDsNhanVien.AllowUserToAddRows = false;
            this.dgvDsNhanVien.AllowUserToDeleteRows = false;
            this.dgvDsNhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvDsNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDsNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDsNhanVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDsNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDsNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_NhanVien,
            this.HoTen,
            this.SDT,
            this.GioiTinh,
            this.NgaySinh,
            this.DiaChi,
            this.NgayVaoLam,
            this.luong,
            this.TenChucVu,
            this.Column1});
            this.dgvDsNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDsNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsNhanVien.EnableHeadersVisualStyles = false;
            this.dgvDsNhanVien.Location = new System.Drawing.Point(10, 113);
            this.dgvDsNhanVien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvDsNhanVien.MultiSelect = false;
            this.dgvDsNhanVien.Name = "dgvDsNhanVien";
            this.dgvDsNhanVien.ReadOnly = true;
            this.dgvDsNhanVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDsNhanVien.RowHeadersVisible = false;
            this.dgvDsNhanVien.RowHeadersWidth = 51;
            this.dgvDsNhanVien.RowTemplate.Height = 24;
            this.dgvDsNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsNhanVien.Size = new System.Drawing.Size(1350, 533);
            this.dgvDsNhanVien.TabIndex = 6;
            this.dgvDsNhanVien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDsNhanVien_MouseClick);
            // 
            // ID_NhanVien
            // 
            this.ID_NhanVien.DataPropertyName = "ID_NhanVien";
            this.ID_NhanVien.HeaderText = "Mã Nhân Viên";
            this.ID_NhanVien.MinimumWidth = 6;
            this.ID_NhanVien.Name = "ID_NhanVien";
            this.ID_NhanVien.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // NgayVaoLam
            // 
            this.NgayVaoLam.DataPropertyName = "NgayVaoLam";
            this.NgayVaoLam.HeaderText = "Ngày Vào Làm";
            this.NgayVaoLam.MinimumWidth = 6;
            this.NgayVaoLam.Name = "NgayVaoLam";
            this.NgayVaoLam.ReadOnly = true;
            // 
            // luong
            // 
            this.luong.DataPropertyName = "luong";
            this.luong.HeaderText = "Lương";
            this.luong.MinimumWidth = 6;
            this.luong.Name = "luong";
            this.luong.ReadOnly = true;
            // 
            // TenChucVu
            // 
            this.TenChucVu.DataPropertyName = "TenChucVu";
            this.TenChucVu.HeaderText = "Chức vụ";
            this.TenChucVu.MinimumWidth = 6;
            this.TenChucVu.Name = "TenChucVu";
            this.TenChucVu.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TrangThai";
            this.Column1.HeaderText = "Trạng Thái";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageIndex = 4;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(478, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 50);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1390, 741);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "fQuanLyNhanVien";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.fQuanLyNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnSua_NV;
        private System.Windows.Forms.Button btnXoa_NV;
        private System.Windows.Forms.DataGridView dgvDsNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button2;
    }
}