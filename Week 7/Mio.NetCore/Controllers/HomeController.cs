using Microsoft.AspNetCore.Mvc;
using Mio.NetCore.Models;
using Mio.NetCore.Services;
using System.Diagnostics;

namespace Mio.NetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var service = new RetrieveData();
            var articoli = service.GetAllArticles();

            return View(articoli);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}