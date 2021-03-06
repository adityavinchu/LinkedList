using System;
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

        public void InsertLast(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
            {
                head = newnode;
                
            }
            else
            {
                Node Temp = head;
                while (Temp.next != null)
                {
                    Temp = Temp.next;
                }
                Temp.next = newnode;
                
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

        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                head = head.next;
            }
        }

        public void DeleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");   
            }
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                Node temp = head;

                while (temp.next.next != null)
                { temp = temp.next; }
                temp.next = null;                
            }
        }


        public void DeleteAtPos(int pos)
        {
            if ((pos < 1) || pos > Count())
            {
                Console.WriteLine("Enter Valid Position\n");
                return;
            }
            if (pos == 1)
            {
            DeleteFirst();
            }
            if (pos == Count())
            {
                DeleteLast();
            }
            else
            {
                Node temp = head;
                for (int i = 0; i < pos - 1; i++)
                {
                    temp = temp.next;
                }
                Node targated = temp.next;
                temp.next = targated.next;
            }
        }


        public int Search(int data)
        {
            Node temp = head;
            int position = 0;
            while (temp != null)
            {
                if (temp.data == data)
                { 
                    return position; 
                }
                temp = temp.next;
                position++;
            }
            return -1;
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
