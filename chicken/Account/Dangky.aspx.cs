using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Account
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Account_DAL acc = new Account_DAL();
        private String message;

        public string Message { get => message; set => message = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            MultiView.ActiveViewIndex = 0;
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            MultiView.ActiveViewIndex = 1;
        }

        protected void btnPre_Click(object sender, EventArgs e)
        {
            MultiView.ActiveViewIndex = 0;
        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            String tDangNhap, mKhau, hTen, sdt, dChi, ngaysinh ,gTinh;
            tDangNhap = txtUsername.Text;
            mKhau = txtPassword1.Text;
            hTen = txtName.Text;
            sdt = txtSDT.Text;
            dChi = txtDiaChi.Text;
            gTinh = DropDownListSex.SelectedValue.ToString();
            ngaysinh = txtNgaySinh.Text;

            if (acc.checkUser(tDangNhap) < 1)
            {
                int row = acc.dangKyUser(tDangNhap, mKhau, hTen, sdt, dChi, ngaysinh, gTinh, true);
                if (row > 0)
                {
                    message = "Đăng ký thành công";
                }
                else
                {
                    message = "Có lỗi xảy ra vui lòng thử lại";
                }
            }
            else
            {
                message = "Tài khoản đã tồn tại";
            }
            Label1.Text = message;
        }
    }
}