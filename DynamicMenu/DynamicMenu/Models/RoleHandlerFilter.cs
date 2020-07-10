using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DynamicMenu.Models
{
    public class RoleHandlerFilter : ActionFilterAttribute,IActionFilter
    {
        private readonly ApplicationContext _context;
        private readonly IMenuMasterService menu;
       

        public RoleHandlerFilter(ApplicationContext _context,IMenuMasterService menu)
        {
            this._context = _context;
            this.menu = menu;
        }

        public  override void OnActionExecuting(ActionExecutingContext Context )
        {
            int flag = 0;
            var user = Context.HttpContext.User;
            var userName = user.Identity.Name.ToString();
            var userId = _context.Users.Where(x => x.UserName == userName).Select(x => x.Id).FirstOrDefault().ToString();
            var roleId = _context.UserRoles.Where(x => x.UserId == userId).Select(x => x.RoleId).FirstOrDefault();
            var userRole = _context.Roles.Where(x => x.Id.Equals(roleId)).Select(x => x.Name).FirstOrDefault().ToString();
            var controllerName = Context.RouteData.Values["Controller"];
            var actionName = Context.RouteData.Values["action"];
            var menuItems = menu.GetMenuMaster(userRole, userName).ToArray();
            foreach (var links in menuItems)
            {
                var ctr = (_context.MenuMaster.Where(x => x.User_Roll == userRole && x.MenuURL == links.MenuURL).Select(x => x.MenuURL).FirstOrDefault()).ToString();
                var actn = (_context.MenuMaster.Where(x => x.User_Roll == userRole && x.MenuFileName == links.MenuFileName).Select(x => x.MenuFileName).FirstOrDefault()).ToString();
                if (ctr.Equals(controllerName) && actn.Equals(actionName))
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Context.HttpContext.Response.Redirect("/Home/AccessDenied");
            }
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.Write("Afte action execution");
        }

    }
}
