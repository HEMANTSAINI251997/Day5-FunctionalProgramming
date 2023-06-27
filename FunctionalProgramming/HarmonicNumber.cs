using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class HarmonicNumber
    {
        public void Checkharmonic()
        {
            int num;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            for (int val = 1; val <= num; val++)
            {
                Console.Write("1/{0} + ", val);
            }
        }

    }
}