using QUANLY_TOUR.DAO;
using QUANLY_TOUR.DTO;
using QUANLY_TOUR.GUI.CrystalReport.FormCR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_TOUR
{
    public partial class fChiTietTour : Form
    {
        private int idTour;
        private DataTable dtKH, dtDD;
        public fChiTietTour(int idTour)
        {
            this.idTour = idTour;
            InitializeComponent();
            dgvDsKH.Columns[5].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvDsKH.Columns[6].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvDiaDiem.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        public void quyenNVDD()
        {
            btnXoaDD.Enabled = btnXoaKH.Enabled = false;
        }
        private void fChiTietTour_Load(object sender, EventArgs e)
        {
            
            NhanVienDTO nv = new NhanVienDTO();
            nv = NhanVienDAO.Instance.getThongTinNV(fDangNhap.ptenDangNhap);
            if (String.Compare(nv.TenChucVu, "Nhân Viên Dẫn Đoàn", StringComparison.OrdinalIgnoreCase) == 0)
            {
                quyenNVDD();
            }
            try
            {
                loadDsKhachHang();
                loadDsDiaDiem();

                var query = TourDAO.Instance.LoadTourFull().AsEnumerable().Where(t => t.Field<int>("ID_Tour") == idTour).SingleOrDefault();
                DateTime ngaybd = query.Field<DateTime>("NgayBD");

                lbMa.Text = query.Field<int>("ID_Tour").ToString();
                lbTen.Text = query.Field<string>("TenTour");
                lbNgayBD.Text = ngaybd.ToString();
                lbNgayKT.Text = query.Field<DateTime>("NgayKT").ToString();
                lbSoVe.Text = query.Field<int>("SoVe").ToString();
                lbConVe.Text = query.Field<int>("SoVe").ToString();
                lbKhachSan.Text = query.Field<string>("TenKhachSan");
                lbNhanVienDan.Text = query.Field<string>("NVDan");
                lbGia.Text = string.Format("{0:0,00} VNĐ", query.Field<decimal>("Gia").ToString());
                lbGiamGia.Text = query.Field<int>("GiamGia").ToString()+ " %";
                lbNguoiTao.Text = query.Field<string>("NVMo");
                lbTrangThai.Text = query.Field<string>("TrangThaiTour");

                if(ngaybd <= DateTime.Today)
                {
                    btnXoaDD.Enabled = btnXoaKH.Enabled = false;
                }
                EnabledBtn();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }
        public void loadDsKhachHang()
        {
            dtKH = KhachHangDAO.Instance.GetKHByMaTour(idTour);
            dgvDsKH.AutoGenerateColumns = false;
            dgvDsKH.DataSource = dtKH;
        }
        public void loadDsDiaDiem()
        {
            dtDD = DiaDiemDAO.Instance.GetDiaDiemByIdTour(idTour);
            dgvDiaDiem.AutoGenerateColumns = false;
            dgvDiaDiem.DataSource = dtDD;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Xóa khách hàng
            if (dgvDsKH.SelectedRows.Count > 0)
            {
                string name = dgvDsKH.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa khách hàng: " + name + " ra khỏi tour này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idKH = int.Parse(dgvDsKH.CurrentRow.Cells[0].Value.ToString());
                    int res = KhachHangDAO.Instance.XoaTourKhachHang(idTour, idKH);
                    if (res == -1)
                    {
                        MessageBox.Show("Có lỗi xảy ra! Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (res > 0)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDsKhachHang();
                        EnabledBtn();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void EnabledBtn()
        {
            if(dgvDsKH.Rows.Count == 0)
            {
                btnXoaKH.Enabled = btnInVe.Enabled = false;
                
            }
            if(dgvDiaDiem.Rows.Count == 0)
            {
               btnXoaDD.Enabled = btnInDD.Enabled = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Tìm kiếm địa điểm
            DataView dv = dtDD.DefaultView;
            dv.RowFilter = string.Format("TenDiaDiem like '%{0}%'", textBox1.Text);
            dgvDiaDiem.DataSource = dv.ToTable();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Xóa địa điểm
            if (dgvDiaDiem.SelectedRows.Count > 0)
            {
                string name = dgvDiaDiem.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa địa điểm: " + name + " ra khỏi tour này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int idDiaDiem = int.Parse(dgvDiaDiem.CurrentRow.Cells[0].Value.ToString());
                    TourDiaDiemDTO tourDD = new TourDiaDiemDTO(idTour, idDiaDiem);
                    int res = DiaDiemDAO.Instance.XoaTourDiaDiem(tourDD);
                    if (res == -1)
                    {
                        MessageBox.Show("Có lỗi xảy ra! Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (res > 0)
                    {
                        MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDsDiaDiem();
                        EnabledBtn();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInVe_Click(object sender, EventArgs e)
        {
            if (dgvDsKH.Rows.Count > 0)
            {
                int idKhachHang = int.Parse(dgvDsKH.CurrentRow.Cells[0].Value.ToString());
                fXuatReport f = new fXuatReport();
                f.loadHoaDon(idKhachHang, idTour);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Danh sách rỗng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnInDs_Click(object sender, EventArgs e)
        {
            fXuatReport f = new fXuatReport();
            f.loadDiaDiem(idTour);
            f.ShowDialog();
        }

        private void dgvDsKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        NhanVienDTO nv = NhanVienDAO.Instance.getThongTinNV(fDangNhap.ptenDangNhap);
        private void dgvDsKH_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new ContextMenuStrip();
                int currentMouseOverRow = dgvDsKH.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    myMenu.Items.Add("Xóa").Name = "delete";
                    myMenu.Items.Add("In vé").Name = "print";
                }
                myMenu.Show(dgvDsKH, new Point(e.X, e.Y));
                try
                {
                    if (String.Compare(nv.TenChucVu, "Nhân viên dẫn đoàn", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        myMenu.Items["delete"].Visible = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenuKH_ItemCLick);
            }
        }
        private void dgvDiaDiem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new ContextMenuStrip();
                int currentMouseOverRow = dgvDiaDiem.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    myMenu.Items.Add("Xóa").Name = "delete";
                    myMenu.Items.Add("Xuất").Name = "print";
                }
                try
                {
                    if (String.Compare(nv.TenChucVu, "Nhân viên dẫn đoàn", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        myMenu.Items["delete"].Visible = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn chưa chọn địa điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                myMenu.Show(dgvDiaDiem, new Point(e.X, e.Y));

                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenuDD_ItemCLick);
            }
        }
        void myMenuKH_ItemCLick(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "delete":
                    btnXoaKH.PerformClick();
                    break;
                case "print":
                    btnInVe.PerformClick();
                    break;
            }
        }
        void myMenuDD_ItemCLick(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "delete":
                    btnXoaDD.PerformClick();
                    break;
                case "print":
                    btnInDD.PerformClick();
                    break;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Tìm kiếm khách hàng
            DataView dv = dtKH.DefaultView;
            dv.RowFilter = string.Format("HoTen like '%{0}%'", textBox2.Text);
            dgvDsKH.DataSource = dv.ToTable();
        }
    }
}
