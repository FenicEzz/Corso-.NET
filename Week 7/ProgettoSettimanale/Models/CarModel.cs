using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProgettoSettimanale.Models
{
    public class CarModel
    {
        [Display(Name = "Marca della macchina")]
        [Required(ErrorMessage = "La marca della macchina è obbligatoria")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Numero caratteri per la macchina compreso tra 2 e 20")]
        public string Marca { get; set; }

        [Display(Name = "Modello della macchina")]
        [Required(ErrorMessage = "Il modello della macchina è obbligatorio")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Numero caratteri per il modello compreso tra 1 e 20")]
        public string Modello { get; set; }

        [Display(Name = "Anno di produzione della macchina")]
        [Required(ErrorMessage = "L'anno di produzione è obbligatorio")]
        [Range(1900, 2100, ErrorMessage = "Anno di produzione compreso tra 1900 e 2100")]
        public int Anno { get; set; }
    }
}