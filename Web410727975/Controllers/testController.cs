using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410727975.Controllers
{
    public class testController : Controller
    {
        // GET: testr
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HW1()
        {
            return View();
        }

        public ActionResult HW2() {
            return View();
        }
        public ActionResult HW3()
        {
            ViewBag.text = "Hello";
            return View();
        }

    }
}