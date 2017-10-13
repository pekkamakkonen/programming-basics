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
                Console.WriteLine("Rivi {0}:{1}", laskuri + 1, luvutListaan(rnd));
            }
            Console.ReadKey();
        }
            static string luvutListaan(Random rnd)
            {
                int arpa = 0;
                string msg = "";
                for (int luku = 0; luku < 5; luku++)
                {
                    arpa = rnd.Next(51);

                    if (luku < 4)
                    {
                        msg += string.Format(" {0}, ", muotoileLuku(arpa));
                    }
                    else
                    {
                    msg += string.Format(" {0} ", muotoileLuku(arpa));
                    }
                }
                return msg;
            }

            static string muotoileLuku(int x)
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
