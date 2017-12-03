using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syota sana. Ohjelma tarkistaa onko sana palintromi.");
            string userInput = Console.ReadLine();
            string syote = userInput.ToUpper();
            string reversed = "";

            foreach (char x in syote)
            {
                reversed = x + reversed;
            }

            string message = "";

            if (syote == reversed)
            {
                message = ($"Sana { syote } on palintromi");
            }
            else
            {
                message = ($"Sana { syote } ei ole palintromi");
            }
            Console.WriteLine($"{ message }");
            Console.ReadKey();
        }
    }
}