using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using FiscalCodeCalculator.Data;

namespace FiscalCodeCalculator.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly FiscalCodeContext _context;

        public CitiesController(FiscalCodeContext context)
        {
            _context = context;
        }

        // GET: api/Cities/5
        [HttpGet("{pr}")]
        public async Task<ActionResult<City>> GetCitiesByProvince(string pr)
        {
            var cities = await _context.Cities.Where(x => x.Province == pr).ToListAsync();

            if (cities == null)
            {
                return BadRequest("Questa provincia non esiste!");
            }

            return Ok(cities);
        }
    }
}