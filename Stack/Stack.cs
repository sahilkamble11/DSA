namespace StackDSA;

public class Stack
{
    int current=-1;
    int [] arr;
    int size;

    public Stack(int size)
    {
        this.size=size;
        arr=new int [size];
       // current=0;
    }

    public void Push(int data)
    {
        if (current == size-1)
        {
            Console.WriteLine("Stack Overflow..");
            return;
            
        }
        current++;
        arr[current]=data;
        Console.WriteLine("Inserting: "+arr[current]);
        
         
    }

    public void Pop()
    {
        if(current==-1)
        {
            Console.WriteLine("Stack is Empty..");
            return;
        }
        Console.WriteLine("Popped Element: "+arr[current]);
        current--;
    }

    public void Peek()
    {
        if(current==-1)
        {
            Console.WriteLine("Stack is Empty..");
            return;
        }
        Console.WriteLine("Last Inserted Element: "+ arr[current]);
        
    }
}