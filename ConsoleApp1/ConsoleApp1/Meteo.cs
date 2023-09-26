using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Meteo
    {
        public Meteo() 

        {
            Console.WriteLine("Bienvenue à l'outil Météo.\n");
            Console.WriteLine("Entrez C pour le mode en Celsius ou F pour le mode en Fahrenheit.");

            // double resultat = 0.0;
            // double resultat2 = Math.Round(resultat, 2);
            double tempenCelsius;
            double tempenFahrenheit;
            string? line;


            while (true)
            {
                string? Line = Console.ReadLine();
                if (Line == "c" || Line == "C")
                {
                    Console.WriteLine("Bienvenue en mode Celsius.");
                    Console.WriteLine("\n \n Entrez la température en Celsius: \n \n");
                    line = Console.ReadLine();
                    tempenCelsius = Convert.ToDouble(line);
                    tempenFahrenheit = (tempenCelsius * 9 / 5) + 32;
                    tempenFahrenheit = Math.Round(tempenFahrenheit, 2);
                    Console.WriteLine($"La température en Fahrenheit: {tempenFahrenheit}");

                    break;
                }
                else if (Line == "f" || Line == "F")
                {
                    Console.WriteLine("Bienvenue en mode Fahrenheit.");
                    Console.WriteLine("\n \n Entrez la température en Fahrenheit: \n \n");
                    line = Console.ReadLine();
                    tempenFahrenheit = Convert.ToDouble(line);
                    tempenCelsius = ((tempenFahrenheit - 32) *5 ) / 9;
                    tempenCelsius = Math.Round(tempenCelsius, 2);
                    Console.WriteLine($"La température en Celsius: {tempenCelsius}");

                    break;
                }
                else
                {
                    Console.WriteLine("Assurez-vous de taper soit C ou F");
                }
            }

            Console.WriteLine("Merci d'avoir utilisé l'outil Météo!");

        }

    }

}
