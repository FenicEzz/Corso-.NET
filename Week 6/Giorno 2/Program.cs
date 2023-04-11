using linq;

namespace Giorno_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var comuni = File.ReadAllLines("C:\\Users\\bavba\\OneDrive\\Documenti\\Riccardo\\Corso .NET\\Percorso Formativo\\Corso-.NET\\Week 6\\Giorno 2\\elenco-comuni.csv");

            comuni
                .OrderBy(c => c.Denominazione)
                .Select()
        }
    }
}