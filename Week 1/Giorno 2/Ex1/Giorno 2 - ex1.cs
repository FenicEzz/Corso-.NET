namespace Giorno_2
{
    internal class Program
    {
        class Atleta
        {
            public string Nome { get; set; }
            public int Age { get; set; }
            public string Sport { get; set; }
            public int startAge { get; set; }

            public void presentazione()
            {
                Console.WriteLine($"Mi chiamo {Nome}, ho {Age} anni e pratico il {Sport}.");
            }

            public void startSportAge()
            {
                Console.WriteLine($"Ho iniziato a {startAge} anni.");
            }
        }

        class Dipendente
        {
            public string Nome { get; set; }
            public string Matricola { get; set; }
            public int Age { get; set; }
            public string Mansione { get; set; }

            public void presentazione()
            {
                Console.WriteLine($"Il mio nome è {Nome}, numero {Matricola}, ho {Age} anni e sono un {Mansione}.");
            }
        }

        class Animale
        {
            public string Specie { get; set; }
            public string TipoSangue { get; set; }
            public string Ambiente { get; set; }

            public void presentazione()
            {
                Console.WriteLine($"Sono un {Specie}, a sangue {TipoSangue} e vivo nel {Ambiente}.");
            }
        }

        class Veicolo
        {
            public string Marca { get; set; }
            public string Modello { get; set; }
            public int Ruote { get; set; }
            public int Prezzo { get; set; }

            public void presentazione()
            {
                Console.WriteLine($"{Marca} {Modello}, con {Ruote} ruote, costa {Prezzo} Euro.");
            }
        }

        static void Main(string[] args)
        {
            Atleta messi = new Atleta();
            messi.Nome = "Lionel Messi";
            messi.Age = 35;
            messi.Sport = "calcio";
            messi.startAge = 14;
            messi.presentazione();
            messi.startSportAge();

            Atleta doe = new Atleta();
            doe.Nome = "John Doe";
            doe.Age = 20;
            doe.Sport = "baseball";
            doe.startAge = 16;
            doe.presentazione();
            doe.startSportAge();

            Dipendente medico = new Dipendente();
            medico.Nome = "Mario Rossi";
            medico.Matricola = "A45B78";
            medico.Age = 56;
            medico.Mansione = "medico";
            medico.presentazione();

            Dipendente ing = new Dipendente();
            ing.Nome = "Tizio Caio";
            ing.Matricola = "L464M";
            ing.Age = 40;
            ing.Mansione = "ingegnere";
            ing.presentazione();

            Animale snake = new Animale();
            snake.Specie = "serpente a sonagli";
            snake.Ambiente = "deserto";
            snake.TipoSangue = "freddo";
            snake.presentazione();

            Animale cinghiale = new Animale();
            cinghiale.Specie = "cinghiale";
            cinghiale.Ambiente = "bosco";
            cinghiale.TipoSangue = "caldo";
            cinghiale.presentazione();

            Veicolo truck = new Veicolo();
            truck.Marca = "Scania";
            truck.Modello = "Interlink";
            truck.Ruote = 6;
            truck.Prezzo = 60000;
            truck.presentazione();

            Veicolo car = new Veicolo();
            car.Marca = "Ford";
            car.Modello = "Fiesta";
            car.Ruote = 4;
            car.Prezzo = 20000;
            car.presentazione();

        }
    }
}
