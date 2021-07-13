using SyncAndAsyncTAsk.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SyncAndAsyncTAsk.Controllers
{
    public class EmployeeController : Controller
    { 
        AzuredbEntities db = new AzuredbEntities();
        // GET: Employee
        public async Task<ActionResult> Index()
        {
            var list = await db.Employees.ToListAsync();
            return View(list);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task< ActionResult> Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(emp);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}