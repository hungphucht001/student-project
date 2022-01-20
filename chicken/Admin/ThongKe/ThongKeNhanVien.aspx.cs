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
    public partial class ThongKeNhanVien : System.Web.UI.Page
    {
        XuLy xuly = new XuLy();
        private String number;
        private String titleTK;
        private String slNV;

        public string Number { get => number; set => number = value; }
        public string TitletTK { get => titleTK; set => titleTK = value; }
        int quyen;

        public int Quyen { get => quyen; set => quyen = value; }
        public string SlNV { get => slNV; set => slNV = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HUAOJATQQ"] != null)
            {
                quyen = Decentralization.quyen(Session["CHUCVU"].ToString());
                if (quyen != 1)
                {
                    Response.Redirect("/admin"); return;
                }
                else if (!IsPostBack) thongKeNhanVien();
            }
            slNV = xuly.count("select count(*) from members").ToString();
        }
        public void thongKeNhanVien()
        {
            String sql = "select COUNT(*) AS SL, CHUCVU from MEMBERS group by CHUCVU";
            DataTable dt = xuly.select(sql);
            int i = 0;
            number = "";
            titleTK = "";
            foreach(DataRow r in dt.Rows)
            {
                if (i > 0)
                {
                    number += ",";
                    titleTK += "_";
                }
                number += r["SL"].ToString();
                titleTK += r["CHUCVU"].ToString();
                i++;
            }
            titleTK = "'"+titleTK.Replace("_", "','")+"'";
        }
    }
}