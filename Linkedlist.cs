using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlistprg
{
    public class Linkedlist
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted in linked list", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
        internal Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        internal Node RemoveLastNode()
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;
        }
        internal Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                }
                this.head = this.head.next;
            }
            return null;

        }
        public void InsertAfter(Node prev_node,
                                int new_data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given previous node" + "cannot be null");

                return;
            }

            Node new_node = new Node(new_data);
            new_node.next = prev_node.next;

        }
        void deleteNode(int position)
        {

            if (head == null)
                return;

            Node temp = head;

            if (position == 0)
            {

                head = temp.next;
                return;
            }

            for (int i = 0; temp != null && i < position - 1; i++)

                temp = temp.next;

            if (temp == null || temp.next == null)
                return;

            Node next = temp.next.next;

            temp.next = next;

            Node tnode = head;
            while (tnode != null)
            {
                Console.Write(tnode.data + " ");
                tnode = tnode.next;
            }
        }
        void sortedInsert(Node new_node)
        {
            Node current;

            if (head == null || head.data >= new_node.data)
            {
                new_node.next = head;
                head = new_node;
            }
            else
            {

                current = head;

                while (current.next != null && current.next.data < new_node.data)
                    current = current.next;

                new_node.next = current.next;
                current.next = new_node;
            }
        }
        Node newNode(int data)
        {
            Node x = new Node(data);
            return x;
        }

        void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }


    }
}







