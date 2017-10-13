using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            double luku;
            char merkki;

            for (int i = 1; i <= 13; i++)
            {
                luku = rnd.NextDouble();

                if (luku <= 0.4)
                {
                    merkki = '1';
                }
                else if(luku <= 0.6)
                {
                    merkki = 'x';
                }
                else
                {
                    merkki = '2';
                }
                Console.WriteLine($" { i }. { merkki } ");
            }
            Console.ReadKey();
        }
    }
}