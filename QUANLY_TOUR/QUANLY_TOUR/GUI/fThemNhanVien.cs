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
    public partial class fThemNhanVien : Form
    {
        XuLy xl = new XuLy();
        public fThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
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
            if (xl.checkHoTen(txtHoTen.Text) == false)
            {
                MessageBox.Show("Họ tên phải từ 1-100 ký tự Tiếng Việt", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var today = DateTime.Today;
            var age = today.Year - dtpNgaySinh.Value.Year;
            
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
            if (xl.checkSDT(txtSDT.Text) == false)
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải từ 10 đến 11 số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (txtSDT.Text.Trim().Length > 10 || txtSDT.Text.Trim().Length < 9)
            //    {
            //    MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải từ 9 đến 10 số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            if (txtDiaChi.Text == string.Empty)
            {
                MessageBox.Show("Địa chỉ không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (xl.checkDiaChi(txtDiaChi.Text) == false)
            {
                MessageBox.Show("Địa chỉ chỉ chứa tối đa 250 ký tự Tiếng việt và dấu /", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (txtTaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (xl.checkTenDangNhap(txtTaiKhoan.Text) == false)
            {
                MessageBox.Show("Tài khoản phải từ 4-20 ký tự thường", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (TaiKhoanDAO.Instance.KTTrungTaiKhoan(txtTaiKhoan.Text) == 1)
            {
                MessageBox.Show("Tài khoản đã tồn tại, Vui lòng nhập tài khoản khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbTrangThai.SelectedValue == null)
            {
                MessageBox.Show("Trạng thái không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm nhân viên mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                bool res = NhanVienDAO.Instance.InsertNhanVien(txtHoTen.Text, txtSDT.Text, gt, dtpNgaySinh.Text, dtpNgayVl.Text, double.Parse(txtLuong.Text), int.Parse(cbbChucVu.SelectedValue.ToString()), txtDiaChi.Text, int.Parse(cbbTrangThai.SelectedValue.ToString()));
                bool res2 = TaiKhoanDAO.Instance.InsertTaiKhoan(txtTaiKhoan.Text, xl.EncodeSHA1(TaiKhoanDAO.Instance.pMatKhau), NhanVienDAO.Instance.getIDNhanVien());
                if (res && res2)
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clear()
        {
            txtHoTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            dtpNgaySinh.Value = DateTime.Today;
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            rdbKhac.Checked = false;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            dtpNgayVl.Value = DateTime.Today;
            txtLuong.Text = string.Empty;
            cbbChucVu.SelectedIndex = 0;
            txtTaiKhoan.Text = string.Empty;
            cbbTrangThai.SelectedIndex = 0;
            txtHoTen.Focus();
        }

        private void fThemNhanVien_Load(object sender, EventArgs e)
        {
            cbbChucVu.DataSource = ChucVuDAO.Instance.GetChucVu();
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.ValueMember = "ID_ChucVu";

            cbbTrangThai.DataSource = NhanVienDAO.Instance.GetTrangThaiNV();
            cbbTrangThai.DisplayMember = "TrangThai";
            cbbTrangThai.ValueMember = "ID_TrangThai";
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
