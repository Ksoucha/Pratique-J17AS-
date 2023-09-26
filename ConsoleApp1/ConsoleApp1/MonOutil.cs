using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MonOutil
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, what is your name?");

            // Code qui lit la console pour stocker le nom
            string? username;

            username = Console.ReadLine();

            // Code qui accueille l'utilisateur par son nom
            Console.WriteLine($"Nice to meet you {username}. Welcome to MonOutil.");

            // Code qui permet à l'utilisateur de choisir entre l'outil Meteo et l'outil Monnaie
            string? Tool;
            Console.WriteLine("Do you want to access the Meteo tool or the Monnaie tool (Meteo = 1, Monnaie = 2)?: ");
            Tool = Console.ReadLine();
            Tool = Convert.ToString(Tool);

            if (Tool == "1")
            {
                Meteo meteo = new Meteo();
            }
            else if (Tool == "2")
            {
                Monnaie monnaie = new Monnaie();
            }

        }

    }

}
