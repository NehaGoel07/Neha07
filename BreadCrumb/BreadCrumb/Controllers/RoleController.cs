using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BreadCrumb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BreadCrumb.Controllers
{
    public class RoleController : Controller
    {
        private readonly IEmployee _employee;
        private readonly SignInManager<IdentityUser> _signInManager;

        public RoleController(IEmployee employee,SignInManager<IdentityUser> signInManager)
        {
            _employee = employee;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username,string password)
        {
            var validUser = _employee.Authenticate(username,password);
            var user = new IdentityUser { UserName = validUser.UserName };
            _signInManager.SignInAsync(user, isPersistent: false);
            return Ok(user);
        }
    }
}