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


            linkedlist.InsertLast(56);
            
            linkedlist.InsertLast(70);
            linkedlist.InsertAtPos(30, 2);
            linkedlist.DisplayAll();

            Console.WriteLine();
            Console.WriteLine("Total Nodes:" + linkedlist.Count());


            linkedlist.DeleteLast();

            Console.WriteLine();
            linkedlist.DisplayAll();
            Console.WriteLine();
            Console.WriteLine("Total Nodes:" + linkedlist.Count());
            Console.ReadLine();
        }
    }
}
