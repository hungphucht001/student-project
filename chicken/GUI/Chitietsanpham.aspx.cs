using chicken.App_Start;
using chicken.DAL;
using chicken.GUI.modelGioHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken
{
    public partial class Chitietsanpham : System.Web.UI.Page
    {
        Dish_DAL dish = new Dish_DAL();
        DataTable dt = null;
        DataTable dtMenuByCategory = null;
        private String id, name, image, price;
        private int quantity;
        public DataTable Dt { get { return dt; } }
        public DataTable DtMenuByCategory { get { return dtMenuByCategory; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (RouteData.Values["Id"] == null)
                {
                    Response.Redirect("/");
                }
                else
                {
                    int id_product = Int32.Parse(RouteData.Values["id"].ToString());
                    dt = dish.selectDish(id_product);
                    Page.Title = dt.Rows[0]["TENSP"].ToString() + " - Chicken";
                    ListView1.DataSource = dt;
                    ListView1.DataBind();
                }
                dtMenuByCategory = dish.selectMenuByCategory(int.Parse(dt.Rows[0]["ID_CATEGORY"].ToString()));
                RepeaterMenuByCategory.DataSource = dtMenuByCategory;
                RepeaterMenuByCategory.DataBind();
                int i = 0;
                foreach (DataRow r in dtMenuByCategory.Rows)
                {
                    int sale = (int)(r["SALE"]);

                    float price = float.Parse(r["GIA"].ToString());
                    if (r["SALE"].ToString().Equals("0") == true)
                    {
                        ((Panel)RepeaterMenuByCategory.Controls[i].FindControl("pnSale")).Visible = false;
                    }
                    else 
                    {
                        ((Label)RepeaterMenuByCategory.Controls[i].FindControl("lbPrice")).Text = Fun.fromatMoney(price.ToString());
                    }
                     ((Label)RepeaterMenuByCategory.Controls[i].FindControl("lbSale")).Text = (sale == 0 ? "" : " - ") + Fun.fromatMoney((price - ((float)sale / 100) * price).ToString());
                    i++;
                }
                int j = 0;
                foreach (DataRow r in dt.Rows)
                {
                    int sale = (int)(r["SALE"]);

                    float price =float.Parse(r["GIA"].ToString());
                    
                    if (sale == 0)
                    {
                        ((Label)ListView1.Controls[j].FindControl("lbPrice")).Visible = false;
                    }
                    ((Label)ListView1.Controls[j].FindControl("lbPrice")).Text = Fun.fromatMoney(price.ToString());
                    ((Label)ListView1.Controls[j].FindControl("lbSale")).Text = Fun.fromatMoney((price - ((float)sale / 100) * price).ToString());
                    j++;
                }
            }
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            string strPath = HttpContext.Current.Request.Url.AbsolutePath.ToString();
            Cart cart;
            if (Session["cart"] != null)
            {
                cart = (Cart)Session["cart"];
            }
            else
            {
                cart = new Cart();
                Session["cart"] = cart;
            }
            name = ((Label)ListView1.Controls[0].FindControl("lbName")).Text;
            id = RouteData.Values["id"].ToString();
            image  = ((Image)ListView1.Controls[0].FindControl("imgAvatar")).ImageUrl.ToString();
            price = ((Label)ListView1.Controls[0].FindControl("lbSale")).Text.Replace(".","").Replace(" đ","");
            quantity = int.Parse(((TextBox)ListView1.Controls[0].FindControl("txtQuantity")).Text);

            CartItem item = new CartItem(id,name,image, quantity,price);
            cart.insert(item);
            lbMessage.Text = "<script> showToast('ok', 'hihi', 'success');</script>";
            Response.Redirect(HttpContext.Current.Request.Url.AbsoluteUri.ToString());
            
        }
       
    }
}