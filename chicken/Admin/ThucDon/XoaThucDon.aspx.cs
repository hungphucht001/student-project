using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.ThucDon
{
    public partial class XoaThucDon : System.Web.UI.Page
    {
        Dish_DAL dish = new Dish_DAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"].ToString());

            if (dish.deleteDish(id) > 0)
            {
                Response.Redirect("/admin/thucdon/quanlythucdon");
            }
        }
    }
}