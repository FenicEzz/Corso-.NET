namespace Giorno_2___Secondo_Esercizio
{

    
    internal class Program
    {
        class Persona
        {
            public string Nome { get; set; }
            public string Cognome { get; set;}
            public int Eta { get; set;}

            public void GetNome()
            {
                Console.WriteLine($"{Nome}.");
            }

            public void GetCognome()
            {
                Console.WriteLine($"{Cognome}.");
            }

            public void GetEta()
            {
                Console.WriteLine($"{Eta}.");
            }

            public void GetDettagli()
            {
                Console.WriteLine($"Mi chiamo {Nome} {Cognome} ed ho {Eta} anni.");
            }

        }

        
        static void Main(string[] args)
        {
            Persona rick = new Persona();
            rick.Nome = "Riccardo";
            rick.Cognome = "Serino";
            rick.Eta = 29;
            rick.GetNome();
            rick.GetCognome();
            rick.GetEta();
            rick.GetDettagli();

            Persona tizio = new Persona();
            tizio.Nome = "Tizio";
            tizio.Cognome = "Caio";
            tizio.Eta = 34;
            tizio.GetNome();
            tizio.GetCognome();
            tizio.GetEta();
            tizio.GetDettagli();
        }
    }
}