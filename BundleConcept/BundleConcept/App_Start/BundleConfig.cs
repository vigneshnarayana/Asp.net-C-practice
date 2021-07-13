using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace BundleConcept.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            //var bundle = new ScriptBundle("~/bundles/js");
            //bundle.Include("~/Content/JS/JavaScript1.js", "~/Content/JS/JavaScript2.js",
            //    "~/Content/JS/JavaScript3.js",
            //    "~/Content/JS/JavaScript4.js",
            //    "~/Content/JS/JavaScript5.js");
            //bundles.Add(bundle);


            bundles.Add(new ScriptBundle("~/bundles/js")
                .IncludeDirectory("~/Content/JS", "*.js"));
            bundles.Add(new StyleBundle("~/bundle/css")
              .IncludeDirectory("~/Content/Style", "*.css"));

            //bundles.Add(new StyleBundle("~/bundle/css")
            //    .Include("~/Content/Style/StyleSheet1.css", "~/Content/Style/StyleSheet2.css"));


            BundleTable.EnableOptimizations = true;
        }
    }
}