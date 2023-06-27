using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class LargestNumber
    {
        public void Checklargestnumber()
        {
            Console.Write("Enter the first number: ");
            int num_one = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num_two = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num_three = Convert.ToInt32(Console.ReadLine());

            int largestNumber = num_one;

            if (num_two > largestNumber)
                largestNumber = num_two;

            if (num_three > largestNumber)
                largestNumber = num_three;

            Console.WriteLine($"The largest number among {num_one}, {num_two}, and {num_three} is: {largestNumber}");
        }
    }
}