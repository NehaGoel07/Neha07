using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;


namespace ProjectAPI.Model.Repository.Class
{
    public class MyActionFilter : ActionFilterAttribute, IActionFilter
    {
        private readonly ILogger<MyActionFilter> _logger;
        public MyActionFilter(ILogger<MyActionFilter> logger)
        {
            _logger = logger;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.Write("Afte action execution");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {

            var controller = context.RouteData.Values["Controller"];
            var actionMethod = context.RouteData.Values["action"];
            var log = new LoggerConfiguration().WriteTo.File("Logs/actionExecuting.txt").CreateLogger();
            log.Information("Contoller:{0} Action Method:{1}", new[] { controller, actionMethod });
        }

    }
}
