using System;

namespace CircularQueueUsingArrays
{
    public class CircularQueue
    {
        private int[] queueArray;
        private int front;
        private int rear;
        public CircularQueue()
        {
            this.queueArray = new int[10];
            this.front = -1;
            this.rear = -1;
        }
        public CircularQueue(int maxSize)
        {
            this.queueArray = new int[maxSize];
            this.front = -1;
            this.rear = -1;
        }

        public bool IsEmpty()
        {
            return front == -1;
        }
        public bool IsFull()
        {
            return ((this.front == 0 && this.rear == this.queueArray.Length - 1) || (this.front == this.rear + 1));
        }
        public void Insert(int rand)
        {
            if (this.IsFull())
                throw new Exception("Queue overflow");
            if (front == -1)
                front = 0;
            if (this.rear == this.queueArray.Length - 1)
                rear = 0;
            else 
                rear = rear+1;
            this.queueArray[rear] = rand;
        }
        public int Delete()
        {
            if (this.IsEmpty()) throw new Exception("Queue underflow");
            int rand = this.queueArray[rear];

            if (this.front == this.rear) {
                // queue only has one element
                this.front = -1;
                this.rear = -1;
            } else if (this.front  == this.queueArray.Length -1) {
                this.front = 0;
            } else {
                this.front++;
            }
            return rand;
        }
        public int Peek()
        {
            if (this.IsEmpty()) throw new Exception("Queue is currently empty");
            return this.queueArray[front];
        }
        public void Display()
        {
            if (this.IsEmpty()) return;
            Console.WriteLine("Queue is: ");
            int i = this.front;
            if (this.front <= this.rear) {
                while (i <= this.rear) {
                    Console.Write(this.queueArray[i++] + " ");
                } Console.WriteLine();
            } 
            else {
                while (i<this.queueArray.Length) {
                    Console.Write(this.queueArray[i++] + " ");
                }
                i=0;
                while (i <= this.rear) {
                    Console.Write(this.queueArray[i++] + " ");
                } Console.WriteLine();
            }
        }
    }

}