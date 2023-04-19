using Mio.NetCore.Models;

namespace Mio.NetCore.Services
{
    public interface IBlogService
    {
        void AddArticle(Article article);
        void RemoveArticle(int id);
        void UpdateArticle(Article article);
        IEnumerable<Article> GetAllArticles();
        Article GetArticle(int id);
    }
}
