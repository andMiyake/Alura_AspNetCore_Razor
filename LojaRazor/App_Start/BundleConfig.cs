using System.Web;
using System.Web.Optimization;

namespace LojaRazor
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            StyleBundle estilos = new StyleBundle("~/bundle/estilos");
            estilos.Include("~/Content/bootstrap/css/bootstrap.css");
            estilos.Include("~/Content/Style.css");
            bundles.Add(estilos);

            ScriptBundle scripts = new ScriptBundle("~/bundles/scripts");
            scripts.Include("~/Scripts/jquery-1.7.1.js");
            scripts.Include("~/Scripts/jquery.validate.js");
            scripts.Include("~/Scripts/jquery.validate.unobtrusive.js");
            bundles.Add(scripts);
        }
    }
}