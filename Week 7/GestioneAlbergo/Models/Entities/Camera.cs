using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestioneAlbergo.Models.Entities
{
    public class Camera
    {
        public int IdCamera { get; set; }
        public string Descrizione { get; set; }
        public string Tipologia { get; set; }
        public Cliente Cliente { get; set; }
    }
}