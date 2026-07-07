using DoublyLinkedList.DoublyLinkedList;
using DoublyLinkedList.Node1;
namespace DoublyLinkedList.Main;

public class Program
{
    public static void Main(string [] args)
    {
        DLinkedList doubly=new DLinkedList();
        
        doubly.InsertAtFront(3);
        doubly.InsertAtFront(2);
        doubly.InsertAtFront(1);
        doubly.InsertAtEnd(5);
        doubly.InsertInMiddle(4);
        
        doubly.Display();

       // doubly.Delete(2);
        Console.WriteLine();
        doubly.ReverseDisplay();
       // doubly.Display();
    }
}
