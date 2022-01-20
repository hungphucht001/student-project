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
    public partial class fChinhSuaNhanVien : Form
    {
        private int id_NhanVien;
        XuLy xl = new XuLy();
        public fChinhSuaNhanVien(int id)
        {
            id_NhanVien = id;
            InitializeComponent();
            dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            dtpNgayVaoLam.CustomFormat = "dd-MM-yyyy";
        }

        private void fChinhSuaNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                cbbChucVu.DataSource = ChucVuDAO.Instance.GetChucVu();
                cbbChucVu.DisplayMember = "TenChucVu";
                cbbChucVu.ValueMember = "ID_ChucVu";

                cbbTrangThai.DataSource = NhanVienDAO.Instance.GetTrangThaiNV();
                cbbTrangThai.DisplayMember = "TrangThai";
                cbbTrangThai.ValueMember = "ID_TrangThai";

                var query = NhanVienDAO.Instance.GetNhanVienChucVu().AsEnumerable().Where(t => t.Field<int>("ID_NhanVien") == id_NhanVien).SingleOrDefault();

                txtHoTen.Text = query.Field<string>("HoTen");
                txtDiaChi.Text = query.Field<string>("DiaChi");
                txtLuong.Text = query.Field<double>("Luong").ToString();
                txtSDT.Text = query.Field<string>("SDT");
                cbbChucVu.SelectedValue = query.Field<int>("idChucVu");
                dtpNgayVaoLam.Value = query.Field<DateTime>("NgayVaoLam");
                dtpNgaySinh.Value = query.Field<DateTime>("NgaySinh");

                string gt = query.Field<string>("GioiTinh");
                if (gt.CompareTo("Nam") == 0) rdbNam.Checked = true;
                else if (gt.CompareTo("Nữ") == 0) rdbNu.Checked = true;
                else rdbKhac.Checked = true;
                cbbTrangThai.SelectedValue = query.Field<int>("TrangThai");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Dispose();
            else return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string gt = string.Empty;
            if (rdbNam.Checked) gt = "Nam";
            else if (rdbNu.Checked) gt = "Nữ";
            else if (rdbKhac.Checked) gt = "Khác";
            if (txtHoTen.Text == string.Empty)
            {
                MessageBox.Show("Họ tên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var today = DateTime.Today;
            var age = today.Year - dtpNgaySinh.Value.Year;
            // Go back to the year the person was born in case of a leap year
            if (age < 18)
            {
                MessageBox.Show("Tuổi phải từ 18", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh phải bé hơn ngày hiện tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (gt == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSDT.Text == string.Empty)
            {
                MessageBox.Show("Số điện thoại không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (txtSDT.Text.Trim().Length > 10 || txtSDT.Text.Trim().Length < 9)
            //{
            //    MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải từ 9 đến 10 số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (xl.checkSDT(txtSDT.Text)==false)
            {
                MessageBox.Show("Số điện thoại chỉ được chứa 10 hoặc 11 ký tự số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Địa chỉ không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtLuong.Text == string.Empty)
            {
                MessageBox.Show("Lương không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbChucVu.SelectedValue == null)
            {
                MessageBox.Show("Chức vụ không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbTrangThai.SelectedValue == null)
            {
                MessageBox.Show("Trạng thái không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool res = NhanVienDAO.Instance.UpdateNhanVien(id_NhanVien, txtHoTen.Text, txtSDT.Text, gt, dtpNgaySinh.Value, dtpNgaySinh.Value, double.Parse(txtLuong.Text), int.Parse(cbbChucVu.SelectedValue.ToString()), txtDiaChi.Text, int.Parse(cbbTrangThai.SelectedValue.ToString()));
            if (res)
            {
                MessageBox.Show("Chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đặt lại mật khẩu của nhân viên?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (TaiKhoanDAO.Instance.DatLaiMK(id_NhanVien.ToString(), xl.EncodeSHA1(TaiKhoanDAO.Instance.pMatKhau)))
                {
                    MessageBox.Show("Đặt lại mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
