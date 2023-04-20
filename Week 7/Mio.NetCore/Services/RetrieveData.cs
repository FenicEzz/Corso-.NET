using Elfie.Serialization;
using Microsoft.Data.SqlClient;
using Mio.NetCore.Models;

namespace Mio.NetCore.Services
{
    public class RetrieveData : IBlogService
    {
        private static string _connString = @"Data Source=localhost\sqlexpress;Initial Catalog=Esercizio3;Integrated Security=True;TrustServerCertificate=true";

        private static List<Article> _list = new List<Article>();
        public static List<Article> List { get { return _list; } }

        public void AddArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAllArticles()
        {
            var selectCommand = "SELECT * FROM ARTICOLI";
            var conn = new SqlConnection(_connString);
            var cmd = conn.CreateCommand();
            cmd.CommandText = selectCommand;

            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var article = new Article
                    {
                        Id = reader.GetInt32(0),
                        Author = reader.GetString(1),
                        Title = reader.GetString(2),
                        Description = reader.GetString(3),
                        CreatedAt = reader.GetDateTime(4),
                    };

                    _list.Add(article);                  
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return _list;
        }

        public Article GetArticle(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveArticle(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateArticle(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
