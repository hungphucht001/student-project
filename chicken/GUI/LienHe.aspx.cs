using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken
{
    public partial class LienHe : System.Web.UI.Page
    {
        XuLy xuly = new XuLy();
        String message;

        public string Message { get => message; set => message = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String name, sdt, email, content;
            name = txtName.Text;
            sdt = txtSDT.Text;
            email = txtEmail.Text;
            content = txtContent.Text;
            if (xuly.guiThu(name, sdt, email, content) > 0) message = "Gửi thư thành công. Bạn sẽ sớm nhận được phản hồi qua email";
            else message = "Gửi thư thất bại. Có lỗi xảy ra, xin vui lòng thử lại sau";
            lbMessage.Text = message;
        }
    }
}