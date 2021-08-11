using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestD45AV
{
    public class Opgave5
    {
        // opgave 5 - Lommeregner
        // Af Anders Vilhelmsen

        public static void Start()
        {
            bool Afslut=false;
            Console.Clear();
            Console.WriteLine("\t\tOpg5");

            do
            {
                Console.WriteLine("\n\t\tVelkommen til lommeregneren\n\t\tHvad vil du udregne?:" +
                "\n\t\tA:\tArealberegning af geometriske figurer" +
                "\n\t\tO:\tBeregning af Ohms Lov" +
                "\n\t\tQ:\tFor Afslut");
            String Userinput1=Console.ReadLine();
            Userinput1 = Userinput1.ToUpper();

                switch (Userinput1)
                {
                    case "A":
                        {
                            Areal();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case "O":
                        {
                            Ohm();
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case "Q":
                        {
                            Afslut = true;
                            Console.WriteLine("\t\tDu har trykket afslut");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\t\tForkert input - prøv igen");
                            break;
                        }
                }
                
            } while (!Afslut);
            Console.WriteLine("\n\t\tPress any key to continue");
            Console.ReadKey();
        }

        public static void Areal()
        {
            bool Afslut = false;

            do
            {

                Console.WriteLine("\n\t\tDu har valgt arealberegning\n\t\tHvilken figur vil du udregne arealet af?:" +
                "\n\t\tF:\tFirkant" +
                "\n\t\tT:\tTrekant" +
                "\n\t\tC:\tCirkel" +
                "\n\t\tH:\tTilbage til hovedmenu");

                String Userinput1 = Console.ReadLine();
                Userinput1 = Userinput1.ToUpper();
                switch (Userinput1)
                {
                    case "F":
                        {
                            Console.Write("\tIndtast side 1: ");
                            string Side1String = Console.ReadLine();
                            double Side1 = Convert.ToDouble(Side1String);
                            Console.Write("\tIndtast side 2: ");
                            string Side2String = Console.ReadLine();
                            double Side2 = Convert.ToDouble(Side1String);
                            Console.WriteLine("\n\tArealet af firkanten er {0}", (Side1*Side2));
                            Afslut = true;
                            break;
                        }

                    case "T":
                        {
                            Console.Write("\tIndtast højden: ");
                            string HøjdeString = Console.ReadLine();
                            double Højde = Convert.ToDouble(HøjdeString);
                            Console.Write("\tIndtast Grundlinje: ");
                            string GrundString = Console.ReadLine();
                            double Grund = Convert.ToDouble(GrundString);
                            Console.WriteLine("\n\tArealet af trekanten er {0}", (Højde * Grund *0.5));
                            Afslut = true;
                            break;
                        }

                    case "C":
                        {
                            Console.Write("\tIndtast radius: ");
                            string RadiusString = Console.ReadLine();
                            double Radius = Convert.ToDouble(RadiusString);
                            Console.WriteLine("\n\tArealet af cirklen er {0}", (Radius * Radius * 3.14));
                            Afslut = true;
                            break;
                        }

                    case "H":
                        {
                            Afslut = true;
                            Console.WriteLine("\n\t\tDu har trykket tilbage");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\t\tForkert input - prøv igen");
                            break;
                        }
                }
            } while (!Afslut);
        }

        public static void Ohm()
        {
            bool Afslut = false;
            do
            {
                Console.WriteLine("\n\t\tDu har valgt Ohms Lov\n\t\tHvad vil du udregne?:" +
                "\n\t\tU:\tSpændning" +
                "\n\t\tR:\tModstand" +
                "\n\t\tI:\tStrømstyrke" +
                "\n\t\tH:\tTilbage til hovedmenu");

                String Userinput1 = Console.ReadLine();
                Userinput1 = Userinput1.ToUpper();
                switch (Userinput1)
                {
                    case "U":
                        {
                            Console.Write("\tIndtast modstand: ");
                            string ModstandString = Console.ReadLine();
                            double Modstand = Convert.ToDouble(ModstandString);
                            Console.Write("\tIndtast strømstyrken: ");
                            string StrømString = Console.ReadLine();
                            double Strøm = Convert.ToDouble(StrømString);
                            Console.WriteLine("\n\tSpændningen er {0} Volt", (Modstand * Strøm));
                            Afslut = true;
                            break;
                        }

                    case "R":
                        {
                            Console.Write("\tIndtast Spænding: ");
                            string SpændningString = Console.ReadLine();
                            double Spænding = Convert.ToDouble(SpændningString);
                            Console.Write("\tIndtast strømstyrken: ");
                            string StrømString = Console.ReadLine();
                            double Strøm = Convert.ToDouble(StrømString);
                            Console.WriteLine("\n\tModstanden er {0} Ohm", (Spænding/Strøm));
                            Afslut = true;
                            break;
                        }

                    case "I":
                        {
                            Console.Write("\tIndtast Spænding: ");
                            string SpændningString = Console.ReadLine();
                            double Spænding = Convert.ToDouble(SpændningString);
                            Console.Write("\tIndtast modstand: ");
                            string ModstandString = Console.ReadLine();
                            double Modstand = Convert.ToDouble(ModstandString);
                            Console.WriteLine("\n\tStrømstyrken er {0} Ampere", (Modstand * Spænding));
                            Afslut = true;
                            break;
                        }

                    case "H":
                        {
                            Afslut = true;
                            Console.WriteLine("\t\tDu har trykket tilbage");
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\t\tForkert input - prøv igen");
                            break;
                        }
                }
            } while (!Afslut);
        }


    }
}