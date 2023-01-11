using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1._1_CollectingUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int output; // storage for converted string

            // infinite loop
            while (true)
            {
                Console.Write("Enter a number between 1 and 10: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out output))
                {
                    // it was an int, now is it between 1 and 10?
                    if (output >= 1 && output <= 10)
                    {
                        break; // good input
                    }
                    else
                    {
                        Console.WriteLine("That number was not between 1 and 10!");
                    }
                }
                else
                {
                    Console.WriteLine("That was not a number!");
                }
            }

        }
    }
}
