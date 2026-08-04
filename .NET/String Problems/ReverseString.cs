using System;
using System.Collections.Generic;
using System.Text;

namespace String_Problems
{
    internal class ReverseString
    {
        public void ReverseInputString()
        {
            Console.WriteLine("Enter a string to reverse:");
            string inputString = Console.ReadLine();
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine($"The reversed string is: {reversedString}");
        }

        public void ReverseStringWithoutUsingReverseMethod()
        {
            Console.WriteLine("Enter a string to reverse without using built-in methods:");
            string inputString = Console.ReadLine();
            string reversedString = string.Empty;
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                reversedString += inputString[i];
            }
            Console.WriteLine($"The reversed string is: {reversedString}");
        }
    }
}
