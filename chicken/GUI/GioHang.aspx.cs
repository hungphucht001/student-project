using chicken.App_Start;
using chicken.GUI.modelGioHang;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.GUI
{
    public partial class GioHang : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        Cart cart;
        List<CartItem> items;
        private double total;

        public double Total { get => total; set => total = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["cart"] == null)
            {
                cart = new Cart();
            }
            else
            {
                cart = (Cart)Session["cart"];
            }
            if (!IsPostBack) 
            {
                loadData();
                totalAll();
            }
            if(Request.QueryString["id"] != null)
            {
                delete(Request.QueryString["id"].ToString());
                Response.Redirect("/gio-hang");
                Session["cart"] = cart;
            }
            if(cart.Items.Count == 0)
            {
                
                linkThanhToan.Visible = false;
                Panel1.Visible = false;
                Panel2.Visible = false;
            }
        }
        private void loadData()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("NAME");
            dt.Columns.Add("IMAGE");
            dt.Columns.Add("PRICE");
            dt.Columns.Add("QUANTITY");
            dt.Columns.Add("TOTAL");

            items = cart.Items;
            foreach (CartItem item in items)
            {
                dt.Rows.Add(item.Id, item.Name, item.Image, Fun.fromatMoney(item.Price), item.Quantity, Fun.fromatMoney(item.totalPrice().ToString()));
            }
            ListView1.DataSource = dt;
            ListView1.DataBind();
        }
        private void totalAll()
        {
            double total = 0;
            int num = 0;
            foreach (CartItem item in items)
            {
                num++;
                total += item.totalPrice();
            }

            lbTotal.Text = lbTotal2.Text = Fun.fromatMoney(total.ToString());
            lbTotalNum.Text = lbTotalNum2.Text ="Tổng " +num+" món";
        }
        private void delete(String id)
        {
            cart.delete(id);
        }
        protected void btnUpdateCart_Click(object sender, EventArgs e)
        {
            items = cart.Items;
            if (items.Count > 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    int quantity = int.Parse(((HiddenField)ListView1.Controls[i].FindControl("HiddenFieldQuantity")).Value);
                    String id = ((HiddenField)ListView1.Controls[i].FindControl("HiddenFieldID")).Value;
                    cart.update(id, quantity);
                    Session["cart"] = cart;
                }
                loadData();
                totalAll();
                if (cart.Items.Count == 0)
                {

                    linkThanhToan.Visible = false;
                    Panel1.Visible = false;
                    Panel2.Visible = false;
                }
            }
        }
    }
}