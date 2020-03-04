using System;
using System.Collections.Generic;
namespace HelloWorld
{
    public class QueueUsingLinkedList
    {
        LinkedList<Int32> queue;
        public QueueUsingLinkedList()
        {
            queue = new LinkedList<Int32>();
        }

        public void Enqueue(int i)
        {
            queue.AddLast(i);
        }

        public void Dequeue()
        {
            queue.RemoveFirst();
        }

        public void Display()
        {
            foreach(int i in queue)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
