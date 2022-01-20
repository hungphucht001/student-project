using QUANLY_TOUR.DAO;
using QUANLY_TOUR.DTO;
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
    public partial class fChinhSuaTour : Form
    {
        int idTour;
        public fChinhSuaTour(int idTour)
        {
            this.idTour = idTour;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Lưu
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
            if (int.Parse(txtSoVe.Text) < 0)
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
            double giaVe = double.Parse(txtGiaVe.Text);
            int giamGia = int.Parse(txtGiamGia.Text);
            string tenTour = txtTenTour.Text;
            int idMe = 26;
            var res = TourDAO.Instance.UpdateTour(idTour,dtpNgayBD.Value, dtpNgayKT.Value, soVe, phuongTien, khachSan, nguoiDan, giaVe, giamGia, idMe, tenTour, 1);
            if (res == 0)
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }    
            else if(res == 1)
                MessageBox.Show("Tour không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void fChinhSuaTour_Load(object sender, EventArgs e)
        {
            //load tour
            try
            {
                cbbKhachSan.DataSource = KhachSanDAO.Instance.GetKhachSan();
                cbbKhachSan.DisplayMember = "TenKhachSan";
                cbbKhachSan.ValueMember = "ID_KhachSan";
                cbbKhachSan.SelectedItem = null;

                cbbPhuongTien.DataSource = PhuongTienDAO.Instance.GetPhuongTien();
                cbbPhuongTien.DisplayMember = "TenPhuongTien";
                cbbPhuongTien.ValueMember = "ID_PhuongTien";
                cbbPhuongTien.SelectedItem = null;

                cbbNhanVien.DataSource = NhanVienDAO.Instance.GetNhanVienDanDoan();
                cbbNhanVien.DisplayMember = "HoTen";
                cbbNhanVien.ValueMember = "ID_NhanVien";
                cbbNhanVien.SelectedItem = null;


                //TourDTO t = TourDAO.Instance.GetTour(idTour);
                //txtSoVe.Text = t.SoVe.ToString();
                //cbbPhuongTien.SelectedValue = t.idPhuongTien;
                //cbbKhachSan.SelectedValue = t.idKhachSan;
                //cbbNhanVien.SelectedValue = t.idNhanVienDanDoan;
                //txtGiaVe.Text = t.Gia.ToString();
                //txtGiamGia.Text = t.GiamGia.ToString();
                //txtTenTour.Text = t.TenTour;
                //dtpNgayBD.Value = t.NgayBD;
                //dtpNgayKT.Value = t.NgayKT;

                var query = TourDAO.Instance.GetTour().AsEnumerable().Where(t => t.Field<int>("ID_Tour") == idTour).SingleOrDefault();
                txtTenTour.Text = query.Field<string>("Tentour");
                dtpNgayBD.Value = query.Field<DateTime>("NgayBD");
                dtpNgayKT.Value = query.Field<DateTime>("NgayKT");
                txtSoVe.Text = query.Field<int>("SoVe").ToString();
                cbbPhuongTien.SelectedValue = query.Field<int>("idPhuongTien");
                cbbKhachSan.SelectedValue = query.Field<int>("idKhachSan");
                txtGiaVe.Text = query.Field<decimal>("Gia").ToString();
                txtGiamGia.Text = query.Field<int>("GiamGia").ToString();
                cbbNhanVien.SelectedValue = query.Field<int>("idNhanVienDanDoan");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
