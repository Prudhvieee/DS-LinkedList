using System;
using System.Collections.Generic;
using System.Text;

namespace DS_LinkedList
{
    public class LinkedList
    {
        public Node head;
        /// <summary>
        /// Add method is used to add data into the linkedlist.
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
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
        /// Append method is used to append the data
        /// </summary>
        /// <param name="item"></param>
        public void Append(int item)
        {
            Node node = new Node(item);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} appended to the linked list", node.data);
        }
        /// <summary>
        /// display method is used to Display the instance
        /// </summary>
        public void Display()
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
        /// <summary>
        /// UC-4 
        /// used to insert data at particular position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position");
            }
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position out of range");
                }
            }
            return head;
        }
        /// <summary>
        /// UC-5
        /// Pop method deletes the first element in the linked list
        /// </summary>
        /// <returns></returns>
        public Node Pop()
        {
            Node node = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty.");
            }
            else
            {
                head = head.next;
            }
            return node;
        }
        /// <summary>
        /// UC-6
        /// PopLast method is used to delete the last element
        /// </summary>
        /// <returns></returns>
        public Node PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty.");
                return null;
            }
            else
            {
                Node newNode = head;
                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
                Node removedNode = newNode.next;
                newNode.next = null;
                return removedNode;
            }
        }
        /// <summary>
        /// UC-7
        /// used to search data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int Search(int data)
        {
            int count = 1;
            Node temp = head;
            if (this.head == null)
            {
                return 0;
            }
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return count; ;
                }
                temp = temp.next;
                count++;
            }
            return 0;
        }
        public void InsertNodeAfterParticularNode(int data, int dataToSearch)
        {
            int position = Search(dataToSearch);
            if (position == 0)
            {
                Console.WriteLine("No such element found");
                return;
            }
            Node node = new Node(data);
            Node temp = this.head;
            for (int i = 1; i < position; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
        }
    }
}
