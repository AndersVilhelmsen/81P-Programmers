using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestD45AV
{
    public class Opgave6
    {
        // Opgave 6 - Fuglevægt
        // Af Anders Vilhelmsen

        public static void Start()
        {
            double Gennemsnit = 0;
            int Lav = 0;
            int Normal = 0;
            int Høj = 0;

            Console.Clear();
            Console.WriteLine("\t\tOpg6");

            Console.WriteLine("\n\n\t\tHvor mange målinger er der?");
            string Antal_string = Console.ReadLine();
            int Antal = Convert.ToInt16(Antal_string);

            double[] mål = new double[Antal];

            for (int i = 0; i < Antal; i++)
            {
                Console.WriteLine("\t\tIndtast vægt af fugl nummer {0} i gram", (i+1));
                string Vægt = Console.ReadLine();
                mål[i] = Convert.ToDouble(Vægt);
            }

            Array.Sort(mål);

            for (int i = 0; i < Antal; i++)
            {
                Gennemsnit = Gennemsnit + mål[i] / Antal;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("*****************");
                if (mål[i] < 50)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*\tFugl {0} vejer {1} gram - Sendes til A", (i+1), mål[i]);
                    Lav = ++Lav;
                }
                else if (mål[i] <= 75)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*\tFugl {0} vejer {1} gram - Normal", (i+1), mål[i]);
                    Normal = ++Normal;
                }
                else if (mål[i] > 75)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("*\tFugl {0} vejer {1} gram - Sendes til B", (i+1), mål[i]);
                    Høj = ++Høj;
                }
                
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*****************");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\t\tMindste fugl vejer {0} gram", mål[0]);
            Console.WriteLine("\t\tStørste fugl vejer {0} gram", mål[Antal-1]);
            Console.WriteLine("\t\tGennemsnittet er {0:F2} gram", Gennemsnit);
            Console.WriteLine("\t\tFugle under 50 gram: {0}", Lav);
            Console.WriteLine("\t\tFugle med normal vægt: {0}", Normal);
            Console.WriteLine("\t\tFugle over 75 gram: {0}", Høj);

            Console.ReadKey();

        }
    }
}