using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonOutil
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

           
   
        }

    }

}








