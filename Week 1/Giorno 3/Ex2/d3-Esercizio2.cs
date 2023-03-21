namespace Giorno_3___ex2
{
    internal class Esercizio2
    {

        static void RicercaNome(string[] arr)
        {
            Console.WriteLine("Inserire nome da cercare: ");
            string nomeRichiesto = Console.ReadLine();
            bool x = false;

            foreach (string s in arr)
            {
                if (s == nomeRichiesto)
                {
                    x = true;
                }
            }

            if (x) 
            {
                Console.WriteLine($"{nomeRichiesto} esiste!");
            }
            else
            {
                Console.WriteLine($"{nomeRichiesto} è mancante!");
            }
        }
        static void Main(string[] args)
        {
            string[] nomi = new string[] { "Riccardo", "Marco", "Alice", "Giulia" };   
            
            RicercaNome(nomi);
        }
    }
}