using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartBreadcrumbs.Attributes;

namespace BreadCrumb.Controllers
{
    public class RouteController : Controller
    {

        [Breadcrumb("Route",FromAction = "Index", FromController = typeof(HomeController))]
        public IActionResult Index()
        {
            return View();
        }

        [Breadcrumb("RouteSample")]
        public IActionResult Sample()
        {
            return View();
        }
    }
}