using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using chicken.DAL;

namespace chicken.Account
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Account_DAL account = new Account_DAL();
        String message;
        public String Message{get { return message; } set { message = value; }}

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            if (account.checkUsername(username,true) > 0)
            {
                int idUser = account.checkPassword(username,password);
                if (idUser > 0)
                {
                    DataTable ds = account.selectUser(idUser,true);

                    if (ds == null)
                    {
                        message = "Có lỗi xảy ra xin vui lòng thử lại";
                    }
                    else
                    {
                        foreach (DataRow r in ds.Rows)
                        {
                            Session["name"] = r["FULLNAME"];
                            Session["sdt"] = r["SDT"];
                            Session["diachi"] = r["DIACHI"];
                            Session["id"] = r["ID_USER"];
                            Session["userkh"] = r["USERNAME"];

                            var user = r["USERNAME"];
                            var pass = r["PASSWORD"];
                            break;
                        }
                        Response.Redirect("/");
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
        }
    }
}