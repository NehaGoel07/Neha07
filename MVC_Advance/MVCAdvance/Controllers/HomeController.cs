using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using MVCAdvance.Models.Entity;
using MVCAdvance.Models.Repository;
using MVCAdvance.Models.Services;

namespace MVCAdvance.Controllers
{
    [HandleError(View= "_CustomError")]
    
    public class HomeController : Controller
    {
        readonly ILogin login;

        public HomeController()
        {
            login = new Models.Services.Login();   
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        
        public ActionResult LoginData()
        {
            return View();
        }

        /// <summary>
        /// Validating login credentials
        /// </summary>
        /// <param name="loginDetail"></param>
        /// <returns>ActionResult</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [OutputCache(Duration = 50)]
        public ActionResult LoginData(LoginDetail loginDetail)
        {
            if (ModelState.IsValid)
            {
                
                    var res = login.AuthenticateCreds(loginDetail);
                    if (res)
                    {
                        FormsAuthentication.SetAuthCookie(loginDetail.Username, false);
                    }
                    return RedirectToAction("Employees");
                
            }
            else
            {
                return View();
            }
        }

        /// <summary>
        /// Showing list of employees if logged in user is admin
        /// </summary>
        /// <returns>ActionResult</returns>

        [Authorize(Roles="admin")]
        public ActionResult Employees()
        {
            
                var data = login.ShowData();
                return View(data);
           
        }

        public ActionResult QuesFive()
        {
            return View();
        }

        public ActionResult ErrorAction()
        {
            throw new Exception("Unhandled");
        }




    }
}