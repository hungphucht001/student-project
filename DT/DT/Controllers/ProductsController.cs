using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DT.Entity;
using DT.Models;
using PagedList;

namespace DT.Controllers
{
    public class ProductsController : Controller
    {
        dbPhoneStoreEntities db = new dbPhoneStoreEntities();
        // GET: Products
        public ActionResult Index(int page = 1)
        {
            string p = null;
            int totalRecord = 0;
            int pageSize = 12;
            int totalPage = 0;

            if (Request.QueryString["p"] != null)
            {
                p = Request.QueryString["p"].ToString();
                ViewBag.listProduct = searchProduct(ref totalRecord, p, page, pageSize);
                ViewBag.p = p;

            }
            else ViewBag.listProduct = getAllProduct(ref totalRecord, page , pageSize);
            
            totalPage = (int)Math.Ceiling((double)(totalRecord / pageSize)) + 1;
            ViewBag.totalPage = totalPage;
            ViewBag.crPage = page;
            return View();
        }
        public ActionResult Phone(int id = -1, int page = 1)
        {
            int totalRecord = 0;
            ViewBag.listProduct = getPhones(ref totalRecord, id, page);

            int totalPage = 0;
            totalPage = (int)Math.Ceiling((double)(totalRecord / 12)) + 1;
            ViewBag.totalPage = totalPage;

            ViewBag.crPage = page;

            return View();
        }
        public ActionResult Accessory(int page = 1)
        {
           
            int totalRecord = 0;
            ViewBag.listProduct = getAccessory(ref totalRecord, page);

            int totalPage = 0;
            totalPage = (int)Math.Ceiling((double)(totalRecord / 12));
            ViewBag.totalPage = totalPage;
            return View();

        }
        public List<tb_SanPham> getPhones(ref int totalRecord, int idThgHieu, int page = 1, int pageSize = 12)
        {
            var model = db.tb_SanPham;
            var md = model.Where(x => x.MaDanhMuc == 1);
            if (idThgHieu != -1)
                md = model.Where(x => x.MaDanhMuc == 1 && x.ThgHieu == idThgHieu);
            totalRecord = md.Count();
            return md.OrderBy(x => x.ID).Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
        public IEnumerable<SanPham_Result> getAllProduct(int page = 1, int pageSize = 12)
        {
            return db.SanPham().OrderBy(x => x.ID).ToPagedList(page, pageSize);
        }

        public List<tb_SanPham> getAllProduct(ref int totalRecord, int page = 1, int pageSize = 12)
        {
            var model = db.tb_SanPham;
            totalRecord = model.Count();
            return model.OrderBy(x => x.ID).Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }
        public IQueryable<TimKiemSanPham_Result> searchProduct(ref int totalRecord, string name, int page = 1, int pageSize = 12)
        {
            var model = db.TimKiemSanPham(name);
            totalRecord = model.Count();
            return model.OrderBy(x => x.ID).Skip((page - 1) * pageSize).Take(pageSize);
        }

        public List<tb_SanPham> getAccessory(ref int totalRecord, int page = 1, int pageSize = 12)
        {
            var model = db.tb_SanPham.Where(x => x.MaDanhMuc == 2);
            totalRecord = model.Count();
            return model.OrderBy(x => x.ID).Skip((page - 1) * pageSize).Take(pageSize).ToList();
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