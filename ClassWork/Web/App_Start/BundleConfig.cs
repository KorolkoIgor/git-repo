using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection collection)
        {
            collection.Add(new ScriptBundle("~/scripts")
                            .Include("~/Scripts/modernizr-2.8.3.js")
                            .Include("~/Scripts/jquery-2.2.4.js")
                            .Include("~/Scripts/jquery-2.2.4.intellisense.js")
                            .Include("~/Scripts/bootstrap.js"));

            collection.Add(new StyleBundle("~/styles")
                            .Include("~/Content/bootstrap.css", new CssRewriteUrlTransform())
                            .Include("~/Content/bootstrap-theme.css", new CssRewriteUrlTransform())
                            .Include("~/Content/Site.css", new CssRewriteUrlTransform()));
        }
    }
}