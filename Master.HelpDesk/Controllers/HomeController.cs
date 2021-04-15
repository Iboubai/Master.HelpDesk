using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Master.HelpDesk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var proxy = new Proxy();
            //proxy.GetPersonne(1);
            return View();
        }

    }
}