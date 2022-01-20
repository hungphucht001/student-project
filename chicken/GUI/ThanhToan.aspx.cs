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

namespace chicken.GUI
{
    public partial class ThanhToan : System.Web.UI.Page
    {
        Cart_DAL cartDAL = new Cart_DAL();
        XuLy xuly = new XuLy();
        String ten, diachi, sdt, ghichu, sql, message;
        double total;

        private List<CartItem> ltMenu;
        public string Ten { get => ten; set => ten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public double Total { get => total; set => total = value; }
        public string Sql { get => sql; set => sql = value; }

        Cart cart;

        public string Message { get => message; set => message = value; }
        public List<CartItem> LtMenu { get => ltMenu; set => ltMenu = value; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                displayData();
                DataTable dt = new DataTable();
                dt.Columns.Add("NAME");
                dt.Columns.Add("PRICE");
                dt.Columns.Add("QUANTITY");
               
                if (Session["cart"] != null)
                {
                    lt();
                    total = 0;
                    foreach (CartItem item in cart.Items)
                    {
                        dt.Rows.Add(item.Name, item.Price, item.Quantity);
                        total += item.totalPrice();
                    }
                    Repeater1.DataSource = dt;
                    Repeater1.DataBind();
                    lbTotal.Text = Fun.fromatMoney(total.ToString());
                }
                else
                {
                    Response.Redirect("/thuc-don");
                }
            }
            Panel2.Visible = false;
        }
        public String fromatMoney(String data)
        {
            return Fun.fromatMoney(data);
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            getData();
            insertCart();
        }
        public void displayData()
        {
            if(Session["name"] != null)
            {
                txtTen.Text = Session["name"].ToString();
                txtSDT.Text = Session["sdt"].ToString();
                txtDiaChi.Text = Session["diachi"].ToString();
            }
        }
        public void lt()
        {
            cart = (Cart)Session["cart"];
            ltMenu = cart.Items;
        }
        public void getData()
        {
            ten = txtTen.Text;
            diachi = txtDiaChi.Text;
            sdt = txtSDT.Text;
            ghichu = txtNote.Text;
        }
        public void insertCart()
        {
            Random ran = new Random();
            String b = "abcdefghijklmnopqrstuvwxyz1234567890ZXCVBNMASDFGHJKLPOIUYTREWQ";
            int length = 12;
            String id_random = "MH_";
            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                id_random = id_random + b.ElementAt(a);
            }
            String id_user = "";
            if(Session["id"] != null)
            {
                id_user = Session["id"].ToString();
            }
            
            lt();
            
            if (cartDAL.insertOrder(id_random, id_user, ten, sdt, diachi, ghichu) > 0)
            {
                foreach (CartItem item in cart.Items)
                {
                    sql = "INSERT INTO ORDER_DETAILS(ID_ORDER, ID_PRODUCT, Gia, SoLuong) VALUES";
                    sql += String.Format("('" + id_random + "',{0},{1},{2})", item.Id, item.Price, item.Quantity);
                    if(xuly.insert(sql) <= 0)
                    {
                        return;
                    }
                }
                message = "Đặt hàng thành công";
                Session["cart"] = null;
                Panel1.Visible = false;
                Panel2.Visible = true;
                Panel2.Controls.Add(LoadControl("/controls/camon.ascx"));
            }
            else message = "Có lỗi xảy ra vui lòng thử lại";
        }
    }
}