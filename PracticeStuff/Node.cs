using System;

namespace PracticeStuff
{
    public class Node
    {
        public Node next;
        public Node prev;
        public int Value;
        public Node(int value)
        {
            this.Value = value;
        }
        
    }
}