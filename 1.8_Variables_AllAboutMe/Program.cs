using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8_Variables_AllAboutMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, fav_food, location;
            int no_of_pets;
            bool whistle;


            name = "Ada Lovelace";
            fav_food = "hot buttered gnocchi";
            no_of_pets = 5;
            location = "pineaple under the sea";
            whistle = false;

            Console.WriteLine("My name is {0}.",name);
            Console.WriteLine("My favorite food is {0}.",fav_food);
            Console.WriteLine("I have {0} pets.",no_of_pets);
            Console.WriteLine("I live in a {0}, and I love it here.",location);

            if (whistle){
                Console.WriteLine(" It is {0}, I know how to whistle.", whistle);
            }
            else {
                Console.WriteLine("It is {0}, I do not know how to whistle.", whistle);
            }


        }
    }
}
