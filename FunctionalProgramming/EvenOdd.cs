using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class EvenOdd
    {
        public void Checkevenodd()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0 || num < 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Number is Even");
                }
                else
                {
                    Console.WriteLine("Number id Odd");
                }
            }
            else
            {
                Console.WriteLine("Please enter the correct number");
            }
        }
    }
}