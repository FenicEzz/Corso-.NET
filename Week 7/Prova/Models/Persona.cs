using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prova.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Nome obbligatorio")]
        [Display(Name = "Inserisci nome")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Lunghezza compresa tra 1 e 50 caratteri")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Cognome obbligatorio")]
        [Display(Name = "Inserisci cognome")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Lunghezza compresa tra 1 e 50 caratteri")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Età obbligatoria")]
        [Range(1, 80, ErrorMessage = "Età compresa tra 1 e 80 anni")]
        [Display(Name = "Inserisci nome")]
        public int Age { get; set; }
    }
}