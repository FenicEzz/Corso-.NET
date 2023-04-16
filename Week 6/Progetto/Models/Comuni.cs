using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Progetto.Models
{
    public class Comuni
    {
        [Display(Name = "Comune di nascita")]
        public string Denominazione { get; set; }
        public string Codice { get; set; }
    }
}