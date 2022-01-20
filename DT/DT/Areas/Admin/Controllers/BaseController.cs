using DT.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DT.Entity;
using System.Security.Cryptography;

namespace DT.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (tb_NhanVien)Session["user"];
            if(session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new
                    System.Web.Routing.RouteValueDictionary(new {controller = "Login", action = "DangNhap", Area = "admin"}));
            }
            base.OnActionExecuting(filterContext);
        }
        protected void SetAlert(string message, string type)
        {
            TempData["AlertMessage"] = message;
            if (type == "success")
                TempData["AlertType"] = "alert-success";
            else if (type == "warning")
                TempData["AlertType"] = "alert-warning";
            if (type == "error")
                TempData["AlertType"] = "alert-danger";
        }
        protected string EncodeSHA1(string pass)
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
    }
}