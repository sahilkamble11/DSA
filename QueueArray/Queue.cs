namespace QueueArray;

public class Queue
{
    int size;
    int front;
    int rear;
    int[] arr;
    public Queue(int size)
    {
        this.size=size;
        arr=new int[size];
        front=0;
        rear=-1;
    }

    public void Enqueue(int data)
    {
        if (rear == size - 1)
        {
            Console.WriteLine("Queue is full..");
            return;
        }

        rear++;
        arr[rear]=data;

    }

    public int Dequeue()
    {
        if (front > rear)
        {
            Console.WriteLine("Queue is Empty..");
            return 0;
        }
        Console.WriteLine();
         return arr[front];
        
        front++;
    }

    public bool IsEmpty()
    {
        if (front > rear)
        {
            return true;
        }
        return false;
    }

    public void Peek()
    {
        if (front > rear)
        {
            Console.WriteLine("Queue is Empty..");
            return;
        }
        Console.WriteLine("First Element: "+arr[front]); 
    }

    public void Display()
    {
        for(int i = front ; i <= rear; i++)
        {
            Console.Write(arr[i]+"<--");
        }
    }

}