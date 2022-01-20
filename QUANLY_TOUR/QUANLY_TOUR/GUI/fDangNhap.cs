using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLY_TOUR.DTO;
using QUANLY_TOUR.DAO;
using QUANLY_TOUR.GUI;


namespace QUANLY_TOUR
{
    public partial class fDangNhap : Form
    {
        public static string ptenDangNhap = string.Empty;
        XuLy xl = new XuLy();
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Length == 0)
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (xl.ktraDangNhap(txtTenDangNhap.Text, txtMatKhau.Text))
            {
                ptenDangNhap = txtTenDangNhap.Text;
                if (String.Compare(xl.EncodeSHA1(txtMatKhau.Text.Trim()), xl.EncodeSHA1(TaiKhoanDAO.Instance.pMatKhau), StringComparison.OrdinalIgnoreCase) == 0)
                {
                    fDoiMatKhau fdmk = new fDoiMatKhau();
                    fdmk.Show();
                }
                else
                {
                    fMain f = new fMain(txtTenDangNhap.Text);
                    f.Size = new Size(1600, 900);
                    this.Hide();
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenDangNhap_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void txtMatKhau_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if ((MessageBox.Show("Bạn có thật sự muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK))
            //{
                Application.Exit();
            //}
        }

        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
