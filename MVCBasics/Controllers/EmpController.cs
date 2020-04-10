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

        // GET: Emp
        public ActionResult Index()
        {
             var data=EmpData();
            return View(data);
        }

        [NonAction]
        public List<TBL_Employees> EmpData()
        {
            var res = employee.Data();
            return res;
        }

        [HttpGet]
        public ActionResult CallChild()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Child()
        {
            BootCamp2020Entities bootCamp2020 = new BootCamp2020Entities();
            var res = bootCamp2020.Employees;
            return View(res);
        }

        public ActionResult ShowRenderAction()
        {
            return PartialView("ShowPartial_UsingRenderAction");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            BootCamp2020Entities bootCamp2020 = new BootCamp2020Entities();
            var edit = bootCamp2020.TBL_Employees.Where(x => x.emp_id == id).FirstOrDefault();
            return View(edit);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include ="emp_id,emp_name,Emp_dob,manager_id,IsTrainer")]TBL_Employees tBL_Employees)
        {
            employee.EditData(tBL_Employees);
            return RedirectToAction("Index");
           
        }
    }
}