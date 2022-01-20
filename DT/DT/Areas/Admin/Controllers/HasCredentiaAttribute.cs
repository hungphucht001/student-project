using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DT.Entity;


namespace DT.Areas.Admin.Controllers
{
    public class HasCredentiaAttribute : AuthorizeAttribute
    {
        public int ID_ChucVu { get; set; }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {

            //List<tb_ChucVu> CV = (List<tb_ChucVu>)HttpContext.Current.Session["CV"];
            tb_NhanVien user = (tb_NhanVien)HttpContext.Current.Session["user"];

            if(user != null)
            {
                if (user.ChucVu == this.ID_ChucVu)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Areas/Admin/Views/Shared/401.cshtml"
            };
        }
    }
}