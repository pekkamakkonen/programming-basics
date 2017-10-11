using System;

namespace loop_statesments2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luku | Neliojuuri");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" {i} | { Math.Round(Math.Sqrt(i), 2) }");
            }
            Console.ReadKey();
        }
    }
}