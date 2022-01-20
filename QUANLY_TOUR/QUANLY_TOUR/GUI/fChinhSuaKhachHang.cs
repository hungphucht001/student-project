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
    public partial class fChinhSuaKhachHang : Form
    {
        private int id_KhachHang;
        public delegate void DlgtQLKH();
        public DlgtQLKH dlgtQLKH;

        private int index;

        public int Index { get => index; set => index = value; }
        public fChinhSuaKhachHang(int id)
        {
            id_KhachHang = id;
            InitializeComponent();
        }

        private void fChinhSuaKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                var query = KhachHangDAO.Instance.GetKhachHang().AsEnumerable().Where(t => t.Field<int>("ID_KhachHang") == id_KhachHang).SingleOrDefault();

                txtHoTen_KH.Text = query.Field<string>("HoTen");
                txtDiaChi_KH.Text = query.Field<string>("DiaChi");
                txtSDT_KH.Text = query.Field<string>("SDT");
                dtpNgaySinh_KH.Value = query.Field<DateTime>("NgaySinh");

                string gt = query.Field<string>("GioiTinh");
                if (gt.CompareTo("Nam") == 0) rdNam_KH.Checked = true;
                else if (gt.CompareTo("Nữ") == 0) rdNu_KH.Checked = true;
                else rdKhac_KH.Checked = true;
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra! Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private void btnChinhSua_KH_Click(object sender, EventArgs e)
        {
            int ID = id_KhachHang;
            string hoTen = txtHoTen_KH.Text;
            string diaChi = txtDiaChi_KH.Text;
            string gioiTinh = string.Empty;
            string sdt = txtSDT_KH.Text;
            if (rdNam_KH.Checked)
            {
                gioiTinh = "Nam";
            }
            else if(rdNu_KH.Checked){
                gioiTinh = "Nữ";
            }
            else if(rdKhac_KH.Checked)
            {
                gioiTinh = "Khác";
            }
            
            DateTime ngaySinh = dtpNgaySinh_KH.Value;
            if (hoTen.Length == 0)
            {
                MessageBox.Show("Họ tên không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (diaChi.Length == 0)
            {
                MessageBox.Show("Địa chỉ không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (gioiTinh.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có muốn sửa thông tin khách hàng không", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                KhachHangDTO kh = new KhachHangDTO(ID, hoTen, sdt, diaChi, gioiTinh, ngaySinh);
                if (KhachHangDAO.Instance.suaKhachHang(kh))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }
                else MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
