using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
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

                if (evaluatedNumber > 0)
                {
                    Console.Write($"Numero {evaluatedNumber} on positiivinen ja se on");                

                    if (evaluatedNumber % 2 == 0)
                    {
                        Console.WriteLine(" parillinen.");
                    }
                    else
                    {
                        Console.WriteLine(" pariton.");
                    }

                }
                else if (evaluatedNumber < 0)
                {
                    Console.Write($"Numero {evaluatedNumber} on negatiivinen ja se on");

                    if (evaluatedNumber % 2 == 0)
                    {
                        Console.WriteLine(" parillinen.");
                    }
                    else
                    {
                        Console.WriteLine(" pariton.");
                    }

                }
                else
                {
                    Console.WriteLine($"Numero {evaluatedNumber} on nolla ja se on");
                    Console.WriteLine(" parillinen.");
                }

            }
            else
            {
                Console.WriteLine("Syötit muuta kuin numeroita.");
            }
            Console.ReadKey();

        }
    }
}
