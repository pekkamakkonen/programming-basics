using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 101);
            int number;
            int arvaus = 0;
            Console.WriteLine("Minäpä tiedän luvun väliltä 1-100, jota sinä et tiedä!");

            do
            {
                Console.WriteLine("Arvaa luku:");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
                arvaus++;
            } while (number != x);

            if(number == x)
            {
                Console.WriteLine($"Oikein! Arvauksia yhteensä: {arvaus}");
            }
            Console.ReadKey();
        }
    }
}
