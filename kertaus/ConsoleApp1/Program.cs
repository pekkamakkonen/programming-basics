using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä sana tai lause: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($" { i }. { userInput }");
            }
            Console.ReadKey();
        }
    }
}
