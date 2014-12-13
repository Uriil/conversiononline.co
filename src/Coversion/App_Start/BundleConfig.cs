using System.Web;
using System.Web.Optimization;

namespace Conversion
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        //"~/Scripts/jquery.js",
                        "~/Scripts/jquery.easing.1.3.js",
                        "~/Scripts/fancybox/jquery.fancybox-1.3.1.js",
                        "~/Scripts/easyslider.js",
                        "~/Scripts/md5.js",
                        "~/Scripts/custom.js"));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css",
                "~/Scripts/fancybox/jquery.fancybox-1.3.1.css",
                "~/Content/bootstrap.css"));

            
        }
    }
}