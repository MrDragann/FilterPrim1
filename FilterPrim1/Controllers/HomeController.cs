using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterPrim1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideError")]
        public ActionResult Divide()
        {
            int a = 10, b = 0;
            int result = a / b;

            return Content(result.ToString());
        }
    }
}