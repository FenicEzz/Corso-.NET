using Giorno_4.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Giorno_4.Services
{
    public class ContattiService
    {
        public IEnumerable<Contatti> CaricaContatti()
        {
            IList<Contatti> contacts = new List<Contatti>();
            var connString = @"DataSource=localhost\sqlexpress;InitialCatalog=Esercizio2;IntegratedSecurity=True";
            var select = "SELECT Nome, Cognome, Numero_Telefono, Email FROM ELENCO_TELEFONICO";
            var conn = new SqlConnection(connString);
            var cmd = conn.CreateCommand();
            cmd.CommandText = select;
            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var contatto = new Contatti
                    {
                        Nome = reader.GetString(0),
                        Cognome = reader.GetString(1),
                        NumeroTelefono = reader.GetString(2),
                        Email = reader.GetString(3),
                    };
                    contacts.Add(contatto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return contacts;
        }
    }
}