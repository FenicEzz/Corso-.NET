using System.ComponentModel.DataAnnotations;

namespace Mio.NetCore.Models
{
    public class Article
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Autore obbligatorio.")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Nome autore massimo 20 caratteri.")]
        [Display(Name = "Inserisci autore")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Titolo obbligatorio")]
        [StringLength(20, ErrorMessage = "Titolo massimo 20 caratteri.")]
        [Display(Name = "Inserisci titolo")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Descrizione obbligatoria")]
        [StringLength(1000, ErrorMessage = "Descrizione massimo 1000 caratteri.")]
        [Display(Name = "Inserisci descrizione")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Data obbligatoria")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
    }
}
