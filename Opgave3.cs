using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestD45AV
{
    public class Opgave3
    {
        // Opgave 3 - pH-værdi
        // Af Anders Vilhelmsen

        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("\t\tOpg3");
            Console.Write("\n\n\t\tIndtast en pH-værdi:\n\t\t(pH-værdier ligger mellem 0 og 14)\n\t\t");
            string pH_string = Console.ReadLine();
            double pH_double = Convert.ToDouble(pH_string);

            if (pH_double < 0 || pH_double > 14)
            { Console.WriteLine("\n\t\tDen indtastede pH skal være mellem 0 og 14"); }
            else if (pH_double < 7)
            { Console.WriteLine("\n\t\tVæsken med den pågældende pH-værdi er sur"); }
            else if (pH_double > 7)
            { Console.WriteLine("\n\t\tVæsken med den pågældende pH-værdi er basisk"); }
            else if (pH_double == 7)
            { Console.WriteLine("\n\t\tVæsken med den pågældende pH-værdi er neutral"); }

            Console.WriteLine("\n\t\tPress any key to continue");
            Console.ReadKey();
        }
    }
}