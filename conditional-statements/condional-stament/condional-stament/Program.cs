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

            //Määritetään muuttuja luku1 joka on int-tietotyyppiä

            int luku;

            //Kysytään käyttäjältä luku

            Console.WriteLine("Anna numero:");
            luku = int.Parse(Console.ReadLine());

            //Tarkistetaan if-lausekkeella onko luku positiivinen, negatiivinen vai nolla

            if (luku > 0)
            {
                Console.WriteLine("Numero " + luku + " on positiivinen.");
            }
            else if (luku < 0)
            {
                Console.WriteLine("Numero " + luku + " on negatiivinen.");
            }
            else
            {
                Console.WriteLine("Numero " + luku + " on nolla.");
            }
            Console.ReadKey();
        }
    }
}
