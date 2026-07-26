using System;
using System.Collections.Generic;
using System.Text;

namespace String_Problems;
    public class PrintCharacter
    {
    public void DisplayCharacter()
    {
        Console.WriteLine("Enter string to display characters one by one:");
        string inputString = Console.ReadLine();
        Console.WriteLine("Characters in the string:");
        foreach(char c in inputString)
        {
            Console.WriteLine(c);
        }
    }
}
