namespace StackLinkedList;

public class Stack
{
    Node top = null;
    
    public void Push(int data)
    {
        Node newNode= new Node(data);
        newNode.next=top;
        top=newNode;
        return;
    }

    public void Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack is Empty.");
            return;
        }
        Console.WriteLine($"Popped Element: {top.data}");
        top=top.next;
        return;
    }

    public void Peek()
    {
         if (top == null)
        {
            Console.WriteLine( "Stack is Empty.");
            return;
        }

        Console.WriteLine($"Last Inserted Element: {top.data}");
        return ;
    }

    public bool IsEmpty()
    {
        if (top == null)
        {
            return true;
        }
        return false;
    }
}