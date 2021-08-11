using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestD45AV
{
    public class Opgave4
    {
        // Opgave 4 - Gæt et ord & opgave 4.2 - Gæt et tal
        // Af Anders Vilhelmsen

        public static void Start()
        {
            bool Afslut = false;
            string Ord = "toyota";
            int Antal_gæt = 0;

            Console.Clear();
            Console.WriteLine("\t\tOpg4");
            Console.WriteLine("\n\n\t\tJeg tænker på et ord\n\t\tPrøv at gætte det");
            do
            {
                Console.Write("\n\t\tHvad gætter du på?\n\t\t");
                string Gæt_string = Console.ReadLine();

                if (Gæt_string == Ord)
                {
                    Console.WriteLine("\t\tDu har gættet det");
                    Console.WriteLine("\t\tDu brugte {0} forsøg", ++Antal_gæt);
                    if (Antal_gæt <= 10)
                    { Console.WriteLine("\t\tDu har overnaturlige evner uden at vide det selv"); }
                    Afslut = true;
                }
                else
                {
                    Console.Write("\t\tDet var ikke rigtigt (du har brugt {0} forsøg) - Prøv igen:\t", ++Antal_gæt);
                }
            } while (!Afslut);

            Console.WriteLine("\n\t\tPress any key to continue");
            Console.ReadKey();
        }

    public static void Start2()
        {
            bool Afslut = false;
            int Antal_gæt = 0;
            int Rnd_tal;
            Random rnd = new Random();
            Rnd_tal = rnd.Next(1, 100);

            Console.Clear();
            Console.WriteLine("\t\tOpg4");
            Console.WriteLine("\n\n\t\tJeg tænker på et tal mellem 1 og 100\n\t\tPrøv at gætte det");
            do
            {
                Console.Write("\n\t\tHvad gætter du på?\n\t\t");
                string Gæt_string = Console.ReadLine();
                int Gæt_int = Convert.ToInt16(Gæt_string);

                if (Gæt_int < 1 || Gæt_int > 100)
                { Console.WriteLine("\t\tGæt på et tal mellem 1 og 100"); }
                else if (Gæt_int == Rnd_tal)
                {
                    Console.WriteLine("\t\tTil lykke!\n\t\tDu gættede tallet");
                    Console.WriteLine("\t\tTallet var {1}, og du brugte gæt: {0}", ++Antal_gæt, Rnd_tal);
                    if (Antal_gæt <= 6)
                    { Console.WriteLine("\t\tDu er rigtig hurtig! (under 7 gæt)"); }
                    Afslut=true;
                }
                else if (Gæt_int < Rnd_tal)
                {
                    Console.WriteLine("\t\tDet tal du gættede på var for lavt");
                    Console.WriteLine("\t\tAntal gæt: {0}", ++Antal_gæt);
                }
                else if (Gæt_int > Rnd_tal)
                {
                    Console.WriteLine("\t\tDet tal du gættede på var for højt");
                    Console.WriteLine("\t\tAntal gæt: {0}", ++Antal_gæt);
                }

            } while (!Afslut);
            Console.WriteLine("\n\t\tPress any key to continue");
            Console.ReadKey();
        }
    }
}