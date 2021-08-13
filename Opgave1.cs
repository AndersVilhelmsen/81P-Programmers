using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestD45AV
{
    class Opgave1
    {

        //Opgave1 1 - parkeringsplads
        //    af Anders Vilhelmsen

        public static void Start()
        {

            Console.Clear();
            Console.WriteLine("\t\tOpg1");
            Console.WriteLine("\n\t\tVelkommen til parkeringspladsen\n\n\t\tDer er to typer parkeringspladser:\n\t\t- Friluftsplads\t\t\t 10 kr. pr. 30 minutter\n\t\t- Overdækkede pladser\t\t 15 kr. pr. 30 minutter");
            Console.WriteLine("\n\t\tDerudover er der en grundtakst:\n\t\t- Friluftsplads\t\t 15 kr.\n\t\t- Overdækket plads\t 20 kr.");
            Console.Write("\n\n\t\tHvilke type parkering vælger De?\n\t\tFriluftsplads (F) eller overdækket plads (O)\n\t\t");
            string Type = Console.ReadLine();
            Type = Type.ToUpper();
            double Minutter;
            int Halvtime;
            int Pris;

            if (Type == "F")
            {
                Console.Write("\n\t\tHvor mange minutter har de parkeret?\n\n\t\t");
                Minutter = Convert.ToDouble(Console.ReadLine());
                Halvtime = (int) Math.Ceiling(Minutter / 30);
                Pris = Halvtime * 10 + 15;
                Console.WriteLine("\n\n\t\tAt batale {0} kr.", Pris);
            }
            else if (Type == "O")
            {
                Console.Write("\n\t\tHvor mange minutter har de parkeret?\n\n\t\t");
                Minutter = Convert.ToDouble(Console.ReadLine());
                Halvtime = (int) Math.Ceiling(Minutter / 30);
                Pris = Halvtime *15 + 20;
                Console.WriteLine("\n\n\t\tAt batale {0} kr.", Pris);
            }
            else
            {
                Console.WriteLine("Forkert input");
                Console.WriteLine("Programmet lukkes - Press any key");
            }


            Console.ReadKey();

        }
    }
}