
namespace QUANLY_TOUR.GUI
{
    partial class fQuanLyPhuongTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLyPhuongTien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnXuat = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnLamMoiDS = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnLamMoiPT = new System.Windows.Forms.Button();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cboLoaiPT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPT = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1400, 816);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(450, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(950, 816);
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
            this.groupBox2.Size = new System.Drawing.Size(930, 796);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phương tiện";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dataGridView1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(10, 113);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(910, 608);
            this.panel11.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(910, 608);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID_PhuongTien";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenPhuongTien";
            this.Column2.HeaderText = "Tên phương tiện";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenLoaiPT";
            this.Column3.HeaderText = "Loại phương tiện";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnXuat);
            this.panel12.Controls.Add(this.btnLamMoiDS);
            this.panel12.Controls.Add(this.btnChinhSua);
            this.panel12.Controls.Add(this.btnXoa);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(10, 721);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(910, 65);
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
            this.btnXuat.ImageKey = "printer.png";
            this.btnXuat.ImageList = this.imageList1;
            this.btnXuat.Location = new System.Drawing.Point(542, 12);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(70, 50);
            this.btnXuat.TabIndex = 8;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-delete-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-edit-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-plus-+-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-refresh-48.png");
            this.imageList1.Images.SetKeyName(4, "printer.png");
            // 
            // btnLamMoiDS
            // 
            this.btnLamMoiDS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoiDS.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLamMoiDS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiDS.FlatAppearance.BorderSize = 0;
            this.btnLamMoiDS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiDS.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiDS.ImageKey = "icons8-refresh-48.png";
            this.btnLamMoiDS.ImageList = this.imageList1;
            this.btnLamMoiDS.Location = new System.Drawing.Point(299, 12);
            this.btnLamMoiDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoiDS.Name = "btnLamMoiDS";
            this.btnLamMoiDS.Size = new System.Drawing.Size(70, 50);
            this.btnLamMoiDS.TabIndex = 7;
            this.btnLamMoiDS.UseVisualStyleBackColor = false;
            this.btnLamMoiDS.Click += new System.EventHandler(this.btnLamMoiDS_Click);
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
            this.btnChinhSua.Location = new System.Drawing.Point(380, 12);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(70, 50);
            this.btnChinhSua.TabIndex = 6;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(461, 12);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 50);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label5);
            this.panel10.Controls.Add(this.txtSearch);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(10, 37);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(910, 76);
            this.panel10.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Location = new System.Drawing.Point(329, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(395, 34);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(450, 816);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(430, 796);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm phương tiện";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 749);
            this.panel4.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnLamMoiPT);
            this.panel8.Controls.Add(this.btnThemPT);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 170);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(410, 85);
            this.panel8.TabIndex = 10;
            // 
            // btnLamMoiPT
            // 
            this.btnLamMoiPT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLamMoiPT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLamMoiPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiPT.FlatAppearance.BorderSize = 0;
            this.btnLamMoiPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiPT.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiPT.ImageIndex = 3;
            this.btnLamMoiPT.ImageList = this.imageList1;
            this.btnLamMoiPT.Location = new System.Drawing.Point(97, 28);
            this.btnLamMoiPT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoiPT.Name = "btnLamMoiPT";
            this.btnLamMoiPT.Size = new System.Drawing.Size(70, 50);
            this.btnLamMoiPT.TabIndex = 3;
            this.btnLamMoiPT.UseVisualStyleBackColor = false;
            this.btnLamMoiPT.Click += new System.EventHandler(this.btnLamMoiPT_Click);
            // 
            // btnThemPT
            // 
            this.btnThemPT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemPT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThemPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemPT.FlatAppearance.BorderSize = 0;
            this.btnThemPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPT.ForeColor = System.Drawing.Color.White;
            this.btnThemPT.ImageIndex = 2;
            this.btnThemPT.ImageList = this.imageList1;
            this.btnThemPT.Location = new System.Drawing.Point(243, 28);
            this.btnThemPT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(70, 50);
            this.btnThemPT.TabIndex = 2;
            this.btnThemPT.UseVisualStyleBackColor = false;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cboLoaiPT);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 85);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel7.Size = new System.Drawing.Size(410, 85);
            this.panel7.TabIndex = 9;
            // 
            // cboLoaiPT
            // 
            this.cboLoaiPT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboLoaiPT.FormattingEnabled = true;
            this.cboLoaiPT.Location = new System.Drawing.Point(0, 48);
            this.cboLoaiPT.Name = "cboLoaiPT";
            this.cboLoaiPT.Size = new System.Drawing.Size(410, 37);
            this.cboLoaiPT.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại phương tiện:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label1);
            this.panel9.Controls.Add(this.txtTenPT);
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
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên phương tiện:";
            // 
            // txtTenPT
            // 
            this.txtTenPT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTenPT.Location = new System.Drawing.Point(0, 51);
            this.txtTenPT.Name = "txtTenPT";
            this.txtTenPT.Size = new System.Drawing.Size(410, 34);
            this.txtTenPT.TabIndex = 0;
            // 
            // fQuanLyPhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fQuanLyPhuongTien";
            this.Text = "Quản lý phương tiện";
            this.Load += new System.EventHandler(this.fQuanLyPhuongTien_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnLamMoiDS;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnLamMoiPT;
        private System.Windows.Forms.Button btnThemPT;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cboLoaiPT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenPT;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}