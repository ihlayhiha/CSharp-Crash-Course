using System;
using System.Collections;

namespace QueueCLL
{
    public class Node
    {
        public int value;
        public Node next;
        public Node prev;
        public Node(int val)
        {
            this.value = val;
            this.next = null;
            this.prev = null;
        }
    }
    public class CircularLinkedList:  IEnumerable
    {
        private Node head;
        private Node tail;
        public CircularLinkedList()
        {
            this.head = null;
            this.tail = null;
        }
        public void Insert(int val)
        {
            var newNode = new Node(val);
            if (this.head == null) {
                this.head = newNode;
                this.tail = newNode;
                newNode.next = this.head;
                newNode.prev = this.tail;                
                return;
            }
            newNode.prev = this.tail;
            newNode.next = this.head;
            this.tail.next = newNode;
            this.tail = newNode;
        }
        public void Delete()
        {
            if (this.head == null) throw new InvalidOperationException("Queue underflow");
            var newHead = this.head.next;
            newHead.prev = this.tail;
            this.head = newHead;
            this.tail.next = newHead;
        }
        public int Size()
        {
            if (this.head == null) return 0;
            var count = 1;
            var node = this.head.next;
            while (node != this.head) {
                count++;
                node = node.next;
            }
            return count;
        }
        public IEnumerator GetEnumerator()
        {
            if (this.head == null) throw new Exception("Cannot iterate over empty CLL");
            yield return this.head.value;
            var node = this.head.next;
            while (node != this.head) {
                yield return node.value;
                node = node.next;
            }
        }
        public override string ToString()
        {
            if (this.head == null) return "";
            var finalArray = new int[this.Size()];
            finalArray[0] = this.head.value;
            var node = this.head.next;
            var idx = 1;
            while (node != this.head) {
                finalArray[idx] = node.value;
                idx++;
                node = node.next;
            }
            return string.Join(" ", finalArray);
        }
    }
}
