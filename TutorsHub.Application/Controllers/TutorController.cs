﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TutorsHub.Application.Controllers
{
    public class TutorController : Controller
    {
        
        [HttpGet]
        public ActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SearchUser(int id)
        {
            
            return View();
        }
        [HttpGet]
        public ActionResult EditProfile(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditProfile(int id, FormCollection collection)
        {
            try
            {

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult StudentList(int id)
        {
            return View();
        }
        [HttpGet]
        public ActionResult ViewProfile(int id)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Timer()
        {

            return View();
        }
    }
}