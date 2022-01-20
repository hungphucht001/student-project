using chicken.GUI.modelGioHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken
{
    public partial class Site : System.Web.UI.MasterPage
    {
        private int num;

        public int Num { get => num; set => num = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] != null)
            {
                Cart cart = (Cart)Session["cart"];
                lbNumCart.Text = cart.Items.Count().ToString();
                lbNumCart.Visible = true;
            }
            else
            {
                num = 0;
                lbNumCart.Visible = false;
            }
        }

    }
}