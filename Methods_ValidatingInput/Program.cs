//Using method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_ValidatingInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetIntFromUser("Enter a number to start!"));
        }

        /// <summary>
        /// Method to retrieve and validate input from user 
        /// </summary>
        /// <param name="prompt">Request for user</param>
        /// <returns>The integer value of the user input</returns>
        static int GetIntFromUser(string prompt) 
        { 
            while (true) 
            {
                Console.Write(prompt+":");
                string input = Console.ReadLine();

                int number;

                if (int.TryParse(input, out number))
                {
                    return number;
                }

                Console.WriteLine("That was not a valid integer!");
            }
        
        }
    }
}
