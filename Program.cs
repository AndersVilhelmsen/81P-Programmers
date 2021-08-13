using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using basicProgramming;

//      Velkommen til min afsluttende opgave i programmering i grundforløb 2
//      Opgaven er lavet af Anders Vilhelmsen
//      1. oktober 2020


namespace TestD45AV
{
    class Program
    {
        static void Main(string[] args)
        {
            string Userinput;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\tIndtast opgavenummer: " +
                    "\n\n\t\t1: Parkeringsplads" +
                    "\n\t\t2: Differens mellem to tal" +
                    "\n\t\t3: pH-værdi" +
                    "\n\t\t4: Gæt et ord" +
                    "\n\t\t4.2: Gæt et tal" +
                    "\n\t\t5: Lommeregner" +
                    "\n\t\t6: Fuglevægt" +
                    "\n\t\t7: GP" +

                    "\n\n\t\t(Q for quit)");
                Userinput = Console.ReadLine();

                switch (Userinput)
                {
                    case "1":
                        {
                            Opgave1.Start();
                            break;
                        }


                    case "2":
                        {
                            Opgave2.Start();
                            break;
                        }


                    case "3":
                        {
                            Opgave3.Start();
                            break;
                        }


                    case "4":
                        {
                            Opgave4.Start();
                            break;
                        }

                    case "4.2":
                        {
                            Opgave4.Start2();
                            break;
                        }


                    case "5":
                        {
                            Opgave5.Start();
                            break;
                        }

                    case "6":
                        {
                            Opgave6.Start();
                            break;
                        }

                    case "7":
                        {
                            Opgave7.Start();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Forkert input. Prøv igen.");
                            break;
                        }
                }
            } while (Userinput.ToUpper() != "Q");
        }
    }
}
