using chicken.App_Start;
using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.Thu
{
    public partial class DuyetThu : System.Web.UI.Page
    {
        XuLy xuly = new XuLy();
        String totalLeffter;
        String pag;
        int p, offset;

        public string Pag { get => pag; set => pag = value; }
        public int P { get => p; set => p = value; }
        public int Offset { get => offset; set => offset = value; }
        public string TotalLeffter { get => totalLeffter; set => totalLeffter = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["p"] == null)
            {
                p = 0;
            }
            else
            {
                p = Int32.Parse(Request.QueryString["p"].ToString().Trim()) - 1;
            }

            Offset = p * 10;
            if (!IsPostBack)
            {
                if (Request.QueryString["n"] != null)
                {
                    loadData(Offset, Request.QueryString["n"].ToString());
                    pagination(Request.QueryString["n"].ToString());
                }
                else
                {
                    loadData(Offset, "");
                    pagination("");
                }
                totalLeffter = xuly.count("SELECT COUNT(*) FROM LETTERS").ToString();
            }
        }
        private void loadData(int offset, String search)
        {
            
            DataTable dt = xuly.selectThu(offset,search);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/thu/duyetthu?n="+txtSearch.Text);
        }

        private void pagination(String n)
        {
            int total = xuly.count("SELECT COUNT(*) FROM LETTERS WHERE TENKHONGDAU LIKE '%'+'" + Fun.convertToUnSign3(n) + "'+'%'");
            float a = total / (float)10;
            double numberPage = Math.Ceiling(a);
            String qrcu = HttpContext.Current.Request.Url.Query.ToString();
            String qrmoi;
            if (qrcu.Contains("?n="))
            {
                if (qrcu.Contains("&")) qrcu = qrcu.Substring(0, qrcu.IndexOf("&"));
                qrmoi = qrcu + "&p=";
            }
            else qrmoi = "?p=";
            for (int i = 0; i < numberPage; i++)
            {
                int num = i + 1;
                String pa;
                if (i == P) pa = "<li class=\"page-item\"><a class=\"page-link\">" + num + "</a></li>";
                else pa = "<li class=\"page-item\"><a class=\"page-link\" href=\"" + qrmoi + num + "\">" + num + "</a></li>";
                Pag += pa;
            }
        }
    }
}