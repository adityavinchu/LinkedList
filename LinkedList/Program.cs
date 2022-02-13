using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();

            linkedlist.InsertFirst(85);
            linkedlist.InsertFirst(45);
            
            linkedlist.InsertLast(56);
            linkedlist.InsertLast(70);
            
            linkedlist.InsertAtPos(30, 2);
            linkedlist.InsertAtPos(35, 6);


            linkedlist.DisplayAll();

            Console.WriteLine();
            Console.WriteLine("Total Nodes:" + linkedlist.Count());

            linkedlist.DeleteFirst();

            linkedlist.DeleteLast();

            Console.WriteLine();
            linkedlist.DisplayAll();
            Console.WriteLine();
            Console.WriteLine("Total Nodes:" + linkedlist.Count());
            

            Console.WriteLine();
            Console.WriteLine("Searched value is at position :"+linkedlist.Search(56));
            

Console.ReadLine();

        }
    }
}
