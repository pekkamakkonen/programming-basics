using System;

namespace string_handling1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int merkkimaara = userInput.Length;
            Console.WriteLine($"Syötteessä on { merkkimaara } merkkiä.");
            Console.ReadKey();
        }
    }
}
