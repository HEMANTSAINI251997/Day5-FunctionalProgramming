using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class PowerOfTwo
    {

        public void Checkpower()
        {
            int powervalue = 0;
            Console.Write("Enter the power value (0 <= N < 31): ");
            powervalue = Convert.ToInt32(Console.ReadLine());

            if (powervalue > 0 && powervalue <= 31)
            {
                Console.WriteLine("Powers of 2 up to 2^" + powervalue + ":");

                for (int i = 0; i <= powervalue; i++)
                {
                    int result = 0;
                    result = (int)Math.Pow(2, i);
                    Console.WriteLine("2^" + i + " = " + result);
                }
            }
            else
            {
                Console.WriteLine("Invalid power value. Please enter a value between 0 and 31.");

            }
        }
    }
}
