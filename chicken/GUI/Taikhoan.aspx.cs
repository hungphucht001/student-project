using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.GUI
{
    public partial class Taikhoan : System.Web.UI.Page
    {
        XuLy xuly = new XuLy();
        String message;

        public string Message { get => message; set => message = value; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(RouteData.Values["pr"] != null)
            {
                String pr = RouteData.Values["pr"].ToString();

                if (pr.Equals("a"))
                {
                    pnContent.Controls.Add(LoadControl("/controls/taikhoan.ascx"));
                }
                else if (pr.Equals("b"))
                {
                    pnContent.Controls.Add(LoadControl("/controls/DonHangDangDat.ascx"));
                }
                else
                {
                    int n = xuly.count("SELECT COUNT(*) FROM ORDERS WHERE ID_ORDER = '" + pr + "' AND STATUS = 0");
                    if (n > 0)
                    {
                        message = "Hủy thành công";
                        huyDonHang(pr);
                        Response.Redirect("/tai-khoan/b");
                    }
                    else message = "Hủy Thất bại. Đơn hàng đang tiến hành làm";
                }
            }
        }
        private void huyDonHang(String id)
        {
            int n = xuly.delete("DELETE ORDERS WHERE ID_ORDER = '" + id + "'");
        }

    }
}