using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCArchitecture
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Employee",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "QuestionOne",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "QuestionOne", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "QuestionTwo",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "QuestionTwo", action = "Index", id = UrlParameter.Optional }
          );

            routes.MapRoute(
              name: "Question4Theory",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Question4Theory", action = "Index", id = UrlParameter.Optional }
          );
            
            routes.MapRoute(
               name: "QuestionFive",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "QuestionFive", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "Login",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
