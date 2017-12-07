using System;

namespace vokaalilaskuri
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Syötä sana tai lause.");
            string userInput;
            userInput = Console.ReadLine();
            string syote = userInput.ToUpper();
            int vokaali = 0;

            foreach(char x in syote)
            {
                if(x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U' || x == 'Y' || x == 'Ä' || x == 'Ö')
                {
                    vokaali++;
                }
            }
            Console.WriteLine($"Sanassa { userInput } on { vokaali } vokaalia");
            Console.ReadKey();

        
        }
    }
}
