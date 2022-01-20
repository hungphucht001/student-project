using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using DT.Entity.DAO;
using DT.Entity;
using System.Data.Entity;

namespace DT.Areas.Admin.Controllers
{
    public class OrdersController : BaseController
    {
        dbPhoneStoreEntities db = new dbPhoneStoreEntities();
        // GET: Admin/Orders
        public ActionResult Index(int page = 1, int pageSize = 12, string p = null)
        {
            int totalRecord = 0;
            var model = getAllOrder(ref totalRecord, page, pageSize,p);
            int totalPage = 0;
            totalPage = (int)Math.Ceiling((double)(totalRecord / 12)) + 1;
            ViewBag.totalPage = totalPage;
            ViewBag.totalRecord = totalRecord;
            ViewBag.p = p;
            ViewBag.crPage = page;
            return View(model);
        }
        public ActionResult UnBrowsedOrders(int page = 1, int pageSize = 12)
        {
            int totalRecord = 0;
            var model = getAllOrder(ref totalRecord, 1, page, pageSize);
            int totalPage = 0;
            totalPage = (int)Math.Ceiling((double)(totalRecord / 12)) + 1;
            ViewBag.totalPage = totalPage;
            ViewBag.totalRecord = totalRecord;
            ViewBag.crPage = page;
            return View(model);
        }
        public ActionResult PaidOrders(int page = 1, int pageSize = 12)
        {
            int totalRecord = 0;
            var model = getAllOrder(ref totalRecord, 2, page, pageSize);
            int totalPage = 0;
            totalPage = (int)Math.Ceiling((double)(totalRecord / 12)) + 1;
            ViewBag.totalPage = totalPage;
            ViewBag.totalRecord = totalRecord;
            ViewBag.crPage = page;
            return View(model);
        }
        public ActionResult UnpaidOrders(int page = 1, int pageSize = 12)
        {
            int totalRecord = 0;
            var model = getAllOrder(ref totalRecord, 3, page, pageSize);
            int totalPage = 0;
            totalPage = (int)Math.Ceiling((double)(totalRecord / 12)) + 1;
            ViewBag.totalPage = totalPage;
            ViewBag.totalRecord = totalRecord;
            ViewBag.crPage = page;
            return View(model);
        }
        public ActionResult CancelOrders(int page = 1, int pageSize = 12)
        {
            int totalRecord = 0;
            var model = getAllOrder(ref totalRecord, 4, page, pageSize);
            int totalPage = 0;
            totalPage = (int)Math.Ceiling((double)(totalRecord / 12)) + 1;
            ViewBag.totalPage = totalPage;
            ViewBag.totalRecord = totalRecord;
            ViewBag.crPage = page;
            return View(model);
        }

        public ActionResult HuyDonHang(int MaHDBH)
        {
            try
            {
                var dh = db.tb_HDBanHang.Find(MaHDBH);

                if (dh == null)
                {
                    SetAlert("Không tìm thấy đơn hàng", "warning");
                    return Redirect("/admin/quan-ly-don-hang");
                }
                else
                {
                    var maNV = ((tb_NhanVien)Session["user"]).MaNV;
                    db.DuyetDonHang(MaHDBH, maNV);
                    dh.TrangThai = 4;
                    dh.MaNV = maNV;
                    db.Entry(dh).State = EntityState.Modified;
                    db.SaveChanges();

                    SetAlert("Hủy đơn hàng thành công", "success");
                    return Redirect("/admin/quan-ly-don-hang");
                }
            }
            catch
            {
                SetAlert("Có lỗi xảy ra vui lùng thử lại", "error");
                return Redirect("/admin/quan-ly-don-hang");
            }
        }

        public ActionResult DuyetDon(int MaHDBH)
        {
            try
            {
                var maNV = ((tb_NhanVien)Session["user"]).MaNV;
                db.DuyetDonHang(MaHDBH, maNV);
                SetAlert("Duyet thành công", "success");
                return Redirect("/admin/quan-ly-don-hang");
            }
            catch
            {
                SetAlert("Có lỗi xảy ra vui lùng thử lại", "error");
                return Redirect("/admin/quan-ly-don-hang");
            }
        }

        // GET: admin/chi-tiet-don-hang/{MaHDBH}
        public ActionResult Details(int? MaHDBH)
        {
            if (MaHDBH == null) return HttpNotFound();
            var result = db.tb_HDBanHang.Find(MaHDBH);
            if (result == null)
            {
                SetAlert("Không tìm thấy đơn hàng", "warning");
                return Redirect("/admin/quan-ly-don-hang");
            }
            return View(result);
        }
       
        // GET: admin/chinh-sua-don-hang/{MaHDBH}
        public ActionResult Edit(int? MaHDBH)
        {
            if (MaHDBH == null) return HttpNotFound();
            return View();
        }
        public IEnumerable<DonHang_Result> getAllOrder(ref int totalRecord, int page = 1, int pageSize = 12, string p = null)
        {
            var model = db.DonHang("-1");
            totalRecord = db.DonHang("-1").Count();
            if (p != null)
            {
                totalRecord = db.DonHang("-1").Where(t => t.SDT.Equals(p)).OrderByDescending(x => x.NgayLap).Count();
                return model.Where(t => t.SDT.Equals(p)).OrderByDescending(x => x.NgayLap).Skip((page - 1) * pageSize).Take(pageSize);

            }
            return model.OrderByDescending(x => x.NgayLap).Skip((page - 1) * pageSize).Take(pageSize);
        }
        public IEnumerable<DonHang_Result> getAllOrder(ref int totalRecord, int idTrangThai, int page = 1, int pageSize = 12)
        {
            string trangThai = "";
            if (idTrangThai == 1) trangThai = "Chờ xác nhận";
            else if (idTrangThai == 2) trangThai = "Chưa thanh toán";
            else if (idTrangThai == 3) trangThai = "Đã thanh toán";
            else trangThai = "Hủy đơn";
            var model = db.DonHang("-1").Where(t => t.TrangThai.CompareTo(trangThai) == 0);
            totalRecord = db.DonHang("-1").Where(t => t.TrangThai.CompareTo(trangThai) == 0).Count();

            return model.OrderByDescending(x => x.NgayLap).Skip((page - 1) * pageSize).Take(pageSize);
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
