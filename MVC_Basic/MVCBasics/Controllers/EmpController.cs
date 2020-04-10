using MVCBasics.Models;
using MVCBasics.Models.Repository;
using MVCBasics.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics.Controllers
{
    public class EmpController : Controller
    {
        readonly IEmployee employee;
        public EmpController()
        {
            employee = new Emp();
        }

        /// <summary>
        /// Calling NonAction action method and displaying the list of employees
        /// </summary>
        /// <returns>ActionResult</returns>
        public ActionResult Index()
        {
            try
            {
                var data = EmpData();
                return View(data);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// fetching data from the database and sending to Index Action Method
        /// </summary>
        /// <returns>List</returns>
        [NonAction]
        public List<TBL_Employees> EmpData()
        {
            try
            {
                var res = employee.Data();
                return res;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Calling ChildActionOnly action method
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpGet]
        public ActionResult CallChild()
        {
            return View();
        }


        /// <summary>
        /// Fetching data from database of table Employees
        /// </summary>
        /// <returns>ActionResult</returns>
        [ChildActionOnly]
        public ActionResult Child()
        {
            try
            {
                BootCamp2020Entities bootCamp2020 = new BootCamp2020Entities();
                var res = bootCamp2020.Employees;
                return View(res);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Rendering Partial View using RenderAction
        /// </summary>
        /// <returns>ActionResult</returns>
        public ActionResult ShowRenderAction()
        {
            return PartialView("ShowPartial_UsingRenderAction");
        }

        /// <summary>
        /// Edit the details of an employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResult</returns>

        [HttpGet]
        public ActionResult Edit(int id)
        {
            try
            {
                BootCamp2020Entities bootCamp2020 = new BootCamp2020Entities();
                var edit = bootCamp2020.TBL_Employees.Where(x => x.emp_id == id).FirstOrDefault();
                return View(edit);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Updating the editted value and binding specific fields
        /// </summary>
        /// <param name="tBL_Employees"></param>
        /// <returns>ActionResult</returns>
        [HttpPost]
        public ActionResult Edit([Bind(Include ="emp_id,emp_name,Emp_dob,manager_id,IsTrainer")]TBL_Employees tBL_Employees)
        {
            try
            {
                employee.EditData(tBL_Employees);
                return RedirectToAction("Index");
            }
            catch
            {
                throw;
            }
           
        }
    }
}