using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DT.Entity;

namespace DT.Controllers
{
    public class OrderLookupController : Controller
    {
        dbPhoneStoreEntities db = new dbPhoneStoreEntities();
        // GET: OrderLookup
        public ActionResult Index()
        {
            string sdt = "";

            if (Request.QueryString["sdt"] != null)
            {
                sdt = Request.QueryString["sdt"].ToString();

                ViewBag.Order = db.TimKiemDonHang(sdt);
            }
            
            ViewBag.Sdt = sdt;
            return View();
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