﻿using System;
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
            linkedList.Append(30);
            linkedList.Append(70);
            Console.WriteLine("\nValues in Linked List:-");
            linkedList.Display();
        }
    }
}