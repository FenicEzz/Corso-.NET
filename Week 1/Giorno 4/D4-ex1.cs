using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Giorno_4___ex1
{
    static class Utente
    {
        public static string Username { get; private set; }
        public static string Password { get; private set; }
        public static string ConfermaPassword { get; private set; }
        public static bool AuthOk { get; private set; }
        public static DateTime DataLogin { get; private set; }
        public static bool SeiUscito { get; private set; } = false;
        public static List<DateTime> ListaAccessi { get; private set; }

        public static void Login()
        {
            Console.WriteLine("Inserire username: ");
            string name = Console.ReadLine();
            Username = name;

            Console.WriteLine("Inserire password: ");
            string psw = Console.ReadLine();
            Password = psw;

            Console.WriteLine("Confermare password:");
            string confPsw = Console.ReadLine();

            if (confPsw == psw)
            {
                Console.WriteLine($"Benvenuto, {Username}!");
                AuthOk = true;
                DataLogin = DateTime.Now;

                try
                {
                    if (ListaAccessi == null)
                    {
                        ListaAccessi = new List<DateTime>();
                    }

                    ListaAccessi.Add(DataLogin);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Impossibile aggiungere l'ora alla lista!");
                    Console.WriteLine(e.StackTrace);
                }
            }
            else
            {
                Console.WriteLine("Le password non coincidono!");
            }
        }

        public static void Logout()
        {
            if (AuthOk)
            {
                Username = "";
                Password = "";
                ConfermaPassword = "";
                DataLogin = DateTime.MinValue;
                AuthOk = false;
                Console.WriteLine("Logout avvenuto!");
            }
            else
            {
                Console.WriteLine("Prima devi autenticarti!");
            }
        }

        public static void DataOraLogin()
        {
            if (AuthOk)
            {
                Console.WriteLine($"Ti sei autenticato in data: {DataLogin.ToString()}");
            }
            else
            {
                Console.WriteLine("Non sei autenticato!");
            }
        }

        public static void CronoListaAccessi()
        {
            if (ListaAccessi == null)
            {
                Console.WriteLine("La lista è vuota!");
            }
            else
            {
                foreach (DateTime crono in ListaAccessi)
                {
                    Console.WriteLine($"Login fatto il: {crono.ToString()}");
                }
            }
        }

        public static void Esci()
        {
            Console.WriteLine("Arrivederci!");
            SeiUscito = true;
        }
    }

    internal class Program
    {
        public static void Banner()
        {
            string[] opzioni = { "Login", "Logout", "Verifica ora e data di login", "Lista degli accessi", "Esci" };

            Console.WriteLine("\n===============OPERAZIONI==============");
            Console.WriteLine("Scegli l’operazione da effettuare:");
            for (int i = 0; i < opzioni.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {opzioni[i]}");
            }
            Console.WriteLine("========================================");
        }

        public static void Gestione()
        {
            Banner();
            string stringa = Console.ReadLine();
            int scelta = int.Parse(stringa);

            switch (scelta)
            {
                case 1:
                    Utente.Login();
                    break;
                case 2:
                    Utente.Logout();
                    break;
                case 3:
                    Utente.DataOraLogin();
                    break;
                case 4:
                    Utente.CronoListaAccessi();
                    break;
                case 5:
                    Utente.Esci();
                    break;
                default:
                    Console.WriteLine("Non è una scelta valida");
                    break;
            }
        }

        public static void App()
        {
            do
            {
                Gestione();
            } while (Utente.SeiUscito == false);
        }

        static void Main(string[] args)
        {
            App();
        }
    }
}