using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class LeapYear
    {
        public void Checkleapyear()
        {
            int year = 0;
            Console.Write("Enter a year (4 digits): ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year.ToString().Length == 4)
            {

                bool isLeapYear = false;

                if (year % 4 == 0)
                {
                    if (year % 100 != 0 || year % 400 == 0)
                    {
                        isLeapYear = true;
                    }
                }

                if (isLeapYear)
                {
                    Console.WriteLine(year + " is a leap year.");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine("Invalid year format. Please enter a 4-digit year.");

            }
        }

    }
}