using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prova.NetCore.Models;
using Prova.NetCore.Services;

namespace Prova.NetCore.Controllers.Api
{
    [Route("api/[controller]")] // --> http://server:porta/api/blog
    [ApiController]
    public class BlogController : ControllerBase
    {
        private IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpGet("articles", Name = "GetAll")] // --> GET http://server:porta/api/blog/articles
        public IActionResult GetAll() 
        {
            var articles = _blogService.GetAllArticles();
            return Ok(articles);
        }

        [HttpPost("articles")] // --> POST http://server:porta/api/blog/articles
        public IActionResult PublishArticle(Article article)
        {
            if(ModelState.IsValid)
            {
                _blogService.PublishArticle(article);
                return Created(Url.RouteUrl("GetById", new { id = article.Id }), article);
            }

            return BadRequest("Errore nei dati");
        }

        [HttpGet("article/{id}")] // --> GET http://server.porta/api/blog/article/1
        public IActionResult GetArticle(int id)
        {
            var article = _blogService.GetArticle(id);
            return Ok(article);
        }
    }
}