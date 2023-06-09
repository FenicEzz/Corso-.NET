﻿using Giorno_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Giorno_5.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult CalcoloCodiceFiscale(PersonalDataViewModel model)
        {
            return View(model);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}