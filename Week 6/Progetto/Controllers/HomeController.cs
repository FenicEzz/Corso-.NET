﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Progetto.Models;
using Progetto.Services;

namespace Progetto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DatiUtente(ModelPersona model)
        {
            var servizio = new CalcolaCodiceFiscale();

            model.CF = servizio.CalcolaCF(model);

            return View(model);
        }
    }
}