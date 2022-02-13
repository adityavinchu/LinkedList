﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {   
        public Node head;

        public void InsertFirst(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public Node InsertLast(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                return head;
            }
            else
            {
                Node Temp = head;
                while (Temp.next != null)
                {
                    Temp = Temp.next;
                }
                Temp.next = newnode;
                return head;
            }
        }


        public void InsertAtPos(int data ,int pos)
        {
            Node newnode = new Node(data);
            if ((pos<1) || pos>Count())
            {
                Console.WriteLine("Enter a valid position");
            }
            if(pos==1)
            {
                InsertFirst(data);
            }
            if(pos>Count())
            {
                InsertLast(data);
            }
            else
            {
                
                Node temp = head;
                for (int i = 1; i < pos - 1; i++)
                {
                    temp = temp.next; 
                }
                newnode.next = temp.next;
                temp.next = newnode;
            }
        }

        public int Count()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        public void DisplayAll()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    Console.Write("->");
                    temp = temp.next;
                }
            }
            Console.Write("NULL");
        }

    }

}
