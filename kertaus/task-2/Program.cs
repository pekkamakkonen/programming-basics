using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä sana tai lause: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine($" { i }. { userInput }");
            }
            Console.ReadKey();
        }
    }
}
