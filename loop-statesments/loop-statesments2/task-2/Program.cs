using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vastaus: ");

            for (int y = 1; y <= 9; y++)
            {
                for (int x = 1; x <= 9; x++)
                {
                    int tulos;
                    tulos = x * y;
                    Console.WriteLine($"{x} x {y} = {tulos}");
                }
            }
            Console.ReadKey();
        }
    }
}