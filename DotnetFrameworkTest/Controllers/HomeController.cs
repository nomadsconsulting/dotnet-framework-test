using System;
using System.Web.Mvc;

namespace DotnetFrameworkTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            throw new Exception("Hello World");

            return View();
        }
    }
}
