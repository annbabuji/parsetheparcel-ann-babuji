using System.Web;
using System.Web.Optimization;

namespace ParseThe_Parcel_App
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            StyleBundle(bundles);
            ScriptBundle(bundles);
        }

        public static void StyleBundle(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css")
                     .Include("~/Content/bootstrap.css"));

        }

        public static void ScriptBundle(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js")
                     .Include("~/Scripts/jquery-{version}.js")
                     .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.js"));


        }    
    }
}