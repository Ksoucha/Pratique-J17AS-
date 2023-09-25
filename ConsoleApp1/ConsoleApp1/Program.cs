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
            Console.Write("Bonjour, quel est votre nom?");

            // Code qui lit la console pour stocker le nom
            string? username;

            username = Console.ReadLine();

            // Code qui accueille l'utilisateur par son nom
            Console.WriteLine($"Bienvenue {username} à MonOutil.");

           
        }
    }

}








