using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.TinTuc
{
    public partial class XoaBaiViet : System.Web.UI.Page
    {
        News news = new News();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"].ToString());

            if (news.deletenNews(id) > 0)
            {
                Response.Redirect(Request.UrlReferrer.ToString());
            }
        }
    }
}