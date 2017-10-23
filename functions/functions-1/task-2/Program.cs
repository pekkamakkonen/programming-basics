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
            Console.WriteLine("Syota luku 1: ");
            string userInput = Console.ReadLine();
            int luku1 = int.Parse(userInput);
            Console.WriteLine("Syota luku 2: ");
            string userInput2 = Console.ReadLine();
            int luku2 = int.Parse(userInput2); 
            Console.WriteLine(Minimi(luku1, luku2));
            Console.ReadKey();
        }
        static string Minimi(int luku1, int luku2)
        {
            string vastaus;
            vastaus = "";

            if (luku1 < luku2)
            {
                vastaus = luku1 + " on pienempi kuin " + luku2 + ".";
            }
            else if (luku1 > luku2) 
            {
                vastaus = luku2 + " on pienempi kuin " + luku1 + ".";
            }
            else
            {
                vastaus = luku1 + " ja luku " + luku2 + " ovat yhtä suuret.";
            }
            return vastaus;
        }
    }
}
