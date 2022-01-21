using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues;

    public class StackLinkedlist
    {
        private Node top;
        public StackLinkedlist()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if(this.top == null)
            {
                node.next = null;

            }
            else
            {
                node.next = this.top;
            }
            this.top=(node);
            Console.WriteLine("{0} is pushed to stack", value);


        }
        internal void Display()
        {
            Node temp = this.top;
            while(temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;

            }
        }
        internal void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);
        }
        
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty cannot be deleted");
                return;
            }
            Console.WriteLine("value popped is {0},this.topdata");
            this.top=this.top.next;
        }
    internal void Isempty()
        {
            while(this.top!= null)
            {
                Peek();
                Pop();
            }
        }
    
     }

