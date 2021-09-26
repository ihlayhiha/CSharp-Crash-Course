using System;
using System.Collections;

namespace Stack_and_Queue
{
    public class QueueA: IEnumerable
    {
        private int front;
        private int  rear;
        private int[] queueArray;
        // default constructor
        public QueueA()
        {
            this.queueArray = new int[10];
            this.front = -1;
            this.rear = -1;
        } 
        public QueueA(int maxSize)
        {
            this.queueArray = new int[maxSize];
            this.front = -1;
            this.rear = -1;
        }
        public void Display()
        {
            if(this.front == -1 || this.front == this.rear + 1)
                Console.WriteLine("This is an empty queue");
            for (int i=front; i<=rear; i++)
                Console.Write(this.queueArray[i] + " ");
            Console.WriteLine();
        }
        public void Insert(int rand)    
        {
            if (this.rear == this.queueArray.Length - 1) 
                throw new InvalidOperationException("Queue overflow");
            if (front == -1) {
                this.front++;
            } 
            this.rear++;
            this.queueArray[rear] = rand;
        }
        public void Delete()
        {
            if (this.front == -1 || this.front == this.rear + 1) {
                throw new InvalidOperationException("Queue is already empty");
            }
            this.front++;
        }
        public bool IsEmpty()
        {
            return this.front == -1 || this.front == this.rear + 1;
        }
        public bool IsFull()
        {
            return this.rear == this.queueArray.Length - 1;
        }
        public int Size()
        {
            if (this.front == -1  || this.front == this.rear + 1) 
                return 0;
            return this.rear - this.front + 1;
        }
        public override string ToString()
        {
            if (this.front == -1 || this.front == this.rear + 1) {
                return "This is an empty queue";
            }
            var finalArray = new int[this.Size()];
            var idx = 0;
            for(int i=this.front; i<=this.rear; i++) {
                finalArray[idx] = this.queueArray[i];
                idx++;
            }
            return string.Join(" ", finalArray);
        }
        public IEnumerator GetEnumerator()
        {
            if (this.front == -1 || this.front == this.rear + 1) {
                throw new InvalidOperationException("Empty queue cannot be iterated over");
            } 

            for(int i=this.front; i<=this.rear; i++) {
                yield return this.queueArray[i];
            }
        }
    }
}