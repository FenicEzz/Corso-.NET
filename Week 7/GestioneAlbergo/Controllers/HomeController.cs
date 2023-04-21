using GestioneAlbergo.Models.Entities;
using GestioneAlbergo.Services;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestioneAlbergo.Controllers
{
    public class HomeController : Controller
    {
        private ClientiService _clientiService = new ClientiService();

        public ActionResult Index()
        {
            var clienti = _clientiService.GetAll();

            return View(clienti);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Exclude = "IdCliente")]Cliente cliente)
        {
            if(ModelState.IsValid)
            {
                _clientiService.AggiungiCliente(cliente);
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public ActionResult Delete(int id)
        {
            var lista = _clientiService.GetAll();
            var model = lista.First(m => m.IdCliente == id);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Cliente utente)
        {
            if (ModelState.IsValid)
            {
                _clientiService.EliminaCliente(utente.IdCliente);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Delete");
        }
    }
}