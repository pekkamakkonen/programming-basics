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
            MuutettuLuku();
            Console.ReadKey();
        }

        static string MuutettuLuku()
        {
            Random rnd = new Random();
            int[] array = new int[10];
            string tulostus = "";

            for (int i = 0; i <= 9; i++)
            {
                array[i] = rnd.Next(0, 20);
                int number = array[i];
                string merkkijono = number.ToString();

                if (array[i] < 10)
                {
                    tulostus = 0 + merkkijono;
                }
                else
                {
                    tulostus = merkkijono;
                }
                Console.WriteLine(tulostus);
            }
            return tulostus;
        }
    }
}
