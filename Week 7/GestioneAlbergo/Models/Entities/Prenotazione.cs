using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestioneAlbergo.Models.Entities
{
    public class Prenotazione
    {
        private List<string> _altriDettagli = new List<string> { "Mezza pensione", "Pensione completa", "Prima colazione" };

        public int IdPrenotazione { get; set; } 
        public DateTime DataPrenotazione { get; set; }
        public DateTime InizioSoggiorno { get; set; }
        public DateTime FineSoggiorno { get; set; }
        public decimal CaparraIniziale { get; set; }
        public decimal Tariffa { get; set; }
        public Camera Camera { get; set; }
        public Servizio Servizio { get; set; }
        public List<string> AltriDettagli { get {  return _altriDettagli; } }
    }
}