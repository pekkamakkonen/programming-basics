using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kertaus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tulostus());
            Console.ReadKey();
        }

        static string Tulostus()
        {
            int[] numbers = new int[] { 2, 5, 10, 7, 3 };
            string stars = "";

            foreach (int number in numbers)
            {
                for (int i = 0; i < number; i++)
                {
                    stars = stars + "*";
                }
                Console.WriteLine(stars);
                stars = "";
            }
            return stars;
        }
    }
}
