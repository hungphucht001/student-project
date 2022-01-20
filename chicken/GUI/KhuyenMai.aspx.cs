using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken
{
    public partial class KhuyenMai : System.Web.UI.Page
    {
        XuLy xyly = new XuLy();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) displayData();
        }
        private void displayData()
        {
            String sql = "SELECT * FROM PRODUCTS WHERE ID_CATEGORY = 6";
            ListView1.DataSource = xyly.select(sql);
            ListView1.DataBind();
        }
        public int ranNum()
        {
            Random a = new Random();
            return a.Next(1,9);
        }
    }
}