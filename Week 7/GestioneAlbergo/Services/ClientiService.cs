using GestioneAlbergo.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GestioneAlbergo.Services
{
    public class ClientiService
    {
        private string _connString = @"Data Source=localhost\sqlexpress;Initial Catalog = GestioneAlbergo; Integrated Security = True;";
        private string _selectQuery = "SELECT * FROM Cliente";
        private string _insertQuery = "INSERT INTO Cliente (Nome, Cognome, Email, CodiceFiscale, Telefono, Cellulare, Citta, Provincia) VALUES (@Nome, @Cognome, @Email, @CodiceFiscale, @Telefono, @Cellulare, @Citta, @Provincia)";
        private string _deleteQuery = "DELETE FROM Cliente WHERE IdCliente = @id";
        private List<Cliente> _listaClienti = new List<Cliente>();

        public List<Cliente> ListaClienti { get { return _listaClienti; } }

        public List<Cliente> GetAll()
        {
            var conn = new SqlConnection(_connString);
            var cmd = conn.CreateCommand();
            cmd.CommandText = _selectQuery;

            try
            {
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var customer = new Cliente
                    {
                        IdCliente = reader.GetInt32(0),
                        Nome = reader.GetString(1),
                        Cognome = reader.GetString(2),
                        Email = reader.GetString(3),
                        CodiceFiscale = reader.GetString(4),
                        Telefono = reader[5] is DBNull ? "//" : reader.GetString(5),
                        Cellulare = reader.GetString(6),
                        Citta = reader.GetString(7),
                        Provincia = reader.GetString(8)
                    };

                    _listaClienti.Add(customer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return _listaClienti;
        }

        public void AggiungiCliente(Cliente cliente)
        {
            var conn = new SqlConnection(_connString);
            var cmd = conn.CreateCommand();
            cmd.CommandText = _insertQuery;

            cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@Cognome", cliente.Cognome);
            cmd.Parameters.AddWithValue("@Email", cliente.Email);
            cmd.Parameters.AddWithValue("@CodiceFiscale", cliente.CodiceFiscale);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Cellulare", cliente.Cellulare);
            cmd.Parameters.AddWithValue("@Citta", cliente.Citta);
            cmd.Parameters.AddWithValue("@Provincia", cliente.Provincia);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                _listaClienti.Add(cliente);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void EliminaCliente(int id)
        {
            var conn = new SqlConnection(_connString);
            var cmd = conn.CreateCommand();
            cmd.CommandText = _deleteQuery;

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                var cliente = _listaClienti.FirstOrDefault(c => c.IdCliente == id);
                cmd.ExecuteNonQuery();   
                if (cliente != null)
                {
                    _listaClienti.Remove(cliente);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}