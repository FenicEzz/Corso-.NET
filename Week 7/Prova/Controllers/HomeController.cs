using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prova.Models;

namespace Prova.Controllers
{
    public class HomeController : Controller
    {
        private static List<Persona> lista = new List<Persona>();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexLista()
        {
            var model = lista.OrderBy(x => x.FirstName);
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Persona model)
        {
            if(ModelState.IsValid)
            {
                lista.Add(model);
                return RedirectToAction("IndexLista");
            }

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