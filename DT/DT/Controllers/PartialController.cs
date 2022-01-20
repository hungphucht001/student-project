using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DT.Entity;

namespace DT.Controllers
{
    public class PartialController : Controller
    {
        dbPhoneStoreEntities db = new dbPhoneStoreEntities();
        // GET: Partial
        public ActionResult ThuongHieu()
        {
            return PartialView(db.tb_ThuongHieu);
        }
        public ActionResult ThuongHieuSideBar()
        {
            return PartialView(db.tb_ThuongHieu);
        }
        public ActionResult ThuongHieuMenu()
        {
            return PartialView(db.tb_ThuongHieu);
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