using System;
using System.Collections.Generic;
using System.Text;

namespace QueueLinkedList
{
    internal class Node
    {
        internal Node next;
        internal int data;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
