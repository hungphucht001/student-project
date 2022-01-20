using chicken.App_Start;
using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.DonHang
{
    public partial class ThemDonHang : System.Web.UI.Page
    {
        XuLy xuly = new XuLy();
        Dish_DAL dish = new Dish_DAL();
        String total;
        int offset;
        String pag; int p;
        public string Pag { get => pag; set => pag = value; }
        public int P { get => p; set => p = value; }
        public int Offset { get => offset; set => offset = value; }
        public string Total { get => total; set => total = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["duyet_id"] != null)
            {
                duyetDon(Request.QueryString["duyet_id"].ToString());
            }
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
                    displayData(Offset, Request.QueryString["n"].ToString());
                    pagination(Request.QueryString["n"].ToString());
                }
                else
                {
                    displayData(Offset, "");
                    pagination("");
                }
                total = xuly.count("SELECT COUNT(*) FROM ORDERS WHERE STATUS = 0").ToString();
                lbTotal.Text = total;
            }
        }
        public void displayData(int offset, String search)
        {
            DataTable dt = xuly.selectDonHangDuyet(offset,search,0);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                GridView1.Rows[i].Cells[5].Text = Fun.fromatMoney(GridView1.Rows[i].Cells[5].Text);
                String status = GridView1.Rows[i].Cells[6].Text.ToString();
                String kt = "";
                if (status.Equals("0")) kt = "<span class=\"badge badge-danger\">Chờ xét duyệt</span>";
                else if (status.Equals("1")) kt = "<span class=\"badge badge-warning\">Đang làm</span>";
                else if (status.Equals("2")) kt = "<span class=\"badge badge-info\">Đang giao</span>";
                else if (status.Equals("3")) kt = "<span class=\"badge badge-success\">Giao thành công</span>";
                GridView1.Rows[i].Cells[6].Text = kt;
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/donhang/duyetdonhang?n="+txtSearch.Text);
        }
        private void pagination(String n)
        {
            int total = xuly.count("SELECT COUNT(*) FROM ORDERS WHERE STATUS = 0 AND TENKHONGDAU LIKE '%'+'" + Fun.convertToUnSign3(n) + "'+'%'");
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
                if (i == p) pa = "<li class=\"page-item\"><a class=\"page-link\">" + num + "</a></li>";
                else pa = "<li class=\"page-item\"><a class=\"page-link\" href=\"" + qrmoi + num + "\">" + num + "</a></li>";
                Pag += pa;
            }
        }
        private int duyetDon(String id_duyet)
        {
            String sql = "UPDATE ORDERS SET ID_MEMBER = "+ Session["ID_AD"].ToString()+",STATUS = 1 WHERE ID_ORDER = '"+ id_duyet+"'";
            return xuly.insert(sql);
        }
    }
}