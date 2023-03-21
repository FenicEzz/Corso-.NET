namespace Progetto_Week_1
{
    class Contribuente
    {
        // PROPRIETA' (in formato field-property dove necessario)
        public string Nome
        {
            get;
            private set;
        }
        public string Cognome { get; private set; }
        public string DataNascita { get; private set; }
        public string CodiceFiscale { get; private set; }
        public char Sesso { get; private set; }
        public string ComuneResidenza { get; private set; }
        public decimal RedditoAnnuale { get; private set; }

        // METODI
        public decimal CalcoloAliquota() // Calcolo Aliquota
        {
            if (RedditoAnnuale > 0 && RedditoAnnuale <= 15000)
            {
                return RedditoAnnuale * 23 / 100;
            }
            else if (RedditoAnnuale > 15000 && RedditoAnnuale <= 28000)
            {
                return 3450 + (RedditoAnnuale - 15000) * 27 / 100;
            }
            else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
            {
                return 6960 + (RedditoAnnuale - 28000) * 38 / 100;
            }
            else if (RedditoAnnuale > 55000 && RedditoAnnuale <= 75000)
            {
                return 17220 + (RedditoAnnuale - 55000) * 41 / 100;
            }
            else
            {
                return 25420 + (RedditoAnnuale - 75000) * 43 / 100; ;
            }
        }

        public void Presentati() // Metodo di presentazione e assegnazione proprietà
        {
            //Domande per impostare le proprietà
            Console.WriteLine("\nCome ti chiami?");
            string nome = Console.ReadLine();
            Nome = nome;

            Console.WriteLine("\nQual è il tuo cognome?");
            string cognome = Console.ReadLine();
            Cognome = cognome;

            Console.WriteLine("\nQuando sei nato? DD-MM-YYYY");
            string birth = Console.ReadLine();
            DataNascita = birth;

            Console.WriteLine("\nQual è il tuo codice fiscale?");
            string cf = Console.ReadLine();
            CodiceFiscale = cf;

            Console.WriteLine("\nInserire sesso: M / F");
            string gender1 = Console.ReadLine();
            char gender2 = char.Parse(gender1);
            Sesso = gender2;

            Console.WriteLine("\nQual è il tuo comune di residenza?");
            string comune = Console.ReadLine();
            ComuneResidenza = comune;

            Console.WriteLine("\nQual è il tuo reddito annuale?");
            string reddito1 = Console.ReadLine();

            while (Convert.ToDecimal(reddito1) <= 0)
            {
                Console.WriteLine("\nImpossibile avere reddito negativo! Inserire un valore idoneo:");
                reddito1 = Console.ReadLine();
            }

            Console.WriteLine(" ");
            decimal reddito2 = decimal.Parse(reddito1);
            RedditoAnnuale = reddito2;


            Console.WriteLine("\n==================================================");
            Console.WriteLine("CALCOLO DELL’IMPOSTA DA VERSARE:\n");
            Console.WriteLine($"Contribuente: {Nome} {Cognome},");
            Console.WriteLine($"nato il {DataNascita} ({Sesso}),");
            Console.WriteLine($"residente in {ComuneResidenza},");
            Console.WriteLine($"codice fiscale: {CodiceFiscale.ToUpper()}\n");
            Console.WriteLine($"Reddito dichiarato: Euro {RedditoAnnuale}\n");
            Console.WriteLine($"IMPOSTA DA VERSARE: Euro {CalcoloAliquota()}");
        }
    }
    internal class ProgettoWeek1
    {
        public static void App()
        {
            Contribuente utente = new Contribuente();
            utente.Presentati();
        }

        static void Main(string[] args)
        {
            App();
        }
    }
}