﻿using System;
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


            linkedlist.InsertFirst(70);
            linkedlist.InsertFirst(30);
            linkedlist.InsertFirst(56);

            linkedlist.DisplayAll();
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
