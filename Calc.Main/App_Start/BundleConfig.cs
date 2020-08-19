using System.Web;
using System.Web.Optimization;

namespace Calc.Main
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/modernizr-*",
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/angular.js",
                        "~/Scripts/angular-resource.js",
                        "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/app")
                .Include(
                    "~/js/app.js",
                    "~/js/modules.js"
            )
            .IncludeDirectory("~/js/directives", "*.js", true)
            .IncludeDirectory("~/js/Controllers", "*.js", true)
            .IncludeDirectory("~/js/Services", "*.js", true));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/Site.css"));
        }
    }
}
