using Progetto.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Progetto.Services
{
    public class OttieniComuni
    {
        public IList<Comuni> CaricaComuni()
        {
            var comuni = new List<Comuni>();
            var connString = @"Data Source=localhost\sqlexpress;Initial Catalog=Esercizio1;Integrated Security=True";
            var query = "SELECT Denominazione, Codice_Catastale FROM ComuniItaliani ORDER BY Denominazione";
            var conn = new SqlConnection(connString);
            var cmd = conn.CreateCommand();
            cmd.CommandText = query;
            conn.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var comune = new Comuni
                {
                    Denominazione = reader.GetString(0),
                    Codice = reader.GetString(1),
                };
                comuni.Add(comune);
            }
            conn.Close();

            return comuni;
        }
    }
}