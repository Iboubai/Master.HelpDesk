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

        public ActionResult Tickets()
        {
            return View();
        }
        
        public ActionResult Applications()
        {
            return View();
        }
        
        public ActionResult Configuration()
        {
            return View();
        }
    }
}