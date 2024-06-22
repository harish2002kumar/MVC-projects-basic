using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication6
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"list",
                url:"listof",
                defaults: new {Controller="home",action="list" }
                );



            routes.MapRoute(
                name: "display",
                url: "display/{cid}",
                constraints: new { cid = @"\d{1,3}" },
                defaults: new { Controller = "home", action = "display",cid=UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


        }
    }
}
