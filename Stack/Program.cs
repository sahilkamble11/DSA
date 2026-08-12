namespace StackDSA;

public class Program
{
    public static void Main(string [] arg)
    {
        Stack stack= new Stack(5);
        stack.Push(11);
        stack.Push(22);
        stack.Push(33);

        stack.Peek();
        stack.Pop();
        stack.Peek();
        stack.Pop();
        stack.Peek();
        stack.Pop();
        stack.Peek();
    }

}
