using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicMenu.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DynamicMenu.Controllers
{
    //[ServiceFilter(typeof(RoleHandlerFilter))]
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public EmployeeController(ApplicationContext applicationContext )
        {
            this.applicationContext = applicationContext;
        }

        /// <summary>
        /// Get the list of employees
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public IActionResult Get()
        {
            var empList = applicationContext.TblEmpDetails.AsEnumerable();
            return View(empList);
        }

        /// <summary>
        /// Displays the view to add new employee
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public IActionResult AddNew()
        {
            return View();
        }

        /// <summary>
        /// Add new employee details
        /// </summary>
        /// <param name="details"></param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public IActionResult AddNew(TblEmpDetails details)
        {
            applicationContext.TblEmpDetails.Add(details);
            return RedirectToAction("Get");
        }
    }
}