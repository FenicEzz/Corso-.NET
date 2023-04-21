using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Progetto.Models
{
    public class Comuni
    {
        [Display(Name = "Nome Comune")]
        public string Denominazione { get; set; }

        [Display(Name = "Codice Comune")]
        public string Codice { get; set; }
    }
}