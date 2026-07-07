using DoublyLinkedList.Node1;
namespace DoublyLinkedList.DoublyLinkedList;

public class DLinkedList
{
    Node head=null;
    Node current=null;
    Node tail;

    public bool InsertAtFront(int data)
    {
        Node newNode=new Node(data);

        if (head == null)
        {
            
            head=newNode;
            tail=head;
            return true;
        }
        else
        {
            newNode.Next=head;
            head.Previous=newNode;

            head=newNode;
            return true;
        }
        
        return false;
    }
    
    public bool InsertAtEnd(int data)
    {
        Node newNode=new Node(data);

        if (head == null)
        {
            head=newNode;
            tail=head;
            return true;
        }       
        else
        {
            current=head;
            while (current.Next != null)
            {
                current=current.Next;
            }
            current.Next=newNode;
            newNode.Previous=current;
            tail=newNode;
            //current.Next=null;
            return true;
        }
        return false;
    }   
    
    public bool InsertInMiddle(int data)
    {
        Node newNode=new Node(data);
        

        if (head == null)
        {
            head=newNode;
            return true;
        }
        else
        {
            current=head;
            while(current.Next!=null){
            if (current.Data <= data && current.Next.Data >= data)
            {
                newNode.Next=current.Next;
                newNode.Previous=current;

                current.Next.Previous=newNode;
                current.Next=newNode;

                return true;
            }
            current=current.Next;
            }
        }

        return false;
    }
    
    public bool Update(int OldValue,int NewValue)
    {
        current=head;
        while (current != null)
        {
            if (current.Data == OldValue)
            {
                current.Data=NewValue;
                return true;
            }
            current=current.Next;
        }
        
        return false;
    }    
    
    public bool Delete(int value)
    {
        current=head;

        if(head.Data==value)
        {
            if(head.Next==null)
            {
                head=null;
                tail=null;
                return true;
            }
            else
            {
                head=head.Next;
            }
        }
        else
        {
            while(current.Next.Data<value)
            {
                current=current.Next;
            }

            if(current.Next.Next==null)
            {
                current.Next=null;
                tail=current;
                return true;

            }
            else
            {
                current.Next=current.Next.Next;
                current.Next.Previous=current;
                return true;
            }
        }

        return false;
    }
    
    public void Display()
    {
        current=head;
        while (current != null)
        {
            Console.Write(current.Data + "-->");
            current=current.Next;
        }
    }

    public void ReverseDisplay()
    {
        current=tail;

        while (current != null)
        {
            Console.Write(current.Data+"<--");
            current=current.Previous;
        }
    }
}