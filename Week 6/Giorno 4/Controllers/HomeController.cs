using Giorno_4.Models;
using Giorno_4.Models.ViewModels;
using Giorno_4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Giorno_4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult ListaContatti()
        {
            var servizio = new ContattiService();
            var contatti = servizio.CaricaContatti();

            var model = new ContattiModel
            {
                Contacts = contatti
            };

            return View(model);
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