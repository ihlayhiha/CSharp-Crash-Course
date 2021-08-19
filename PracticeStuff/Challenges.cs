using System;

namespace PracticeStuff
{
    public class Challenges
    {
        public static void ReturnKthLast(DoublyCircularLinkedList randList, int k)
        {
            if (k < 1 || k > randList.Length())
                throw new ArgumentOutOfRangeException("Given index is out of range");
            if (randList.head == null)
                return;
            var count = 0;
            var node = randList.head;
            while (node.next != randList.head)
            {
                count ++;
                node = node.next;
            }
            var index = count - k;
            var i = 0;
            node = randList.head;
            while (i <= index)
            {
                i++;
                node = node.next;
            }
            System.Console.WriteLine(node.Value);
        }
    }
}
