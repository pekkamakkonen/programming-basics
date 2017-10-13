using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int laskuri = 0; laskuri < 4; laskuri++)
            {
                Console.WriteLine("Rivi {0}:{1}", laskuri + 1, LuvutListaan(rnd));
            }
            Console.ReadKey();
        }

        static string LuvutListaan(Random rnd)
        {
            int arpa;
            string msg = "";

            for (int luku = 1; luku <= 5; luku++)
                {
                    arpa = rnd.Next(51);

                    if (luku < 5)
                    {
                        msg += string.Format(" {0}, ", MuotoileLuku(arpa));
                    }
                    else
                    {
                    msg += string.Format(" {0} ", MuotoileLuku(arpa));
                    }
                }
                return msg;
            }

            static string MuotoileLuku(int x)
            {
                string erotin = "";

                if (x < 10)
                {
                    erotin = " ";
                }
                return ($" { erotin } { x.ToString() }");
            }
        }
    }
