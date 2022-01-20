using DT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DT.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {

            if (Session["cart"] != null)
            {
                Cart cart = Session["cart"] as Cart;
                ViewBag.cart = cart.Items;
            }
            else ViewBag.cart = new List<CartItem>();
            return View();  
        }
        public void Delete(int id)
        {
            if (Session["cart"] != null)
            {
                Cart cart = Session["cart"] as Cart;
                cart.delete(id);
            }
        }
        public void Reduce(int id)
        {
            if (Session["cart"] != null)
            {
                Cart cart = Session["cart"] as Cart;
                cart.Reduce(id);
                Session["cart"] = cart;
            }
        }
        public void Increase(int id)
        {
            if (Session["cart"] != null)
            {
                Cart cart = Session["cart"] as Cart;
                cart.Increase(id);
                Session["cart"] = cart;
            }
        }
    }
}