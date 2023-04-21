using Prova.NetCore.Models;

namespace Prova.NetCore.Services
{
    public class MemoryBlogService : IBlogService
    {
        //QUESTA CLASSE DEVE IMPLEMENTARE TUTTI I METODI DELL'INTERFACCIA

        private static List<Article> _articles = new List<Article>()
        {
            new Article{Author = "Nello", CreatedAt=DateTime.Now, Description = "Contenuto dell'articolo 1", Title = "Titolo 1", Id = 1},
            new Article{Author = "Rick", CreatedAt=DateTime.Now, Description = "Contenuto dell'articolo 2", Title = "Titolo 2", Id = 2},
            new Article{Author = "Fab", CreatedAt=DateTime.Now, Description = "Contenuto dell'articolo 3", Title = "Titolo 3", Id = 3},
            new Article{Author = "Matt", CreatedAt=DateTime.Now, Description = "Contenuto dell'articolo 4", Title = "Titolo 4", Id = 4},
            new Article{Author = "Mark", CreatedAt=DateTime.Now, Description = "Contenuto dell'articolo 5", Title = "Titolo 5", Id = 5}
        };

        private static int id = _articles
            .Select(x => x.Id)
            .DefaultIfEmpty(0)
            .Max() + 1;

        public void AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void DeleteArticle(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(int id)
        {
            throw new NotImplementedException();
        }

        public void EditArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAllArticles() => _articles/*.AsEnumerable()*/; //SHORTCUT PER METODO 

        public Article GetArticle(int id) => _articles.Single(a => a.Id == id);

        public void PublishArticle(Article article)
        {
            article.CreatedAt = DateTime.Now;
            article.Id = id;
            article.Author = "Bob";
            _articles.Add(article);
            id++;
        }
    }
}
