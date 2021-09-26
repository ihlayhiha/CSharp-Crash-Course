using System;
using System.Collections.Generic;
using System.Collections;

namespace Stack_and_Queue
{
    public class Node
    {
        public Node next;
        public int value;
        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
    public class StackB : IEnumerable
    {
        private Node head;
        private Node tail;
        public StackB()
        {
            this.head = null;
            this.tail = null;
        }

        public bool IsEmpty()
        {
            return this.head == null;
        }
        public void Display()
        {
            var node = this.head;
            while (node != null) {
                Console.Write(node.value + " ");
                node = node.next;
            } Console.WriteLine();
        }
        public int size()
        {
            if (this.head == null) {
                Console.WriteLine("This is an empty stack");
                return 0;
            }
            var len = 0;
            var node = this.head;
            while ( node!= null) {
                len++;
            }
            return len;
        }
        public void Push(int value)
        {
            var newNode = new Node(value);
            var node = this.head;
            if (node == null) {
                this.head = newNode;
                this.tail = newNode;
                return;
            }
            newNode.next = this.head;
            this.head = newNode;
        }

        public int Pop()
        {
            if (this.IsEmpty()) throw new InvalidOperationException("Cannot pop from an empty stack");
            var popValue = this.head.value;
            if (this.head == this.tail) {
                this.head = null;
                this.tail = null;
                return popValue;
            }

            Node newHead = this.head.next;
            this.head = newHead;
            return popValue;
        }
        public int Peek()
        {
            if (this.head == null) {
                throw new InvalidOperationException("This is an empty stack");                
            }
            return this.head.value;
        }
        public override string ToString()
        {
            var list = new List<int>();
            var node = this.head;
            while (node != null) {
                list.Add(node.value);
                node = node.next;
            }
            return string.Join(" ", list);
        }
        public IEnumerator GetEnumerator()
        {
            var node = this.head;
            while (node != null) {
                yield return node.value;
                node = node.next;
            }
        }

    }
}