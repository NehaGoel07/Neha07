using MVCArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCArchitecture.Controllers
{
    public class LoginController : Controller
    {
        
        public LoginController()
        {
            
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginUser()
        {
            return View();
        }

         //passing data in "details" from view to model

         [HttpPost]
        public ActionResult LoginUser(LoginDetails details)
        {
            //passing data from one controller to another
            return RedirectToAction("ShowList","Employee",details);
        }

    }
}