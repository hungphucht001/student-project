using System;
using DT.Entity;
using DT.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DT.Controllers
{
    public class DetailProductController : Controller
    {
        dbPhoneStoreEntities db = new dbPhoneStoreEntities();
        // GET: DetailProduct
        public ActionResult Index(int id)
        {
        
                tb_SanPham sp = db.tb_SanPham.Find(id);
            if (sp == null) return Redirect("/home/Err404");
                ViewBag.product = sp;

            
                ViewBag.listProductsByTrademark = db.tb_SanPham.Where(x => x.ThgHieu == sp.ThgHieu && x.ID != id).OrderBy(x => x.ID).Skip(0).Take(4).ToList();
            return View();
          
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(int quantity, int id_product)
        {
            tb_SanPham sp = db.tb_SanPham.Find(id_product);
           
            if (!KiemTraSL(id_product, quantity))
            {
                
                ViewBag.product = sp;
                ViewBag.listProductsByTrademark = db.tb_SanPham.Where(x => x.ThgHieu == sp.ThgHieu && x.ID != id_product).OrderBy(x => x.ID).Skip(0).Take(4).ToList();

                double pri = (double)(sp.GiaBan - ((sp.GiaBan * sp.Sale) / 100));
                CartItem item = new CartItem(id_product, sp.TenSP, sp.UrlHinh, quantity, pri);

                Cart cart;

                if (Session["cart"] == null) cart = new Cart();
                else cart = Session["cart"] as Cart;

                cart.Insert(item);

                Session["cart"] = cart;

                ViewBag.showModal = true;
                ViewBag.ModalContent = "Thêm vào giỏ hàng thành công";

                return View();
            }
            else
            {
                if (sp == null) return Redirect("/home/Err404");
                ViewBag.product = sp;

                ViewBag.listProductsByTrademark = db.tb_SanPham.Where(x => x.ThgHieu == sp.ThgHieu && x.ID != id_product).OrderBy(x => x.ID).Skip(0).Take(4).ToList();
                
                ViewBag.showModal = true;
                ViewBag.ModalContent = "Số lượng không đủ. Xin vui lòng nhập số lượng bé hơn";

                return View();
            }
        }
        private bool KiemTraSL(int id, int sl)
        {
            var result = db.tb_SanPham.FirstOrDefault(t => t.ID == id && t.SoLuongTon > sl);
            if (result == null) return true;
            else return false;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
