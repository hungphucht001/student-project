using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DT.Entity;

namespace DT.Areas.Admin.Controllers
{
    public class ThongKeController : BaseController
    {
        dbPhoneStoreEntities db = new dbPhoneStoreEntities();
        // GET: Admin/ThongKe
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ThongKeSanPham()
        {
            IEnumerable<ThongKeThuongHieuSaPham_Result> tk = db.ThongKeThuongHieuSaPham();

            var count = db.ThongKeThuongHieuSaPham().Count();

            string[] lable = new string[count];
            int[] data = new int[count];
            int i = 0;
            foreach (var item in tk)
            {
                string name = "'" + item.TenThgHieu + "-" + item.MaThgHieu + "'";
                lable[i] = name;
                data[i] = (int)item.SLSanPham;
                i++;
            }

            ViewBag.lable = String.Join(",", lable);
            ViewBag.data = String.Join(",", data);

            ViewBag.DienThoai = db.tb_SanPham.Where(t => t.MaDanhMuc == 1).Count();
            ViewBag.PhuKien = db.tb_SanPham.Where(t => t.MaDanhMuc == 2).Count();

            IEnumerable<ThongKeTop10SanPham_Result> sp = db.ThongKeTop10SanPham();

            var countSP = db.ThongKeTop10SanPham().Count();

            string[] tenSP = new string[countSP];
            int[] soLuongSP = new int[countSP];
            int j = 0;
            foreach (var item in sp)
            {
                item.TenSP = "'" + item.TenSP + "'";
                tenSP[j] = item.TenSP;
                soLuongSP[j] = (int)item.SL;
                j++;
            }

            ViewBag.lable2 = String.Join(",", tenSP);
            ViewBag.data2 = String.Join(",", soLuongSP);

            return View();
        }
        public ActionResult ThongKeDonHang()
        {
            return View();
        }
        public ActionResult ThongKeKhachHang()
        {
            IEnumerable<ThongKeKhachHang_Result> tk = db.ThongKeKhachHang();

            var count = db.ThongKeKhachHang().Count();

            string[] lable = new string[count];
            int[] data = new int[count];
            int i = 0;
            foreach (var item in tk)
            {
                string name = "'" + item.HoTen+"-"+item.MaKH + "'";
                lable[i] = name;
                data[i] = (int)item.SoDH;
                i++;
            }

            ViewBag.lable = String.Join(",", lable);
            ViewBag.data = String.Join(",", data);

            return View();
        }
        public ActionResult ThongKeDoanhThuTheoThang()
        {
            IEnumerable<ThongKeDoanhThu_Result> tk = db.ThongKeDoanhThu();

            var count = db.ThongKeDoanhThu().Count();

            string[] lable = new string[count];
            int[] data = new int[count];
            int i = 0;
            foreach (var item in tk)
            {
                string name = "'" + item.datene + "'";
                lable[i] = name;
                data[i] = (int)item.Tien;
                i++;
            }

            ViewBag.lable = String.Join(",", lable);
            ViewBag.data = String.Join(",", data);

            return View();
        }
        public ActionResult ThongKeNhanVien()
        {
            IEnumerable<ThongKeNhanVienDonHang_Result> tk = db.ThongKeNhanVienDonHang();

            var count = db.ThongKeNhanVienDonHang().Count();

            string[] lable = new string[count];
            int[] data = new int[count];
            int i = 0;
            foreach (var item in tk)
            {
                string name = "'" + item.HoTen + "-" + item.MaNV + "'";
                lable[i] = name;
                data[i] = (int)item.SoLuong;
                i++;
            }

            ViewBag.lable = String.Join(",", lable);
            ViewBag.data = String.Join(",", data);
            
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