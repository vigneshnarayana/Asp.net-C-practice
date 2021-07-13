using StoreProcedure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreProcedure.Controllers
{
    public class DemoController : Controller
    {
        
        // GET: Demo
        
        public ActionResult Index()
        {
            AzuredbEntities db = new AzuredbEntities();
     
            return View(db.SelectDatetails().ToList());
        }
    }
}