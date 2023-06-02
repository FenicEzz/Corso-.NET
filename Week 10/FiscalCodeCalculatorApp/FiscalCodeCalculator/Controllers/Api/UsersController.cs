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


        [HttpGet("allusers")]
        public async Task<ActionResult> GetAllUsers()
        {
            var users = await _context.Users.Select(x => new { x.Id, x.Name, x.FiscalCode }).OrderBy(x => x.Id).ToListAsync();

            return Ok(users);
        }


        [HttpGet("user/{id}")]
        public async Task<ActionResult> GetUser(long id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == id);

            if(user == null)
            {
                return BadRequest("Nessun utente con questo id!");
            }

            return Ok(user);
        }
    }
}
