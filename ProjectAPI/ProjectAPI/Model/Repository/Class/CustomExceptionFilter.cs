using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ProjectAPI.Model.Repository.Class
{
    public class CustomExceptionFilter : ActionFilterAttribute,IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var statusCode = context.Exception.Message;
            Debug.Write(statusCode);
        }
    }
}
