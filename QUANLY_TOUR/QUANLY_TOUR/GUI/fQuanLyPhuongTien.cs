using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLY_TOUR.DAO;
using QUANLY_TOUR.GUI.CrystalReport.FormCR;
using QUANLY_TOUR.GUI.Design;

namespace QUANLY_TOUR.GUI
{
    public partial class fQuanLyPhuongTien : Form
    {
        public delegate void DlgtQLPT();
        public DlgtQLPT dlgtQLPT;
        private DataTable dt;
        public fQuanLyPhuongTien()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ThietKe.designDGV(dataGridView1);
        }

        private void btnLamMoiPT_Click(object sender, EventArgs e)
        {
            txtTenPT.Clear();
            txtTenPT.Focus();
            cboLoaiPT.SelectedItem = null;
        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            if (txtTenPT.Text.Length == 0)
            {
                MessageBox.Show("Tên phương tiện không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var res = PhuongTienDAO.Instance.InsertPT(txtTenPT.Text, int.Parse(cboLoaiPT.SelectedValue.ToString()));
            if (res)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                txtTenPT.Clear();
                txtTenPT.Focus();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLamMoiDS_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idPhuongTien = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                fChinhSuaPhuongTien f = new fChinhSuaPhuongTien(idPhuongTien);
                f.ShowDialog();
                loadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                String name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string idPhuongTien = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (PhuongTienDAO.Instance.KTKNDPhuongTien_Tour(int.Parse(idPhuongTien))==1)
                {
                    MessageBox.Show("Phương tiện đang được sử dụng nên không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa phương tiện: '" + name + "' Không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int kq = PhuongTienDAO.Instance.XoaPhuongTien(idPhuongTien);
                    if (kq == 0)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else if (kq == -1) MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fQuanLyPhuongTien_Load(object sender, EventArgs e)
        {
            loadPT();
        }

        public void loadPT()
        {
            cboLoaiPT.DataSource = PhuongTienDAO.Instance.GetLoaiPT();
            cboLoaiPT.DisplayMember = "TenLoaiPT";
            cboLoaiPT.ValueMember = "ID_LoaiPT";
            cboLoaiPT.SelectedIndex = 0;
            loadData();
        }
        public void loadData()
        {
            dt = PhuongTienDAO.Instance.GetPhuongTienLoaiPT();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("TenPhuongTien like '%{0}%'",txtSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new ContextMenuStrip();
                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    myMenu.Items.Add("Làm mới").Name = "refresh";
                    myMenu.Items.Add("Chỉnh sửa").Name = "edit";
                    myMenu.Items.Add("Xuất").Name = "print";
                    myMenu.Items.Add("Xóa").Name = "delete";
                }
                myMenu.Show(dataGridView1, new Point(e.X, e.Y));

                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemCLick);   
            }
        }
        void myMenu_ItemCLick(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "refresh":
                    btnLamMoiDS.PerformClick();
                    break;
                case "edit":
                    btnChinhSua.PerformClick();
                    break;
                case "print":
                    btnXuat.PerformClick();
                    break;
                case "delete":
                    btnXoa.PerformClick();
                    break;
            }
        }
    }
}
