using System;
using System.Collections.Generic;
using System.Text;

namespace String_Problems
{
    internal class DuplicateCharacters
    {
        public void DisplayDuplicateCharacters()
        {
            Console.WriteLine("Enter String :");
            string str = Console.ReadLine();
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            Console.WriteLine("Duplicate characters in the string:");
            foreach (var item in charCount)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine($"Character '{item.Key}' occurred {item.Value} times.");
                }
            }

        }
    }
}
