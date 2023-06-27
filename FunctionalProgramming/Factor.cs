using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class Factor
    {
        public void Checkfactor()
        {
            Console.Write("Enter a number to find its prime factors: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1)
            {

                Console.Write("Prime factors of " + number + ": ");

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
               
                               
            }
            else
            {
                Console.WriteLine("Number should be greater than 1.");

            }
        }

    }


}