using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using FiscalCodeCalculator.Data;

namespace FiscalCodeCalculator.Controllers
{
    public class CityController : Controller
    {
        private readonly FiscalCodeContext _context;


        public CityController(FiscalCodeContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var cities = await _context.Cities.OrderBy(x => x.Name).ToListAsync();

            return View(cities);
        }


        public async Task<IActionResult> Details(long id)
        {

            var city = await _context.Cities.SingleAsync(m => m.Id == id);

            return View(city);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CityCode,Province")] City city)
        {
            if (ModelState.IsValid)
            {
                _context.Add(city);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(city);
        }


        public async Task<IActionResult> Edit(long id)
        {
            var city = await _context.Cities.FindAsync(id);

            return View(city);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Name,CityCode,Province")] City city)
        {
            if (ModelState.IsValid)
            {
                _context.Update(city);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(city);
        }


        public async Task<IActionResult> Delete(long id)
        {
            var city = await _context.Cities.SingleAsync(m => m.Id == id);

            return View(city);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var city = await _context.Cities.FindAsync(id);
            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
