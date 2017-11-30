using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä sana tai lause. E-kirjaimet korvataan @-merkillä");
            string userInput = Console.ReadLine();
            string tuloste = userInput.Replace("e", "@");
            Console.WriteLine(tuloste);
            Console.ReadKey();
        }
    }
}
