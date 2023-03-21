namespace Giorno_3___ex3
{
    internal class Program
    {
        static void OperazioniArray(int[] arr)
        {
            double sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }

            Console.WriteLine(sum);

            double average = sum / arr.Length;

            Console.WriteLine(average);
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int[] numbers2 = { 12, 23, 34, 45, 56, 68 };

            OperazioniArray(numbers);
            OperazioniArray(numbers2);
        }
    }
}