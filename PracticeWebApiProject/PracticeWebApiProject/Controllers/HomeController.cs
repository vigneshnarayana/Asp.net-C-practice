using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeWebApiProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult CreatePage()
        {
            ViewBag.Data = "Create Page";
            ViewData["Data"]= "Create Page";
            return View();
        }
    }
}
