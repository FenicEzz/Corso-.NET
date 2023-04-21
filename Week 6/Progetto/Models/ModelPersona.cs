using Progetto.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Progetto.Models
{
    public class ModelPersona
    {
        public string Nome { get; set; }
        public string Cognome { get; set;}

        [Display(Name = "Data di nascita")]
        [DataType(DataType.Date)]
        public DateTime DataNascita { get; set;}
        public Comuni Comune { get; set;}
        public char Sesso { get; set;}
        public string CF { get; set;}
    }
}