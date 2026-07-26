using System;
using System.Collections.Generic;
using System.Text;

namespace String_Problems
{
    internal class CountFrequency
    {
        public void CountFrequencyOfCharacter()
        {
            Console.WriteLine("Enter String :");
            string str = Console.ReadLine();
            Console.WriteLine("Enter Character to find Occurrence");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int count = 0;

            foreach (char c in str)
            {
                if (c == inputChar)
                {
                    count++;
                }
            }
            Console.WriteLine($"Char {inputChar} occurred {count} times in {str}");
        }
    }
}

