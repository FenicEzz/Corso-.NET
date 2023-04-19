using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProgettoSettimanale.Models;

namespace ProgettoSettimanale.Controllers
{
    public class ListaController : Controller
    {
        private static List<CarModel> cars = new List<CarModel>();
        // GET: Lista

        public ActionResult Index()
        {
            var model = cars.OrderBy(x => x.Marca);
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarModel model)
        {
            if (ModelState.IsValid)
            {
                cars.Add(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}