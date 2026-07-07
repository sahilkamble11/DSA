using CircularLinkedList.DSANode;

namespace CircularLinkedList.DSACircularLinkedList;

public class CircularLinkedList
{
    Node head=null;
    Node current=null;

    public bool InsertAtStart(int data)
    {
        Node newNode=new Node(data);
        
        if (head == null)
        {
            head=newNode;
            head.next=head;
            return true;
        }
        else
        {
            current=head;
            while (current.next != head)
            {
                current=current.next;
            }
            current.next=newNode;
            newNode.next=head;
            head=newNode;

            return true;
        }
        // else
        // {
        //     head.next.next=newNode;
        //     head=newNode;
        // }
        return false;
    }
    public bool InsertAtEnd(int data)
    {
        Node newNode=new Node(data);
        current=head;
        if (head == null)
        {
            head=newNode;
            head.next=head;
            return true;
        }
        else
        {
            current=head;
            while (current.next != head)
            {
                current=current.next;
            }
            current.next=newNode;
            newNode.next=head;
            return true;
        }
        return false;
    }
   
    public bool InsertAnyWhere(int data)
    {
        Node newNode=new Node(data);
        current=head;
        if (head == null)
        {
            head=newNode;
            head.next=head;
            return true;
        }
        else
        {
            while (current.next.data < data)
            {
                current=current.next;
            }
            newNode.next=current.next;
            current.next=newNode;
        }
        return false;
    }
    public void Display()
    {
        Console.Write("Linked List: ");
        current=head;
        while (current.next != head)
        {
            Console.Write(current.data+" ");
            current=current.next;
        }       
        Console.Write(current.data+" ");

    }
}