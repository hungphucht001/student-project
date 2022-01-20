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
    public partial class fTaiKhoan : Form
    {
        public fTaiKhoan()
        {
            InitializeComponent();
        }
        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv = NhanVienDAO.Instance.getThongTinNV(fDangNhap.ptenDangNhap);
            //DateTime dNgaySinh = DateTime.Parse(nv.NgaySinh);
            //string sqlFormattedDate = dNgaySinh.Date.ToString("dd-MM-yyyy");
            txtMaNV.Text = nv.ID_NhanVien.ToString();
            txtTenNV.Text = nv.HoTen;
            txtChucVu.Text = nv.TenChucVu.ToString();
            txtNgaySinh.Text = nv.NgaySinh;
            //dateTimePicker1.Value = Convert.ToDateTime(nv.NgaySinh.ToString());
            txtGioiTinh.Text = nv.GioiTinh;
            txtDiaChi.Text = nv.DiaChi;
            txtSDT.Text = nv.SDT;
            txtNgayVL.Text = nv.NgayVaoLam.ToString();
            txtTrangThai.Text = nv.TrangThai.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau();
            f.ShowDialog();
        }

    }
}
