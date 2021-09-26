using System;

namespace Stack_and_Queue
{
    public class StackA
    {
        private int[] stackArray;
        private int top;

        // Setting default stack size = 10
        public StackA()
        {
            stackArray = new int[10];
            top = -1;
        }
        public StackA(int maxSize)
        {
            stackArray = new int[maxSize];
            top = -1;
        }
        public int Size()
        {
            return top+1;
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
        public bool IsFull()
        {
            return top == this.stackArray.Length - 1;
        }

        public void Push(int n)
        {
            if (this.IsFull()) throw new InvalidOperationException("This stack is already full");
            top++;
            this.stackArray[top] = n;
        }
        public int Pop()
        {
            if(this.IsEmpty()) throw new InvalidOperationException("Cannot pop values from an empty stack");
            var popVal = this.stackArray[top];
            // this.stackArray[top] = 0;
            top--;
            return popVal;
        }
        public int Peek()
        {
            if(this.IsEmpty()) throw new InvalidOperationException("Stack Underflow");
            return this.stackArray[top];
        }
        public void Display()
        {
            if (this.IsEmpty()) Console.WriteLine("This stack is Empty");
            for(int i=top; i>=0; i--) {
                Console.Write(this.stackArray[i] + " ");
            } Console.WriteLine("");
        }

        public override string ToString()
        {
            var finalArray = new int[top+1];
            for (int i=top;  i>=0; i--) {
                finalArray[top - i] = this.stackArray[i];
            }

            return string.Join(" ", finalArray);
        }
    }
}

