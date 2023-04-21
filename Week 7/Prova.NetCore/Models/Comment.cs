namespace Prova.NetCore.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ArticleId { get; set; }
        public string Author { get; set; }
    }
}
