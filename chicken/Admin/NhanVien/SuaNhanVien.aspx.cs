using chicken.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.NhanVien
{
    public partial class SuaNhanVien : System.Web.UI.Page
    {
        int quyen;

        public int Quyen { get => quyen; set => quyen = value; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HUAOJATQQ"] != null)
            {
                quyen = Decentralization.quyen(Session["CHUCVU"].ToString());
                if(quyen > 1)
                {
                    Response.Redirect("/admin"); return;
                }
            }
        }
    }
}