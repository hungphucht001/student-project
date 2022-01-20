using chicken.App_Start;
using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.ThongKe
{
    public partial class ThongKeDoanhThu : System.Web.UI.Page
    {
        int quyen;
        String titleTK, slTK;
        public int Quyen { get => quyen; set => quyen = value; }
        public string TitleTK { get => titleTK; set => titleTK = value; }
        public string SlTK { get => slTK; set => slTK = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HUAOJATQQ"] != null)
            {
                quyen = Decentralization.quyen(Session["CHUCVU"].ToString());
                if (quyen != 1)
                {
                    Response.Redirect("/admin"); return;
                }
                if (!IsPostBack) thongkeDoanhThu();
            }
            
        }
        private void thongkeDoanhThu()
        {
            String sql = "SELECT MONTH(NGAYMUA) THANG, SUM(Gia) GIA FROM ORDERS WHERE YEAR(NGAYMUA) = YEAR(GETDATE()) GROUP BY MONTH(NGAYMUA)";
            DataTable dttk = new XuLy().select(sql);
            int i = 0;
            SlTK = "";
            titleTK = "";
            foreach (DataRow r in dttk.Rows)
            {
                if (i > 0)
                {
                    SlTK += ",";
                    titleTK += "_";
                }
                SlTK += r["GIA"].ToString();
                titleTK += "Tháng "+r["THANG"].ToString();
                i++;
            }
            titleTK = "'" + titleTK.Replace("_", "','") + "'";
        }
    }
}