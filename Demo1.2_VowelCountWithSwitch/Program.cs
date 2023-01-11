//Using loops to print out the vowels and count of vowels in a string
//Adapted from original - print vowels in a string
//Jan 10, 2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1._2_VowelCountWithSwitch
{
    internal class Program
    {           
        static void Main(string[] args)
        {
            string input; // storage for user input string
            Console.Write("Enter a any string: ");
            input = Console.ReadLine();
            int count = 0;

            // infinite loop
            while (string.IsNullOrEmpty(input))
            {
                Console.Write("Enter a any string: ");
                input = Console.ReadLine();

            }

            //   iterator    condition   increment
            for (int i = 0; i < input.Length; i++)
            {
                // get character at index i
                char current = input[i];

                // is current a vowel?
                switch (current)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.Write(current);
                        count++;

                        break;
                }

            }

            Console.WriteLine();
            Console.WriteLine($"There are {count} vowels");

        }
    }
}
