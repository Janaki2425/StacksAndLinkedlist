using System;
namespace StacksAndQueues;

public class Program
{
    static void Main(string[] args)
    {
        StackLinkedlist push = new StackLinkedlist();
        push.Push();
        StackLinkedlist pop = new StackLinkedlist();
        pop.Pop();
        StackLinkedlist peek = new StackLinkedlist();
        peek.Peek();
        StackLinkedlist display = new StackLinkedlist();
        display.Display();
        StackLinkedlist isempty = new StackLinkedlist();
        isempty.Isempty();
        Queue enqueue= new Queue();
        enqueue.Enqueue();
        Queue dequeue= new Queue();
        dequeue.Dequeue();
    }
}



