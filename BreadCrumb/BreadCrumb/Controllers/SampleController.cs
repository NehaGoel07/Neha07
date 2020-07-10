using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartBreadcrumbs.Attributes;
using SmartBreadcrumbs.Nodes;

namespace BreadCrumb.Controllers
{
    
    public class SampleController : Controller
    {
        [Breadcrumb("Sample",FromAction="Index",FromController =typeof(RouteController))]
        public IActionResult Index()
        {
            return View();
        }

        [Breadcrumb("Example")]
        public IActionResult Example()
        {
            return View();
        }
    }
}