using System;

namespace conditional_statement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Syota ikasi: ");
            String userInput;
            userInput = Console.ReadLine();
            int age;
            bool isNumber = int.TryParse(userInput, out age);

            if (isNumber == true)
            {
                double normalPrice = 16.00;
                double discount;
                discount = 0.00;

                if (age < 7)
                {
                   discount = 1.00;
                }
                else if (age <= 15 || age >= 65)
                {
                   discount = 0.50;
                }
                else
                {
                    Console.WriteLine("Oletko varusmies? Syota K jos olet, E jos et.");
                    String varusmies;
                    varusmies = Console.ReadLine().ToUpper();

                    if (varusmies == "K")
                    {
                        discount = 0.50;
                    }
                    else
                    {
                        Console.WriteLine("Oletko opiskelija? Syota K jos olet, E jos et.");
                        String student;
                        student = Console.ReadLine().ToUpper();

                        Console.WriteLine("Oletko MTK-jasen? Syota K jos olet, E jos et.");
                        String mtk;
                        mtk = Console.ReadLine().ToUpper();

                        if (student == "K")
                        {
                           discount = 0.45;
                        }

                        if (mtk == "K")
                        {
                           discount = discount + 0.15;
                        }
                    }
                }

                //Calculating Total Price

                double totalPrice;
                totalPrice = normalPrice - (normalPrice * discount);
                Console.WriteLine($"Lopullinen hinta: {totalPrice} euroa.");
            }
            else
            {
                Console.WriteLine("Virheellinen ika!");
            }
           Console.ReadKey();
        }
    }
}