using System;
namespace DS_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********LINKED LIST********\n");
            ///Creating instance of linked list
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Append(70);
            Console.WriteLine("\nValues in Linked List:-");
            linkedList.Display();
            Console.WriteLine("--------------------------------");
            //Inserting the element at particular position
            Console.WriteLine("Inserting the values");
            linkedList.InsertAtParticularPosition(2, 30);
            linkedList.Display();
            Console.WriteLine("Deleting element at first position");
            linkedList.Pop();
            linkedList.Display();

        }
    }
}