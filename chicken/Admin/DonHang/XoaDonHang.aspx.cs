using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.DonHang
{
    public partial class XoaDonHang : System.Web.UI.Page
    {
        XuLy xuly = new XuLy();
        protected void Page_Load(object sender, EventArgs e)
        {
            String id = (Request.QueryString["id"].ToString());
            String sql = "DELETE ORDERS WHERE ID_ORDER = '"+id+"'";
            if (xuly.delete(sql) > 0)
            {
                Response.Redirect("/admin/donhang/quanlydonhang");
            }
        }
    }
}