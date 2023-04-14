using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Giorno_4.Models
{
    public class Contatti
    {
        public string Nome { get; set; }
        public string Cognome { get;set; }
        public string NumeroTelefono { get; set; }
        public string Email { get; set; }
        public override bool Equals(object obj) => obj is Contatti && obj.GetHashCode() == GetHashCode();
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}