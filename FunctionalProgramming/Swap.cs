using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class Swap
    {
        public void Checkswap()
        {
            Console.Write("Enter the first number: ");
            int num_one = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num_two = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping: ");
            Console.WriteLine("First number: " + num_one);
            Console.WriteLine("Second number: " + num_two);

            int temp = num_one;
            num_one = num_two;
            num_two = temp;

            Console.WriteLine("After swapping: ");
            Console.WriteLine("First number: " + num_one);
            Console.WriteLine("Second number: " + num_two);
        }
    }
}