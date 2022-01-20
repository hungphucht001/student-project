using QUANLY_TOUR.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLY_TOUR.GUI;
using QUANLY_TOUR.DTO;
using QUANLY_TOUR.GUI.Design;

namespace QUANLY_TOUR
{
    public partial class fQuanLyTour : Form
    {
        int indexDiaDiem = 0;
        private object[] ltTrangThaiDD;
        private DataTable dtDiaDiem;
        private DataTable dtTour;
        private DataTable dtTourDiDiem;
        public fQuanLyTour()
        {
            ltTrangThaiDD = new object[]{
            "Hoạt động",
            "Tạm ngưng",
            "Ngừng hoạt động"};

            InitializeComponent();
            ThietKe.designDGV(dvgDDMoTour);
            ThietKe.designDGV(dgvDsTour);
            ThietKe.designDGV(dgvDiaDiem);
            dvgDDMoTour.MultiSelect = true;
            dgvDsTour.Columns[5].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvDsTour.Columns[6].DefaultCellStyle.Format = "dd-MM-yyyy";
            dvgDDMoTour.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvDiaDiem.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
            dgvDsTour.Columns[2].DefaultCellStyle.Format = "0,0 đ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }
        public void quyenNVDD()
        {
            btnSuaTour.Enabled = btnXoaTour.Enabled = false;
            btnThemTour.Enabled = btnThemDD.Enabled = btnSuaDD.Enabled = btnXoaDD.Enabled = false;
        }
        private void fQuanLyTour_Load(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv = NhanVienDAO.Instance.getThongTinNV(fDangNhap.ptenDangNhap);
            if (String.Compare(nv.TenChucVu, "Nhân Viên Dẫn Đoàn", StringComparison.OrdinalIgnoreCase) == 0)
            {
                quyenNVDD();
            }
            cbbKhuVuc.DataSource = KhuVucDAO.Instance.GetKhuVuc();
            cbbKhuVuc.DisplayMember = "TenKhuVuc";
            cbbKhuVuc.ValueMember = "ID_KhuVuc";
            cbbKhuVuc.SelectedIndex = 0;

            cbbKhuVucDiaDiem.DataSource = KhuVucDAO.Instance.GetKhuVuc();
            cbbKhuVucDiaDiem.DisplayMember = "TenKhuVuc";
            cbbKhuVucDiaDiem.ValueMember = "ID_KhuVuc";
            cbbKhuVucDiaDiem.SelectedIndex = 0;

            cbbPhuongTien.DataSource = PhuongTienDAO.Instance.GetPhuongTien();
            cbbPhuongTien.DisplayMember = "TenPhuongTien";
            cbbPhuongTien.ValueMember = "ID_PhuongTien";
            cbbPhuongTien.SelectedIndex = 0;

            loadData();

            LoadNhanVien();

            loadDiaDiem();

            int idChucVu = int.Parse(cbbKhuVuc.SelectedValue.ToString());

            dtTourDiDiem = DiaDiemDAO.Instance.GetDiaDiem(idChucVu);
            dvgDDMoTour.AutoGenerateColumns = false;
            dvgDDMoTour.DataSource = dtTourDiDiem;

            if (cbbTrangThaiDD.Items.Count > 0)
            {
                cbbTrangThaiDD.Items.Clear();
            }

            cbbTrangThaiDD.Items.AddRange(ltTrangThaiDD);
            cbbTrangThaiDD.SelectedIndex = 0;
        }


        private void cbbKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhuVuc.SelectedItem != null)
            {
                cbbKhuVuc.DisplayMember = "TenKhuVuc";
                cbbKhuVuc.ValueMember = "ID_KhuVuc";
                int idChucVu = int.Parse(cbbKhuVuc.SelectedValue.ToString());

                dtTourDiDiem = DiaDiemDAO.Instance.GetDiaDiem(idChucVu);
                dvgDDMoTour.AutoGenerateColumns = false;
                dvgDDMoTour.DataSource = dtTourDiDiem;

                cbbKhachSan.Text = string.Empty;
                cbbKhachSan.DataSource = KhachSanDAO.Instance.GetKhachSan(idChucVu);
                cbbKhachSan.DisplayMember = "TenKhachSan";
                cbbKhachSan.ValueMember = "ID_KhachSan";
            }
        }

