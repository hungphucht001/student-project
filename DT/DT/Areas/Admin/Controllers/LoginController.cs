using DT.Areas.Admin.Models;
using DT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace DT.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        dbPhoneStoreEntities db = new dbPhoneStoreEntities();
        public ActionResult DangNhap()
        {
            if (Session["user"] != null)
            {
                return Redirect("/admin");
            }
            return View();
        }

        public ActionResult DangXuat()
        {
            Session.Clear();
            return Redirect("/admin/dang-nhap");
        }

        // POST: Admin/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangNhap(Login login)
        {
            if (ModelState.IsValid)
            {
                var model = db.LoginPhoneStore(login.Username, EncodeSHA1(login.Password));
                if (model.Count() > 0)
                {
                    var chucvu = db.tb_ChucVu.ToList();

                    Session["CV"] = chucvu;
                    Session["user"] = db.tb_NhanVien.FirstOrDefault(t=>t.Username == login.Username);
                    return Redirect("/admin");
                }
                else
                {
                    ViewBag.err = "Tài khoản hoặc mật khẩu không chính xác";
                }
            }
            return View();
        }
        private string EncodeSHA1(string pass)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);
            bs = sha1.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x1").ToLower());
            }

            pass = s.ToString();
            return pass;
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