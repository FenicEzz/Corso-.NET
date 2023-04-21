using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;

namespace Prova.NetCore.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Display(Name = "Titolo")]
        [Required(ErrorMessage = "Il titolo è obbligatorio.")]
        [StringLength(80, ErrorMessage = "Max 80 caratteri.")]
        public string Title { get; set; }

        [Display(Name = "Contenuto")]
        [Required(ErrorMessage = "Contenuto articolo obbligatorio.")]
        [StringLength(1024, ErrorMessage = "Max 1024 caratteri.")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string Author { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
