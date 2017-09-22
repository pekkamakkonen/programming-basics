using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna numero: ");
            String userInput;
            userInput = Console.ReadLine();
            int luku1;
            luku1 = int.Parse(userInput);

            Console.WriteLine("Anna numero: ");
            String userInput2;
            userInput2 = Console.ReadLine();
            int luku2;
            luku2 = int.Parse(userInput2);

            Console.WriteLine("Anna numero: ");
            String userInput3;
            userInput3 = Console.ReadLine();
            int luku3;
            luku3 = int.Parse(userInput3);

            int[] values = { luku1, luku2, luku3 };

            Array.Sort(values);
            foreach (int value in values)
            {
                Console.Write(value);
                Console.Write(' ');
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
