using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Syota heittojen lukumaara: ");
            string userInput = Console.ReadLine();
            int n = int.Parse(userInput);
            int kolikko;
            int klaava = 0;
            int kruuna = 0;

            for (int i = 1; i <= n; i++)
            {
                kolikko = rnd.Next(2);

                if (kolikko == 0)
                {
                    klaava++;
                }
                else
                {
                    kruuna++;
                }

            }
            Console.WriteLine($"Rahaa on heitetty { n } kertaa.");
            Console.WriteLine($"Klaavoja tuli { klaava } ja kruunuja { kruuna }.");
            Console.ReadKey();
        }
    }
}