using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BreadCrumb.Models;
using SmartBreadcrumbs.Attributes;

namespace BreadCrumb.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Breadcrumb("Home")]
        public IActionResult Index()
        {
            return View();
        }

        [Breadcrumb("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Breadcrumb("Show")]
        public IActionResult Show()
        {
            return RedirectToAction("Index", "Route");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
