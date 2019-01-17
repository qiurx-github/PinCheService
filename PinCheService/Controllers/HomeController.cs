using LS.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PinCheService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var a = new Class1().GetStr();
            ViewBag.Message = a;

            return View();
        }

        public ActionResult Contact()
        {
            var a = new Class1().GetStr();
            ViewBag.Message = a;

            return View();
        }
    }
}