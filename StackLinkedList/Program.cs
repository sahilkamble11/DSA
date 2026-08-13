namespace StackLinkedList;

public class Program
{
    public static void Main(string [] args)
    {
        Stack stack=new Stack();
        stack.Push(11);
        stack.Push(22);
        stack.Push(33);
        stack.Push(44);

        stack.Peek();

        stack.Pop();

        stack.Peek();

        stack.IsEmpty();
    }
}