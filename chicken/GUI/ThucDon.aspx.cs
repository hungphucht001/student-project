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
    public partial class ThucDon : System.Web.UI.Page
    {
        private String menu = "";
        private String categorys = "";
        private String menuBySearch, search;
        Dish_DAL dish = new Dish_DAL();
        XuLy xuly = new XuLy();
        public String Categorys { get { return categorys; } set { categorys = value; } }
        public String Menu { get { return menu; } set { menu = value; } }

        public string MenuBySearch { get => MenuBySearch1; set => MenuBySearch1 = value; }
        public string MenuBySearch1 { get => menuBySearch; set => menuBySearch = value; }
        public string Search { get => search; set => search = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            loadCategorys();
            if (Request.QueryString["search"] == null)
            {
                pnMenu.Visible = true;
                pnSearch.Visible = false;
            }
            else
            {
                search = Request.QueryString["search"].ToString();
                pnMenu.Visible = false;
                pnSearch.Visible = true;
                DataTable dt = xuly.select("SELECT * FROM PRODUCTS where TENKHONGGIAU LIKE '%'+'" + Fun.convertToUnSign3(search) + "'+'%'");
                MenuBySearch = loadMenuByCategory(dt);
            }
        }
        private void loadCategorys()
        {
            DataTable ds = xuly.select("SELECT * FROM CATEGORYS");

            if (ds == null)
            {
                categorys = "err";
            }
            else
            {
                foreach (DataRow r in ds.Rows)
                {
                    String cate = "<li class=\"special-item\"><span>" + r["TEN_CATEGORY"] + "</span></li>";

                    categorys += cate;
                    int id = (int)r[0];
                    String tab = "<div class= \"tab-item mt-5\"><div class= \"foods\"><div class=\"row\">";
                    String cl = "</div></div></div>";
                    DataTable dt = xuly.select("SELECT TOP 8 * FROM PRODUCTS where ID_CATEGORY =" + id);
                    menu += tab + loadMenuByCategory(dt) + cl;
                }
            }
        }
        private string loadMenuByCategory( DataTable dt)
        {
            String listTab = "";
            
            if (dt == null)
            {
                listTab = "err";
            }
            else
            {
                foreach (DataRow r in dt.Rows)
                {
                    int sale = int.Parse(r["SALE"].ToString());
                    float price = float.Parse(r["Gia"].ToString());
                    String priceSale = null;
                    String a = "";
                    if (sale > 0)
                    {
                        a = Fun.fromatMoney(price.ToString()) + "</span><span> - </span>";
                        priceSale = Fun.fromatMoney((price - ((float)sale / 100) * price).ToString()); 
                        
                    }
                    else
                    {
                        a = "</span>";
                        priceSale = Fun.fromatMoney(price.ToString());
                    }

                    String html1 = "<div class= \"col-lg-4 col-md-6\"><div class= \"item-food\">";
                    String html2 = "<div class=\"single-image\"><a href = \"/san-pham/" + r["TENKHONGGIAU"] + "/" + r["ID_PRODUCTS"] + "\"><img src = \"" + r["AVATAR"] + "\" alt = \"" + r["AVATAR"] + "\" ></a><div class= \"price\">";
                    String html3 = "<span style=\"text-decoration:line-through;color: #e3e3e3;\" >" + a + "<span>" + priceSale + "</span></div>";
                    String html4 = "";
                    String html5 = "";
                    if (sale > 0)
                    {
                        html4 = "<div class= \"sale\"><svg width = 70 viewBox = \"0 0 100 80\"><defs><style>.cls-1 {font-size: 72px;fill: #fefefe;font-family: \"Buxton Sketch\";}</style></defs><image y = \"1\" width = \"99\" height = \"79\" xlink: href = \"./Content/assets/imgs/sale-img.png\"/>";
                        html5 = "<text id = \"_50_\" data-name = \"50%\" class= \"cls-1\" transform = \"translate(26.444 55.814) scale(0.418 0.418)\">" + sale + "%</text></svg></div>";
                    }
                    String html6 = "</div><div class= \"article\"><h4 class= \"title\"><a href = \"/san-pham/" + r["TENKHONGGIAU"] + "/" + r["ID_PRODUCTS"] + "\">" + r["TENSP"] + "</a></h4>";
                    String html7 = "<p class=\"introduction\">" + r["MOTA"] + "</p><h5 class= \"order\" ><a href = \"/san-pham/" + r["TENKHONGGIAU"] + "/" + r["ID_PRODUCTS"] + "\"> Đặt hàng </a></h5>";
                    String html8 = "</div></div></div>";
                    listTab += html1 + html2 + html3 + html4 + html5 + html6 + html7 + html8;
                }
            }
            return listTab;
        }
    }
}


    






