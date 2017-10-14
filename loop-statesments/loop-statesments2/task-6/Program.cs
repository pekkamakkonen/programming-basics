using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int luku;
            int kuutonen = 0;

            Console.WriteLine("Vastaus:");

            for (int heitto = 1; heitto <= 1000; heitto++)
            {
                luku = rnd.Next(1,7);

                Console.WriteLine($"{ heitto }. { luku }");

                if (luku == 6)
                {
                    kuutonen++;
                }

            }
            Console.WriteLine($"Kuutonen arvottiin { kuutonen } kertaa.");
            Console.ReadKey();
        }
    }
}