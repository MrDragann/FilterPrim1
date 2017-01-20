﻿using System;
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
        public ActionResult Divide(Data model)
        {
            //int a = 10, b = 2;
            int result = model.a / model.b;

            return Content(result.ToString());
        }

        public class Data
        {
            public int a { get; set; }
            public int b { get; set; }
        }
    }
}