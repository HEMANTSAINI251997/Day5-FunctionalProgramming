using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class FlipCoin
    {
        public void Checkflipcoin()
        {
            int toss;
            int headscount = 0;
            int tailscount = 0;
            Console.WriteLine("Enter the number of times, you want to flip");
            toss = Convert.ToInt32(Console.ReadLine());
            if (toss > 0)
            {
                for (int i = 0; i < toss; i++)
                {
                    Random random = new Random();
                    double check = random.Next(0, 2);
                    if (check < 0.5)
                    {
                        headscount++;
                    }
                    else
                    {
                        tailscount++;
                    }

                }
                int headsPercentage = (int)headscount / toss * 100;
                int tailsPercentage = (int)tailscount / toss * 100;

                Console.WriteLine("Number of flips: " + toss);
                Console.WriteLine("Heads count: " + headscount);
                Console.WriteLine("Tails count: " + tailscount);
                Console.WriteLine("Percentage of Heads: " + headsPercentage + "%");
                Console.WriteLine("Percentage of Tails: " + tailsPercentage + "%");
            }
            else
            {
                Console.WriteLine("Please enter the positive number");
            }

        }
    }
}