using QUANLY_TOUR.DAO;
using QUANLY_TOUR.DTO;
using QUANLY_TOUR.GUI.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_TOUR.GUI
{
    public partial class fQuanLyKhachHang : Form
    {
        public delegate void DlgtQLKH();
        public DlgtQLKH dlgtQLKH;
        DataTable dt;

        private int index;

        public int Index { get => index; set => index = value; }
        public fQuanLyKhachHang()
        {
            InitializeComponent();
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ThietKe.designDGV(dgvKhachHang);
        }

        private void dgvDsNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void quyenNVDD()
        {
            btnThem_KH.Enabled = btnSua_KH.Enabled = btnXoaKH.Enabled = false;
        }
        private void fQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv = NhanVienDAO.Instance.getThongTinNV(fDangNhap.ptenDangNhap);
            if(String.Compare(nv.TenChucVu, "Nhân Viên Dẫn Đoàn", StringComparison.OrdinalIgnoreCase) == 0)
            {
                quyenNVDD();
            }
            dgvKhachHang.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
            loadData();
        }

        public void loadData()
        {
            dgvKhachHang.AutoGenerateColumns = false;
            dt = KhachHangDAO.Instance.GetKhachHang();
            dgvKhachHang.DataSource = dt;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_KH_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_KH_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhachHang.Rows.Count > 0)
                {
                    fThemKhachHang f = new fThemKhachHang();
                    f.ShowDialog();
                    loadData();
                }
        }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btnSua_KH_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvKhachHang.Rows.Count > 0)
                {
                    int id = int.Parse(dgvKhachHang.CurrentRow.Cells[0].Value.ToString());
                    fChinhSuaKhachHang f = new fChinhSuaKhachHang(id);
                    f.ShowDialog();
                    loadData();
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (Index >= 0)
            {
                String name = dgvKhachHang.Rows[Index].Cells[1].Value.ToString();
                int idKhachHang = int.Parse(dgvKhachHang.Rows[Index].Cells[0].Value.ToString());
                if (KhachHangDAO.Instance.KTKNKhachHang_DangKyTour(idKhachHang) == 1)
                {
                    MessageBox.Show("Khách hàng đang được sử dụng nên không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa khách hàng: '" + name + "' Không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (KhachHangDAO.Instance.xoaKhachHang(idKhachHang))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();

                    }
                    else MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fQuanLyKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("HoTen like '%{0}%'", txtSearch.Text);
            dgvKhachHang.DataSource = dv.ToTable();
        }
        NhanVienDTO nv = NhanVienDAO.Instance.getThongTinNV(fDangNhap.ptenDangNhap);
        private void dgvKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new ContextMenuStrip();
                int currentMouseOverRow = dgvKhachHang.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    myMenu.Items.Add("Làm mới").Name = "refresh";
                    myMenu.Items.Add("Thêm mới").Name = "add";
                    myMenu.Items.Add("Chỉnh sửa").Name = "edit";
                    myMenu.Items.Add("Xóa").Name = "delete";
                    myMenu.Items.Add("Xuất").Name = "print";
                    
                }
                myMenu.Show(dgvKhachHang, new Point(e.X, e.Y));
                try
                {
                    if (String.Compare(nv.TenChucVu, "Nhân viên dẫn đoàn", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        myMenu.Items["add"].Visible = myMenu.Items["edit"].Visible = myMenu.Items["delete"].Visible = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenu_ItemCLick);
            }
        }
        void myMenu_ItemCLick(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "refresh":
                    btnLamMoi_KH.PerformClick();
                    break;
                case "add":
                    btnThem_KH.PerformClick();
                    break;
                case "edit":
                    btnSua_KH.PerformClick();
                    break;
                case "print":
                    btnXuat.PerformClick();
                    break;
                case "delete":
                    btnXoaKH.PerformClick();
                    break;
            }
        }
    }
}
