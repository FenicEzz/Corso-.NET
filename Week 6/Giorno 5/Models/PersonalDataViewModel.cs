using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Giorno_5.Models
{
    public class PersonalDataViewModel
    {
        // DISPLAY SERVE A MOSTRARE IL DATO IN MANIERA DIVERSA
        // DATATYPE GESTISCE IL TIPO DI DATO DENTRO IL FORM

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Cognome")]
        public string Cognome { get; set; }

        [Display(Name = "Data di Nascita")]
        [DataType(DataType.Date)]
        public DateTime DataNascita { get; set; }

        [Display(Name = "Comune di Nascita")]
        public string Istat { get; set; }

        [Display(Name = "Sesso")]
        public char Sesso { get; set; }
    }
}