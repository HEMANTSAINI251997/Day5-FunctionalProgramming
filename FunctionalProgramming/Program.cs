using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n" + "1.Flip Coin and print percentage of Heads and Tails" + "\n");
                Console.WriteLine("\n" + "2. Check Leap Year" + "\n");
                Console.WriteLine("\n" + "3. FOR EXIT" + "\n");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Checkflipcoin();
                        break;
                    case 2:
                        LeapYear leapYear = new LeapYear();
                        leapYear.Checkleapyear();
                        break;

                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter correct options");
                        break;
                }
            }
        }
    }

}
