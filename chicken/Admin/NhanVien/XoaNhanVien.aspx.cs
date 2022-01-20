using chicken.App_Start;
using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin.NhanVien
{
    public partial class XoaNhanVien : System.Web.UI.Page
    {
        XuLy xuly = new XuLy();
        int quyen;

        public int Quyen { get => quyen; set => quyen = value; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["HUAOJATQQ"] != null)
            {
                quyen = Decentralization.quyen(Session["CHUCVU"].ToString());
                if (quyen > 1)
                {
                    Response.Redirect("/admin");return;
                }
                String sql = "DELETE MEMBERS WHERE ID_MEMBER = " + Request.QueryString["id"].ToString();
                if (xuly.delete(sql) > 0)
                {
                    Response.Redirect("/admin/nhanvien/quanlynhanvien"); return;
                }
            }
        }
    
        }
    }