        private void cbbKhuVuc_MouseClick(object sender, MouseEventArgs e)
        {
             
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
        public void LoadNhanVien()
        {
            cbbNhanVien.DataSource = NhanVienDAO.Instance.GetNhanVienDanDoan();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "ID_NhanVien";
            cbbNhanVien.SelectedItem = 0;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void clear()
        {
            dtpNgayBD.Value = DateTime.Today;
            dtpNgayKT.Value = DateTime.Today;
            txtSoVe.Clear();
            cbbPhuongTien.SelectedIndex = 0;
            cbbKhachSan.SelectedIndex = 0;
            cbbNhanVien.SelectedItem = 0;
            txtGiaVe.Clear();
            txtGiamGia.Clear();
            txtTenTour.Clear();
            txtSoVe.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtSoVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSoVe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThemTour.PerformClick();
            }
        }

        private void txtGiaVe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThemTour.PerformClick();
            }
        }

        private void txtGiamGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThemTour.PerformClick();
            }
        }
        public void loadData()
        {
            dtTour = TourDAO.Instance.LoadTourFull();
            dgvDsTour.AutoGenerateColumns = false;
            dgvDsTour.DataSource = dtTour;
        }

        //Địa điểm

        public void loadDiaDiem()
        {
            dtDiaDiem = DiaDiemDAO.Instance.GetDiaDiem();
            dgvDiaDiem.AutoGenerateColumns = false;
            dgvDiaDiem.DataSource = dtDiaDiem;

        }
        public bool TextBoxIsEmpty(TextBox t)
        {
            if (t.Text != string.Empty) return false;
            return true;
        }

        public void clearDiaDiem()
        {
            txtDiaDiem.Clear();
            txtMoTa.Clear();
            dtpNgayThemDD.Value = DateTime.Now;
            cbbTrangThaiDD.SelectedIndex = 0;
            cbbKhuVucDiaDiem.SelectedIndex = 0;
            txtDiaDiem.Focus();
        }
        private void btnLuuDD_Click(object sender, EventArgs e)
        {
            //Thêm địa điểm

            if (TextBoxIsEmpty(txtDiaDiem))
            {
                MessageBox.Show("Tên địa điểm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaDiem.Focus();
                return;
            }
            if (TextBoxIsEmpty(txtMoTa))
            {
                MessageBox.Show("Mô tả địa điểm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoTa.Focus();
                return;
            }
            if (cbbKhuVucDiaDiem.SelectedValue == null)
            {
                MessageBox.Show("Khu vực không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ltTrangThaiDD.Where(t => t.Equals(cbbTrangThaiDD.Text)).Any())
            {
                MessageBox.Show("Trạng thái không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DiaDiemDTO dd = new DiaDiemDTO(txtDiaDiem.Text, 16, cbbTrangThaiDD.Text, txtMoTa.Text, dtpNgayThemDD.Value, int.Parse(cbbKhuVucDiaDiem.SelectedValue.ToString()));
            var res = DiaDiemDAO.Instance.InsertDiaDiem(dd);
            if (res)
            {
                MessageBox.Show("Thêm địa điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDiaDiem();
                clearDiaDiem();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra. Thêm địa điểm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSua_KH_Click(object sender, EventArgs e)
        {
            if (dgvDiaDiem.SelectedRows.Count > 0)
            {
                string name = dgvDiaDiem.CurrentRow.Cells[1].Value.ToString();
                int id = int.Parse(dgvDiaDiem.CurrentRow.Cells[0].Value.ToString());
                if (DiaDiemDAO.Instance.KTKNDiaDiem_TourDiaDiem(id)==1)
                {
                    MessageBox.Show("Không thể xóa do địa điểm đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa địa điểm: " + name + " này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DiaDiemDAO.Instance.DeletetDiaDiem(id) == 0)
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDiaDiem();
                    }
                    else if (DiaDiemDAO.Instance.DeletetDiaDiem(id) == 1)
                    {
                        MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClearFromDD_Click(object sender, EventArgs e)
        {
            clearDiaDiem();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtDiaDiem.DefaultView;
            dv.RowFilter = string.Format("TenDiaDiem like '%{0}%'", txtSearch.Text);
            dgvDiaDiem.DataSource = dv.ToTable();
        }

        private void btnThem_KH_Click(object sender, EventArgs e)
        {
            indexDiaDiem = int.Parse(dgvDiaDiem.CurrentRow.Cells[0].Value.ToString());
            fChinhSuaDiaDiem f = new fChinhSuaDiaDiem(indexDiaDiem);
            f.ShowDialog();
            loadDiaDiem();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Chi tiết tour

            int idTour = int.Parse(dgvDsTour.CurrentRow.Cells[0].Value.ToString());
            fChiTietTour f = new fChiTietTour(idTour);
            f.ShowDialog();

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtTour.DefaultView;
            dv.RowFilter = string.Format("TenTour like '%{0}%'" ,txtTimKiem.Text);
            dgvDsTour.DataSource = dv;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dtpNgayBD.Value <= DateTime.Today)
            {
                MessageBox.Show("Ngày bắt đầu phải lớn hơn hoặc bằng ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpNgayKT.Value <= DateTime.Today)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpNgayKT.Value <= dtpNgayBD.Value)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSoVe.Text.Length == 0)
            {
                MessageBox.Show("Số vé không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(txtSoVe.Text) <= 0)
            {
                MessageBox.Show("Số vé không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbPhuongTien.SelectedValue == null)
            {
                MessageBox.Show("Phương tiện không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbKhachSan.SelectedValue == null)
            {
                MessageBox.Show("Khách sạn không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbNhanVien.SelectedValue == null)
            {
                MessageBox.Show("Nhân viên không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtGiaVe.Text.Length == 0)
            {
                MessageBox.Show("Giá vé không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(txtGiaVe.Text) < 0)
            {
                MessageBox.Show("Giá vé không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtGiamGia.Text.Length == 0)
            {
                MessageBox.Show("Giá giảm không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.Parse(txtGiamGia.Text) < 0)
            {
                MessageBox.Show("Giá giảm không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int soVe = int.Parse(txtSoVe.Text);
            int phuongTien = int.Parse(cbbPhuongTien.SelectedValue.ToString());
            int khachSan = int.Parse(cbbKhachSan.SelectedValue.ToString());
            int nguoiDan = int.Parse(cbbNhanVien.SelectedValue.ToString());
            int giaVe = int.Parse(txtGiaVe.Text);
            int giamGia = int.Parse(txtGiamGia.Text);
            string tenTour = txtTenTour.Text;
            int idMe = 26;
            var res = TourDAO.Instance.InsertTour(dtpNgayBD.Value, dtpNgayKT.Value, soVe, phuongTien, khachSan, nguoiDan, giaVe, giamGia, idMe, tenTour, 1);
            if (res)
            {
                int idTour = TourDAO.Instance.GetIdTourNew();
                //Thêm địa điểm
                foreach(DataGridViewRow item in dvgDDMoTour.SelectedRows)
                {
                    int idDiaDiem = int.Parse(item.Cells[0].Value.ToString());
                    TourDiaDiemDTO tourDD = new TourDiaDiemDTO(idTour, idDiaDiem);
                    DiaDiemDAO.Instance.ThemDiaDiem(tourDD);
                }

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clear();
            }
            else
            {
                MessageBox.Show("Lỗi, Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Tìm kiếm địa điểm
            DataView dv = dtTourDiDiem.DefaultView;
            dv.RowFilter = string.Format("TenDiaDiem like '%{0}%'",textBox4.Text);
            dvgDDMoTour.DataSource = dv.ToTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Xóa tour

            if(dgvDsTour.SelectedRows.Count > 0)
            {
                int idTour = int.Parse(dgvDsTour.CurrentRow.Cells[0].Value.ToString());
                string tenTour = dgvDsTour.CurrentRow.Cells[1].Value.ToString();
                if (TourDAO.Instance.KTKNDTour_DangKyTour(idTour)==1 || TourDAO.Instance.KTKNDTour_TourDiaDiem(idTour) == 1)
                {
                    MessageBox.Show("Tour đang được sử dụng nên không thể xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có muốn xóa tour: "+tenTour+" này không.","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    if (TourDAO.Instance.CheckDeleteTour(idTour) == true)
                    {
                        var res = TourDAO.Instance.DeleteTour(idTour);
                        if (res == 0)
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                            return;
                        }
                        else if (res == 1)
                        {
                            MessageBox.Show("Không tìm thấy tour.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra. Không thể xóa. Vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa tour này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Reset tour
            loadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Chỉnh sửa tour


            if (dgvDsTour.SelectedRows.Count > 0)
            {
                int idTour = int.Parse(dgvDsTour.CurrentRow.Cells[0].Value.ToString());
                fChinhSuaTour f = new fChinhSuaTour(idTour);
                f.ShowDialog();
                loadData();
            }
        }

        private void dvgDDMoTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbbPhuongTien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvDsTour_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new ContextMenuStrip();
                int currentMouseOverRow = dgvDsTour.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    myMenu.Items.Add("Làm mới").Name = "refresh";
                    myMenu.Items.Add("Chỉnh sửa").Name = "edit";
                    myMenu.Items.Add("Xóa").Name = "delete";
                    myMenu.Items.Add("Xuất").Name = "print";
                    myMenu.Items.Add("Chi tiết").Name = "detail";
                }
                myMenu.Show(dgvDsTour, new Point(e.X, e.Y));
                try
                {
                    if (String.Compare(nv.TenChucVu, "Nhân viên dẫn đoàn", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        myMenu.Items["edit"].Visible = myMenu.Items["delete"].Visible = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn chưa chọn tour", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenuTour_ItemCLick);
            }
        }
        NhanVienDTO nv = NhanVienDAO.Instance.getThongTinNV(fDangNhap.ptenDangNhap);
        private void dgvDiaDiem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip myMenu = new ContextMenuStrip();
                int currentMouseOverRow = dgvDiaDiem.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    myMenu.Items.Add("Làm mới").Name = "refresh";
                    myMenu.Items.Add("Chỉnh sửa").Name = "edit";
                    myMenu.Items.Add("Xóa").Name = "delete";
                    myMenu.Items.Add("Xuất").Name = "print";
                }
                myMenu.Show(dgvDiaDiem, new Point(e.X, e.Y));
                try
                {
                    if (String.Compare(nv.TenChucVu, "Nhân viên dẫn đoàn", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        myMenu.Items["edit"].Visible = myMenu.Items["delete"].Visible = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn chưa chọn địa điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                myMenu.ItemClicked += new ToolStripItemClickedEventHandler(myMenuDD_ItemCLick);
            }
        }
        void myMenuTour_ItemCLick(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "refresh":
                    btnLamMoi_Tour.PerformClick();
                    break;
                case "edit":
                    btnSuaTour.PerformClick();
                    break;
                case "print":
                    btnXuatTour.PerformClick();
                    break;
                case "delete":
                    btnXoaTour.PerformClick();
                    break;
                case "detail":
                    btnChiTiet.PerformClick();
                    break;
            }
        }
        void myMenuDD_ItemCLick(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "refresh":
                    btnLamMoiDD.PerformClick();
                    break;
                case "edit":
                    btnSuaDD.PerformClick();
                    break;
                case "print":
                    btnXuatDD.PerformClick();
                    break;
                case "delete":
                    btnXoaDD.PerformClick();
                    break;
            }
        }
    }
}
