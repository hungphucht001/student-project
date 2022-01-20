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
    public partial class ThongKeDonHang : System.Web.UI.Page
    {
        int quyen;
        string titleTK, slTK;
        string titleTK2, slTK2;
        public int Quyen { get => quyen; set => quyen = value; }
        public string TitleTK { get => titleTK; set => titleTK = value; }
        public string SlTK { get => slTK; set => slTK = value; }
        public string TitleTK2 { get => titleTK2; set => titleTK2 = value; }
        public string SlTK2 { get => slTK2; set => slTK2 = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HUAOJATQQ"] != null)
            {
                quyen = Decentralization.quyen(Session["CHUCVU"].ToString());
                if (quyen != 1)
                {
                    Response.Redirect("/admin"); return;
                }
                if (!IsPostBack)
                {
                    thongkeThucDonDcMua();
                    thongkeDHTrongNam();
                }
            }
        }
        private void thongkeThucDonDcMua()
        {
            String sql = "SELECT TOP 10 COUNT(*) SL,TENSP FROM PRODUCTS p, ORDERS O, ORDER_DETAILS OD WHERE O.ID_ORDER = OD.ID_ORDER AND OD.ID_PRODUCT = P.ID_PRODUCTS GROUP BY ID_PRODUCT,TENSP order by COUNT(*) desc";
            DataTable dttk = new XuLy().select(sql);
            int i = 0;
            SlTK = "";
            TitleTK = "";
            foreach (DataRow r in dttk.Rows)
            {
                if (i > 0)
                {
                    SlTK += ",";
                    TitleTK += "_";
                }
                SlTK += r["SL"].ToString();
                TitleTK += r["TENSP"].ToString();
                i++;
            }
            TitleTK = "'" + TitleTK.Replace("_", "','") + "'";
        }
        private void thongkeDHTrongNam()
        {
            String sql = "SELECT TOP 12 COUNT(*) SL, MONTH(NGAYMUA) THANG FROM PRODUCTS p, ORDERS O, ORDER_DETAILS OD WHERE O.ID_ORDER = OD.ID_ORDER AND OD.ID_PRODUCT = P.ID_PRODUCTS AND YEAR(NGAYMUA) = YEAR(GETDATE()) GROUP BY MONTh(NGAYMUA) ORDER BY MONTH(NGAYMUA) ASC";
            DataTable dttk = new XuLy().select(sql);
            int i = 0;
            slTK2 = "";
            titleTK2 = "";
            foreach (DataRow r in dttk.Rows)
            {
                if (i > 0)
                {
                    slTK2 += ",";
                    titleTK2 += "_";
                }
                slTK2 += r["SL"].ToString();
                titleTK2 += "Tháng " + r["THANG"].ToString();
                i++;
            }
            titleTK2 = "'" + titleTK2.Replace("_", "','") + "'";
        }
    }
}