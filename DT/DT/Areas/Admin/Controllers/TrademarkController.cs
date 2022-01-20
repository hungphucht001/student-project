using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DT.Entity;

namespace DT.Areas.Admin.Controllers
{
    [HasCredentia(ID_ChucVu = 1)]
    public class TrademarkController : BaseController
    {
        private dbPhoneStoreEntities db = new dbPhoneStoreEntities();

        // GET: Admin/Trademark
        public ActionResult Index()
        {
            var tb_NCC_ThgHieu = db.tb_NCC_ThgHieu.Include(t => t.tb_ThuongHieu).Include(t => t.tb_NhaCungCap);
            return View(tb_NCC_ThgHieu.ToList());
        }

        // GET: Admin/Trademark/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_NCC_ThgHieu tb_NCC_ThgHieu = db.tb_NCC_ThgHieu.Find(id);
            if (tb_NCC_ThgHieu == null)
            {
                return HttpNotFound();
            }
            return View(tb_NCC_ThgHieu);
        }

        // GET: Admin/Trademark/Create
        public ActionResult Create()
        {
            ViewBag.MaNCC = new SelectList(db.tb_NhaCungCap, "MaNCC", "TenNCC");
            return View();
        }

        // POST: Admin/Trademark/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tb_NCC_ThgHieu tb_NCC_ThgHieu)
        {
            if (ModelState.IsValid)
            {
                tb_NCC_ThgHieu.tb_ThuongHieu.DaXoa = false;
                db.tb_ThuongHieu.Add(tb_NCC_ThgHieu.tb_ThuongHieu);

                tb_NCC_ThgHieu.MaThgHieu = tb_NCC_ThgHieu.tb_ThuongHieu.MaThgHieu;

                db.tb_NCC_ThgHieu.Add(tb_NCC_ThgHieu);

                db.SaveChanges();
                SetAlert("Thêm thương hiệu thành công", "success");
                return RedirectToAction("Index");
            }
            ViewBag.MaNCC = new SelectList(db.tb_NhaCungCap, "MaNCC", "TenNCC", tb_NCC_ThgHieu.MaNCC);
            return View(tb_NCC_ThgHieu);
        }

        // GET: Admin/Trademark/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_NCC_ThgHieu tb_NCC_ThgHieu = db.tb_NCC_ThgHieu.Find(id);
            if (tb_NCC_ThgHieu == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNCC = new SelectList(db.tb_NhaCungCap, "MaNCC", "TenNCC", tb_NCC_ThgHieu.MaNCC);
            return View(tb_NCC_ThgHieu);
        }

        // POST: Admin/Trademark/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tb_NCC_ThgHieu tb_NCC_ThgHieu)
        {
            if (ModelState.IsValid)
            {
                tb_NCC_ThgHieu.tb_ThuongHieu.MaThgHieu = tb_NCC_ThgHieu.MaThgHieu;
                db.Entry(tb_NCC_ThgHieu.tb_ThuongHieu).State = EntityState.Modified;
                db.Entry(tb_NCC_ThgHieu).State = EntityState.Modified;
                db.SaveChanges();
                SetAlert("Cập nhật thành công", "success");
                return RedirectToAction("Index");
            }
            ViewBag.MaNCC = new SelectList(db.tb_NhaCungCap, "MaNCC", "TenNCC", tb_NCC_ThgHieu.MaNCC);
            return View(tb_NCC_ThgHieu);
        }

        public void Delete(int id)
        {
            tb_NCC_ThgHieu tb_NCC_ThgHieu = db.tb_NCC_ThgHieu.Find(id);
            tb_NCC_ThgHieu.tb_ThuongHieu.DaXoa = true;
            db.Entry(tb_NCC_ThgHieu.tb_ThuongHieu).State = EntityState.Modified;
            db.SaveChanges();
        }
        public ActionResult Deleted()
        {
            var tb_NCC_ThgHieu = db.tb_NCC_ThgHieu.Where(t=>t.tb_ThuongHieu.DaXoa == true).Include(t => t.tb_ThuongHieu).Include(t => t.tb_NhaCungCap);
            return View(tb_NCC_ThgHieu.ToList());
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
