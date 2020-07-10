using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicMenu.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DynamicMenu.Controllers
{
    
    [ServiceFilter(typeof(RoleHandlerFilter))]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AdminController(RoleManager<IdentityRole> roleManager,UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        /// <summary>
        /// Displays the view to add new role
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        /// <summary>
        /// Create new role
        /// </summary>
        /// <param name="role"></param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel role)
        {
            if(ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = role.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);
                if(result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
            }
            
            return View(role);
        }

        /// <summary>
        /// List all the existing roles
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        /// <summary>
        /// Displays view to edit existing roles
        /// </summary>
        /// <param name="id"></param>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role=await roleManager.FindByIdAsync(id);
            var model = new EditRole
            {
                Id = role.Id,
                RoleName = role.Name
            };
            foreach(var user in userManager.Users)
            {
                if(await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }

        /// <summary>
        /// Edit existing roles
        /// </summary>
        /// <param name="editRole"></param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRole editRole)
        {
            var role = await roleManager.FindByIdAsync(editRole.Id);
            role.Name = editRole.RoleName;
            var result=await roleManager.UpdateAsync(role);
            if(result.Succeeded)
            {
                return RedirectToAction("ListRoles");
            }
            return View(editRole);
        }

        /// <summary>
        /// Displays the view to edit user's role
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public async Task<IActionResult> EditUserInRole(string roleId)
        {
            ViewBag.roleId = roleId;
            var role = await roleManager.FindByIdAsync(roleId);
            var model = new List<UserRoleViewModel>();
            foreach(var user in userManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };
                if(await userManager.IsInRoleAsync(user,role.Name))
                {
                    userRoleViewModel.IsSelected = true;
                }
                else
                {
                    userRoleViewModel.IsSelected = false;
                }
                model.Add(userRoleViewModel);
            }
            return View(model);
        }

        /// <summary>
        /// Edit user's role
        /// </summary>
        /// <param name="model"></param>
        /// <param name="roleId"></param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public async Task<IActionResult> EditUserInRole(List<UserRoleViewModel> model,string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);
            for(int i=0;i<model.Count;i++)
            {
                var user=await userManager.FindByIdAsync(model[i].UserId);
                IdentityResult result = null;
                if(model[i].IsSelected && !(await userManager.IsInRoleAsync(user,role.Name)))
                {
                    result=await userManager.AddToRoleAsync(user, role.Name);
                }
                else if(!model[i].IsSelected && (await userManager.IsInRoleAsync(user, role.Name)))
                {
                    await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }
                if(result.Succeeded)
                {
                    if (i < model.Count - 1)
                        continue;
                    else
                        return RedirectToAction("EditRole", new { Id = roleId });
                }
            }
            return RedirectToAction("EditRole", new { Id = roleId });
        }
    }
}