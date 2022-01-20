using chicken.App_Start;
using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.KhachHang
{
    public partial class XoaKhachHang : System.Web.UI.Page
    {
        XuLy xuly = new XuLy();
        String message;
        int quyen;
        public int Quyen { get => quyen; set => quyen = value; }
        public string Message { get => message; set => message = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HUAOJATQQ"] != null)
            {
                quyen = Decentralization.quyen(Session["CHUCVU"].ToString());
                if (quyen > 3)
                {
                    Response.Redirect("/admin");return;
                }
            }
            if (Request.QueryString["id"] != null)
            {
                String id = Request.QueryString["id"].ToString();
                String sql = "DELETE CUSTOMER WHERE ID_KHACHHANG = "+ id;
                if (xuly.delete(sql) > 0)
                {
                    message = "Xóa thành công";
                    Response.Redirect(Request.UrlReferrer.ToString());
                }
                else message = "Có lỗi xảy ra. Vui lòng thử lại";
            }
            else Response.Redirect("/admin/khachhang/quanlykhachhang");
        }
    }
}