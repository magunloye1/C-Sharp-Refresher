﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_Variables_TheOrderOfThings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            String opinion, size, age, shape, color, origin, material, purpose;
            String noun;

            number = 5;
            opinion = "AWESOME";
            size = "teensy-weensy";
            age = "new";
            shape = "oblong";
            color = "yellow";
            origin = "Martian";
            material = "platinum";
            purpose = "good";

            noun = "dragons";

            // Using the + with strings doesn't add -- it concatenates! (sticks them together)
            Console.WriteLine(number + " " + opinion + " " + size + " " + age + " " + shape + " " + color
                    + " " + origin + " " + material + " " + purpose + " " + noun);
        }
    }
}
