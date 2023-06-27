using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    public class Alphabet
    {
        public void CheckVowelConsonant()
        {
            Console.Write("Enter an alphabet: ");
            char alphabet = Convert.ToChar(Console.ReadLine());

            if (char.IsLetter(alphabet))
            {
                alphabet = char.ToLower(alphabet);
                if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
                    Console.WriteLine(alphabet + " is a vowel.");
                else
                    Console.WriteLine(alphabet + " is a consonant.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an alphabet.");
            }
        }
    }
}
