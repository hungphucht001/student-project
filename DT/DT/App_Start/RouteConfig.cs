using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DT
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Khách hàng
            routes.MapRoute(
               name: "Hỏi đáp",
               url: "hoi-dap",
               defaults: new { controller = "QA", action = "Index" }
            );

            routes.MapRoute(
               name: "Di động1",
               url: "di-dong",
               defaults: new { controller = "Products", action = "Phone"}
            );

            routes.MapRoute(
               name: "Di động",
               url: "di-dong/{slug}-{id}",
               defaults: new { controller = "Products", action = "Phone" , slug = UrlParameter.Optional, id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "Sản phẩm",
              url: "san-pham",
              defaults: new { controller = "Products", action = "Index" }
           );

            routes.MapRoute(
               name: "Chi tiết",
               url: "san-pham/{slug}/{id}",
               defaults: new { controller = "DetailProduct", action = "Index", slug = UrlParameter.Optional, id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Phụ kiện",
               url: "phu-kien/{slug}",
               defaults: new { controller = "Products", action = "Accessory", slug = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Liên hệ",
               url: "lien-he",
               defaults: new { controller = "Contact", action = "Index" }
            );

            routes.MapRoute(
               name: "Tra cứu đơn hàng",
               url: "tra-cuu-don-hang",
               defaults: new { controller = "OrderLookup", action = "Index" }
           );

            routes.MapRoute(
               name: "Giỏ hàng",
               url: "gio-hang",
               defaults: new { controller = "Cart", action = "Index" }
           );

            routes.MapRoute(
               name: "Thanh toán",
               url: "thanh-toan",
               defaults: new { controller = "Pay", action = "Index" }
           );

            routes.MapRoute(
               name: "Cảm ơn",
               url: "cam-on",
               defaults: new { controller = "Pay", action = "Thankyou" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}
