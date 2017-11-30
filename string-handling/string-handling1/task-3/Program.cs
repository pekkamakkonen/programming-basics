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
            Console.WriteLine("Syötä sana tai lause. Lasketaan L-kirjaimien määrä.");
            string userInput = Console.ReadLine();
            string syote = userInput.ToUpper();
            int i = 0;

            foreach(char x in syote)
            {
                if(x == 'L')
                {
                    i++;
                }
            }

            Console.WriteLine($"Syötteessä { userInput } on { i } L kirjainta.");
            Console.ReadKey();
        }
    }
}
