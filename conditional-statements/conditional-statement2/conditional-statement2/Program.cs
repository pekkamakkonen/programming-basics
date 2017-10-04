using System;

namespace conditional_statement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Syötä ikäsi: ");

            String userInput;
            userInput = Console.ReadLine();

            int age;
            bool isNumber = int.TryParse(userInput, out age);

            if(isNumber == true)
            {
                double normalPrice = 16.00;
                double discount;

                if (age < 7)
                {
                    discount = 1.00;
                }
                else if ((age >= 7 && age <= 15) || (age >= 65)) {
                    discount = 0.50;
                }
                else if (age)
                {
                    discount = 0.50;
                }


            }
            else
            {
                Console.WriteLine("Virheellinen ikä!");
            }
            Console.ReadKey();
        }
    }
}