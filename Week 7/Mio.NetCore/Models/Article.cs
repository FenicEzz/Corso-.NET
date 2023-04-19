using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace Mio.NetCore.Models
{
    public class Article
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Nome autore massimo 20 caratteri.")]
        public string Author { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}