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
            linkedlist.InsertLast(30);
            linkedlist.InsertLast(70);

            linkedlist.DisplayAll();
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
