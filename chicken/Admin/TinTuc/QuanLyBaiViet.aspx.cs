using chicken.App_Start;
using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.BaiViet
{
    public partial class QuanLyBaiViet : System.Web.UI.Page
    {
        News news = new News();
        XuLy xuly = new XuLy();
        private DataTable dt;
        private int p;
        private int offset;
        private String pag;
        private String totalNews;
        public String Pag { get { return pag; } }
        public DataTable Dt { get { return dt; } }
        int quyen;
        public int Quyen { get => quyen; set => quyen = value; }
        public string TotalNews { get => totalNews; set => totalNews = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HUAOJATQQ"] != null)
            {
                quyen = Decentralization.quyen(Session["CHUCVU"].ToString());
                if (quyen > 2)
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

            offset = p * 10;

            if (Request.QueryString["n"] != null)
            {
                dt = news.selectNews(offset,Request.QueryString["n"].ToString(),10);
                GridViewTinTuc.DataSource = dt;
                GridViewTinTuc.DataBind();
                pagination(Request.QueryString["n"].ToString());
            }
            else
            {
                dt = news.selectNews(offset,"",10);
                GridViewTinTuc.DataSource = dt;
                GridViewTinTuc.DataBind();
                pagination("");
            }
            for (int i = 0; i < GridViewTinTuc.Rows.Count; i++)
            {
                GridViewTinTuc.Rows[i].Cells[3].Text = DateTime.Parse(GridViewTinTuc.Rows[i].Cells[3].Text).ToString("d");
                GridViewTinTuc.Rows[i].Cells[4].Text = DateTime.Parse(GridViewTinTuc.Rows[i].Cells[4].Text).ToString("d");
            }
            
            totalNews = xuly.count("SELECT COUNT(*) FROM NEWS").ToString();
        }
        private void pagination(String n)
        {
            int total = xuly.count("SELECT COUNT(*) FROM NEWS WHERE TENKHONGDAU LIKE '%'+'" + Fun.convertToUnSign3(n) + "'+'%'");
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
                pag += pa;
            }
        }
        protected void btnTimBaiViet_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/tintuc/quanlybaiviet?n="+txtTimBaiViet.Text);
        }
    }
}