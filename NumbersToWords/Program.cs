using System.ComponentModel;

public class Program
{
   String [] ones=["", "One", "Two", "Three", "Four",
                    "Five", "Six", "Seven", "Eight", "Nine",
                     "Ten", "Eleven", "Twelve", "Thirteen",
                     "Fourteen", "Fifteen", "Sixteen",
                     "Seventeen", "Eighteen", "Nineteen"];

    String [] tens=[ "", "", "Twenty", "Thirty", "Forty",
                     "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];

    public String NumberToWords(int Number)
    {
        String result="";

        if(Number >= 100)
        {
            result += ones[Number/100] + " hundred";
            Number=Number%100;

            if(Number > 0)
            {
                result += " and ";
            }
        }

        if (Number >= 20)
        {
            result+= tens[Number/10];
            Number=Number%10;


            if (Number > 0)
            {
                result+=" "+ones[Number];
            }
        }

        else if (Number > 0)
        {
            result+=" "+ones[Number];
        }
        return result;
    }

    public static void Main(String [] arg)
    {
        Program program = new Program();
        Console.Write("Enter Number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Answer: "+program.NumberToWords(number));
    }
    
}