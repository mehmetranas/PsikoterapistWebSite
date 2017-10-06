using System.Web.Optimization;

namespace PsychotherapistWebSite
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/assests/scripts")
                .Include("~/Scripts/Assests/picturefill.min.js",
                         "~/Scripts/Assests/magnific-popup.js",
                         "~/Scripts/Assests/main.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/lib/scripts")
                .Include("~/Scripts/bootbox.min.js"));

            bundles.Add(new ScriptBundle("~/admin/scripts")
                .Include("~/Scripts/App/app.js",
                "~/Scripts/App/Controller/ServiceController.js",
                "~/Scripts/App/Controller/BootboxController.js",
                "~/Scripts/App/Service/ServiceService.js",
                "~/Scripts/App/Service/InfoService.js",
                "~/Scripts/App/Controller/InfoController.js",
                "~/Scripts/App/Controller/HomeFaqController.js",
                "~/Scripts/App/Service/HomeFaqService.js"));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/assests/css")
                .Include("~/Content/Assests/css/style.css",
                         "~/Content/Assests/css/magnific-popup.css"));

            bundles.Add(new StyleBundle("~/lib/css")
                .Include("~/Content/animate.css",
                "~/Content/font-awesome.css"));

            bundles.Add(new StyleBundle("~/bootstrap/css")
                .Include("~/Content/bootstrap.css"));

        }
    }
}
