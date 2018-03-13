using System.Web;
using System.Web.Optimization;

namespace LiteBot
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/jquery-1.10.2.min.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js",
                        "~/Scripts/jquery.cookie.min.js",
                        "~/Assets/lib/js/uikit.min.js",
                        "~/Assets/lib/js/uikit-icons.min.js",
                        "~/Assets/lib/js/angular.min.js",
                        "~/Assets/lib/js/angular-animate.min.js",
                        "~/Assets/lib/js/angular-loader.min.js",
                        "~/Assets/lib/js/angular-sanitize.min.js",
                        "~/Assets/js/lang/en.js",
                        "~/Assets/js/lang/vn.js",
                        "~/Assets/js/utils.js",
                        "~/Assets/js/app.js",
                        "~/Assets/js/controllers/login.js",
                        "~/Assets/js/controllers/register.js",
                        "~/Assets/js/controllers/forgot-password.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/js/controllers/dashboard").Include(
                        "~/Assets/js/controllers/dashboard.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/Content/css/controllers/dashboard").Include(
                        "~/Assets/css/controllers/dashboard.css"  
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Assets/lib/css/uikit.min.css",
                      "~/Assets/css/app.css",
                      "~/Content/Site.css"));
        }
    }
}
