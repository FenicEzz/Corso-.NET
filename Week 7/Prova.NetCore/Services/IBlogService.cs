using Prova.NetCore.Models;

namespace Prova.NetCore.Services
{
    public interface IBlogService
    {
        //ELENCO OPERAZIONI DISPONIBILI NELL'APPLICAZIONE
        void PublishArticle(Article article);
        void EditArticle(Article article);
        void DeleteArticle(int id);
        IEnumerable<Article> GetAllArticles();
        Article GetArticle(int id);
        void AddComment(Comment comment);
        void DeleteComment(int id);
    }
}
