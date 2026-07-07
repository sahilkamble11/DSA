namespace DoublyLinkedList.Node1;

public class Node
{
    public Node Previous;
    public  int Data;
    public Node Next;
    public Node(int data)
    {
        Previous=null;
        this.Data=data;
        Next=null;
    }
}