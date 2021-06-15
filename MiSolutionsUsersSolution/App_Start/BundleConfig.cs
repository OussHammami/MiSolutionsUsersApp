using System.Web;
using System.Web.Optimization;

namespace MiSolutionsUsersSolution
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/KendoUI/kendo.web.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
                        "~/Scripts/KendoUI/jquery.min.js",
                        "~/Scripts/KendoUI/kendo.all.min.js",
                        "~/Scripts/KendoUI/jszip.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/Adio/bootstrap.min.css", 
                      "~/Content/Adio/style.css", 
                      "~/Content/Adio/responsive.css", 
                      "~/Content/KendoUI/kendo.rtl.min.css", 
                      "~/Content/Adio/owl.carousel.min.css",
                      "~/Content/KendoUI/kendo.bootstrap.min.css",
                      "~/Content/KendoUI/kendo.common-bootstrap.min.css",
                      "~/Content/KendoUI/kendo.common.min.css",
                      "~/Content/KendoUI/kendo.default.min.css"));
        }
    }
}
