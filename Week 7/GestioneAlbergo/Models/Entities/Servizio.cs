using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestioneAlbergo.Models.Entities
{
    public class Servizio
    {
        private List<string> _tipologia = new List<string> { "Colazione in camera", "Minibar", "Internet", "Letto aggiuntivo", "Culla"};

        public int IdServizio { get; set; }
        public List<string> Tipologia { get { return _tipologia; } }
        public int Prezzo { get; set; }
        public int Quantita { get; set; }
    }
}