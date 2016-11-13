using System.Web;
using System.Web.Optimization;

namespace p1
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            /*below added by ebube*/
            bundles.Add(new ScriptBundle("~/bundles/search").Include(
                        "~/Content/Search button/js/functions.js",
                        "~/Content/Search button/js/jquery-1.7.1.min.js",
                        "~/Content/Search button/js/jquery.easing.1.3.js"));

            bundles.Add(new StyleBundle("~/Content/searchcss").Include(
                        "~/Content/Search button/images/bg.jpg",
                        "~/Content/Search button/images/form-bg.jpg",
                        "~/Content/Search button/images/magnifier.jpg",
                        "~/Content/Search button/images/popup-bg.jpg",
                        "~/Content/Search button/images/Thumbs.jpg",
                        "~/Content/Search button/search-form.psd",
                        "~/Content/Search button/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/carousel").Include(
                        "~/Content/Carousel slider/dist/jquery.carrousel-3d.js",
                        "~/Content/Carousel slider/dist/jquery.carrousel-3d.min.js",
                        "~/Content/Carousel slider/src/Carousel3d.js",
                        "~/Content/Carousel slider/src/child.js",
                        "~/Content/Carousel slider/src/childrenWrapper.js",
                        "~/Content/Carousel slider/src/jquery.resize.ex.js"));

            bundles.Add(new StyleBundle("~/Content/carouselcss").Include(
                        "~/Content/Carousel slider/dist/jquery.carousel-3d.default.css",
                        "~/Content/Carousel slider/styles/common/jquery.carousel-3d.scss",
                        "~/Content/Carousel slider/styles/themes/jquery.carousel-3d.default.scss",
                        "~/Content/Carousel slider/styles/themes/images/next.png",
                        "~/Content/Carousel slider/styles/themes/images/prev.png"));
        }
    }
}
