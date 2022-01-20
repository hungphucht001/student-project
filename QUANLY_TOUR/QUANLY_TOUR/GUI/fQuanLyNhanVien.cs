using QUANLY_TOUR.DAO;
using QUANLY_TOUR.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLY_TOUR.DTO;
using QUANLY_TOUR.GUI.Design;

namespace QUANLY_TOUR
{
    public partial class fQuanLyNhanVien : Form
    {
        XuLy xl = new XuLy();
        private DataTable dt;
     
        public fQuanLyNhanVien()
        {
            InitializeComponent();
          
            dgvDsNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ThietKe.designDGV(dgvDsNhanVien);
            dgvDsNhanVien.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvDsNhanVien.Columns[6].DefaultCellStyle.Format = "dd-MM-yyyy";
        }
 

        private void button3_Click(object sender, EventArgs e)
        {
            if(dgvDsNhanVien.SelectedRows.Count > 0)
            {
                String name = dgvDsNhanVien.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa nhân viên: " + name + " Không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int idNhanVien = int.Parse(dgvDsNhanVien.CurrentRow.Cells[0].Value.ToString());

                    int kq = 1;
                    if(kq > 0)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            dt = NhanVienDAO.Instance.GetNhanVienChucVu();
            dgvDsNhanVien.AutoGenerateColumns = false;
            dgvDsNhanVien.DataSource = dt;
        }
     
        void myMenu_ItemCLick(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "edit":
                    btnSua_NV.PerformClick();
                    break;
                case "print":
                    btnXuat.PerformClick();
                    break;
                case "delete":
                    btnXoa_NV.PerformClick();
                    break;
                case "reset":
                    button2.PerformClick();
                    break;
                case "add":
                    button1.PerformClick();
                    break;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("HoTen like '%{0}%'", txtSearch.Text);
            dgvDsNhanVien.DataSource = dv.ToTable();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fThemNhanVien f = new fThemNhanVien();
            f.ShowDialog();
            loadData();
        }

        private void btnXoa_NV_Click_1(object sender, EventArgs e)
        {
            if (dgvDsNhanVien.SelectedRows.Count > 0)
            {
                String name = dgvDsNhanVien.CurrentRow.Cells[1].Value.ToString();
                string idNhanVien = dgvDsNhanVien.CurrentRow.Cells[0].Value.ToString();
                int intIDnhanVien = int.Parse(idNhanVien);
                int kq1 = NhanVienDAO.Instance.KTKNNhanVien_DKTour(intIDnhanVien);
                int kq2 = NhanVienDAO.Instance.KTKNNhanVien_Tour(intIDnhanVien);
                int kq3 = NhanVienDAO.Instance.KTKNNhanVien_DiaDiem(intIDnhanVien);
                if (kq1 == 1 || kq2 == 1 || kq3 == 1)
                {
                    MessageBox.Show("Nhân viên đang được sử dụng nên không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa nhân viên: '" + name + "' Không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    if (TaiKhoanDAO.Instance.xoaTaiKhoan(idNhanVien) && NhanVienDAO.Instance.xoaNhanVien(idNhanVien))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSua_NV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDsNhanVien.Rows.Count > 0)
                {
                    int id = int.Parse(dgvDsNhanVien.CurrentRow.Cells[0].Value.ToString());
                    fChinhSuaNhanVien f = new fChinhSuaNhanVien(id);
                    f.ShowDialog();
                    loadData();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvDsNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new ContextMenuStrip();
                int currentMouseOverRow = dgvDsNhanVien.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    myMenu.Items.Add("Làm mới").Name = "reset";
                    myMenu.Items.Add("Thêm mới").Name = "add";
                    myMenu.Items.Add("Xóa").Name = "delete";
                    myMenu.Items.Add("Chỉnh sửa").Name = "edit";
                    myMenu.Items.Add("Xuất").Name = "print";
                }
                myMenu.Show(dgvDsNhanVien, new Point(e.X, e.Y));

                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemCLick);
            }
        }
    }
}
