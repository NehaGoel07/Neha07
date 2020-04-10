using MVCArchitecture.Models;
using MVCArchitecture.Models.Repository;
using MVCArchitecture.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCArchitecture.Controllers
{
    public class EmployeeController : Controller
    {
        readonly IEmployeeData employeeData;
        public EmployeeController()
        {
            employeeData = new EmployeeData();
        }
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// passing data from controller to view
        /// </summary>
        /// <param name="data"></param>
        /// <returns>ActionResult</returns>
        public ActionResult ShowList(LoginDetails data)
        {
            try
            {
                var res = employeeData.Data();

                TempData["username"] = data.userName;
                ViewBag.EmployeeDataList = res;
                return View();
            }
            catch
            {
                throw;
            }
        }






    }
}