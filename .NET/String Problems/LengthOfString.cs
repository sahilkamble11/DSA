using System;
using System.Collections.Generic;
using System.Text;

namespace String_Problems
{
    internal class LengthOfString
    {
        public void FindLengthOfStringEWithoutUsingLengthMethod()
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            int length = 0;
            foreach (char c in inputString)
            {
                length++;
            }
            Console.WriteLine($"The length of the string is: {length}");
        }
    }
}
