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
            Console.WriteLine("Syota luku valilta 1-20: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            Console.WriteLine(LuvunKelpoisuus(number));
            Console.ReadKey();
        }

        static string LuvunKelpoisuus (int number)
        {
            do
            {
                retNumber = numberFromRange(lowerBound, upperBound);
            } while()
        }
    }
}
