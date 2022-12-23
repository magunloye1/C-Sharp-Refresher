using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5_Variables_InABUcket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can declare all KINDS of variables.
            String walrus;
            double piesEaten;
            float weightOfTeacupPig;
            int grainsOfSand;

            // But declaring them just sets up the space for data.
            // If you want to use the variable, you have to put data IN it first!
            walrus = "Sir Leroy Jenkins III";
            piesEaten = 42.1;

            Console.WriteLine("Meet my pet walrus, " + walrus);
            Console.Write("He was a bit hungry today and ate this many pies: ");
            Console.WriteLine(piesEaten);
        }
    }
}
