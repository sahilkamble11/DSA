namespace QueueLinkedList;

internal class Program
{
    public static void Main(string[] args)
    {
        Queue queue= new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        queue.Display();

        Console.WriteLine();
        queue.Dequeue();

        Console.WriteLine();

        //queue.Display();~    
            
        }
}