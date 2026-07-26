namespace String_Problems;

    public class AsciiValueFinder
{
    public void DisplayAsciiValue()
    {
        Console.Write("Enter char: ");
        char inputChar = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int asciiValue = (int)inputChar;
        Console.WriteLine($"The ascii value of '{inputChar}' is: {asciiValue}");
    }
}

