using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Syötä numero: ");
            String userInput;
            userInput = Console.ReadLine();
            int n;
            bool isNumber = int.TryParse(userInput, out n);

            if (isNumber == true && n >= 1)
            {

                int x = 0;

                for (int i = 1; i <= n; i++)
                    {
                        x = x + i;
                    }
                Console.WriteLine($"Vastaus: {x}");
            }

            else if (isNumber == true && n <= 1)
            {
                int x = 0;

                for (int i = -1; i >= n; i--)
                {
                        x = x + i;
                }
                Console.WriteLine($"Vastaus: {x}");
            }
            else
            {
                Console.WriteLine("Määrittelemätön");
            }
            Console.ReadKey();
        }
    }
}