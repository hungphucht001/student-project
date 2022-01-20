using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DT.Entity.DAO;
using DT.Entity;
using PagedList;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.IO;

namespace DT.Areas.Admin.Controllers
{
    public class ProductsQLController : BaseController
    {

      

        private dbPhoneStoreEntities db = new dbPhoneStoreEntities();
        // GET: Admin/ProductsQL
        public ActionResult Index(int page = 1, int pageSize = 12)
        {
            var model = db.SanPham().OrderByDescending(x => x.ID).ThenBy(x => x.TenTTSP).ToPagedList(page, pageSize);
            return View(model);
        }
        public ActionResult SPNgungKinhDoanh(int page = 1, int pageSize = 12)
        {
            var model = db.SanPham().Where(t=>t.MaTTSP == 1).OrderByDescending(x => x.ID).ThenBy(x => x.TenTTSP).ToPagedList(page, pageSize);
            return View(model);
        }
        public ActionResult SPHetHang(int page = 1, int pageSize = 12)
        {
            var model = db.SanPham().Where(t => t.MaTTSP == 3).OrderByDescending(x => x.ID).ThenBy(x => x.TenTTSP).ToPagedList(page, pageSize);
            return View(model);
        }
        public ActionResult SPConHang(int page = 1, int pageSize = 12)
        {
            var model = db.SanPham().Where(t => t.MaTTSP == 2).OrderByDescending(x => x.ID).ThenBy(x => x.TenTTSP).ToPagedList(page, pageSize);
            return View(model);
        }
        // GET: Admin/ProductsQL/Create
        [HasCredentia(ID_ChucVu = 1)]
        public ActionResult Create()
        {
            setViewBag();
            return View();
        }

        // POST: Admin/ProductsQL/Create
        [HttpPost]
        [HasCredentia(ID_ChucVu = 1)]
        public ActionResult Create(tb_CTHDNhapHang sp)
        {
            setViewBag();
            try
            {
                if (ModelState.IsValid)
                {
                    
                    if (!CheckTenSanPham(sp.tb_SanPham.TenSP))
                    {
                        try
                        {
                            if (Request.Files != null)
                            {
                                var post = Request.Files["tb_SanPham.UrlHinh"];
                                if (post.FileName != "")
                                {
                                    const string pathStoredImage = "/Assets/img/img_downloaded/";
                                    string image = Path.GetFileName(post.FileName);
                                    var filePath = pathStoredImage + image;
                                    post.SaveAs(Server.MapPath(filePath));
                                    sp.tb_SanPham.UrlHinh = image;
                                    tb_HDNhapHang tb_HDNhapHang = new tb_HDNhapHang() { MaNV = 1, NgayLap = DateTime.Now };

                                    db.tb_HDNhapHang.Add(tb_HDNhapHang);

                                    sp.MaHDNH = tb_HDNhapHang.MaHDNH;

                                    sp.tb_SanPham.SoLuongTon = sp.SoLuong;

                                    db.tb_SanPham.Add(sp.tb_SanPham);

                                    int idSP = sp.tb_SanPham.ID;
                                    sp.MaSP = idSP;

                                    db.tb_CTHDNhapHang.Add(sp);

                                    db.SaveChanges();

                                    SetAlert("Thêm sản phẩm mới thành công", "success");

                                    return RedirectToAction("Index");

                                }
                            }
                        }
                        catch
                        {
                            SetAlert("Có lỗi xảy ra vui lòng thử lại", "error");
                            return View();
                        }
                    }
                    else
                    {
                        SetAlert("Tên sản phẩm đã tồn tại", "error");
                        return View();
                    }

                }
              
                return View();
            }
            catch
            {
                SetAlert("Có lỗi xảy ra! Vui lòng thử lại", "error");
                return View();
            }
        }

        // GET: Admin/ProductsQL/Edit/5
        [HasCredentia(ID_ChucVu = 1)]
        public ActionResult Edit(int id)
        {
            var sp = db.tb_CTHDNhapHang.FirstOrDefault(t => t.MaSP == id);

            if (sp == null) return HttpNotFound();
            setViewBag();
            return View(sp);
        }

        // POST: Admin/ProductsQL/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [HasCredentia(ID_ChucVu = 1)]
        public ActionResult Edit(tb_CTHDNhapHang sp,string urlImage)
        {
            try
            {
                if (Request.Files != null)
                {
                    var post = Request.Files["tb_SanPham.UrlHinh"];
                    if (post.FileName != "")
                    {
                        const string pathStoredImage = "/Assets/img/img_downloaded/";
                        string image = Path.GetFileName(post.FileName);
                        var filePath = pathStoredImage + image;
                        post.SaveAs(Server.MapPath(filePath));
                        sp.tb_SanPham.UrlHinh = image;
                    }
                }
                if (sp.tb_SanPham.UrlHinh == null)
                    sp.tb_SanPham.UrlHinh = urlImage;

                    sp.SoLuong = sp.tb_SanPham.SoLuongTon.Value;

                    db.Entry(sp.tb_SanPham).State = EntityState.Modified;
                    db.Entry(sp).State = EntityState.Modified;
                    db.SaveChanges();

                    SetAlert("Chỉnh sửa thành công", "success");
                    return RedirectToAction("Index");
            }
            catch
            {
                var sps = db.tb_CTHDNhapHang.FirstOrDefault(t => t.MaSP == sp.MaSP);
                if (sps == null) return HttpNotFound();
                setViewBag();
                SetAlert("Có lỗi xảy ra vui lòng thử lại", "error");
                return View(sps);
            }
        }
        [HasCredentia(ID_ChucVu = 1)]
        public ActionResult NgungKinhDoanh(int? id)
        {
            try
            {
                if (id == null)
                    return RedirectToAction("Index");
                else
                {
                    var sp = db.tb_SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.TrangThai = 1;
                        db.Entry(sp).State = EntityState.Modified;
                        db.SaveChanges();

                        SetAlert("Ngừng kinh doanh thành công", "success");
                        return RedirectToAction("Index");
                    }
                    SetAlert("Sản phẩm không tồn tại", "warning");
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                SetAlert("Có lỗi xảy ra vui lòng thử lại", "error");
                return RedirectToAction("Index");
            }
        }
        public bool CheckTenSanPham(string name)
        {
            var sp = db.tb_SanPham.FirstOrDefault(t => t.TenSP.Equals(name));
            if (sp == null) return false;
            return true;
        }
        private void setViewBag()
        {
            ViewBag.TrangThai = new SelectList(db.tb_TrangThaiSanPham, "MaTTSP", "TenTTSP");
            ViewBag.MaDanhMuc = new SelectList(db.tb_DanhMuc, "MaDM", "TenDM");
            ViewBag.ThgHieu = new SelectList(db.tb_ThuongHieu.Where(t => t.DaXoa == false).ToList(), "MaThgHieu", "TenThgHieu");
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
