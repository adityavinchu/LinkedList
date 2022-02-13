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
            linkedlist.DisplayAll();
            Console.WriteLine();

            linkedlist.InsertFirst(56);
            linkedlist.InsertFirst(30);
            linkedlist.InsertFirst(70);
            Console.ReadLine();

        }
    }
}
