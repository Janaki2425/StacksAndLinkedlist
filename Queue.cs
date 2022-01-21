using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues;

internal class Queue
{
    private Node rear;
    public Queue()
    {
        this.rear = null;
    }
    internal void Enqueue(int value)
    {
        Node node = new Node(value);
        if (this.rear == null)
        {
            node.next = null;

        }
        else
        {
            node.next = this.rear;
        }
        this.rear = (node);
        Console.WriteLine("{0} is queued", value);


    }
    internal void Display()
    {
        Node temp = this.rear;
        while (temp != null)
        {
            Console.WriteLine(temp.data + "");
            temp = temp.next;

        }
    }

    internal void Dequeue()
    {
        if (this.rear == null)
        {
            Console.WriteLine("queue is empty cannot be deleted");
            return;
        }
        Console.WriteLine("value dequeued is {0},this.topdata");
        this.rear = this.rear.next;
    }
    internal void Isempty()
    {
        while (this.rear != null)
        {
            Enqueue();
            Dequeue();
        }
    }
}

