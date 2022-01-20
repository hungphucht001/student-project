using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        Account_DAL account = new Account_DAL();
        private String message;
        public String Message { get { return message; } set { message = value; } }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            String username_ad = txtUsername.Text;
            String password_ad = txtPassword.Text;

            if(account.checkUsername(username_ad,false) > 0)
            {
              
                    int idUser = account.checkPassword(username_ad, password_ad);
                    if (idUser > 0)
                    {
                        DataTable ds = account.selectUser(idUser, false);

                        if (ds == null)
                        {
                            message = "Có lỗi xảy ra xin vui lòng thử lại";
                        }
                        else
                        {
                            foreach (DataRow r in ds.Rows)
                            {
                                Session["ID_AD"] = r["ID_MEMBER"].ToString();
                                Session["NAME_AD"] = r["FULLNAME"].ToString();
                                Session["CHUCVU"] = r["CHUCVU"].ToString();
                                Session["HUAOJATQQ"] = r["FULLNAME"].ToString() + r["USERNAME"].ToString() + r["PASSWORD"].ToString() + "abc";
                                break;
                            }
                            Response.Redirect("/admin/dashboard");
                        }
                    }
                    else
                    {
                        message = "Mật khẩu không chính xác";
                    }
            }
            else
            {
                message = "Tài khoản không tồn tại";
            }
            lbMessage.Text = message;
        }
    }
}