using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Controls
{
    public partial class DonHangDangDat : System.Web.UI.UserControl
    {
        DataTable dt;
        XuLy xuly = new XuLy();
        String message;

        public string Message { get => message; set => message = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            loadData();
        }
        private void loadData()
        {
            dt = xuly.layDonHang(int.Parse(Session["id"].ToString()));
            ListView1.DataSource = dt;
            ListView1.DataBind();
        }
        
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            loadData();
        }
    }
}