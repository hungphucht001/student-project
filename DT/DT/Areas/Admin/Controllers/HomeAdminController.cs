using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DT.Areas.Admin.Models;
using DT.Entity;

namespace DT.Areas.Admin.Controllers
{
    public class HomeAdminController : BaseController
    {
        private dbPhoneStoreEntities db = new dbPhoneStoreEntities();

        // GET: Admin/HomeAdmin
        public ActionResult Index()
        {
            ViewBag.countDonHang = db.tb_HDBanHang.Count();
            ViewBag.countSanPham = db.tb_SanPham.Count();
            ViewBag.countNhanVien = db.tb_NhanVien.Count();

            IEnumerable<ThongKeNhanVien_Result> nv  = db.ThongKeNhanVien();

            var count = db.ThongKeNhanVien().Count();

            string[] tenChucVu = new string[count];
            int[] soLuong = new int[count];
            int i = 0;
            foreach (var item in nv)
            {
                item.TenChucVu = "'"+ item.TenChucVu + "'";
                tenChucVu[i] = item.TenChucVu;
                soLuong[i] = (int)item.SoLuong;
                i++;
            }



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



            ViewBag.TenChucVu = String.Join(",", tenChucVu);
            ViewBag.SoLuong = String.Join(",", soLuong);

            ViewBag.TenSP = String.Join(",", tenSP);
            ViewBag.SoLuongSP = String.Join(",", soLuongSP);

            return View();
        }
        public ActionResult TaiKhoan()
        {
            var idNV = ((tb_NhanVien)Session["user"]).MaNV;
            ViewBag.nv = db.tb_NhanVien.FirstOrDefault(t=>t.MaNV == idNV);
            return View();
        }

        [HttpPost]
        public ActionResult TaiKhoan(DoiMatKhau dmk)
        {
            var idNV = ((tb_NhanVien)Session["user"]).MaNV;
            ViewBag.nv = db.tb_NhanVien.FirstOrDefault(t => t.MaNV == idNV);
            if (ModelState.IsValid)
            {
                try
                {
                    if (dmk.PassMoi.Equals(dmk.PassMoi02))
                    {
                        tb_NhanVien a = db.tb_NhanVien.FirstOrDefault(t => t.MaNV == idNV);
                        if (a.Password.Equals(EncodeSHA1(dmk.PassCu)))
                        {
                            a.Password = EncodeSHA1(dmk.PassMoi);
                            //db.Entry(a).State = EmptyResult();
                            db.SaveChanges();
                            SetAlert("Đổi mật khẩu thành công", "success");
                            return View();
                        }
                        SetAlert("Đổi mật khẩu không thành công. Mật khẩu cũ sai", "error");
                        return View();
                    }
                    SetAlert("Đổi mật khẩu không thành công. Mật khẩu không trùng khớp", "warning");
                    return View();
                }
                catch
                {
                    SetAlert("Có lỗi xảy ra vui lòng thử lại sau.", "warning");
                    return View();
                }
            }
            else
            {
                SetAlert("Vui lòng nhập đầy đủ thông tin.", "warning");
            }
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