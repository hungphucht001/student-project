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
    public partial class fDoiMatKhau : Form
    {
        XuLy xl = new XuLy();
        public fDoiMatKhau()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void txtTenPT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoiMatKhau.PerformClick();
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatKhauCu.Text.Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtMatKhauMoi.Text.Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtNhapLaiMK.Text.Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.Compare(txtNhapLaiMK.Text, txtMatKhauMoi.Text) != 0)
                {
                    MessageBox.Show("Mật khẩu mới không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (xl.ktraDangNhap(fDangNhap.ptenDangNhap, txtMatKhauCu.Text) == false)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (String.Compare(txtMatKhauCu.Text, txtMatKhauMoi.Text) == 0)
                {
                    MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.Compare(txtMatKhauMoi.Text, TaiKhoanDAO.Instance.pMatKhau) == 0)
                {
                    MessageBox.Show("Mật khẩu mới không được trùng mật khẩu mặc định", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Bạn có chắc muốn đổi mật khẩu?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (TaiKhoanDAO.Instance.DoiMatKhau(fDangNhap.ptenDangNhap, xl.EncodeSHA1(txtMatKhauMoi.Text)))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fDoiMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
