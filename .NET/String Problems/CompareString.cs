using System;
using System.Collections.Generic;
using System.Text;

namespace String_Problems;

    public class CompareString
    {
        public void CompareTwoStrings()
    {
        Console.WriteLine("Enter first string:");
        string firstString = Console.ReadLine();

        Console.WriteLine("Enter second string:");
        string secondString = Console.ReadLine();

        Console.WriteLine("Comparing the two strings....");
        if (firstString.Equals(secondString))
        {
            Console.WriteLine("The two strings are equal.");
        }
        else
        {
            Console.WriteLine("The two strings are not equal.");
        }
    }
}

