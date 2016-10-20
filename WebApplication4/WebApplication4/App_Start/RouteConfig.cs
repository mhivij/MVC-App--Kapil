using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Customer", action = "GetData", id = UrlParameter.Optional }
            //);
            routes.MapRoute(
                name: "Customer",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customer", action = "InsertData", id = UrlParameter.Optional }
            );
        }
    }
}
