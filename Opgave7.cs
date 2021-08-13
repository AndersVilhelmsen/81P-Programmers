using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicProgramming
{
    class Opgave7
    {
        public static void Start()
        {

            string Userinput;

            do
            {
                Console.Clear();
                Console.WriteLine("\t\tIndtast opgavenummer: " +
                    "\n\n\t\t1: Fra Fahrenheit:" +
                    "\n\n\t\t2: Fra Celcius:" +
                    "\n\n\t\t3: Valutaomregner:" +
                    "\n\n\t\t4: Regnskabstal:" +
                    "\n\n\t\t5: Alder:" +
                    "\n\n\t\t(Q for quit)");

                Userinput = Console.ReadLine();

                switch (Userinput)
                {
                    case "1":
                        {
                            Fahrenheit();
                            break;
                        }

                    case "2":
                        {
                            Celcius();
                            break;
                        }
                    case "3":
                        {
                            ValutaOmregner();
                            break;
                        }
                    case "4":
                        {
                            Regnskabstal();
                            break;
                        }
                    case "5":
                        {
                            Age();
                            break;
                        }
                }

            } while (Userinput.ToUpper() != "Q");

        }

        public static void Fahrenheit()
        {
            Console.WriteLine("Indtast Fahrenheit");
            string Fahrenheit = Console.ReadLine();
            int Celcius = (int.Parse(Fahrenheit) - 32) * 5 / 9;
            Console.WriteLine($"Temperaturen i \u02daC er {Celcius}");
            Console.ReadKey();
        }

        public static void Celcius()
        {
            Console.WriteLine("Indtast Celcius");
            string Celcius = Console.ReadLine();
            int Fahrenheit = (int.Parse(Celcius) * 9 / 5) + 32;
            float Kelvin = (float.Parse(Celcius) + 273.15f);
            float Réaumur = (float.Parse(Celcius) * 0.8f);
            Console.WriteLine($"Temperaturen i Fahrenheit er {Fahrenheit}");
            Console.WriteLine($"Temperaturen i Kelvin er {Kelvin}");
            Console.WriteLine($"Temperaturen i Réaumur er {Réaumur}");
            Console.ReadKey();

        }

        public static void ValutaOmregner()
        {
            Console.WriteLine("Indtast valutakurs");
            float kurs = (float.Parse(Console.ReadLine()));
            Console.WriteLine("Indtast startbeløb (Euro)");
            float amount = (float.Parse(Console.ReadLine()));
            float endAmount = kurs * amount / 100;
            Console.WriteLine($"Beløbet er {endAmount} DKK");
            Console.ReadKey();


        }

        public static void Regnskabstal()
        {
            Console.WriteLine("Indtast omsætning");
            float turnover = (float.Parse(Console.ReadLine()));
            Console.WriteLine("Indtast variable omkostninger");
            float varExpenses = (float.Parse(Console.ReadLine()));
            Console.WriteLine("Indtast faste omkostninger");
            float fixedExpenses = (float.Parse(Console.ReadLine()));

            Console.WriteLine($"\t\t {turnover}");
            Console.WriteLine($"\t\t {varExpenses}");
            Console.WriteLine($"\t\t --------");
            Console.WriteLine($"\t\t {turnover - varExpenses}");
            Console.WriteLine($"\t\t {fixedExpenses}");
            Console.WriteLine($"\t\t --------");
            Console.WriteLine($"\t\t {turnover - varExpenses - fixedExpenses}");

            Console.WriteLine($"\n\t\t Dækningsgrad:  {(turnover - varExpenses) * 100 / turnover } %");
            Console.WriteLine($"\t\t Overskudsgrad: {(turnover - varExpenses - fixedExpenses) * 100 / turnover}");

            Console.ReadKey();

        }

        public static void Age()
        {
            Console.WriteLine("Indtast navn");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast alder");
            int age = (int.Parse(Console.ReadLine()));
            string tekst;
            ConsoleColor color;
            switch (age)
            {
                case 1:
                    {
                        tekst = "du er lige blevet født";
                        color = ConsoleColor.Red;
                        break;
                    }
                case <= 5:
                    {
                        tekst = "du kan begynde i børnehave";
                        color = ConsoleColor.DarkMagenta;
                        break;
                    }
                case <= 16:
                    {
                        tekst = "du går i skole";
                        color = ConsoleColor.Green;
                        break;
                    }
                default:
                    {
                        tekst = "nu begynder alvoren";
                        color = ConsoleColor.Blue;
                        break;
                    }
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = color;
            Console.WriteLine($"Dit navn er {name}, du er {age} år gammel og {tekst}.");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }


    }

}

