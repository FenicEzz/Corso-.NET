using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Progetto.Models
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set;}

        [Display(Name = "Data di nascita")]
        [DataType(DataType.Date)]
        public DateTime DataNascita { get; set;}

        [Display(Name = "Comune di nascita")]
        public string NomeComune { get; set;}
    }
}