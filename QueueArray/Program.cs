namespace QueueArray;

public class Program
{
    public static void Main(String[] args)
    {
        Queue queue= new Queue(3);

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
       // queue.Enqueue(4);
        //queue.Peek();
        queue.Display();

        queue.Dequeue();
        queue.Display();
    }
}