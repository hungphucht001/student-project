using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken
{
    public partial class chitietbaiviet : System.Web.UI.Page
    {
        News news = new News();
        private DataTable dt;
        public DataTable Dt { get { return dt; } }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(RouteData.Values["Id"] != null)
            {
                dt = news.selectNewsItem(RouteData.Values["Id"].ToString());
                ListView.DataSource = dt;
                ListView.DataBind();
            }
            else
            {
                Response.Redirect("/tin-tuc");
            }
        }
    }
}