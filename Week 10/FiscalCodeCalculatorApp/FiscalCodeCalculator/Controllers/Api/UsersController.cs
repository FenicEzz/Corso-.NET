using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLayer;
using FiscalCodeCalculator.Data;
using NuGet.Protocol;
using Microsoft.DotNet.MSIdentity.Shared;
using Newtonsoft.Json.Schema;
using BusinessLayer.Interfaces;
using System.Web.Helpers;
//using System.Web.Mvc;

namespace FiscalCodeCalculator.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly FiscalCodeContext _context;
        private readonly ICalcolaCodiceFiscaleService _service;

        public UsersController(FiscalCodeContext context, ICalcolaCodiceFiscaleService service)
        {
            _context = context;
            _service = service;
        }


        // POST: api/Api
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost()]
        public ActionResult GetUserFiscalCode(User user)
        {
            if (ModelState.IsValid)
            {
                var cf = _service.CalculateCode(user).ToJson();

                return Ok(cf);
            }

            return BadRequest("Errore nei dati");
        }
    }
}
