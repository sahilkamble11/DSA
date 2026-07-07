namespace DSA.LinkedList;

using DSA.Nodes;
public class LinkedList
{
    Node? head;
    public bool Insert(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return true;
        }
        Node p = head;
        while (p.next != null)
        {
            p = p.next;
        }
        p.next = newNode;
        return true;
    }

    public void DisplayNodes()
    {
        Node p = head;
        while (p != null)
        {
            Console.Write(p.data + " ");
            p = p.next;
        }

        Console.WriteLine();
    }

    public bool UpdateNode(int oldValue, int newValue)
    {
        if (head == null)
        {
            return false;
        }
        Node? current = head;

        while (current != null)
        {
            if (current.data == oldValue)
            {
                current.data = newValue;
                Console.WriteLine($"{oldValue} has been changed with {newValue}");
                return true;
            }
            current = current.next;
        }
        return false;
    }

    public void DeleteNode(int value)
    {

        if (head.data == value)
        {
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                head=head.next ;
            }
        }
        else
        {
            Node current = head;

            while (current.next.data != value)
            {
                current = current.next;
            }
            if (current.next.next == null)
            {
                current.next = null;
            }
            else
            {
                current.next = current.next.next;
            }
        }
    }

}