using System.Web;
using System.Web.Optimization;

namespace CRUDporject
{
    public class BundleConfig
    {
        // 如需統合的詳細資訊，請瀏覽 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.1.11.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryUI").Include(
             "~/Scripts/jquery-ui.js"));
            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好可進行生產時，請使用 https://modernizr.com 的建置工具，只挑選您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr.custom.js"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap-switch.js"));

            bundles.Add(new ScriptBundle("~/bundles/JS").Include(
                       "~/Scripts/SmoothScroll.js",
                      "~/Scripts/jquery.isotope.js",
                      "~/Scripts/owl.carousel.js",
                      "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-switch.css",
                      "~/Content/font-awesome.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/owl.theme.css",
                      "~/Content/style.css",
                      "~/Content/responsive.css"));
        }
    }
}
