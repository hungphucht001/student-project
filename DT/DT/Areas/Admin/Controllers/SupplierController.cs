using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DT.Entity;
using PagedList;

namespace DT.Areas.Admin.Controllers
{
    [HasCredentia(ID_ChucVu = 1)]
    public class SupplierController : BaseController
    {
        private dbPhoneStoreEntities db = new dbPhoneStoreEntities();

        // GET: Admin/Supplier
        public ActionResult Index(int page = 1, int pageSize = 12)
        {
            var ncc = db.tb_NhaCungCap.Where(t => t.DaXoa == false).OrderByDescending(t => t.MaNCC).ToPagedList(page, pageSize);
            return View(ncc);
        }
        public ActionResult Deleted(int page = 1, int pageSize = 12)
        {
            var ncc = db.tb_NhaCungCap.Where(t => t.DaXoa == true).OrderByDescending(t => t.MaNCC).ToPagedList(page, pageSize);
            return View(ncc);
        }
        // GET: Admin/Supplier/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_NhaCungCap tb_NhaCungCap = db.tb_NhaCungCap.Find(id);
            if (tb_NhaCungCap == null)
            {
                return HttpNotFound();
            }
            return View(tb_NhaCungCap);
        }

        // GET: Admin/Supplier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Supplier/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNCC,TenNCC,DiaChi,Email,SDT,DaXoa")] tb_NhaCungCap tb_NhaCungCap)
        {
            if (ModelState.IsValid)
            {
                db.tb_NhaCungCap.Add(tb_NhaCungCap);
                db.SaveChanges();
                SetAlert("Thêm thành công", "success");
                return RedirectToAction("Index");
            }
            return View(tb_NhaCungCap);
        }

        // GET: Admin/Supplier/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_NhaCungCap tb_NhaCungCap = db.tb_NhaCungCap.Find(id);
            if (tb_NhaCungCap == null)
            {
                return HttpNotFound();
            }
            return View(tb_NhaCungCap);
        }

        // POST: Admin/Supplier/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tb_NhaCungCap tb_NhaCungCap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_NhaCungCap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_NhaCungCap);
        }
       
        public void Delete(int id)
        {
            tb_NhaCungCap tb_NhaCungCap = db.tb_NhaCungCap.Find(id);
            db.tb_NhaCungCap.Remove(tb_NhaCungCap);
            db.SaveChanges();
        }
        public void Cancel(int id)
        {
            tb_NhaCungCap tb_NhaCungCap = db.tb_NhaCungCap.Find(id);
            tb_NhaCungCap.DaXoa = true;
            db.Entry(tb_NhaCungCap).State = EntityState.Modified;
            db.SaveChanges();
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
