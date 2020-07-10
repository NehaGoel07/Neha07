using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreadCrumb.Entity;
using BreadCrumb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartBreadcrumbs.Attributes;

namespace BreadCrumb.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _employee;
        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }

        [Breadcrumb("Employee",FromAction ="Index",FromController =typeof(HomeController))]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        [Authorize(Roles ="Admin")]
        [Breadcrumb("EmployeeList")]
        public IActionResult Get()
        {
            var employeesList = _employee.GetEmployees();
            return View(employeesList);
        }
    }
}