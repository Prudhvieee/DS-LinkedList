using System;
using System.Collections.Generic;
using System.Text;

namespace DS_LinkedList
{
    public class LinkedList
    {
        internal Node head;
        /// <summary>
        /// Add method is used to add data into the linkedlist.
        /// </summary>
        /// <param name="data"></param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node Temp = head;
                while (Temp.next != null)
                {
                    Temp = Temp.next;
                }
                Temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }
        /// <summary>
        /// display method is used to Display the instance
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedLlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
