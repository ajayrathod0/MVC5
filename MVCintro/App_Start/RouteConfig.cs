using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCintro
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();//Enable Attribute Route


            //Frist routing
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "category", action = "allcategory", id = UrlParameter.Optional }
            );

            //second routing
            routes.MapRoute(
               name: "Default1",
               url: "{controller}/{action}/{id}/{name}"
           );
        }
    }
}
