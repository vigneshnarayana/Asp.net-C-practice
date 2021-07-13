
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dataBindingMVC.Controllers
{
    public class MVCWebGridController : Controller
    {
        // GET: MVCWebGrid
        public ActionResult Index()
        {

            AzuredbEntities db = new AzuredbEntities();

            return View(db.Emptables.ToList());
        }
        //[HttpGet]
        //public ActionResult GetStoreProcedure()
        //{

        //    AzuredbEntities db = new AzuredbEntities();

        //    return View(db.crudeemp(null,null,null,null, "select"));
        //}
        public ActionResult GetdataSp()
        {
            AzuredbEntities db = new AzuredbEntities();
            return View(db.crudeemp(null,null,null,null, "select").ToList());

        }
    }
}