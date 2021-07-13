﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Context;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        db_testEntities dbObj = new db_testEntities();
        // GET: Student
        public ActionResult Student()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(tbl_student model)
        {
            tbl_student obj = new tbl_student();
            obj.Name = model.Name;
            obj.Fname = model.Fname;
            obj.Email = model.Email;
            obj.Mobile = model.Mobile;
            obj.Description = model.Description;

            dbObj.tbl_student.Add(obj);
            dbObj.SaveChanges();
                
            return View("Student");
        }

    }
}