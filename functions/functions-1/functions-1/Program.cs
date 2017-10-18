using System;

namespace functions_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syota luku: ");
            string userInput = Console.ReadLine();
            int luku = int.Parse(userInput);
            string tahdet;
            tahdet = "";
            Console.WriteLine(Tulostus(tahdet));
            Console.ReadKey();
        }

        static string Tulostus(string tahdet)
        {
            char merkki = '*';

            for (int i = 1; i <= 20; i++)
            {
                tahdet = tahdet + merkki;
            }
            return tahdet;
        }        
    }
}