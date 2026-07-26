namespace LinkedList.Node;
using System.Globalization;
public class Node
{
    public Node Previous;
    public int data;
    public Node Next;

    public Node(int data)
    {
        this.data=data;
        Previous=null;
        Next=null;
    }
}