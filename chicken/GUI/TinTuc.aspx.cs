using chicken.App_Start;
using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken
{
    public partial class TinTuc : System.Web.UI.Page
    {
        News news = new News();
        XuLy xuly = new XuLy();
        private DataTable dt;
        private DataTable dtRand;
        private String pag ,search, query;
        private int offset,p;
        public String Pag { get { return pag; } }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.QueryString["p"] == null) p = 0;
            else p = Int32.Parse(Request.QueryString["p"].ToString()) - 1;
            query = search = "";
            if (Request.QueryString["search"] != null)
            {
                search = Request.QueryString["search"].ToString();
                query = HttpContext.Current.Request.Url.Query.ToString();
                query = query.Replace("?", "") + "&";
                query = query.IndexOf("p=") >0 ?query.Substring(0, query.IndexOf("p=")): query;
            }
            offset = p * 4;
            dt = news.selectNews(offset, search,4);
            ListViewNews.DataSource = dt;
            ListViewNews.DataBind();

            String sql = "SELECT top 4 * FROM NEWS N, MEMBERS M, USERS U WHERE N.ID_MEMBER = M.ID_MEMBER AND M.ID_USER = U.ID_USER ORDER BY newid()";

            dtRand = xuly.select(sql);
            ListViewRand.DataSource = dtRand;
            ListViewRand.DataBind();
            pagination(search);
        }
        private void pagination(String search)
        {
            int total = xuly.count("SELECT COUNT(*) FROM NEWS WHERE TENKHONGDAU LIKE '%'+'"+Fun.convertToUnSign3(search) +"'+'%'");
            float a = total / (float)4;
            double numberPage = Math.Ceiling(a);
            for(int i = 0; i < numberPage; i++)
            {
                int num = i + 1;
                String pa;
                if (i == p)pa = "<li class=\"page-item\"><a class=\"page-link\">" + num + "</a></li>";
                else pa = "<li class=\"page-item\"><a class=\"page-link\" href=\"?"+ query + "p=" + num + "\">" + num + "</a></li>";
                pag += pa;
            }
        }
    }
}