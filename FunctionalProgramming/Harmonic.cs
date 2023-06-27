using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class Harmonic
    {
        public void Checkharmonic()
        {
            Console.Write("Enter the Number (N >= 0): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0)
            {

                double harmonicNumber = 0;

                for (int i = 1; i <= n; i++)
                {
                    harmonicNumber += 1.0 / i;
                }

                Console.WriteLine("The " + n + "th Harmonic Number: " + harmonicNumber);
            }
            else
            {
                Console.WriteLine("Number should be a greater than zero integer.");

            }
        }

    }
}