namespace CircularLinkedList.Main;

using CircularLinkedList.DSACircularLinkedList;

public class Program
{
    public static void Main(string[] args)
    {
       CircularLinkedList circularLinkedList=new CircularLinkedList();
    //    circularLinkedList.InsertAtStart(5);
      
       circularLinkedList.InsertAtStart(6);
       circularLinkedList.InsertAtStart(3);
       circularLinkedList.InsertAtStart(2);
       circularLinkedList.InsertAtStart(1);
       circularLinkedList.Display(); 

       circularLinkedList.InsertAnyWhere(4);
       circularLinkedList.InsertAnyWhere(5);

        Console.WriteLine();
              circularLinkedList.Display(); 

    }
}
