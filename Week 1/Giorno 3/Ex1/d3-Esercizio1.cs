namespace Giorno_3
{
    internal class Esercizio1
    {
        class ContoCorrente
        {
            // PROPRIETA'
            private decimal Conto { get; set; }
            private bool StatoConto { get; set; }
            public string Intestatario { get; set; }
            public string Iban { get; set; }
            public string NomeBanca { get; set; }

            // METODI
            public void AperturaConto()
            {
                if (StatoConto == false)
                {
                    StatoConto = true;
                    Console.WriteLine("E' necessario un versamento di almeno 1000 Euro per aprire il conto: ");
                    string vers = Console.ReadLine();
                    decimal vers1 = decimal.Parse(vers);
                    if (vers1 >= 1000)
                    {
                        Conto = Conto + vers1;
                        Console.WriteLine($"Il tuo conto è stato aperto. Saldo di {vers1} Euro, a nome di {Intestatario} con banca {NomeBanca.ToUpper()}, coordinate bancarie '{Iban.ToUpper()}'.");
                    }
                    else
                    {
                        Console.WriteLine("Versamento non sufficiente! Impossibile aprire il conto!");
                    }
                }
                else
                {
                    Console.WriteLine("Conto già aperto!");
                    
                }
                Console.WriteLine("---------------------------------");
            }
            public void Versamento()
            {
                Console.WriteLine("Quanto vuoi versare?");
                string value = Console.ReadLine();
                decimal x = decimal.Parse(value);
                Console.WriteLine($"Versamento di {x} Euro. Il tuo Saldo: {Conto += x} Euro.");
                Console.WriteLine("---------------------------------");
            }

            public void Prelevamento()
            {
                Console.WriteLine("Quanto vuoi prelevare?");
                string y = Console.ReadLine();
                decimal x = decimal.Parse(y);
                if (x > Conto)
                {
                    Console.WriteLine("Saldo non disponibile!");
                }
                else
                {
                    Console.WriteLine($"Prelievo di {x} Euro. Il tuo Saldo: {Conto -= x} Euro.");
                }
                Console.WriteLine("---------------------------------");
            }
        }
        static void Main(string[] args)
        {
            ContoCorrente primo = new ContoCorrente() { Iban = "sd34s54fj", Intestatario = "Rick", NomeBanca = "bnl" };
            primo.AperturaConto();
            primo.Versamento();
            primo.Prelevamento();
            Console.WriteLine("\n-------Segue dimostrazione della singola chiamata per AperturaConto-------\n");
            primo.AperturaConto();

            ContoCorrente secondo = new ContoCorrente() { Iban = "f42g3d4ab", Intestatario = "Marco", NomeBanca = "intesa" };
            secondo.AperturaConto();
            secondo.Versamento();
            secondo.Prelevamento();
            Console.WriteLine("\n-------Segue dimostrazione della singola chiamata per AperturaConto-------\n");
            secondo.AperturaConto();
        }
    }
}