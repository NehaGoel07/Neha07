using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAdvance.Models
{
    public class CustomException: ActionFilterAttribute,IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.Result = new ViewResult()
            {
                ViewName = "_Error"
            };
            filterContext.ExceptionHandled = true;
        
        }

        
    }
}