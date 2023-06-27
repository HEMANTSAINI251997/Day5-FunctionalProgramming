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
                Console.WriteLine("\n" + "3. Power of 2" + "\n");
                Console.WriteLine("\n" + "4. Harmonic Number" + "\n");
                Console.WriteLine("\n" + "5. Factors" + "\n");
                Console.WriteLine("\n" + "6. To Compute Quotient and Remainder" + "\n");
                Console.WriteLine("\n" + "7. For Swaping Two NUmber" + "\n");
                Console.WriteLine("\n" + "8. To Check Whether a Number is Even or Odd" + "\n");
                Console.WriteLine("\n" + "9. To Check Whether an Alphabet is Vowel or Consonant" + "\n");
                Console.WriteLine("\n" + "10. To Find the Largest Among Three Numbers" + "\n");
                Console.WriteLine("\n" + "11. FOR EXIT" + "\n");
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
                        PowerOfTwo powerOftwo = new PowerOfTwo();
                        powerOftwo.Checkpower();
                        break;                   
                    case 4:
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.Checkharmonic();
                        break;
                    case 5:
                        Factor factor = new Factor();
                        factor.Checkfactor();
                        break;
                    case 6:
                        Division division = new Division();
                        division.Checkcompute();
                        break;
                    case 7:
                        Swap swap = new Swap();
                        swap.Checkswap();
                        break;
                    case 8:
                        EvenOdd evenodd = new EvenOdd();
                        evenodd.Checkevenodd();
                        break;
                    case 9:
                        Alphabet alphabet = new Alphabet();
                        alphabet.CheckVowelConsonant();
                        break;
                    case 10:
                        LargestNumber largestnumber = new LargestNumber();
                        largestnumber.Checklargestnumber();
                        break;
                    case 11:
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
