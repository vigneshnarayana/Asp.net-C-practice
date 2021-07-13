using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoPracticeMVC.Models;

namespace DemoPracticeMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Customer c = new Customer();
            var data = c.GetAllCustomers();


            return View(data);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            Customer c = new Customer();
            var data = c.GetCustomerById(id);
            return View(data);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                Customer c = new Customer();
                c.Name = collection["Name"];
                c.Contry = collection["Contry"];
                c.AddCustomer();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            Customer c = new Customer();
            var data = c.GetCustomerById(id);
            return View(data);
           
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Customer c = new Customer();
                c.Name = collection["Name"];
                c.Contry = collection["Contry"];
                c.Id = id;
                c.UpdateCustomer();
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            Customer c = new Customer();
            var data = c.GetCustomerById(id);
            return View(data);
           
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Customer c = new Customer();
                c.Id = id;
                c.DeleteCustomer();
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
