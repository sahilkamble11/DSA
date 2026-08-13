public class Program
{
    public static void Main(string [] args)
    {
        int [] arr={6,4,5,2,1};
        int target = 11;

        for(int i=0;  i< arr.Length; i++)
        {
            for(int j = i+1; j< arr.Length; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    Console.WriteLine($"[{i},{j}]");
                    Console.WriteLine($"The Two Numbers are: {arr[i]}+{arr[j]}={target}");
                }
            }
        }
    }
}