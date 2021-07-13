using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajax_Calling_for_binding_dropdown_using_SP.Models;

namespace Ajax_Calling_for_binding_dropdown_using_SP.Controllers
{
    public class CasController : Controller
    {
        // GET: Cas
        public ActionResult Index()
        {
            AzuredbEntities db = new AzuredbEntities();
            ViewBag.ContriesList = new SelectList(GetContriesList(), "Cid", "Cname");
            return View();
        }
        public List<Contry> GetContriesList()
        {
            AzuredbEntities db = new AzuredbEntities();
            List<Contry> contries = db.Contries.ToList();
            return contries;
        }

        public ActionResult GetStateList(int Cid)
        {
            AzuredbEntities db = new AzuredbEntities();
            List<State> states = db.States.Where(x=>x.Cid==Cid).ToList();
            ViewBag.StateList = new SelectList(states, "Sid", "Sname");
            return PartialView("DisplayStates");
        }

        public ActionResult GetCityList(String sid) 
        {
            AzuredbEntities db = new AzuredbEntities();
            List<City> cities = db.Cities.Where(x => x.Sid == sid).ToList();
            ViewBag.cityList = new SelectList(cities, "Cityid", "CityName");
            return PartialView("DisplayCity");
        }
    }
}