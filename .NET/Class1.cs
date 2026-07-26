using System;

public class Ascii
{
	public static void Main(string[] args)
    {
        Console.WriteLine("Enter a character:");
        char inputChar = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int asciiValue = (int)inputChar;
        Console.WriteLine($"The ASCII value of '{inputChar}' is: {asciiValue}");
    }
}
