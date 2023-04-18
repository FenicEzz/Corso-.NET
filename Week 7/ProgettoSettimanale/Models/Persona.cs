using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProgettoSettimanale.Models
{
    public class Persona
    {
        [Required(ErrorMessage = "Il nome è obbligatorio")]
        [Display(Name = "Inserisci Nome")]      
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Il nome deve essere compreso tra 1 e 20 caratteri")]
        public string Nome { get; set; }

        [Display(Name = "Inserisci Cognome")]
        [Required(ErrorMessage = "Il cognome è obbligatorio")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Il cognome deve essere compreso tra 1 e 20 caratteri")]
        public string Cognome { get; set; }

        [Display(Name = "Inserisci Età")]
        [Required(ErrorMessage = "L'età è obbligatoria")]
        [Range(1, 80, ErrorMessage = "L'età deve essere compresa tra 1 e 80")]
        public int Età { get; set; }
    }
}