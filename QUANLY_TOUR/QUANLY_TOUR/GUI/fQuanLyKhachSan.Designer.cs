
namespace QUANLY_TOUR.GUI
{
    partial class fQuanLyKhachSan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyKhachSan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dgvKhachSan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnXuat = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnLamMoi_KH = new System.Windows.Forms.Button();
            this.btnHuyHopTac = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbbKhuVuc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoSao = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKS = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachSan)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 767);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(450, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(842, 767);
            this.panel3.TabIndex = 1;
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
            this.groupBox2.Size = new System.Drawing.Size(822, 747);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách sạn";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dgvKhachSan);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(10, 113);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(802, 559);
            this.panel11.TabIndex = 3;
            // 
            // dgvKhachSan
            // 
            this.dgvKhachSan.AllowUserToAddRows = false;
            this.dgvKhachSan.AllowUserToDeleteRows = false;
            this.dgvKhachSan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachSan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKhachSan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKhachSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachSan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvKhachSan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachSan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachSan.EnableHeadersVisualStyles = false;
            this.dgvKhachSan.Location = new System.Drawing.Point(0, 0);
            this.dgvKhachSan.MultiSelect = false;
            this.dgvKhachSan.Name = "dgvKhachSan";
            this.dgvKhachSan.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachSan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachSan.RowHeadersVisible = false;
            this.dgvKhachSan.RowHeadersWidth = 51;
            this.dgvKhachSan.RowTemplate.Height = 24;
            this.dgvKhachSan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachSan.Size = new System.Drawing.Size(802, 559);
            this.dgvKhachSan.TabIndex = 0;
            this.dgvKhachSan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvKhachSan_MouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_KhachSan";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKhachSan";
            this.Column2.HeaderText = "Tên khách sạn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoSao";
            this.Column3.HeaderText = "Số sao";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TenKhuVuc";
            this.Column5.HeaderText = "Tỉnh thành";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnXuat);
            this.panel12.Controls.Add(this.btnXoa);
            this.panel12.Controls.Add(this.btnChinhSua);
            this.panel12.Controls.Add(this.btnLamMoi_KH);
            this.panel12.Controls.Add(this.btnHuyHopTac);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(10, 672);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(802, 65);
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
            this.btnXuat.ImageIndex = 3;
            this.btnXuat.ImageList = this.imageList1;
            this.btnXuat.Location = new System.Drawing.Point(407, 10);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(70, 50);
            this.btnXuat.TabIndex = 15;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-delete-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-edit-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-refresh-48.png");
            this.imageList1.Images.SetKeyName(3, "printer.png");
            this.imageList1.Images.SetKeyName(4, "icons8-plus-+-48.png");
            this.imageList1.Images.SetKeyName(5, "stop.png");
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.ImageIndex = 0;
            this.btnXoa.ImageList = this.imageList1;
            this.btnXoa.Location = new System.Drawing.Point(324, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 50);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnSua_KH_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChinhSua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.FlatAppearance.BorderSize = 0;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnChinhSua.ImageIndex = 1;
            this.btnChinhSua.ImageList = this.imageList1;
            this.btnChinhSua.Location = new System.Drawing.Point(241, 10);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(70, 50);
            this.btnChinhSua.TabIndex = 13;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnThem_KH_Click);
            // 
            // btnLamMoi_KH
            // 
            this.btnLamMoi_KH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoi_KH.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLamMoi_KH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi_KH.FlatAppearance.BorderSize = 0;
            this.btnLamMoi_KH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi_KH.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi_KH.ImageIndex = 2;
            this.btnLamMoi_KH.ImageList = this.imageList1;
            this.btnLamMoi_KH.Location = new System.Drawing.Point(158, 10);
            this.btnLamMoi_KH.Name = "btnLamMoi_KH";
            this.btnLamMoi_KH.Size = new System.Drawing.Size(70, 50);
            this.btnLamMoi_KH.TabIndex = 12;
            this.btnLamMoi_KH.UseVisualStyleBackColor = false;
            this.btnLamMoi_KH.Click += new System.EventHandler(this.btnLamMoi_KH_Click);
            // 
            // btnHuyHopTac
            // 
            this.btnHuyHopTac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuyHopTac.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHuyHopTac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyHopTac.FlatAppearance.BorderSize = 0;
            this.btnHuyHopTac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyHopTac.ForeColor = System.Drawing.Color.White;
            this.btnHuyHopTac.Location = new System.Drawing.Point(490, 10);
            this.btnHuyHopTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyHopTac.Name = "btnHuyHopTac";
            this.btnHuyHopTac.Size = new System.Drawing.Size(154, 50);
            this.btnHuyHopTac.TabIndex = 4;
            this.btnHuyHopTac.Text = "Hủy hợp tác";
            this.btnHuyHopTac.UseVisualStyleBackColor = false;
            this.btnHuyHopTac.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cbbTrangThai);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.txtSearch);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(10, 37);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(802, 76);
            this.panel10.TabIndex = 0;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbTrangThai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(664, 23);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(121, 37);
            this.cbbTrangThai.TabIndex = 12;
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbbTrangThai_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(219, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(331, 34);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(450, 767);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(430, 747);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm khách sạn";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 700);
            this.panel4.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnThem);
            this.panel8.Controls.Add(this.button2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 340);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(410, 120);
            this.panel8.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.ImageIndex = 4;
            this.btnThem.ImageList = this.imageList1;
            this.btnThem.Location = new System.Drawing.Point(229, 50);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 50);
            this.btnThem.TabIndex = 15;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageIndex = 2;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(87, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 50);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbbKhuVuc);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 255);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel7.Size = new System.Drawing.Size(410, 85);
            this.panel7.TabIndex = 9;
            // 
            // cbbKhuVuc
            // 
            this.cbbKhuVuc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbbKhuVuc.FormattingEnabled = true;
            this.cbbKhuVuc.Location = new System.Drawing.Point(0, 48);
            this.cbbKhuVuc.Name = "cbbKhuVuc";
            this.cbbKhuVuc.Size = new System.Drawing.Size(410, 37);
            this.cbbKhuVuc.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tỉnh thành:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtSDT);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 170);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel6.Size = new System.Drawing.Size(410, 85);
            this.panel6.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSDT.Location = new System.Drawing.Point(0, 51);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(410, 34);
            this.txtSDT.TabIndex = 0;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoSao_KeyPress);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtSoSao);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 85);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel5.Size = new System.Drawing.Size(410, 85);
            this.panel5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số sao:";
            // 
            // txtSoSao
            // 
            this.txtSoSao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSoSao.Location = new System.Drawing.Point(0, 51);
            this.txtSoSao.Name = "txtSoSao";
            this.txtSoSao.Size = new System.Drawing.Size(410, 34);
            this.txtSoSao.TabIndex = 0;
            this.txtSoSao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoSao_KeyPress);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.txtTenKS);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel9.Size = new System.Drawing.Size(410, 85);
            this.panel9.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách sạn:";
            // 
            // txtTenKS
            // 
            this.txtTenKS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTenKS.Location = new System.Drawing.Point(0, 51);
            this.txtTenKS.Name = "txtTenKS";
            this.txtTenKS.Size = new System.Drawing.Size(410, 34);
            this.txtTenKS.TabIndex = 0;
            // 
            // fQuanLyKhachSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 767);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fQuanLyKhachSan";
            this.Text = "Quản lý khách sạn";
            this.Load += new System.EventHandler(this.fQuanLyKhachSan_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fQuanLyKhachSan_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachSan)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbbKhuVuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoSao;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKS;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnHuyHopTac;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvKhachSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnLamMoi_KH;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button2;
    }
}