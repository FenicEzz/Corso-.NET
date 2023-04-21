using Microsoft.AspNetCore.Mvc;
using Prova.NetCore.Models;
using Prova.NetCore.Services;
using System.Diagnostics;

namespace Prova.NetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBlogService _blogService;

        public HomeController(ILogger<HomeController> logger, IBlogService service)
        {
            _logger = logger;
            _blogService = service;
        }

        public IActionResult Index()
        {
            var articles = _blogService.GetAllArticles().OrderByDescending(a => a.CreatedAt);
            return View(articles);
        }

        public IActionResult AddArticle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateArticle(Article article) 
        {
            if(ModelState.IsValid)
            {
                _blogService.PublishArticle(article);
                return RedirectToAction("Index");
            }

            return View("AddArticle", article);
        }

        public IActionResult ViewArticle(int id)
        {
            var article = _blogService.GetArticle(id);
            return View(article);
        }

        public IActionResult List()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}