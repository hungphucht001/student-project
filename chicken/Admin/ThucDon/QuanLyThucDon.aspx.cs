using chicken.App_Start;
using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.ThucDon
{
    public partial class QuanLyThucDon : System.Web.UI.Page
    {
        Dish_DAL dish = new Dish_DAL();
        XuLy xuly = new XuLy();
        private DataTable dt;
        private int p;
        private int offset;
        private String soLuongMonAn;
        private String pag;
        private String titleTK, slTK;
        public String Pag { get { return pag; } }
        public DataTable Dt { get { return dt; } }
        int quyen;

        public int Quyen { get => quyen; set => quyen = value; }
        public String SoLuongMonAn { get { return soLuongMonAn; } set { soLuongMonAn = value; } }

        public string TitleTK { get => titleTK; set => titleTK = value; }
        public string SlTK { get => slTK; set => slTK = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HUAOJATQQ"] != null)
            {
                quyen = Decentralization.quyen(Session["CHUCVU"].ToString());
                if (quyen != 1)
                {
                    Response.Redirect("/admin");return;
                }
            }
            demSoLuongMonAn(); thongkeThucDonDcMua();
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
                dt = dish.selectMenu(Request.QueryString["n"].ToString(), offset);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                pagination(Request.QueryString["n"].ToString());
            }    
            else
            {
                dt = dish.selectMenu("", offset);
                GridView1.DataSource = dt;
                GridView1.DataBind();
                pagination("");
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int sale = Int32.Parse(txtSale.Text);
            if(dish.saleAll(sale) > 0)
            {
                Response.Redirect("/admin/thucdon/quanlythucdon");
            }
        }
        private void pagination(String n)
        {
            int total = dish.countMenu(n);
            float a = total / (float)10;
            double numberPage = Math.Ceiling(a);
            String qrcu = HttpContext.Current.Request.Url.Query.ToString();
            String qrmoi;
            if (qrcu.Contains("?n="))
            {
                if (qrcu.Contains("&"))
                {
                    qrcu = qrcu.Substring(0, qrcu.IndexOf("&"));
                }
                qrmoi = qrcu + "&p=";
            }
            else
            {
                qrmoi = "?p=";
            }

            for (int i = 0; i < numberPage; i++)
            {
                int num = i + 1;
                String pa;
                if (i == p) pa = "<li class=\"page-item\"><a class=\"page-link\">" + num + "</a></li>";
                else pa = "<li class=\"page-item\"><a class=\"page-link\" href=\""+ qrmoi + num + "\">" + num + "</a></li>";
                pag += pa;
            }
        }

        protected void btnTimMonAn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/thucdon/quanlythucdon?n=" + txtTimMonAn.Text);
        }
        protected void btnSubmitSaleItem_Click(object sender, EventArgs e)
        {
            String number = txtNumber.Text;
            String id_products = hidden_ID.Value.ToString();
            int kq = dish.sale(number, id_products);
            if (kq > 0)
            {
                Response.Redirect(Request.RawUrl);
            }
        }
        private void demSoLuongMonAn()
        {
            String sql = string.Format("SELECT COUNT(*) FROM PRODUCTS");
            soLuongMonAn = xuly.count(sql).ToString();
        }
        private void thongkeThucDonDcMua()
        {
            String sql = "SELECT TOP 10 COUNT(*) SL,TENSP FROM PRODUCTS p, ORDERS O, ORDER_DETAILS OD WHERE O.ID_ORDER = OD.ID_ORDER AND OD.ID_PRODUCT = P.ID_PRODUCTS GROUP BY ID_PRODUCT,TENSP order by COUNT(*) desc";
            DataTable dttk = xuly.select(sql);
            int i = 0;
            slTK = "";
            titleTK = "";
            foreach (DataRow r in dttk.Rows)
            {
                if (i > 0)
                {
                    slTK += ",";
                    titleTK += "_";
                }
                slTK += r["SL"].ToString();
                titleTK += r["TENSP"].ToString();
                i++;
            }
            titleTK = "'" + titleTK.Replace("_", "','") + "'";
        }
        
    }
}