using System;

namespace task_3
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
                int pariton = 0;
                int parillinen = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0) {
                        pariton = pariton + i;
                    }
                    if (i % 2 == 0)
                    {
                        parillinen = parillinen + i;
                    }
                }
                Console.WriteLine($"Parittomien summa: {pariton}");
                Console.WriteLine($"Parillisten summa: {parillinen}");
            }
            else
            {
                Console.WriteLine("Määrittelemätön");
            }
            Console.ReadKey();
        }
    }
}