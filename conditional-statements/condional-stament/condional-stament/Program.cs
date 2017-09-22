using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condional_stament
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
                        Console.WriteLine($"Numero {evaluatedNumber} on positiivinen.");
                    }
                    else if (evaluatedNumber < 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen.");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on nolla.");
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
