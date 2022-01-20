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
using QUANLY_TOUR.DTO;

namespace QUANLY_TOUR.GUI
{
    public partial class fThemKhachHang : Form
    {
        XuLy xl = new XuLy();
        public fThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_KH_Click_1(object sender, EventArgs e)
        {
            string hoTen = txtHoTen_KH.Text;
            string sdt = txtSDT_KH.Text;
            string diaChi = txtDiaChi_KH.Text;
            string gioiTinh = string.Empty;
            if (rdNam_KH.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (rdNu_KH.Checked)
            {
                gioiTinh = "Nữ";
            }
            else if(rdKhac_KH.Checked)
            {
                gioiTinh = "Khác";
            }
            if (gioiTinh.Length == 0) 
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime ngaySinh = dtpNgaySinh_KH.Value;
            if (hoTen.Length == 0)
            {
                MessageBox.Show("Họ tên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (xl.checkHoTen(hoTen)==false)
            {
                MessageBox.Show("Họ tên chỉ đuọc chứa tối đa 100 ký tự Tiếng Việt", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sdt.Length == 0)
            {
                MessageBox.Show("Số điện thoại không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }          
            if (xl.checkSDT(sdt)==false)
            {
                MessageBox.Show("Số điện thoại chỉ được chứa 10 hoặc 11 ký tự số", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (KhachHangDAO.Instance.KTTrungSDT_KH(sdt) == 1)
            {
                MessageBox.Show("Số điện thoại '" + sdt + "' đang được sử dụng bởi 1 khách hàng khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (diaChi.Length == 0)
            {
                MessageBox.Show("Địa chỉ không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn thêm khách hàng '"+hoTen+"' không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                KhachHangDTO kh = new KhachHangDTO(hoTen, sdt, diaChi, gioiTinh, ngaySinh);
                if (KhachHangDAO.Instance.themKhachHang(kh))
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }
                else MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiTiet_KH_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fThemKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
