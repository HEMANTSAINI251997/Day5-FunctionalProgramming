using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class Division
    {
        public void Checkcompute()
        {
            Console.Write("Enter the dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            if (divisor != 0)
            {

                int quotient = dividend / divisor;
                int remainder = dividend % divisor;

                Console.WriteLine("Quotient: " + quotient);
                Console.WriteLine("Remainder: " + remainder);
            }
            else
            {
                Console.WriteLine("Divisor cannot be zero.");

            }
        }
    }
}
