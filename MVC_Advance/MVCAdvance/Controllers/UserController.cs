using MVCAdvance.Models;
using MVCAdvance.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAdvance.Controllers
{
    [CustomException]
    [RoutePrefix("User")]
    public class UserController : Controller
    {
        // GET: User
        
        readonly ILogin login;
        public UserController()
        {
            login = new Models.Services.Login();
        }
        /// <summary>
        /// Dispay list of all employees
        /// </summary>
        /// <returns>ActionResult</returns>
       
        public ActionResult Index()
        {
           
                var data = login.Show();
                return View(data);

        }

        /// <summary>
        /// Displaying details of particular employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResult</returns>

        [Route("{id}/Details")]
        [Route("{id}")]
        
        public ActionResult Details(int id) 
        {
           
                var detail = login.Detail(id);
                return View(detail);
           
        }

        /// <summary>
        /// Using order property for the execution of filter
        /// </summary>
        /// <returns>ActionResult</returns>

        [FilterA(Order = 2)]
        [FilterB(Order = 1)]
        [Route("Action")]
        public ActionResult Action ()
        {
            return View();
        }

        
        
    }
}