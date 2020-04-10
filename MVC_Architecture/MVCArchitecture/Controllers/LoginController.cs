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
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginUser()
        {
            return View();
        }


        /// <summary>
        ///passing data in "details" from view to model 
        /// </summary>
        /// <param name="details"></param>
        /// <returns>ActionResult</returns>

        [HttpPost]
        public ActionResult LoginUser(LoginDetails details)
        {
            //passing data from one controller to another
            return RedirectToAction("ShowList","Employee",details);
        }

    }
}