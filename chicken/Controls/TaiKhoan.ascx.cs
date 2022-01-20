using chicken.App_Start;
using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Controls
{
    public partial class TaiKhoan : System.Web.UI.UserControl
    {
        XuLy xuly = new XuLy();
        Account_DAL acc = new Account_DAL();
        String message;

        public string Message { get => message; set => message = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
            }
        }

        protected void LinkBtnEdit_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (kiemTraMKCu() > 0)
            {
                String sql = "UPDATE USERS SET PASSWORD = '"+ Fun.EncryptPassword(txtNewPassword.Text)+"' WHERE ID_USER = "+Session["id"].ToString();
                if (xuly.insert(sql) > 0) message = "Đổi mật khẩu thành công";
                else message = "có lỗi xảy ra vui lòng thử lại";
            }
            else
            {
                message = "Mật khẩu cũ không chính xác";
            }
            lbMessage.Text = message;
        }
        private int kiemTraMKCu()
        {
            return xuly.count("SELECT count(*) FROM USERS WHERE USERNAME = '"+Session["userkh"].ToString()+"' AND PASSWORD = '"+Fun.EncryptPassword(txtOldPassword.Text)+"'");
        }
    }
}