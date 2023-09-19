using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Meteo
    {
        public Meteo(double temperatureCelcius) 
        {
            Console.WriteLine("Bienvenue à l'outil Meteo");

            Console.WriteLine("Quelle est la temperature en Celcius aujourdhui?");
            float temperatureCelcius;

            Console.Write("La temperature en Fahrenheit: ");

            _ = temperatureCelcius * 1.8 + 32;
        }
    }
}
