using System;
using System.Collections;

namespace Stack_and_Queue
{
    public class QNode
    {
        public int val;
        public QNode next;
        public QNode(int value)
        {
            this.val = value;
            this.next = null;
        }
    }
    public class QueueLL: IEnumerable
    {
        private QNode front;
        private QNode rear;
        public QueueLL()
        {
            this.front = null;
            this.rear = null;
        }
        public void Insert(int val)
        {
            var newNode = new QNode(val);
            if (this.front == null) {
                this.front = newNode;
                this.rear = newNode;
                return;
            }
            this.rear.next = newNode;
            this.rear = newNode;
        }
        public int Size()
        {
            var count = 0;
            var node = this.front;
            while (node != null) {
                count++;
                node = node.next;
            }
            return count;
        }
        public void Delete()
        {
            if (this.front == null) throw new InvalidOperationException("Queue underflow");
            var newHead = this.front.next;
            this.front = newHead;
        }
        public void Display()
        {
            var node = this.front;
            while (node != null) {
                Console.Write(node.val + " ");
                node = node.next;
            }   Console.WriteLine();
        }
        public IEnumerator GetEnumerator()
        {
            var node = this.front;
            while (node != null) {
                yield return node.val;
                node = node.next;
            }
        }
        public override string ToString()
        {
            var finalArray = new int[this.Size()];
            var node = this.front;
            var idx = 0;
            while (node != null) {
                finalArray[idx] = node.val;
                node = node.next;
                idx++;
            }
            return string.Join(" ", finalArray);
        }
    }
}