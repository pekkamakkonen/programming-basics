using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;
            string userInput;

            do
            {
                Console.WriteLine("Syötä luku: ");
                userInput = Console.ReadLine();
                number = int.Parse(userInput);
                sum = sum + number;
            } while (number != -1);

            Console.WriteLine($"Lukujen summa on { sum }.");
            Console.ReadKey();
        }
    }
}
