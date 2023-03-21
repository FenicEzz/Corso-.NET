//Console.WriteLine("Ciao, come ti chiami?");
//string nome = Console.ReadLine();

//Console.WriteLine("Che ore sono?");
//string ora = Console.ReadLine();

//double orario = double.Parse(ora);
//Console.WriteLine(orario);

//if (orario > 12)
//{
//    Console.WriteLine($"Buonasera, {nome}!");
//}
//else if (orario < 12)
//{
//    Console.WriteLine($"Buongiorno, {nome}!");
//}
//else
//{
//    Console.WriteLine($"Buon appetito, {nome}!");
//}

//int i = 1;

//while(i < 101)
//{
//    Console.WriteLine(i);
//    i++;
//}

//Console.WriteLine("----------");

//for(int x = 2; x <= 100; x += 2)
//{
//    Console.WriteLine(x);
//}

//Console.WriteLine("----------");

//int y = 100;
//while(y >= 1)
//{
//    Console.WriteLine(y);
//    y--;
//}

//Console.WriteLine("Inserire un numero: ");
//string numero = Console.ReadLine();
//int num = int.Parse(numero);

//if (num % 2 == 0)
//{
//    Console.WriteLine("Il numero è pari");
//}
//else
//{
//    Console.WriteLine("Il numero è dispari");

//    if (num % 3 == 0)
//    {
//        Console.WriteLine("Il numero è divisibile per 3");
//    }
//}

Console.WriteLine("Inserire un numero:");
string numero = Console.ReadLine();
int num = int.Parse(numero);

Console.WriteLine("------------------------------");

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(num * i);
}