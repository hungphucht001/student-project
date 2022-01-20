using chicken.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace chicken.Admin
{
    public partial class modal : System.Web.UI.UserControl
    {
        Dish_DAL dish = new Dish_DAL();
        private String message;
        public String Message { get { return message; } set { message = value; } }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitSaleItem_Click(object sender, EventArgs e)
        {
            String number = txtNumber.Text;
            String id_products = hidden_ID.Value;
            int kq = dish.sale(number, id_products);
            if (kq > 0) {
                message = "Cập nhật thành công";
                Response.Redirect(Request.RawUrl);
            }
            else message = "Thất bại, thử lại sau";
        }
    }
}