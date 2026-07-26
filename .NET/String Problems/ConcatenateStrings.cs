using System;
using System.Collections.Generic;
using System.Text;

namespace String_Problems
{
    internal class ConcatenateStrings
    {
        public void ConcatenateTwoStrings()
        {
            Console.WriteLine("Enter the first string: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the second string: ");
            string str2 = Console.ReadLine();
            string concatenatedString = str1 + str2; // Concatenating str1 and str2
            Console.WriteLine("The concatenated string is: " + concatenatedString);
        }
    }
}
