using System;
using System.Collections.Generic;

namespace binary_search_tree
{
    public class Node
    {
        public BSTNode value;
        public Node next;
        public Node(BSTNode value)
        {
            this.value = value;
        }
    }
    public class QueueLL
    {
        private Node front;
        private Node rear;
        public QueueLL()
        {
            this.front = null;
            this.rear = null;
        }
        public void Enqueue(BSTNode value)
        {
            var newNode = new Node(value);
            if (this.front == null) {
                this.front = newNode;
                this.rear = newNode;
                return;
            }
            this.rear.next = newNode;
            this.rear = newNode;
        }
        public BSTNode Dequeue()
        {
            if (this.front == null) {
                throw new InvalidOperationException("This Queue is empty");
            };
            var result = this.front.value;
            var newFront = this.front.next;
            this.front = newFront;
            return result;
        }
        public bool IsEmpty()
        {
            if (this.front == null) return true;
            return false;
        }
        // printable
        public override string ToString()
        {
            var finalList = new List<int>();
            var node = this.front;
            while (node != null)  {
                finalList.Add(node.value.data);
                node = node.next;
            }
            return string.Join(" ", finalList);
        }
    }
}