using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syota luku: ");
            string userInput = Console.ReadLine();
            int luku = int.Parse(userInput);
            Console.WriteLine(Tulostus(luku));
            Console.ReadKey();
        }

        static string Tulostus(int luku)
        {
            char merkki = '*';
            string tahdet;
            tahdet = "";

            for (int i = 1; i <= luku; i++)
            {
                tahdet = tahdet + merkki;
            }
            return tahdet;
        }
    }
}