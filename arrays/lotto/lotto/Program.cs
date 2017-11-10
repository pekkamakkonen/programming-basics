using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[7];

            for (int i = 0; i <= 6; i++)
            {
                numbers[i] = rnd.Next(1, 41);
            }
            Console.WriteLine("Illan lottonumerot ovat: ");

            Array.Sort(numbers);

            foreach (int number in numbers)
            {
                Console.Write(number);
                Console.Write(' ');
            }
            Console.ReadKey();
        }
    }
}
