using BusinessLayer;
using BusinessLayer.Interfaces;
using DataLayer;
using FiscalCodeCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FiscalCodeCalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FiscalCodeContext _ctx;
        private readonly ICalcolaCodiceFiscaleService _srvc;

        public HomeController(ILogger<HomeController> logger, FiscalCodeContext context, ICalcolaCodiceFiscaleService service)
        {
            _logger = logger;
            _ctx = context;
            _srvc = service;
        }

        public IActionResult Index()
        {
            var list = _ctx.Users.ToList();

            return View(list);
        }

        public IActionResult Form()
        {
            var c = _ctx.Cities.OrderBy(x => x.Name).ToList();
            ViewBag.Cities = c;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Form(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _ctx.Database.BeginTransaction();
                    user.FiscalCode = _srvc.CalculateCode(user);
                    _ctx.Users.Add(user);
                    await _ctx.Database.CommitTransactionAsync();
                    await _ctx.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    _ctx.Database.RollbackTransaction();
                    Console.WriteLine(ex.ToString());
                }
            }

            var c = _ctx.Cities.OrderBy(x => x.Name).ToList();
            ViewBag.Cities = c;

            return View(user);
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                _ctx.Database.BeginTransaction();
                var user = _ctx.Users.Single(x => x.Id == id);
                _ctx.Users.Remove(user);
                await _ctx.Database.CommitTransactionAsync();
                await _ctx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _ctx.Database.RollbackTransaction();
                Console.WriteLine(ex.ToString());
            }

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}