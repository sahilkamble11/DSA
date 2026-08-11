using System;
using System.Collections.Generic;
using System.Text;

namespace QueueLinkedList
{
    internal class Queue
    {
        Node front;
        Node rear;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (front == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear = rear.next = newNode;
               //  rear = rear.next;
            }
        }

        public int Dequeue()
        {
            if(front == null)
            {
                Console.WriteLine("Empty Queue..");
            }
            int value = front.data;
            //Console.WriteLine("Front Value: " +value);

            front=front.next;

            //Traverse();

            return value;
        }

        public void Peek()
        {
            if(front == null)
            {
                Console.WriteLine("Empty Queue..");
            }

            Console.WriteLine("Front Element: "+ front.data);


            
        }

        public void Traverse()
        {
            Node current = front;
            while (current != null)
            {
                Console.Write( current.data + "-->");
                current = current.next;
            }
        }
    }
}
