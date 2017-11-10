using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taulukko3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[10];

            for (int i = 0; i <= 9; i++)
            {
                array[i] = rnd.Next(0, 20);

                if (array[i] < 10)
                {
                    Console.WriteLine($"0{ array[i] }");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
