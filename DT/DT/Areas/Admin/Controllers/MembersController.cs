using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DT.Entity;
using DT.Entity.DAO;
using PagedList;

namespace DT.Areas.Admin.Controllers
{
    [HasCredentia(ID_ChucVu = 1)]
    public class MembersController : BaseController
    {
        private dbPhoneStoreEntities db = new dbPhoneStoreEntities();

        // GET: Admin/Members
        public ActionResult Index(int page = 1, int pageSize = 12)
        {
            var tb_NhanVien = db.tb_NhanVien.Where(t => t.DaXoa != true).OrderByDescending(t => t.MaNV).ToPagedList(page, pageSize);
            if (tb_NhanVien == null) return HttpNotFound();
            return View(tb_NhanVien);
        }
        public ActionResult Deleted(int page = 1, int pageSize = 12)
        {
            var tb_NhanVien = db.tb_NhanVien.Where(t => t.DaXoa == true).OrderByDescending(t => t.MaNV).ToPagedList(page, pageSize);
            if (tb_NhanVien == null) return HttpNotFound();
            return View(tb_NhanVien);
        }
        // GET: Admin/Members/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_NhanVien tb_NhanVien = db.tb_NhanVien.Find(id);
            if (tb_NhanVien == null)
            {
                return HttpNotFound();
            }
            return View(tb_NhanVien);
        }

        // GET: Admin/Members/Create
        public ActionResult Create()
        {
            ViewBag.ChucVu = new SelectList(db.tb_ChucVu, "MaChucVu", "TenChucVu");
            return View();
        }

        // POST: Admin/Members/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tb_NhanVien tb_NhanVien)
        {
            ViewBag.ChucVu = new SelectList(db.tb_ChucVu, "MaChucVu", "TenChucVu");
            
            if (ModelState.IsValid)
            {
                DateTime now = DateTime.Now;
                if ((now.Year - tb_NhanVien.NgaySinh.Year) >= 18)
                {
                    if (!CheckUserName(tb_NhanVien.Username))
                    {
                        tb_NhanVien.Username = tb_NhanVien.Username;
                        tb_NhanVien.Password = EncodeSHA1(tb_NhanVien.Username + "123456");
                        tb_NhanVien.DaXoa = false;
                        db.tb_NhanVien.Add(tb_NhanVien);
                        db.SaveChanges();
                        SetAlert("Thêm thành viên thành công", "success");
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        SetAlert("Thêm thất bại. Username đã tồn tại!", "error");
                        return View(tb_NhanVien);
                    }
                }
                else
                {
                    SetAlert("Nhân viên phải lớn hơn 18 tuổi", "warning");
                    return View(tb_NhanVien);
                }
            }
            return View(tb_NhanVien);
        }

        // GET: Admin/Members/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_NhanVien tb_NhanVien = db.tb_NhanVien.Find(id);

            ViewBag.ChucVu = new SelectList(db.tb_ChucVu, "MaChucVu", "TenChucVu", tb_NhanVien.ChucVu);

            if (tb_NhanVien == null)
            {
                return HttpNotFound();
            }
            return View(tb_NhanVien);
        }

        // POST: Admin/Members/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tb_NhanVien tb_NhanVien)
        {
            ViewBag.ChucVu = new SelectList(db.tb_ChucVu, "MaChucVu", "TenChucVu", tb_NhanVien.ChucVu);
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(tb_NhanVien).State = EntityState.Modified;
                    db.SaveChanges();
                    SetAlert("Chỉnh sửa thành công", "success");
                    return RedirectToAction("Index");
                }
                catch
                {
                    SetAlert("Có lỗi xảy ra! Vui lòng thử lại", "error");
                    return View(tb_NhanVien);
                }
            }
            return View(tb_NhanVien);
        }
        public void Delete(int id)
        {
            tb_NhanVien tb_NhanVien = db.tb_NhanVien.Find(id);
            tb_NhanVien.DaXoa = true;
            db.SaveChanges();
        }

        public ActionResult ResetPass(int id)
        {
            tb_NhanVien tb_NhanVien = db.tb_NhanVien.Find(id);
            tb_NhanVien.Password = EncodeSHA1(tb_NhanVien.Username + "123456");
            db.SaveChanges();
            SetAlert("Cập nhật mật khẩu cho nhân viên "+ tb_NhanVien.HoTen+" thành công", "success");
            return Redirect("/admin/thanh-vien");
        }

        public bool CheckUserName(string username)
        {
            var user = db.tb_NhanVien.FirstOrDefault(t => t.Username.Equals(username));
            if (user == null)
                return false;
            return true;
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
