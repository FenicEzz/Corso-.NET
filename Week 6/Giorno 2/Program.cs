namespace Giorno_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] comuni = File.ReadAllLines("C:\\Users\\bavba\\OneDrive\\Documenti\\Riccardo\\Corso .NET\\Percorso Formativo\\Corso-.NET\\Week 6\\Giorno 2\\elenco-comuni.csv");

            comuni.OrderBy(x => x.Denominazione).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}