using System.Web;
using System.Web.Optimization;

namespace InterviewTest2015
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/app/app.js",
                "~/app/services/part.js",
                "~/app/controllers/dashboard.js",
                "~/app/controllers/modal.js",
                "~/app/filters/filters.js"
                
            ));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                 "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                 "~/Scripts/ui-bootstrap-tpls-0.12.0.js"
                 ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));
        }
    }
}
