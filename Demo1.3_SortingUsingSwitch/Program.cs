using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1._3_SortingUsingSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(1,10);

            ////using If..Else
            //if (num < 3)
            //{
            //    Console.WriteLine("Low Number");
            //}
            //else if (num >= 3 && num <= 6)
            //{
            //    Console.WriteLine("Middle Number");
            //}
            //else
            //{
            //    Console.WriteLine("High Number");
            //}


            //using Switch
            switch (num)
            {
                case 1: case 2:
                    Console.WriteLine($"Low Number: {num}");
                    break; 

                case 3:case 4:case 5:case 6:
                    Console.WriteLine($"Middle Number: {num}");
                    break;

                default:
                    Console.WriteLine($"High Number: {num}");
                    break;
            }


        }
    }
}
