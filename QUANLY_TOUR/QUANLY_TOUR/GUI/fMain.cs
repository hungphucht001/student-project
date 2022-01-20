using QUANLY_TOUR.DAO;
using QUANLY_TOUR.DTO;
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

namespace QUANLY_TOUR
{
    public partial class fMain : Form
    {
        fQuanLyTour fQLTour = new fQuanLyTour();
        fQuanLyNhanVien fQLNhanVien = new fQuanLyNhanVien();
        fThongKe fThongKe = new fThongKe();
        fTrangChu fTrangchu = new fTrangChu();
        fDangKyTour fDangKyTour = new fDangKyTour();
        fQuanLyKhachHang fQuanLyKhachHang = new fQuanLyKhachHang();
        fQuanLyKhachSan fKhachSan = new fQuanLyKhachSan();
        fQuanLyDoanhThu fDoanhThu = new fQuanLyDoanhThu();
        fQuanLyPhuongTien fPhuongTien = new fQuanLyPhuongTien();
        fTaiKhoan fTaiKhoan = new fTaiKhoan();
        public void quyenNhanVienDK()
        {
            btnDangKyTour.Visible = true;
            btnQuanLyTour.Visible = true;
            btnQuanLyNhanVien.Visible = false;
            btnKhachHang.Visible = true;
            btnKhachSan.Visible = false;
            btnPhuongTien.Visible = false;
            btnDoanhThu.Visible = false;
            btnThongKe.Visible = false;
        }
        public void quyenNhanVienDD()
        {
            btnDangKyTour.Visible = false;
            btnQuanLyTour.Visible = true;
            btnQuanLyNhanVien.Visible = false;
            btnKhachHang.Visible = true;
            btnKhachSan.Visible = false;
            btnPhuongTien.Visible = false;
            btnDoanhThu.Visible = false;
            btnThongKe.Visible = false;
        }
        public void quyenQuanLy()
        {
            btnDangKyTour.Visible = true;
            btnQuanLyTour.Visible = true;
            btnQuanLyNhanVien.Visible = false;
            btnKhachHang.Visible = true;
            btnKhachSan.Visible = true;
            btnPhuongTien.Visible = true;
            btnDoanhThu.Visible = true;
            btnThongKe.Visible = true;
        }
        public void quyenGiamDoc()
        {
            btnDangKyTour.Visible = true;
            btnQuanLyTour.Visible = true;
            btnQuanLyNhanVien.Visible = true;
            btnKhachHang.Visible = true;
            btnKhachSan.Visible = true;
            btnPhuongTien.Visible = true;
            btnDoanhThu.Visible = true;
            btnThongKe.Visible = true;
        }
        bool isExit = true;
        public static NhanVienDTO nv;
        string tenDangNhap;
        public fMain(string tenDangNhap)
        {
            this.tenDangNhap = tenDangNhap;
            nv = NhanVienDAO.Instance.getThongTinNV(tenDangNhap);
            InitializeComponent();
            OpenChildFrom(fTrangchu);

            btnTaiKhoan.Text = nv.HoTen;
        }

        public void OpenChildFrom(Form childForm, object btnSender = null)
        {
            this.pnContent.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnContent.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }

        private void btnDangKyTour_Click(object sender, EventArgs e)
        {
            OpenChildFrom(fDangKyTour);
        }

        
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            OpenChildFrom(fKhachSan);
        }

          private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildFrom(fTrangchu);
        }

        private void btnQuanLyTour_Click(object sender, EventArgs e)
        {
            OpenChildFrom(fQLTour);
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildFrom(fQLNhanVien);
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            OpenChildFrom(fQuanLyKhachHang);
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            OpenChildFrom(fTrangchu);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildFrom(fPhuongTien);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildFrom(fDoanhThu);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có muốn đăng xuất không không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                isExit = false;
                this.Close();
                fDangNhap f = new fDangNhap();
                f.Show();
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenChildFrom(fTaiKhoan);
        }
        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            OpenChildFrom(fThongKe);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            if (nv.TenChucVu.ToString().Equals("Giám Đốc"))
            {     
                quyenGiamDoc();
            }
            else if(nv.TenChucVu.ToString().Equals("Quản Lý"))
            {
                quyenQuanLy();
            }
            else if (nv.TenChucVu.ToString().Equals("Nhân Viên Đăng Ký"))
            {
                quyenNhanVienDK();
            }
            else if (nv.TenChucVu.ToString().Equals("Nhân Viên Dẫn Đoàn"))
            {
                quyenNhanVienDD();
            }
        }
        private void fMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if ((MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }    
        }
    }
}
