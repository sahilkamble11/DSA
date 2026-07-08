using CircularLinkedList.DSANode;

namespace CircularLinkedList.DSACircularLinkedList;

public class CircularLinkedList
{
    Node head=null;
    
    Node current=null;

    public void InsertAtStart(int data)
    {
        Node newNode=new Node(data);
        
        if (head == null)
        {
            head=newNode;
            head.next=head;
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

        }
    }
    public void InsertAtEnd(int data)
    {
        Node newNode=new Node(data);
        current=head;
        if (head == null)
        {
            head=newNode;
            head.next=head;
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
        }
    }
    public void InsertAnyWhere(int data)
    {
        Node newNode=new Node(data);
        current=head;
        if (head == null)
        {
            head=newNode;
            head.next=head;
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
    }
    public void Update(int oldValue,int newValue)
    {
        current=head;
        while (current.data != oldValue)
        {
            current=current.next;
        }
        current.data=newValue;
    }
    public void Delete(int value)
    {
    if (head == null)
    {
        return;
    }

    if (head.data == value)
    {
        head = head.next;
        return;
    }

    Node current = head;

    while (current.next != null && current.next.data != value)
    {
        current = current.next;
    }

    if (current.next != null)
    {
        current.next = current.next.next;
    }
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