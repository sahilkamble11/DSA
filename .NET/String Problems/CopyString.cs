using System;
using System.Collections.Generic;
using System.Text;

namespace String_Problems
{
    internal class CopyString
    {
        public void CopyOneStringToAnother()
        {
            Console.WriteLine("Enter the first string: ");
            string str1 = Console.ReadLine();
            string str2 = str1; // Copying str1 to str2
            Console.WriteLine("The copied string is: " + str2);
        }
    }
}
