using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int j;
            string userInput = "";
            int biggestNumber = 0;
            string lukujono = "";

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Syota luku {i}.");
                userInput = Console.ReadLine();
                j = int.Parse(userInput);

                Console.WriteLine(j);

                if (j > biggestNumber)
                {
                    biggestNumber = j;
                }

                lukujono = lukujono + " " + j;
               
            }
            Console.WriteLine($"Syötit luvut { lukujono }. \n Suurin luku oli { biggestNumber }. ");
            Console.ReadKey();

        }
    }
}
