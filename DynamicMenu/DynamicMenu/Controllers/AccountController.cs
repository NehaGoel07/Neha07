using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicMenu.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DynamicMenu.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        /// <summary>
        /// Logout signed in user
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Displays the view to register new user
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// Register new user
        /// </summary>
        /// <param name="register"></param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if(ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = register.Email, Email = register.Email };
                var result=await userManager.CreateAsync(user, register.Password);
                if(result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent:false);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(register);
        }

        /// <summary>
        /// Displays the view to log the user in
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Log the user in
        /// </summary>
        /// <param name="login"></param>
        /// <param name="returnUrl"></param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(login.Email,login.Password,isPersistent:false,false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View(login);
        }
    }
}