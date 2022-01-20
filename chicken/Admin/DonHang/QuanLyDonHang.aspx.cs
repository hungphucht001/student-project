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
    public partial class QuanLyDonHang : System.Web.UI.Page
    {
        XuLy xuly = new XuLy();
        String total;
        int offset;
        DataTable dt;
        String pag; int p;
        public string Pag { get => pag; set => pag = value; }
        public int P { get => p; set => p = value; }
        public int Offset { get => offset; set => offset = value; }
        public string Total { get => total; set => total = value; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["dpending_id"] != null)
            {
                duyetDon(Request.QueryString["dpending_id"].ToString(), 1);
            }
            if (Request.QueryString["ddonging_id"] != null)
            {
                duyetDon(Request.QueryString["ddonging_id"].ToString(),2);
            }
            if (Request.QueryString["dtransported_id"] != null)
            {
                duyetDon(Request.QueryString["dtransported_id"].ToString(), 3);
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
                    displayData(Offset, Request.QueryString["n"].ToString(),-1,GridViewTotal,5,6);
                    pagination(Request.QueryString["n"].ToString());
                }
                else
                {
                    displayData(Offset, "",-1, GridViewTotal,5,6);
                    pagination("");
                }
                displayData(0, "", 0, GridViewPending, 5, 6);
                displayData(Offset, "", 1, GridViewDoing, 5, 6);
                displayData(Offset, "", 2, GridViewTransported, 5,6);
                total = xuly.count("SELECT COUNT(*) FROM ORDERS").ToString();
                lbTotal.Text = total;
            }

            
        }
        public void displayData(int offset, String search,int status, GridView gv, int colGia, int colStatus)
        {
            DataTable dt = status == -1? xuly.selectDonHang(offset, search): xuly.selectDonHangDuyet(offset, search,status);
            gv.DataSource = dt;
            gv.DataBind();
            trangThai(gv,colGia,colStatus);
        }
        private void trangThai(GridView gv, int colGia, int colStatus)
        {
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                if (colGia != -1)
                    gv.Rows[i].Cells[colGia].Text = Fun.fromatMoney(gv.Rows[i].Cells[colGia].Text);
                String status = gv.Rows[i].Cells[colStatus].Text.ToString();
                String kt = "";
                if (status.Equals("0")) kt = "<span class=\"badge badge-danger\">Chờ xét duyệt</span>";
                else if (status.Equals("1")) kt = "<span class=\"badge badge-warning\">Đang làm</span>";
                else if (status.Equals("2")) kt = "<span class=\"badge badge-info\">Đang giao</span>";
                else if (status.Equals("3")) kt = "<span class=\"badge badge-success\">Giao thành công</span>";
                gv.Rows[i].Cells[colStatus].Text = kt;
            }
        }
        private void pagination(String n)
        {
            int total = xuly.count("SELECT COUNT(*) FROM ORDERS WHERE TENKHONGDAU LIKE '%'+'" + Fun.convertToUnSign3(n) + "'+'%'");
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/donhang/quanlydonhang?n="+txtSearch.Text);
        }
        private int duyetDon(String id_duyet,int status)
        {
            String sql = "UPDATE ORDERS SET STATUS = "+status+" WHERE ID_ORDER = '" + id_duyet + "'";
            return xuly.insert(sql);
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            displayData(0, "", 0, GridViewPending, 5, 6);
        }
    }
}