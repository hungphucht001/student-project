using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin
{
    public partial class Dashboard : System.Web.UI.Page
    {
        private String slKhachHang, slThucDon, slThanhVien, slDonHang;
        private String thang, slThang;
        XuLy xuly = new XuLy();
        DataTable dt;
        private String number;
        private String titleTK;
        public string SlThanhVien { get => slThanhVien; set => slThanhVien = value; }
        public string SlKhachHang { get => slKhachHang; set => slKhachHang = value; }
        public string SlThucDon { get => slThucDon; set => slThucDon = value; }
        public string SlDonHang { get => slDonHang; set => slDonHang = value; }
        public string Thang { get => thang; set => thang = value; }
        public string SlThang { get => slThang; set => slThang = value; }
        public string Number { get => number; set => number = value; }
        public string TitleTK { get => titleTK; set => titleTK = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            demSl();
            thongkeDonHang();
            thongKeNhanVien();
        }
        private void demSl()
        {
            String sqlThanhVien = "SELECT COUNT(*) FROM MEMBERS";
            String sqlThucDon = "SELECT COUNT(*) FROM PRODUCTS";
            String sqlKhachHang = "SELECT COUNT(*) FROM CUSTOMER";
            String sqlDonHang = "SELECT COUNT(*) FROM ORDERS";

            slThanhVien = xuly.count(sqlThanhVien).ToString();
            slThucDon = xuly.count(sqlThucDon).ToString();
            slKhachHang = xuly.count(sqlKhachHang).ToString();
            slDonHang = xuly.count(sqlDonHang).ToString();
        }
        private void thongkeDonHang()
        {
            String sql = "SELECT TOP 6 COUNT(*) AS SL, MONTH(NGAYMUA) AS THANG FROM ORDERS GROUP BY MONTH(NGAYMUA)";
            dt = xuly.select(sql);
            int i = 0;
            slThang = "";
            thang = "";
            foreach (DataRow r in dt.Rows)
            {
                if (i > 0)
                {
                    slThang += ",";
                    thang += "_";
                }
                slThang += r["SL"].ToString();
                thang += "Tháng "+r["THANG"].ToString();
                i++;
            }
            thang = "'" + thang.Replace("_", "','") + "'";
        }
        public void thongKeNhanVien()
        {
            String sql = "select COUNT(*) AS SL, CHUCVU from MEMBERS group by CHUCVU";
            DataTable dt = xuly.select(sql);
            int i = 0;
            Number = "";
            TitleTK = "";
            foreach (DataRow r in dt.Rows)
            {
                if (i > 0)
                {
                    Number += ",";
                    TitleTK += "_";
                }
                Number += r["SL"].ToString();
                TitleTK += r["CHUCVU"].ToString();
                i++;
            }
            TitleTK = "'" + TitleTK.Replace("_", "','") + "'";
        }
    }
}