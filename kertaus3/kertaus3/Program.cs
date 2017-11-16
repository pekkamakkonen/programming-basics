using System;

namespace kertaus3
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 0;
            int number2 = 0;
            int i = 0;
            int sum = 0;

            Console.WriteLine("Ohjelma kysyy käyttäjältä lukuja, kunnes hän syöttää kaksi samaa lukua peräkkäin.");

            do
            {
                string userInput = Console.ReadLine();

                if (i % 2 == 0)
                {
                    number = int.Parse(userInput);
                    sum = sum + number;
                }
                else
                {
                    number2 = int.Parse(userInput);
                    sum = sum + number2;
                }
                i++;

            } while (number != number2);

            Console.WriteLine($"Lukujen summa on: {sum}");
            Console.ReadKey();


        }
    }
}
