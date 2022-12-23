//Key the code below into a new project named MoreBucketsMoreFun.
//Build and run it to make sure it works.
//What operator are we using to show that the dog ate a bug? (Answer in a comment.)
//Why does the number of bugs not change when we change the number of butterflies? (Answer in a comment.)
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_Variables_MoreBucketsOfFun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare ALL THE THINGS
            // (Usually it's a good idea to declare them at the beginning of the program)
            int butterflies, beetles, bugs;

            // Now assign values to some of the variables
            butterflies = 5;
            beetles = 9;

            // Next, we use the variables to create output
            bugs = butterflies + beetles;
            Console.WriteLine("There are only " + butterflies + " butterflies,");
            Console.WriteLine("but there are " + bugs + " bugs in all.");

            Console.WriteLine("Uh oh, my dog ate one.");
            butterflies--;
            Console.WriteLine("Now there are only " + butterflies + " butterflies left.");
            Console.WriteLine("But there are still " + bugs + " bugs left...");
            Console.WriteLine("Wait a minute!");
            Console.WriteLine("... maybe my computer can't do math, after all!");
        }
    }
}
