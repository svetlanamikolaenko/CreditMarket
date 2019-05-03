using System.Web.Optimization;

namespace CreditMarket
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/datatables/jquery.datatables.js",
                        "~/Scripts/datatables/datatables.bootstrap.js",
                        "~/Scripts/moment.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/bootstrap-datepicker.js",
                        "~/Scripts/locales/bootstrap-datepicker.uk.min.js",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                   "~/Scripts/bootstrap-datepicker.js",
                   "~/Scripts/locales/bootstrap-datepicker.uk.min.js",
                    "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/datatables/css/datatables.bootstrap.css",
                      "~/Content/site.css"));
        }

    }
}
