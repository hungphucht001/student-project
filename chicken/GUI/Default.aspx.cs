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
    public partial class Default : System.Web.UI.Page
    {
        private String categorys = "";
        private String menu = "";
        XuLy xuly = new XuLy();
        Dish_DAL dish = new Dish_DAL();
        public String Categorys { get { return categorys; } set { categorys = value; } }
        public String Menu { get { return menu; } set { menu = value; } }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ranDishTop3();
            loadCategorys();

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (revEmail.IsValid)
            {
                Label1.Text = "Đăng ký thành công";
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
                    String tab = "<div class= \"tab-item\"><div class= \"row justify-content-center\">";
                    String cl = "</div></div>";
                    menu += tab + loadMenuByCategory(id) + cl;
                }
            }
        }
        private string loadMenuByCategory(int id_category)
        {
            String listTab = "";
            DataTable dt = xuly.select("SELECT TOP 8 * FROM PRODUCTS where ID_CATEGORY ="+id_category);
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

                    String col = "<div class=\"col-lg-3 col-md-3\" data-aos = \"zoom -in\" data-aos-duration = \"1000\"><div class= \"item-food\">";
                    String image = "<div class= \"single-image\"><img src = \""+ r["AVATAR"] +"\" alt = \"\"></div>";
                    String content = "<div class= \"content\"><div class= \"title\"><a href=\"/san-pham/" + r["TENKHONGGIAU"] + "/" + r["ID_PRODUCTS"] + "\"><h5>" + r["TENSP"] + "</h5></a></div><div class= \"describe\"><p>" + r["MOTA"] + "</p></div>";
                    String spice = " <div class= \"spice\"><span>" + priceSale + "</span></div></div></div></div>";
                    listTab +=  col + image + content + spice;
                }
            }
            return listTab;
        }
        private void ranDishTop3()
        {
            String sql = "SELECT TOP 3* FROM PRODUCTS WHERE ID_CATEGORY = 6 OR ID_CATEGORY = 7 OR ID_CATEGORY = 8   ORDER BY newid()";
            DataTable dtRandDish = xuly.select(sql);
            RepRandDish.DataSource = dtRandDish;
            RepRandDish.DataBind();
        }
    }
}
