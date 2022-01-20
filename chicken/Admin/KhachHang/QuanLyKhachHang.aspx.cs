using chicken.App_Start;
using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.KhachHang
{
    
    public partial class QuanLyKhacHang : System.Web.UI.Page
    {
        XuLy xuly = new XuLy();
        Member mem = new Member();
        String pag, totalCustomer;
        int p, offset;
        int quyen;
        public int Quyen { get => quyen; set => quyen = value; }
        public string Pag { get => pag; set => pag = value; }
        public int P { get => p; set => p = value; }
        public int Offset { get => offset; set => offset = value; }
        public string TotalCustomer { get => totalCustomer; set => totalCustomer = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HUAOJATQQ"] != null)
            {
                quyen = Decentralization.quyen(Session["CHUCVU"].ToString());
                if (quyen > 3)
                {
                    Response.Redirect("/admin"); return;
                }
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
                    loadData(Offset, Request.QueryString["n"].ToString());
                    pagination(Request.QueryString["n"].ToString());
                }
                else
                {
                    loadData(Offset, "");
                    pagination("");
                }

                totalCustomer = xuly.count("SELECT COUNT(*) FROM CUSTOMER").ToString();
            }

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/khachhang/quanlykhachhang?n="+txtSearch.Text);
        }

        private void loadData(int offset, String search)
        {

            GridView1.DataSource = mem.selectCustomer(offset,search);
            GridView1.DataBind();

            for(int i=0; i< GridView1.Rows.Count; i++)
            {
                GridView1.Rows[i].Cells[3].Text = DateTime.Parse(GridView1.Rows[i].Cells[3].Text).ToString("d");
            }
        }
        private void pagination(String n)
        {
            int total = xuly.count("SELECT COUNT(*) FROM CUSTOMER C, USERS U WHERE C.ID_USER = U.ID_USER AND TENKHONGDAU LIKE '%'+'" + Fun.convertToUnSign3(n) + "'+'%'");
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