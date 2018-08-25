using System.Web;
using System.Web.Optimization;

namespace ShopFrontEnd
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {         
            //------------------------------------------------------------------
            bundles.Add(new StyleBundle("~/Assest/css").Include("~/Assest/css/style.css", "~/Assest/css/slider.css"));

            bundles.Add(new ScriptBundle("~/Assest/js").Include("~/Assest/js/easing.js", "~/Assest/js/jquery-1.7.2.min.js", "~/Assest/js/move-top.js", "~/Assest/js/startstop-slider.js"));
        }
    }
}
