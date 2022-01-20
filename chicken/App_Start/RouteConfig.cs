using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace chicken
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);

            routes.MapPageRoute("Account/dangnhap", "dang-nhap","~/Account/dangnhap.aspx");
            routes.MapPageRoute("Account/dangky", "dang-ky", "~/Account/dangky.aspx");
            routes.MapPageRoute("chitietbaiviet", "tin-tuc/{Title}/{Id}", "~/gui/chitietbaiviet.aspx");
            routes.MapPageRoute("tintuc", "tin-tuc", "~/gui/tintuc.aspx");
            routes.MapPageRoute("lienhe", "lien-he", "~/gui/lienhe.aspx");
            routes.MapPageRoute("thucdon", "thuc-don", "~/gui/thucdon.aspx");
            routes.MapPageRoute("khuyenmai", "khuyen-mai", "~/gui/khuyenmai.aspx");
            routes.MapPageRoute("", "", "~/gui/Default.aspx");
            routes.MapPageRoute("chitietsanpham", "san-pham/{MetaTile}/{id}", "~/gui/chitietsanpham.aspx");
            routes.MapPageRoute("giohang","gio-hang","~/gui/giohang.aspx");
            routes.MapPageRoute("thanhtoan","thanh-toan","~/gui/thanhtoan.aspx");
            routes.MapPageRoute("taikhoan", "tai-khoan/{pr}", "~/gui/taikhoan.aspx");
            routes.MapPageRoute("donhangdadat","don-hang-da-dat", "~/gui/donhangdadat.aspx");

            //routes admin
            routes.MapPageRoute("Admin/Default","admin/dang-nhap","~/admin/default.aspx");
            routes.MapPageRoute("Admin/Dashboard", "admin/", "~/admin/dashboard.aspx");
        }
    }
}
