using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestD45AV
{
    public class Opgave2
    {
        // Opgave 2 - differens mellem 2 tal
        // Af Anders Vilhelmsen

        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("\t\tOpg2");
            Console.WriteLine("\n\n\t\tIndtast to heltal:\n");
            Console.Write("\t\tTal 1:\t");
            string Tal_1String = Console.ReadLine();
            int Tal1 = Convert.ToInt16(Tal_1String);

            Console.Write("\t\tTal 2:\t");
            string Tal_2String = Console.ReadLine();
            int Tal2 = Convert.ToInt16(Tal_2String);

            if (Tal1 > Tal2)
            { Console.WriteLine("\n\t\tTal 1 er {0}\n\t\tTal 2 er {1}\n\t\tTal 1 er størst, og differensen mellem dem er {2}", Tal1, Tal2, (Tal1-Tal2)); }
            else if (Tal2 > Tal1)
            { Console.WriteLine("\n\t\tTal 1 er {0}\n\t\tTal 2 er {1}\n\t\tTal 2 er størst, og differensen mellem dem er {2}", Tal1, Tal2, (Tal2 - Tal1)); }
            else
            { Console.WriteLine("\t\tDe to indtaste tal er begge {0}", Tal1); }

            Console.WriteLine("\n\t\tPress any key to continue");
            Console.ReadKey();
        }
    }
}