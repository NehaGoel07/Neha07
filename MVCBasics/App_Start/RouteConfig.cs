using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCBasics
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
               name: "Emp",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Emp", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "Section",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Section", action = "Index", id = UrlParameter.Optional }
          );

            routes.MapRoute(
             name: "QuesOne",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "QuesOne", action = "Index", id = UrlParameter.Optional }
         );

            routes.MapRoute(
             name: "RenderAction",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "RenderAction", action = "Index", id = UrlParameter.Optional }
         );

            routes.MapRoute(
             name: "QuesFour",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "QuesFour", action = "Index", id = UrlParameter.Optional }
         );

            routes.MapRoute(
             name: "Login",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
         );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
