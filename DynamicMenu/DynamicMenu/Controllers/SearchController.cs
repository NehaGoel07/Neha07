using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicMenu.Models;
using Microsoft.AspNetCore.Mvc;

namespace DynamicMenu.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public SearchController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Get()
        {
            var empList = applicationContext.TblEmpDetails.ToList();
            return Ok(empList);
        }

    }
}