using System;
namespace HelloWorld
{
    public class StackUsingLinkedList
    {
        private class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }

        }


        Node top;

        public StackUsingLinkedList()
        {
            this.top = null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data)
            {
                next = top
            };
            top = newNode;
        }

        public void Pop()
        {

            if (IsEmpty())
            {
                throw new Exception("Stack is empty!");
            }
            top = top.next;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty!");
         
            }
            return top.data;
        }

        private Boolean IsEmpty()
        {
            return top == null;
        }

        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }


    }
}
