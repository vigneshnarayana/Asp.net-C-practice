using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookiesandSessionASP.net_MVc.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Log()
        {
            Session.Remove("user");
            return View("Index");
        }
        [HttpPost]
        public ActionResult Index(string userTxt, string passWordTxt)
        {

            if (userTxt == "viki" && passWordTxt == "123")
            {//////////Cookies
                //HttpCookie kt1 = new HttpCookie("user","Ali");
                //kt1.Expires = DateTime.Now.AddSeconds(30);
                //Response.Cookies.Add(kt1);


                ///////session/////////
                ///
                Session["user"] = "Ali Raza";
                /////
                ///
                TempData["user"] = "vignesh";
                //HttpContext.Application["user"] = 12;
                //var abc = HttpContext.Application["user"];
                return RedirectToAction("Index", "Demo");
            }
            else
            {
                return View();
            }

        }
    }

}