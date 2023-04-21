using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestioneAlbergo.Models.Entities
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "Nome obbligatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Cognome obbligatorio")]
        public string Cognome { get; set; }

        [Required(ErrorMessage = "Email obbligatoria")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Codice Fiscale obbligatorio")]
        [RegularExpression(@"^[a-zA-Z]{6}\d{2}[a-zA-Z]\d{2}[a-zA-Z]\d{3}[a-zA-Z]$")]
        public string CodiceFiscale { get; set; }
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Cellulare obbligatorio")]
        public string Cellulare { get; set; }

        [Required(ErrorMessage = "Città obbligatoria")]
        public string Citta { get; set; }

        [Required(ErrorMessage = "Provincia obbligatoria")]
        public string Provincia { get; set; }
    }
}