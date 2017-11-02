using System;

namespace arrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] iT = new int[100];
            double sum = 0;
            double average;

            Console.WriteLine("Arvotut luvut ovat: ");

            for (int i = 0; i < iT.Length; i++)
            {
                iT[i] = rnd.Next(0, 51);
                Console.WriteLine($"{ i + 1 }. { iT[i] }");
                sum = (double)sum + iT[i];
            }

            // Lasketaan lukujen keskiarvo:

            average = sum / iT.Length;

            Console.WriteLine($"Lukujen keskiarvo on { average }.");
            Console.ReadKey();
        }
    }
}