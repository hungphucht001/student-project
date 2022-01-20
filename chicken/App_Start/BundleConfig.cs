using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;

namespace chicken
{
    public class BundleConfig
    {
        // For more information on Bundling, visit https://go.microsoft.com/fwlink/?LinkID=303951
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/WebForms").Include(
                            "~/Scripts/WebForms/aos.js",
                            "~/Scripts/WebForms/specialtab.js",
                            "~/Scripts/WebForms/promotion.js",
                            "~/Scripts/WebForms/main.js",
                            "~/Scripts/WebForms/swiper-bundle.min.js",
                            "~/Scripts/WebForms/fontawesome.js",
                            "~/Scripts/WebForms/Toast.js"
                           ));

            bundles.Add(new ScriptBundle("~/bundles/Admin").Include(
                            "~/Admin/assets/js/chart.min.js",
                           "~/Admin/assets/js/main.js",
                           "~/Admin/assets/js/ckeditor/ckeditor.js",
                           "~/Scripts/jquery-3.4.1.js"
                           ));
        }
    }
}