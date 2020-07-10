using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicMenu.Models
{
    public class RoleRequirement :IAuthorizationRequirement
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public RoleRequirement(string controllerName,string actionName)
        {
            ControllerName = controllerName;
            ActionName = actionName;
        }
    }
}
