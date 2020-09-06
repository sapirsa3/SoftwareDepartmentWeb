using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace projectnetwork
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.config");


            routes.MapRoute(
                name: "Home",
                url: "Login/LoginPage",
                defaults: new { controller = "Login", action = "LoginPage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Startpageadmin",
                url: "Admin/Startpageadmin",
                defaults: new { controller = "Admin", action = "Startpageadmin", id = UrlParameter.Optional }
);
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
