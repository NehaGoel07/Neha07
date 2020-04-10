using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVCBasics.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundleCollection)
        {
            bundleCollection.Add(new StyleBundle("~/bundle/css").Include("~/Content/bootstrap.css", "~/Content/style.css", "~/Content/site.css"));
            bundleCollection.Add(new ScriptBundle("~/bundle/js").Include("~/Scripts/jquery-3.0.0.js", "~/ Scripts /bootstrap.js"));
        }
    }
}