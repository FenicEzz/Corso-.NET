using Microsoft.AspNetCore.Mvc;
using Mio.NetCore.Models;
using Mio.NetCore.Services;
using System.Diagnostics;

namespace Mio.NetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBlogService _blogService;

        public HomeController(ILogger<HomeController> logger, IBlogService blogService)
        {
            _logger = logger;
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var articoli = _blogService.GetAllArticles().OrderBy(x => x.Author);

            //var one = new Article { Author = "abc", Id = 0, Description = "adsf", CreatedAt = DateTime.Now, Title = "dsfsdf" };
            //var two = new Article { Author = "abc", Id = 1, Description = "adsf", CreatedAt = DateTime.Now, Title = "dsfsdf" };
            //var three = new Article { Author = "abc", Id = 2, Description = "adsf", CreatedAt = DateTime.Now, Title = "dsfsdf" };
            //var four = new Article { Author = "abc", Id = 3, Description = "adsf", CreatedAt = DateTime.Now, Title = "dsfsdf" };

            return View(articoli);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}