using System;

namespace PracticeStuff
{
    public class DoublyCircularLinkedList
    {
        public Node head;
        public Node tail;
        
        // public DoublyCircularLinkedList()
        // {
        //     this.head = null;
        //     this.tail = null;
        // }

        public void Traverse()
        {
            var node = this.head;
            while (node != null)
            {
                Console.Write($"{node.Value} ");
                if (node.next == this.head)
                    break;
                node = node.next;
            }
            Console.WriteLine();
        }

        public void CreateDLL(int nodeValue)
        {
            if (this.head != null)
                return;
            else
            {
                var newNode = new Node(nodeValue);
                newNode.next = newNode;
                newNode.prev = newNode;
                this.head = newNode;
                this.tail = newNode;
            }
            Console.WriteLine("A new DoublyCircularLinkedList has been initiated.");
        }

        public void Add(int nodeValue)
        {
            if (this.head == null)  
            {
                this.CreateDLL(nodeValue);
                return;
            }
            else
            {
                var newNode = new Node(nodeValue);
                newNode.next = this.head;
                newNode.prev = this.tail;
                this.tail.next = newNode;
                this.tail = newNode;
            }
        }

        public void Insert(int nodeValue, int location)
        {
            if (this.head == null)
            {
                if (location == 0 || location == 1)
                {
                    this.CreateDLL(nodeValue);
                    return;
                }
            }
            else
            {
                var newNode = new Node(nodeValue);
                if (location == 0)
                {
                    newNode.next = this.head;
                    newNode.prev = this.tail;
                    this.head.prev = newNode;
                    this.tail.next = newNode;
                    this.head = newNode;
                }
                else if (location == -1)
                {
                    this.Add(nodeValue);
                }
                else
                {
                    var i = 0;
                    var tempNode = this.head;
                    while (i < location - 1)
                    {
                        if (tempNode.next == this.head)
                            return;
                        i++;
                        tempNode = tempNode.next;
                    }
                    if (tempNode.next == this.head)
                    {
                        this.Add(nodeValue);
                        return;
                    }
                    var nextNode = tempNode.next;
                    newNode.next = nextNode;
                    newNode.prev = tempNode;
                    nextNode.prev = newNode;
                    tempNode.next = newNode;
                }
            }
        }

        public void DeleteHead()
        {
            if (this.head == null)
                return;
            else
            {
                var newHead = this.head.next;
                newHead.prev = this.tail;
                this.tail.next = newHead;
                this.head = newHead;  
            }
        }

        public void DeleteTail()
        {
            if (this.head == null)
                return;
            else
            {
                var newTail = this.tail.prev;
                newTail.next = this.head;
                this.head.prev = newTail;
                this.tail = newTail;
            }
        }

        public void Delete(int location)
        {
            if (this.head == null)
                return;
            else
            {
                if (location == 0)
                {
                    this.DeleteHead();
                    return;
                }
                else if (location == -1)
                {
                    this.DeleteTail();
                    return;
                }
                else
                {
                    var i = 0;
                    var tempNode = this.head;
                    while (i < location) 
                    {
                        if (tempNode.next == this.head)
                            return;
                        i++;
                        tempNode = tempNode.next;
                    }
                    if (tempNode.next == this.head)
                    {
                        this.DeleteTail();
                        return;
                    }
                    var prevNode = tempNode.prev;
                    var nextNode = tempNode.next;
                    prevNode.next = nextNode;
                    nextNode.prev = prevNode;
                }
            }
        }


    
    }
}
