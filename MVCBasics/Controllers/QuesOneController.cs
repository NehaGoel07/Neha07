using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics.Controllers
{
    public class QuesOneController : Controller
    {
        // GET: QuesOne
        public ActionResult Index()
        {
            return View();
        }
    }
}