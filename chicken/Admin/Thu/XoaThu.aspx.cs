using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.Thu
{
    public partial class XoaThu : System.Web.UI.Page
    {
        XuLy xuly = new XuLy();
        String message;

        public string Message { get => message; set => message = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["id"] != null)
            {
                if(xuly.delete("DELETE LETTERS WHERE ID_LETTER = "+ Request.QueryString["id"].ToString()) > 1)
                {
                    message = "Xóa thành công";
                    Response.Redirect("/admin/thu/duyetthu");
                }
                else
                {
                    message = "Có lỗi xảy ra vui lòng thử lại";
                    Response.Redirect("/admin/thu/duyetthu");
                }
            }
        }
    }
}