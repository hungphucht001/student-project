using System.Web;
using System.Web.Optimization;

namespace DT
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            // css 

            bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
                      "~/Assets/css/bootstrap.min.css",
                      "~/Assets/css/bootstrap-icons.css",
                      "~/Assets/css/normalize.css"
                      ));

            bundles.Add(new StyleBundle("~/Assets/css").Include(
                      "~/Assets/css/main.css"));
            //js 

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Assets/js/main.js",
                        "~/Assets/js/validateForm.js",
                        "~/Assets/js/jquery.min.js",
                        "~/Assets/js/aos.js"
                        ));

           
        }
    }
}
