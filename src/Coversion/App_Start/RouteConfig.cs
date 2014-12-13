using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Conversion
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
                       

            routes.MapRoute(
                 "Default",
                 "{language}/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional, language = "en" },
                new { language = @"(ru)|(en)" }
            );

            //routes.MapHttpRoute(
            //    "DefaultApi",
            //    "api/{controller}/{action}"
            //    );
        }
    }
}