namespace StackDSA;

public class Stack
{
    int top=-1;
    int [] arr;
    int size;

    public Stack(int size)
    {
        this.size=size;
        arr=new int [size];
       // top=0;
    }

    public void Push(int data)
    {
        if (top == size-1)
        {
            Console.WriteLine("Stack Overflow..");
            return;
            
        }
        top++;
        arr[top]=data;
        Console.WriteLine("Inserting: "+arr[top]);
        
         
    }

    public void Pop()
    {
        if(top==-1)
        {
            Console.WriteLine("Stack is Empty..");
            return;
        }
        Console.WriteLine("Popped Element: "+arr[top]);
        top--;
    }

    public void Peek()
    {
        if(top==-1)
        {
            Console.WriteLine("Stack is Empty..");
            return;
        }
        Console.WriteLine("Last Inserted Element: "+ arr[top]);
        
    }
}