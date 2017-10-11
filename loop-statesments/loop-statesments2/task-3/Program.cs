using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int i = 1;

            while (i <= 20) {
                i++;

                int satunnainen = rnd.Next(50);
                Console.WriteLine(satunnainen);
            }
            Console.ReadKey();

        }
    }
}