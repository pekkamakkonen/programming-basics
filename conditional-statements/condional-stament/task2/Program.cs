using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // define instructions

            Console.WriteLine("Syötä numero: ");

            // define variables

            String userInput;
            userInput = Console.ReadLine();

            int evaluatedNumber;
            bool isNumber = int.TryParse(userInput, out evaluatedNumber);

            // program logic

            if (isNumber == true)
            {

                if (evaluatedNumber % 2 == 0)
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on parillinen.");
                }
                else
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on pariton.");
                }
            }
            else
            {
                Console.WriteLine("Syötit muuta kuin numeroita");
            }

            Console.ReadKey();
        }
    }
}
